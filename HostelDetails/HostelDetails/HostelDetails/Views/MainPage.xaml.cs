using System;
using System.IO;
using System.Net;
using Xamarin.Forms;

namespace HostelDetails.Views
{
    public partial class MainPage : ContentPage
    {
        string name="Anurag";
        public MainPage()
        {
            InitializeComponent();

        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            //string hostel_details;
            Uri uri = new Uri("http://192.168.1.37/hostel.php?name="+name);
            WebRequest request = WebRequest.Create(uri);
            request.BeginGetResponse((result) =>
            {
                try
                {
                    Stream stream = request.EndGetResponse(result).GetResponseStream();
                    StreamReader reader = new StreamReader(stream);

                    Device.BeginInvokeOnMainThread(() =>
                    {
                        
                        hello.Text = reader.ReadToEnd();
                        //hostel_details = reader.ReadToEnd();

                    });
                }
                catch (Exception exc)
                {
                }
            }, null);




            
        }
    }
}
