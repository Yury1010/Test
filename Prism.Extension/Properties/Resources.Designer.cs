﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prism.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Prism.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Directory {0} was not found..
        /// </summary>
        internal static string DirectoryNotFound {
            get {
                return ResourceManager.GetString("DirectoryNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To use the UIThread option for subscribing, the EventAggregator must be constructed on the UI thread..
        /// </summary>
        internal static string EventAggregatorNotConstructedOnUIThread {
            get {
                return ResourceManager.GetString("EventAggregatorNotConstructedOnUIThread", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to retrieve the module type {0} from the loaded assemblies.  You may need to specify a more fully-qualified type name..
        /// </summary>
        internal static string FailedToGetType {
            get {
                return ResourceManager.GetString("FailedToGetType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument must be a valid absolute Uri to an assembly file..
        /// </summary>
        internal static string InvalidArgumentAssemblyUri {
            get {
                return ResourceManager.GetString("InvalidArgumentAssemblyUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Delegate Reference Type Exception.
        /// </summary>
        internal static string InvalidDelegateRerefenceTypeException {
            get {
                return ResourceManager.GetString("InvalidDelegateRerefenceTypeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Module {0} was not found in the catalog..
        /// </summary>
        internal static string ModuleNotFound {
            get {
                return ResourceManager.GetString("ModuleNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ModulePath cannot contain a null value or be empty.
        /// </summary>
        internal static string ModulePathCannotBeNullOrEmpty {
            get {
                return ResourceManager.GetString("ModulePathCannotBeNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is currently no moduleTypeLoader in the ModuleManager that can retrieve the specified module..
        /// </summary>
        internal static string NoRetrieverCanRetrieveModule {
            get {
                return ResourceManager.GetString("NoRetrieverCanRetrieveModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value must be of type ModuleInfo..
        /// </summary>
        internal static string ValueMustBeOfTypeModuleInfo {
            get {
                return ResourceManager.GetString("ValueMustBeOfTypeModuleInfo", resourceCulture);
            }
        }
    }
}
