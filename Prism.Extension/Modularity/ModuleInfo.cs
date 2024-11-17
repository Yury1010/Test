using Prism.Modularity;
using System;
using System.Collections.ObjectModel;

namespace Prism.Unity.Modularity
{
    [Serializable]
    public class ModuleInfo : IModuleInfo, IModuleCatalogItem
    {
        public ModuleInfo()
          : this(null, null, new string[0])
        {
        }

        public ModuleInfo(string name, string type, params string[] dependsOn)
        {
            if (dependsOn == null)
                throw new ArgumentNullException(nameof(dependsOn));
            ModuleName = name;
            ModuleType = type;
            DependsOn = new Collection<string>();
            foreach (var str in dependsOn)
                DependsOn.Add(str);
        }

        public ModuleInfo(string name, string type)
          : this(name, type, Array.Empty<string>())
        {
        }

        public ModuleInfo(Type moduleType)
          : this(moduleType, moduleType.Name)
        {
        }

        public ModuleInfo(Type moduleType, string moduleName)
          : this(moduleType, moduleName, 0)
        {
        }

        public ModuleInfo(Type moduleType, string moduleName, InitializationMode initializationMode)
          : this(moduleName, moduleType.AssemblyQualifiedName)
        {
            InitializationMode = initializationMode;
        }

        public string ModuleName { get; set; }

        public string ModuleType { get; set; }

        public Collection<string> DependsOn { get; set; }

        public InitializationMode InitializationMode { get; set; }

        public string Ref { get; set; }

        public ModuleState State { get; set; }
    }
}
