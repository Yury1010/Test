using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.IO;

namespace Prism.Unity.Modularity
{
    public class FileModuleTypeLoader : IModuleTypeLoader, IDisposable
    {
        private const string _refFilePrefix = "file://";
        private readonly IAssemblyResolver _assemblyResolver;
        private HashSet<Uri> _downloadedUris = new HashSet<Uri>();

        public FileModuleTypeLoader()
          : this(new AssemblyResolver())
        {
        }

        public FileModuleTypeLoader(IAssemblyResolver assemblyResolver) => _assemblyResolver = assemblyResolver;

        public event EventHandler<ModuleDownloadProgressChangedEventArgs> ModuleDownloadProgressChanged;

        private void RaiseModuleDownloadProgressChanged(
          IModuleInfo moduleInfo,
          long bytesReceived,
          long totalBytesToReceive)
        {
            RaiseModuleDownloadProgressChanged(new ModuleDownloadProgressChangedEventArgs(moduleInfo, bytesReceived, totalBytesToReceive));
        }

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

        public bool CanLoadModuleType(IModuleInfo moduleInfo)
        {
            if (moduleInfo == null)
                throw new ArgumentNullException(nameof(moduleInfo));
            return moduleInfo.Ref != null && moduleInfo.Ref.StartsWith(_refFilePrefix, StringComparison.Ordinal);
        }

        public void LoadModuleType(IModuleInfo moduleInfo)
        {
            if (moduleInfo == null)
                throw new ArgumentNullException(nameof(moduleInfo));
            try
            {
                Uri uri = new Uri(moduleInfo.Ref, UriKind.RelativeOrAbsolute);
                if (IsSuccessfullyDownloaded(uri))
                {
                    RaiseLoadModuleCompleted(moduleInfo, null);
                }
                else
                {
                    string localPath = uri.LocalPath;
                    long num = -1;
                    if (File.Exists(localPath))
                        num = new FileInfo(localPath).Length;
                    RaiseModuleDownloadProgressChanged(moduleInfo, 0L, num);
                    _assemblyResolver.LoadAssemblyFrom(moduleInfo.Ref);
                    RaiseModuleDownloadProgressChanged(moduleInfo, num, num);
                    RecordDownloadSuccess(uri);
                    RaiseLoadModuleCompleted(moduleInfo, null);
                }
            }
            catch (Exception ex)
            {
                RaiseLoadModuleCompleted(moduleInfo, ex);
            }
        }

        private bool IsSuccessfullyDownloaded(Uri uri)
        {
            lock (_downloadedUris)
                return _downloadedUris.Contains(uri);
        }

        private void RecordDownloadSuccess(Uri uri)
        {
            lock (_downloadedUris)
                _downloadedUris.Add(uri);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize((object)this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!(_assemblyResolver is IDisposable assemblyResolver))
                return;
            assemblyResolver.Dispose();
        }
    }
}
