﻿#pragma checksum "..\..\..\CodeView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5F0575A4F7F710A1A78940B790032E3A8922FB8C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Editing;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Rendering;
using ICSharpCode.AvalonEdit.Search;
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
    /// CodeView
    /// </summary>
    public partial class CodeView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 346 "..\..\..\CodeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border MainBackGround;
        
        #line default
        #line hidden
        
        
        #line 351 "..\..\..\CodeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Footer;
        
        #line default
        #line hidden
        
        
        #line 359 "..\..\..\CodeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Header;
        
        #line default
        #line hidden
        
        
        #line 360 "..\..\..\CodeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label MainCaption;
        
        #line default
        #line hidden
        
        
        #line 366 "..\..\..\CodeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image TClose;
        
        #line default
        #line hidden
        
        
        #line 372 "..\..\..\CodeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ICSharpCode.AvalonEdit.TextEditor TextEditor;
        
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
            System.Uri resourceLocater = new System.Uri("/YDSkyrimToolR;component/codeview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CodeView.xaml"
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
            
            #line 9 "..\..\..\CodeView.xaml"
            ((YDSkyrimToolR.CodeView)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\CodeView.xaml"
            ((YDSkyrimToolR.CodeView)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\CodeView.xaml"
            ((YDSkyrimToolR.CodeView)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\CodeView.xaml"
            ((YDSkyrimToolR.CodeView)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.Window_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MainBackGround = ((System.Windows.Controls.Border)(target));
            
            #line 346 "..\..\..\CodeView.xaml"
            this.MainBackGround.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.WinHead_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Footer = ((System.Windows.Controls.Border)(target));
            return;
            case 4:
            this.Header = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.MainCaption = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            
            #line 365 "..\..\..\CodeView.xaml"
            ((System.Windows.Controls.Border)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Close);
            
            #line default
            #line hidden
            
            #line 365 "..\..\..\CodeView.xaml"
            ((System.Windows.Controls.Border)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.RMouserEffectByEnter);
            
            #line default
            #line hidden
            
            #line 365 "..\..\..\CodeView.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.RMouserEffectByLeave);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TClose = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            this.TextEditor = ((ICSharpCode.AvalonEdit.TextEditor)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

