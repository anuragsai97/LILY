using Android.Graphics.Drawables;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ChatbotUI.MyButton), typeof(ChatbotUI.Android.MyButtonRenderer))]
namespace ChatbotUI.Android
{
    class MyButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                GradientDrawable gd = new GradientDrawable();
                gd.SetCornerRadius(100);
                //gd.SetStroke(2, global::Android.Graphics.Color.LightGray);
                gd.SetColor(global::Android.Graphics.Color.LightSeaGreen);
                //Control.SetHeight(300);
                //gd.SetColor(#48C9B0);
                this.Control.SetBackground(gd);
                //Control.Background = this.Resources.GetDrawable(Resources.RoundedCornerEntry);
                //Control.Background = this.Resources.GetDrawable(Resources.Drawable.RoundedCornerEntry);

            }
        }

       
    }
}