﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nexus.Client.Games.TESO.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Nexus.Client.Games.TESO.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;categoryManager fileVersion=&quot;0.1.0.0&quot;&gt;
        ///  &lt;categoryList&gt;
        ///    &lt;category path=&quot;Action Bar&quot; ID=&quot;8&quot;&gt;
        ///      &lt;name&gt;Action Bar&lt;/name&gt;
        ///    &lt;/category&gt;
        ///    &lt;category path=&quot;Action House, Vendors and Economy&quot; ID=&quot;7&quot;&gt;
        ///      &lt;name&gt;Action House, Vendors and Economy&lt;/name&gt;
        ///    &lt;/category&gt;
        ///    &lt;category path=&quot;Bags, Bank and Inventory&quot; ID=&quot;6&quot;&gt;
        ///      &lt;name&gt;Bags, Bank and Inventory&lt;/name&gt;
        ///    &lt;/category&gt;
        ///    &lt;category path=&quot;Buffs and Debuffs&quot; ID=&quot;9&quot;&gt;
        ///      &lt;name&gt;Buffs and De [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Categories {
            get {
                return ResourceManager.GetString("Categories", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon eso_logo {
            get {
                object obj = ResourceManager.GetObject("eso_logo", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
    }
}
