﻿#pragma checksum "..\..\..\Search\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B532C1F27997AD59785EE071CD803219FF718D31"
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
using wndSearch;


namespace wndSearch {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Search\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid invoiceGrid;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Search\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmboxInvoiceID;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Search\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmboxInvoicePrice;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Search\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmboxInvoiceDate;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Search\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdSelect;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Search\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdCancel;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Search\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblInvoiceID;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Search\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblInvoicePrice;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Search\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblInvoiceDate;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Search\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblInvoiceChoice;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Search\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTitle;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjectFinal;component/search/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Search\MainWindow.xaml"
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
            this.invoiceGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.cmboxInvoiceID = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\..\Search\MainWindow.xaml"
            this.cmboxInvoiceID.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmboxInvoiceID_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cmboxInvoicePrice = ((System.Windows.Controls.ComboBox)(target));
            
            #line 16 "..\..\..\Search\MainWindow.xaml"
            this.cmboxInvoicePrice.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmboxInvoicePrice_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cmboxInvoiceDate = ((System.Windows.Controls.ComboBox)(target));
            
            #line 17 "..\..\..\Search\MainWindow.xaml"
            this.cmboxInvoiceDate.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmboxInvoiceDate_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cmdSelect = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Search\MainWindow.xaml"
            this.cmdSelect.Click += new System.Windows.RoutedEventHandler(this.cmdSelect_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cmdCancel = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Search\MainWindow.xaml"
            this.cmdCancel.Click += new System.Windows.RoutedEventHandler(this.cmdCancel_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lblInvoiceID = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.lblInvoicePrice = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.lblInvoiceDate = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.lblInvoiceChoice = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.lblTitle = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

