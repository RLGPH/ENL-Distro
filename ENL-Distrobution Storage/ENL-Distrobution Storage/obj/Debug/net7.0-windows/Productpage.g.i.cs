﻿#pragma checksum "..\..\..\Productpage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C6EACCEEE8554BA6A87F3A9652F2509488FD657A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ENL_Distrobution_Storage;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace ENL_Distrobution_Storage {
    
    
    /// <summary>
    /// Productpage
    /// </summary>
    public partial class Productpage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Productpage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DTG_products;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Productpage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_close_window;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Productpage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_add;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Productpage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_remove;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Productpage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_edit;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Productpage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_ID_Select;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ENL-Distrobution Storage;V1.0.0.0;component/productpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Productpage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DTG_products = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.BTN_close_window = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\Productpage.xaml"
            this.BTN_close_window.Click += new System.Windows.RoutedEventHandler(this.BTN_close_window_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BTN_add = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\Productpage.xaml"
            this.BTN_add.Click += new System.Windows.RoutedEventHandler(this.BTN_add_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BTN_remove = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\Productpage.xaml"
            this.BTN_remove.Click += new System.Windows.RoutedEventHandler(this.BTN_remove_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BTN_edit = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\Productpage.xaml"
            this.BTN_edit.Click += new System.Windows.RoutedEventHandler(this.BTN_edit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TB_ID_Select = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

