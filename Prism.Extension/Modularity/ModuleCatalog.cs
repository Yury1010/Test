using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.IO;

namespace Prism.Unity.Modularity
{
    public class ModuleCatalog : ModuleCatalogBase
    {
        public ModuleCatalog()
        {
        }

        public ModuleCatalog(IEnumerable<ModuleInfo> modules)
          : base(modules)
        {
        }

        protected virtual string GetFileAbsoluteUri(string filePath) => new UriBuilder()
        {
            Host = string.Empty,
            Scheme = Uri.UriSchemeFile,
            Path = Path.GetFullPath(filePath)
        }.Uri.ToString();
    }
}
