﻿#pragma checksum "..\..\..\UI\AddQuestion1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DCFE3CA95424B3D91A0A47FBB727D9CB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.33440
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Elysium.Controls;
using Elysium.Parameters;
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


namespace Test1.UI {
    
    
    /// <summary>
    /// AddQuestion
    /// </summary>
    public partial class AddQuestion : Elysium.Controls.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\UI\AddQuestion1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label test;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\UI\AddQuestion1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Courses;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\UI\AddQuestion1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox content;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\UI\AddQuestion1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox bonus;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\UI\AddQuestion1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button envoyer;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\UI\AddQuestion1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddCourses;
        
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
            System.Uri resourceLocater = new System.Uri("/Test1;component/ui/addquestion1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\AddQuestion1.xaml"
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
            this.test = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.Courses = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.content = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.bonus = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.envoyer = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\UI\AddQuestion1.xaml"
            this.envoyer.Click += new System.Windows.RoutedEventHandler(this.createQuestionSubmit);
            
            #line default
            #line hidden
            return;
            case 6:
            this.AddCourses = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

