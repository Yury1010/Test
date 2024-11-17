using Prism.Modularity;
using Prism.Properties;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Prism.Unity.Modularity
{
    public class ModuleManager : IModuleManager, IDisposable
    {
        private readonly IModuleInitializer _moduleInitializer;
        private IEnumerable<IModuleTypeLoader> _typeLoaders;
        private HashSet<IModuleTypeLoader> _subscribedToModuleTypeLoaders = new HashSet<IModuleTypeLoader>();

        public ModuleManager(IModuleInitializer moduleInitializer, IModuleCatalog moduleCatalog)
        {
            _moduleInitializer = moduleInitializer ?? throw new ArgumentNullException(nameof(moduleInitializer));
            ModuleCatalog = moduleCatalog ?? throw new ArgumentNullException(nameof(moduleCatalog));
        }

        protected IModuleCatalog ModuleCatalog { get; }

        public IEnumerable<IModuleInfo> Modules => ModuleCatalog.Modules;

        public event EventHandler<ModuleDownloadProgressChangedEventArgs> ModuleDownloadProgressChanged;

        private void RaiseModuleDownloadProgressChanged(ModuleDownloadProgressChangedEventArgs e)
        {
            EventHandler<ModuleDownloadProgressChangedEventArgs> downloadProgressChanged = ModuleDownloadProgressChanged;
            if (downloadProgressChanged == null)
                return;
            downloadProgressChanged(this, e);
        }

        public event EventHandler<LoadModuleCompletedEventArgs> LoadModuleCompleted;

        private void RaiseLoadModuleCompleted(IModuleInfo moduleInfo, Exception error) => RaiseLoadModuleCompleted(new LoadModuleCompletedEventArgs(moduleInfo, error));

        private void RaiseLoadModuleCompleted(LoadModuleCompletedEventArgs e)
        {
            EventHandler<LoadModuleCompletedEventArgs> loadModuleCompleted = LoadModuleCompleted;
            if (loadModuleCompleted == null)
                return;
            loadModuleCompleted(this, e);
        }

        public void Run()
        {
            ModuleCatalog.Initialize();
            LoadModulesWhenAvailable();
        }

        public void LoadModule(string moduleName)
        {
            IEnumerable<IModuleInfo> source = ModuleCatalog.Modules.Where(m => m.ModuleName == moduleName);
            if (source == null || source.Count() != 1)
                throw new ModuleNotFoundException(moduleName, string.Format(CultureInfo.CurrentCulture, Resources.ModuleNotFound, (object)moduleName));
            LoadModuleTypes(ModuleCatalog.CompleteListWithDependencies(source));
        }

        protected virtual bool ModuleNeedsRetrieval(IModuleInfo moduleInfo)
        {
            if (moduleInfo == null)
                throw new ArgumentNullException(nameof(moduleInfo));
            if (moduleInfo.State != 0)
                return false;
            bool flag = Type.GetType(moduleInfo.ModuleType) != null;
            if (flag)
                moduleInfo.State = (ModuleState)2;
            return !flag;
        }

        private void LoadModulesWhenAvailable()
        {
            IEnumerable<IModuleInfo> moduleInfos = ModuleCatalog.CompleteListWithDependencies(ModuleCatalog.Modules.Where(m => m.InitializationMode == 0));
            if (moduleInfos == null)
                return;
            LoadModuleTypes(moduleInfos);
        }

        private void LoadModuleTypes(IEnumerable<IModuleInfo> moduleInfos)
        {
            if (moduleInfos == null)
                return;
            foreach (IModuleInfo moduleInfo in moduleInfos)
            {
                if (moduleInfo.State == 0)
                {
                    if (ModuleNeedsRetrieval(moduleInfo))
                        BeginRetrievingModule(moduleInfo);
                    else
                        moduleInfo.State = (ModuleState)2;
                }
            }
            LoadModulesThatAreReadyForLoad();
        }

        protected virtual void LoadModulesThatAreReadyForLoad()
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                foreach (IModuleInfo moduleInfo in ModuleCatalog.Modules.Where(m => m.State == ModuleState.ReadyForInitialization))
                {
                    if (moduleInfo.State != ModuleState.Initialized && AreDependenciesLoaded(moduleInfo))
                    {
                        moduleInfo.State = (ModuleState)3;
                        InitializeModule(moduleInfo);
                        flag = true;
                        break;
                    }
                }
            }
        }

        private void BeginRetrievingModule(IModuleInfo moduleInfo)
        {
            IModuleInfo moduleInfo1 = moduleInfo;
            IModuleTypeLoader typeLoaderForModule = GetTypeLoaderForModule(moduleInfo1);
            moduleInfo1.State = ModuleState.LoadingTypes;
            if (!_subscribedToModuleTypeLoaders.Contains(typeLoaderForModule))
            {
                typeLoaderForModule.ModuleDownloadProgressChanged += new EventHandler<ModuleDownloadProgressChangedEventArgs>(IModuleTypeLoader_ModuleDownloadProgressChanged);
                typeLoaderForModule.LoadModuleCompleted += new EventHandler<LoadModuleCompletedEventArgs>(IModuleTypeLoader_LoadModuleCompleted);
                _subscribedToModuleTypeLoaders.Add(typeLoaderForModule);
            }
            typeLoaderForModule.LoadModuleType(moduleInfo);
        }

        private void IModuleTypeLoader_ModuleDownloadProgressChanged(
          object sender,
          ModuleDownloadProgressChangedEventArgs e)
        {
            RaiseModuleDownloadProgressChanged(e);
        }

        private void IModuleTypeLoader_LoadModuleCompleted(
          object sender,
          LoadModuleCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                if (e.ModuleInfo.State != ModuleState.Initializing && e.ModuleInfo.State != ModuleState.Initialized)
                    e.ModuleInfo.State = (ModuleState)2;
                LoadModulesThatAreReadyForLoad();
            }
            else
            {
                RaiseLoadModuleCompleted(e);
                if (!e.IsErrorHandled)
                    HandleModuleTypeLoadingError(e.ModuleInfo, e.Error);
            }
        }

        protected virtual void HandleModuleTypeLoadingError(IModuleInfo moduleInfo, Exception exception)
        {
            if (moduleInfo == null)
                throw new ArgumentNullException(nameof(moduleInfo));
            if (!(exception is ModuleTypeLoadingException loadingException))
                loadingException = new ModuleTypeLoadingException(moduleInfo.ModuleName, exception.Message, exception);
            throw loadingException;
        }

        private bool AreDependenciesLoaded(IModuleInfo moduleInfo)
        {
            IEnumerable<IModuleInfo> dependentModules = ModuleCatalog.GetDependentModules(moduleInfo);
            return dependentModules == null || dependentModules.Count(requiredModule => requiredModule.State != ModuleState.Initialized) == 0;
        }

        private IModuleTypeLoader GetTypeLoaderForModule(IModuleInfo moduleInfo)
        {
            foreach (IModuleTypeLoader moduleTypeLoader in ModuleTypeLoaders)
            {
                if (moduleTypeLoader.CanLoadModuleType(moduleInfo))
                    return moduleTypeLoader;
            }
            throw new ModuleTypeLoaderNotFoundException(moduleInfo.ModuleName, string.Format((IFormatProvider)CultureInfo.CurrentCulture, Resources.NoRetrieverCanRetrieveModule, (object)moduleInfo.ModuleName), (Exception)null);
        }

        private void InitializeModule(IModuleInfo moduleInfo)
        {
            if (moduleInfo.State != ModuleState.Initializing)
                return;
            _moduleInitializer.Initialize(moduleInfo);
            moduleInfo.State = ModuleState.Initialized;
            RaiseLoadModuleCompleted(moduleInfo, (Exception)null);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            foreach (IModuleTypeLoader moduleTypeLoader in ModuleTypeLoaders)
            {
                if (moduleTypeLoader is IDisposable disposable)
                    disposable.Dispose();
            }
        }

        public virtual IEnumerable<IModuleTypeLoader> ModuleTypeLoaders
        {
            get
            {
                _typeLoaders ??= new List<IModuleTypeLoader>() { new FileModuleTypeLoader() };
                return _typeLoaders;
            }
            set => _typeLoaders = value;
        }
    }
}
