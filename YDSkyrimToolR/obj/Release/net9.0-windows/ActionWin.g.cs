﻿#pragma checksum "..\..\..\ActionWin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4B8506A82BA51888E2A30BABCB38703279514D69"
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
    /// ActionWin
    /// </summary>
    public partial class ActionWin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\..\ActionWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border FristLoad;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\ActionWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Caption;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\ActionWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CurrentMsg;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\ActionWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Cancel;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\ActionWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Confirm;
        
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
            System.Uri resourceLocater = new System.Uri("/YDSkyrimToolR;component/actionwin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ActionWin.xaml"
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
            this.FristLoad = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            
            #line 49 "..\..\..\ActionWin.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.WinHead_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Caption = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.CurrentMsg = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Cancel = ((System.Windows.Controls.Border)(target));
            
            #line 59 "..\..\..\ActionWin.xaml"
            this.Cancel.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OneCancel);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Confirm = ((System.Windows.Controls.Border)(target));
            
            #line 70 "..\..\..\ActionWin.xaml"
            this.Confirm.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OneConfirm);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

