﻿#pragma checksum "..\..\..\Order_Window.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AA41E5F90B785761910FA31AC53CDB3D601ED015"
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
    /// Order_Window
    /// </summary>
    public partial class Order_Window : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\Order_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DTG_Orders;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Order_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_close;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Order_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_remove;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Order_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Order;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Order_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_edit_Order;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Order_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_ID_Select;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ENL-Distrobution Storage;component/order_window.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Order_Window.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DTG_Orders = ((System.Windows.Controls.DataGrid)(target));
            
            #line 21 "..\..\..\Order_Window.xaml"
            this.DTG_Orders.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DTG_Orders_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BTN_close = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Order_Window.xaml"
            this.BTN_close.Click += new System.Windows.RoutedEventHandler(this.BTN_close_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BTN_remove = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Order_Window.xaml"
            this.BTN_remove.Click += new System.Windows.RoutedEventHandler(this.BTN_remove_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BTN_Order = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\Order_Window.xaml"
            this.BTN_Order.Click += new System.Windows.RoutedEventHandler(this.BTN_Order_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BTN_edit_Order = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\Order_Window.xaml"
            this.BTN_edit_Order.Click += new System.Windows.RoutedEventHandler(this.BTN_edit_Order_Click);
            
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

