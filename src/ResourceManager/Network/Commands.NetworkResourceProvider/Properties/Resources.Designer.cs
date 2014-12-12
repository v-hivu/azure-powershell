﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.NetworkResourceProvider.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.NetworkResourceProvider.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to backendAddressPools.
        /// </summary>
        public static string LoadBalancerBackendAddressPoolName {
            get {
                return ResourceManager.GetString("LoadBalancerBackendAddressPoolName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.Network/loadBalancers/{2}/{3}/{4}.
        /// </summary>
        public static string LoadBalancerChildResourceId {
            get {
                return ResourceManager.GetString("LoadBalancerChildResourceId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to frontendIPConfigurations.
        /// </summary>
        public static string LoadBalancerFrontendIpConfigName {
            get {
                return ResourceManager.GetString("LoadBalancerFrontendIpConfigName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to inboundNatRules.
        /// </summary>
        public static string LoadBalancerInBoundNatRuleName {
            get {
                return ResourceManager.GetString("LoadBalancerInBoundNatRuleName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LoadBalancerNameNotSet.
        /// </summary>
        public static string LoadBalancerNameNotSet {
            get {
                return ResourceManager.GetString("LoadBalancerNameNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to probes.
        /// </summary>
        public static string LoadBalancerProbeName {
            get {
                return ResourceManager.GetString("LoadBalancerProbeName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to loadBalancingRules.
        /// </summary>
        public static string LoadBalancerRuleName {
            get {
                return ResourceManager.GetString("LoadBalancerRuleName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to overwriteresource &apos;{0}&apos;.
        /// </summary>
        public static string OverwritingResource {
            get {
                return ResourceManager.GetString("OverwritingResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Overwriting resource ....
        /// </summary>
        public static string OverwritingResourceMessage {
            get {
                return ResourceManager.GetString("OverwritingResourceMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing resource ....
        /// </summary>
        public static string RemoveResourceMessage {
            get {
                return ResourceManager.GetString("RemoveResourceMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove resource &apos;{0}&apos;.
        /// </summary>
        public static string RemovingResource {
            get {
                return ResourceManager.GetString("RemovingResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ResourceGroupNotSet.
        /// </summary>
        public static string ResourceGroupNotSet {
            get {
                return ResourceManager.GetString("ResourceGroupNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SetByResource.
        /// </summary>
        public static string SetByResource {
            get {
                return ResourceManager.GetString("SetByResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SetByResourceId.
        /// </summary>
        public static string SetByResourceId {
            get {
                return ResourceManager.GetString("SetByResourceId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PrivateIpAddress needs to be specified in Static allocation.
        /// </summary>
        public static string StaticIpAddressErrorMessage {
            get {
                return ResourceManager.GetString("StaticIpAddressErrorMessage", resourceCulture);
            }
        }
    }
}
