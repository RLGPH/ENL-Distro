// Updated by XamlIntelliSenseFileGenerator 02-11-2023 08:51:39
#pragma checksum "..\..\..\Product_add_window.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "863594027FA7675DB04BEF5268D5BCB41ED0A128"
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


namespace ENL_Distrobution_Storage
{


    /// <summary>
    /// Product_add_window
    /// </summary>
    public partial class Product_add_window : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 10 "..\..\..\Product_add_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_name;

#line default
#line hidden


#line 11 "..\..\..\Product_add_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label dev_here_pls_kill_me;

#line default
#line hidden


#line 12 "..\..\..\Product_add_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_shelf;

#line default
#line hidden


#line 14 "..\..\..\Product_add_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_row;

#line default
#line hidden


#line 15 "..\..\..\Product_add_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_amount;

#line default
#line hidden


#line 19 "..\..\..\Product_add_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_save;

#line default
#line hidden


#line 20 "..\..\..\Product_add_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_cancel;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ENL-Distrobution Storage;V1.0.0.0;component/product_add_window.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Product_add_window.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.tb_name = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 2:
                    this.dev_here_pls_kill_me = ((System.Windows.Controls.Label)(target));
                    return;
                case 3:
                    this.tb_shelf = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:
                    this.tb_row = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 5:
                    this.tb_amount = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 6:
                    this.tb_desription = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 7:
                    this.btn_save = ((System.Windows.Controls.Button)(target));
                    return;
                case 8:
                    this.btn_cancel = ((System.Windows.Controls.Button)(target));

#line 20 "..\..\..\Product_add_window.xaml"
                    this.btn_cancel.Click += new System.Windows.RoutedEventHandler(this.btn_cancel_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBox tb_description;
    }
}

