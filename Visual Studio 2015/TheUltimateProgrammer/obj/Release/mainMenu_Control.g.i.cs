﻿#pragma checksum "..\..\mainMenu_Control.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "559D0D9A1062D4981449B1826D233FB4"
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
using TheUltimateProgrammer;


namespace TheUltimateProgrammer {
    
    
    /// <summary>
    /// mainMenu_Control
    /// </summary>
    public partial class mainMenu_Control : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\mainMenu_Control.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Titel;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\mainMenu_Control.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Play_game;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\mainMenu_Control.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Help;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\mainMenu_Control.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button about;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\mainMenu_Control.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button quit_game;
        
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
            System.Uri resourceLocater = new System.Uri("/TheUltimateProgrammer;component/mainmenu_control.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\mainMenu_Control.xaml"
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
            this.Titel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.Play_game = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\mainMenu_Control.xaml"
            this.Play_game.Click += new System.Windows.RoutedEventHandler(this.Play_game_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Help = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.about = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\mainMenu_Control.xaml"
            this.about.Click += new System.Windows.RoutedEventHandler(this.about_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.quit_game = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\mainMenu_Control.xaml"
            this.quit_game.Click += new System.Windows.RoutedEventHandler(this.quit_game_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
