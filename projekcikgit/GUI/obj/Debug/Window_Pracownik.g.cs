#pragma checksum "..\..\Window_Pracownik.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6115D82592C5151100301CCB14B5A2AE4145AEEA0305B299C54C6007A8CFC59C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using GUI;
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


namespace GUI {
    
    
    /// <summary>
    /// Window_Pracownik
    /// </summary>
    public partial class Window_Pracownik : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Window_Pracownik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ZATBTN;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Window_Pracownik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ANBTN;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Window_Pracownik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox imieTXT;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Window_Pracownik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NazwiskoTXT;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Window_Pracownik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PeselTXT;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Window_Pracownik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TelTXT;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Window_Pracownik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox wiekTXT;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Window_Pracownik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mailTXT;
        
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
            System.Uri resourceLocater = new System.Uri("/GUI;component/window_pracownik.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window_Pracownik.xaml"
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
            this.ZATBTN = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\Window_Pracownik.xaml"
            this.ZATBTN.Click += new System.Windows.RoutedEventHandler(this.ZATBTN_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ANBTN = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\Window_Pracownik.xaml"
            this.ANBTN.Click += new System.Windows.RoutedEventHandler(this.ANBTN_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.imieTXT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.NazwiskoTXT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.PeselTXT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TelTXT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.wiekTXT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.mailTXT = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

