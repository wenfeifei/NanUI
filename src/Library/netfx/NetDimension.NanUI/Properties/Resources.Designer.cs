﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NetDimension.NanUI.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NetDimension.NanUI.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon DevToolsIcon {
            get {
                object obj = ResourceManager.GetObject("DevToolsIcon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to var NanUI = NanUI || {};
        ///
        ///(function(target) {
        ///  const CMD_ATTR_PREFIX = &quot;nanui-command&quot;;
        ///
        ///  const RAISE_FUNC_NAME = &quot;__nanui_raiseHostWindowEvent&quot;;
        ///
        ///  const GLOBAL_CLICK_HANDLER_REGISTERED =
        ///    &quot;__nanui_global_click_handler_registered&quot;;
        ///
        ///  if (!window.hasOwnProperty(RAISE_FUNC_NAME)) {
        ///    window[RAISE_FUNC_NAME] = function(eventName, data) {
        ///      window.dispatchEvent(new CustomEvent(eventName, { detail: data }));
        ///    };
        ///  }
        ///
        ///  if (!(GLOBAL_CLICK_HANDLER_REGISTERED in window)) {
        ///    windo [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string FrameGlobalRegistrationScript {
            get {
                return ResourceManager.GetString("FrameGlobalRegistrationScript", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to var NanUI = NanUI || {};
        ///
        ///(function (target) {
        ///    var hostWindow = {
        ///        minimize: function () {
        ///            native function Minimize();
        ///            return Minimize();
        ///        },
        ///        maximize: function () {
        ///            native function Maximize();
        ///            return Maximize();
        ///        },
        ///        restore: function () {
        ///            native function Restore();
        ///            return Restore();
        ///        },
        ///        close: function () {
        ///            native function Close();
        ///            return  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string HostWindowExtension {
            get {
                return ResourceManager.GetString("HostWindowExtension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to                                             
        ///  P.O.W.E.R.E.D BY                          
        ///  ███╗   ██╗ █████╗ ███╗   ██╗██╗   ██╗██╗  
        ///  ████╗  ██║██╔══██╗████╗  ██║██║   ██║██║  
        ///  ██╔██╗ ██║███████║██╔██╗ ██║██║   ██║██║  
        ///  ██║╚██╗██║██╔══██║██║╚██╗██║██║   ██║██║  
        ///  ██║ ╚████║██║  ██║██║ ╚████║╚██████╔╝██║  
        ///  ╚═╝  ╚═══╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝ ╚═╝  
        ///                            S.I.N.C.E 2016  
        ///                                            .
        /// </summary>
        internal static string nanui {
            get {
                return ResourceManager.GetString("nanui", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to var NanUI = NanUI || {};
        ///
        ///(function (target) {
        ///
        ///  target.__defineGetter__(&quot;version&quot;, function () {
        ///    native function Version();
        ///    return Version();
        ///  });
        ///  
        ///})(NanUI);.
        /// </summary>
        internal static string NanUIExtension {
            get {
                return ResourceManager.GetString("NanUIExtension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ShadowTemplate {
            get {
                object obj = ResourceManager.GetObject("ShadowTemplate", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
