﻿#pragma checksum "..\..\KlantControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5585371F8315D5FAD24B08E2AFE9596CA09A1C5DD048891D48D05A5EC22B1DBB"
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
using System.Windows.Data;
using System.Windows.Documents;
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
using kassasysteem;


namespace kassasysteem {
    
    
    /// <summary>
    /// KlantControl
    /// </summary>
    public partial class KlantControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 10 "..\..\KlantControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox KlantNaamBox;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\KlantControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StadBox;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\KlantControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MobielBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\KlantControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmailBox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\KlantControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Opslaanklantbtn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\KlantControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateKlantbtn;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\KlantControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGKlant;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\KlantControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox KlantAchterBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/kassasysteem;component/klantcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\KlantControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.KlantNaamBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.StadBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.MobielBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.EmailBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Opslaanklantbtn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\KlantControl.xaml"
            this.Opslaanklantbtn.Click += new System.Windows.RoutedEventHandler(this.Opslaanklantbtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.UpdateKlantbtn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\KlantControl.xaml"
            this.UpdateKlantbtn.Click += new System.Windows.RoutedEventHandler(this.UpdateKlantbtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DGKlant = ((System.Windows.Controls.DataGrid)(target));
            
            #line 21 "..\..\KlantControl.xaml"
            this.DGKlant.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DGKlant_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.KlantAchterBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 8:
            
            #line 31 "..\..\KlantControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnVerwijderenKlant_Click_1);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
