﻿#pragma checksum "..\..\..\UI\AddTeacher.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FA5FE4C71C24E36F2E5541F26A0B7421"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.33440
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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


namespace Test1.UI {
    
    
    /// <summary>
    /// AddTeacher
    /// </summary>
    public partial class AddTeacher : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\UI\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox name;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\UI\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox firstname;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\UI\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox promotion;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\UI\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox campusY;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\UI\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Campus;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\UI\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock countCampus;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\UI\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CampusC;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\UI\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Courses;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\UI\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock countCourses;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\UI\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CoursesC;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\UI\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button envoyer;
        
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
            System.Uri resourceLocater = new System.Uri("/Test1;component/ui/addteacher.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\AddTeacher.xaml"
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
            
            #line 11 "..\..\..\UI\AddTeacher.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateGeneral);
            
            #line default
            #line hidden
            return;
            case 2:
            this.name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.firstname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.promotion = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.campusY = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.Campus = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.countCampus = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.CampusC = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\UI\AddTeacher.xaml"
            this.CampusC.Click += new System.Windows.RoutedEventHandler(this.addCampus);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Courses = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.countCourses = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.CoursesC = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\UI\AddTeacher.xaml"
            this.CoursesC.Click += new System.Windows.RoutedEventHandler(this.addCourses);
            
            #line default
            #line hidden
            return;
            case 12:
            this.envoyer = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\UI\AddTeacher.xaml"
            this.envoyer.Click += new System.Windows.RoutedEventHandler(this.createTeacherSubmit);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
