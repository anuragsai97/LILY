//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SNUInternetUsage {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("C:\\Users\\PDN SRNIVAS\\source\\repos\\SNUInternetUsage\\SNUInternetUsage\\SNUInternetUs" +
        "age\\Internet.xaml")]
    public partial class Internet : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::SNUInternetUsage.CircularProgressControl progressControl;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Label data;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::SNUInternetUsage.CustomRenderer.WebViewer DataWebView;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(Internet));
            progressControl = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::SNUInternetUsage.CircularProgressControl>(this, "progressControl");
            data = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "data");
            DataWebView = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::SNUInternetUsage.CustomRenderer.WebViewer>(this, "DataWebView");
        }
    }
}
