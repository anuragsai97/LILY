using Android.Graphics.Drawables;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ChatbotUI.MyEntry), typeof(ChatbotUI.Android.MyEntryRenderer))]
namespace ChatbotUI.Android
{
    class MyEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                GradientDrawable gd = new GradientDrawable();              
                gd.SetCornerRadius(100);              
                gd.SetStroke(2, global::Android.Graphics.Color.LightGray);
                gd.SetColor(global::Android.Graphics.Color.White);
                //Control.SetHeight(300);
                this.Control.SetBackground(gd);
                //Control.Background = this.Resources.GetDrawable(Resources.RoundedCornerEntry);
                //Control.Background = this.Resources.GetDrawable(Resources.Drawable.RoundedCornerEntry);

            }
        }
    }
}