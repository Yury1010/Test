﻿using Prism.Modularity;
using System;
using System.Runtime.Serialization;

namespace Prism.Unity.Modularity
{
    [Serializable]
    public class ModuleTypeLoaderNotFoundException : ModularityException
    {
        public ModuleTypeLoaderNotFoundException()
        {
        }

        public ModuleTypeLoaderNotFoundException(string message)
          : base(message)
        {
        }

        public ModuleTypeLoaderNotFoundException(string message, Exception innerException)
          : base(message, innerException)
        {
        }

        public ModuleTypeLoaderNotFoundException(
          string moduleName,
          string message,
          Exception innerException)
          : base(moduleName, message, innerException)
        {
        }

        protected ModuleTypeLoaderNotFoundException(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
}
