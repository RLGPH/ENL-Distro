﻿#pragma checksum "..\..\..\..\Images for background\Main page.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "747DD842BE98C9A5D6819EB3919C4CF57DEEF2CF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ENL_Distrobution_Storage.Images_for_background;
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


namespace ENL_Distrobution_Storage.Images_for_background {
    
    
    /// <summary>
    /// Main_page
    /// </summary>
    public partial class Main_page : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\Images for background\Main page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Products;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Images for background\Main page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Workers;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Images for background\Main page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Orders;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Images for background\Main page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image IMG_Main_page;
        
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
            System.Uri resourceLocater = new System.Uri("/ENL-Distrobution Storage;component/images%20for%20background/main%20page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Images for background\Main page.xaml"
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
            this.BTN_Products = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\Images for background\Main page.xaml"
            this.BTN_Products.Click += new System.Windows.RoutedEventHandler(this.BTN_Products_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BTN_Workers = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\Images for background\Main page.xaml"
            this.BTN_Workers.Click += new System.Windows.RoutedEventHandler(this.BTN_Workers_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BTN_Orders = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\Images for background\Main page.xaml"
            this.BTN_Orders.Click += new System.Windows.RoutedEventHandler(this.BTN_Orders_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.IMG_Main_page = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

