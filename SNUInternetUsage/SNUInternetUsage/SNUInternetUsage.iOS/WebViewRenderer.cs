using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using SNUInternetUsage.CustomRenderer;
using System.Threading.Tasks;

[assembly: ExportRenderer(typeof(SNUInternetUsage.CustomRenderer.WebViewer), typeof(SNUInternetUsage.iOS.WebViewRender))]


namespace SNUInternetUsage.iOS
{
    public class WebViewRender : WebViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            var webView = e.NewElement as WebViewer;
            if (webView != null)
                webView.EvaluateJavascript = (js) =>
                {
                    return Task.FromResult(this.EvaluateJavascript(js));
                };
        }

    }
}