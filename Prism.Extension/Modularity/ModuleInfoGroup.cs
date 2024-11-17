using Prism.Modularity;
using Prism.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Prism.Unity.Modularity
{
    public class ModuleInfoGroup :
      IModuleInfoGroup,
      IModuleCatalogItem,
      IList<IModuleInfo>,
      ICollection<IModuleInfo>,
      IEnumerable<IModuleInfo>,
      IEnumerable,
      IList,
      ICollection
    {
        private readonly Collection<IModuleInfo> _modules = new Collection<IModuleInfo>();

        public InitializationMode InitializationMode { get; set; }

        public string Ref { get; set; }

        public void Add(IModuleInfo item)
        {
            ForwardValues(item);
            _modules.Add(item);
        }

        internal void UpdateModulesRef()
        {
            foreach (IModuleInfo module in _modules)
                module.Ref = Ref;
        }

        protected void ForwardValues(IModuleInfo moduleInfo)
        {
            if (moduleInfo == null)
                throw new ArgumentNullException(nameof(moduleInfo));
            moduleInfo.Ref ??= Ref;
            moduleInfo.InitializationMode = InitializationMode;
        }

        public void Clear() => _modules.Clear();

        public bool Contains(IModuleInfo item) => _modules.Contains(item);

        public void CopyTo(IModuleInfo[] array, int arrayIndex) => _modules.CopyTo(array, arrayIndex);

        public int Count => _modules.Count;

        public bool IsReadOnly => false;

        public bool Remove(IModuleInfo item) => _modules.Remove(item);

        public IEnumerator<IModuleInfo> GetEnumerator() => _modules.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        int IList.Add(object value)
        {
            Add((IModuleInfo)value);
            return 1;
        }

        bool IList.Contains(object value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            return value is IModuleInfo imoduleInfo ? Contains(imoduleInfo) : throw new ArgumentException(Resources.ValueMustBeOfTypeModuleInfo, nameof(value));
        }

        public int IndexOf(object value) => _modules.IndexOf((IModuleInfo)value);

        public void Insert(int index, object value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            if (!(value is IModuleInfo imoduleInfo))
                throw new ArgumentException(Resources.ValueMustBeOfTypeModuleInfo, nameof(value));
            _modules.Insert(index, imoduleInfo);
        }

        public bool IsFixedSize => false;

        void IList.Remove(object value) => Remove((IModuleInfo)value);

        public void RemoveAt(int index) => _modules.RemoveAt(index);

        object IList.this[int index]
        {
            get => this[index];
            set => this[index] = (IModuleInfo)value;
        }

        void ICollection.CopyTo(Array array, int index) => ((ICollection)_modules).CopyTo(array, index);

        public bool IsSynchronized => ((ICollection)_modules).IsSynchronized;

        public object SyncRoot => ((ICollection)_modules).SyncRoot;

        public int IndexOf(IModuleInfo item) => _modules.IndexOf(item);

        public void Insert(int index, IModuleInfo item) => _modules.Insert(index, item);

        public IModuleInfo this[int index]
        {
            get => _modules[index];
            set => _modules[index] = value;
        }
    }
}
