using Prism.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Prism.Unity.Modularity
{
    public class AssemblyResolver : IAssemblyResolver, IDisposable
    {
        private readonly List<AssemblyInfo> registeredAssemblies = new List<AssemblyInfo>();
        private bool handlesAssemblyResolve;

        public void LoadAssemblyFrom(string assemblyFilePath)
        {
            if (!handlesAssemblyResolve)
            {
                AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
                handlesAssemblyResolve = true;
            }
            Uri fileUri = GetFileUri(assemblyFilePath);
            if (fileUri == null)
                throw new ArgumentException(Resources.InvalidArgumentAssemblyUri, nameof(assemblyFilePath));
            AssemblyName assemblyName = File.Exists(fileUri.LocalPath) ? AssemblyName.GetAssemblyName(fileUri.LocalPath) : throw new FileNotFoundException(null, fileUri.LocalPath);
            if (registeredAssemblies.FirstOrDefault(a => assemblyName == a.AssemblyName) != null)
                return;
            registeredAssemblies.Add(new AssemblyInfo()
            {
                AssemblyName = assemblyName,
                AssemblyUri = fileUri
            });
        }

        private static Uri GetFileUri(string filePath)
        {
            return string.IsNullOrEmpty(filePath) || !Uri.TryCreate(filePath, UriKind.Absolute, out Uri result) || !result.IsFile ? null : result;
        }

        private Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            AssemblyName assemblyName = new AssemblyName(args.Name);
            AssemblyInfo assemblyInfo = registeredAssemblies.FirstOrDefault(a => AssemblyName.ReferenceMatchesDefinition(assemblyName, a.AssemblyName));
            if (assemblyInfo == null)
                return null;
            if (assemblyInfo.Assembly == null)
                assemblyInfo.Assembly = Assembly.LoadFrom(assemblyInfo.AssemblyUri.LocalPath);
            return assemblyInfo.Assembly;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!handlesAssemblyResolve)
                return;
            AppDomain.CurrentDomain.AssemblyResolve -= new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            handlesAssemblyResolve = false;
        }

        private class AssemblyInfo
        {
            public AssemblyName AssemblyName { get; set; }

            public Uri AssemblyUri { get; set; }

            public Assembly Assembly { get; set; }
        }
    }
}
