﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TetrisOOP.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.4.0.0")]
    internal sealed partial class Controls : global::System.Configuration.ApplicationSettingsBase {
        
        private static Controls defaultInstance = ((Controls)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Controls())));
        
        public static Controls Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Left")]
        public global::System.Windows.Forms.Keys KeyLeft {
            get {
                return ((global::System.Windows.Forms.Keys)(this["KeyLeft"]));
            }
            set {
                this["KeyLeft"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Right")]
        public global::System.Windows.Forms.Keys KeyRight {
            get {
                return ((global::System.Windows.Forms.Keys)(this["KeyRight"]));
            }
            set {
                this["KeyRight"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Down")]
        public global::System.Windows.Forms.Keys KeyDown {
            get {
                return ((global::System.Windows.Forms.Keys)(this["KeyDown"]));
            }
            set {
                this["KeyDown"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Up")]
        public global::System.Windows.Forms.Keys KeyUp {
            get {
                return ((global::System.Windows.Forms.Keys)(this["KeyUp"]));
            }
            set {
                this["KeyUp"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Space")]
        public global::System.Windows.Forms.Keys KeyRotate {
            get {
                return ((global::System.Windows.Forms.Keys)(this["KeyRotate"]));
            }
            set {
                this["KeyRotate"] = value;
            }
        }
    }
}