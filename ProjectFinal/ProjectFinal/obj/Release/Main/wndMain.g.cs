﻿#pragma checksum "..\..\..\Main\wndMain.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5A2490A24FA0F765BAAACC5FEF047E456048DC58"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Main;
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


namespace Main {
    
    
    /// <summary>
    /// wndMain
    /// </summary>
    public partial class wndMain : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\Main\wndMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridView1;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Main\wndMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button create_btn;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Main\wndMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button edit_btn;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Main\wndMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delete_btn;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Main\wndMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridView2;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Main\wndMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridView3;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjectFinal;component/main/wndmain.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Main\wndMain.xaml"
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
            
            #line 12 "..\..\..\Main\wndMain.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 15 "..\..\..\Main\wndMain.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dataGridView1 = ((System.Windows.Controls.DataGrid)(target));
            
            #line 18 "..\..\..\Main\wndMain.xaml"
            this.dataGridView1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGridView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.create_btn = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Main\wndMain.xaml"
            this.create_btn.Click += new System.Windows.RoutedEventHandler(this.Create_btn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.edit_btn = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.delete_btn = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Main\wndMain.xaml"
            this.delete_btn.Click += new System.Windows.RoutedEventHandler(this.delete_btn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.dataGridView2 = ((System.Windows.Controls.DataGrid)(target));
            
            #line 22 "..\..\..\Main\wndMain.xaml"
            this.dataGridView2.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGridView2_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.dataGridView3 = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

