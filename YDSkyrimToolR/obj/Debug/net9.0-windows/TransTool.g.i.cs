﻿#pragma checksum "..\..\..\TransTool.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93071A8F47ADA172F62E35424C95B2F171A36FA5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using YDSkyrimToolR;


namespace YDSkyrimToolR {
    
    
    /// <summary>
    /// TransTool
    /// </summary>
    public partial class TransTool : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\TransTool.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border StartTransBtn;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\TransTool.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TransControlBtn;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\TransTool.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label EditEngine;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\TransTool.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LocalTransCN;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\TransTool.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Appid;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\TransTool.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Key;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\TransTool.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox DeepSeekKey;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\TransTool.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox Log;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/YDSkyrimToolR;V1.0.0.0;component/transtool.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\TransTool.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\TransTool.xaml"
            ((YDSkyrimToolR.TransTool)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\TransTool.xaml"
            ((YDSkyrimToolR.TransTool)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.StartTransBtn = ((System.Windows.Controls.Border)(target));
            
            #line 21 "..\..\..\TransTool.xaml"
            this.StartTransBtn.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.StartTransing);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TransControlBtn = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            
            #line 27 "..\..\..\TransTool.xaml"
            ((System.Windows.Controls.Border)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.EditEngineRule);
            
            #line default
            #line hidden
            return;
            case 5:
            this.EditEngine = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.LocalTransCN = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Appid = ((System.Windows.Controls.TextBox)(target));
            
            #line 53 "..\..\..\TransTool.xaml"
            this.Appid.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Appid_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Key = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 60 "..\..\..\TransTool.xaml"
            this.Key.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Key_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DeepSeekKey = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 67 "..\..\..\TransTool.xaml"
            this.DeepSeekKey.MouseLeave += new System.Windows.Input.MouseEventHandler(this.DeepSeekKey_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Log = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

