using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SNUInternetUsage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
   
    public partial class Internet : ContentPage
    {
        double percentage;
        string url;
        int count = 0;
        string html = "";
        public Internet()
        {
            InitializeComponent();

            DataWebView.Source = "https://myaccount.snu.edu.in/login.php";
            //string firsturl = "https://myaccount.snu.edu.in/login.php";    
            DataWebView.Navigated += loginActivity;

        }

        private void loginActivity(object sender, WebNavigatedEventArgs e)
        {
            string user = "username";
            string password = "password";
            string evaluate = "document.getElementById('snuNetId').value = '" + user + "'";
            //DataWebView.Eval(evaluate);

            string evaluate2 = "document.getElementById('password').value = '" + password + "'";
            //DataWebView.Eval(evaluate2);

            string login = "document.getElementsByName(\"submit\")[0].click()";
            DataWebView.Eval(evaluate + ';' + evaluate2 + ';' + login + ';');



            DataWebView.Navigated += OnNavigatedHandler;
        }

        public void OnNavigatedHandler(object sender, WebNavigatedEventArgs args)
        {
            count++;
            url = args.Url;
            //Debug.WriteLine(url);
            if (count == 1)
            {
                string start = "2017-11-08";
                string end = "2017-11-09";
                string e1 = "document.getElementById('startDate').value = '" + start + "'";
                string e2 = "document.getElementById('endDate').value = '" + end + "'";
                string submit = "document.getElementsByName(\"submit\")[0].click()";


                DataWebView.Eval(e1 + ';' + e2 + ';' + submit + ';');


                DataWebView.Navigated += GetHTMLAsync;

            }


        }

        

        static string DecodeEncodedNonAsciiCharacters(string value)
        {
            return Regex.Replace(
                value,
                @"\\u(?<Value>[a-zA-Z0-9]{4})",
                m => {
                    return ((char)int.Parse(m.Groups["Value"].Value, NumberStyles.HexNumber)).ToString();
                });
        }

       


        private async void GetHTMLAsync(object sender, WebNavigatedEventArgs e)
        {
            string es = "document.body.innerHTML";
            string result = await DataWebView.EvaluateJavascript(es);

            //byte[] bytes = Encoding.UTF8.GetBytes(result);
            //result = Encoding.UTF8.GetString(bytes,0,result.Length);

            result = DecodeEncodedNonAsciiCharacters(result);
            //Console.WriteLine(decoded);

            //var t= Encoding.GetEncoding(result);
            result = Regex.Replace(result, @"\\t|\\n|\\r", "");

            int index = result.IndexOf("</th></tr></tfoot>");
            int startindex = index - 4;
            string finaldata = result.Substring(startindex, 4);

            if (finaldata.Contains(">"))
            {
                int ind = finaldata.IndexOf(">");
                finaldata = finaldata.Substring(ind+1);
            }
           

            double fd = double.Parse(finaldata, CultureInfo.InvariantCulture);
            double td = 3.0;

            data.Text = finaldata;

            if (fd < td)
            {
                percentage = fd / td;
            }
            else
            {
                percentage = 1;
            }

            //Device.StartTimer(TimeSpan.FromSeconds(0.02), OnTimer);
            //OnTimer(percentage);
            //Device.StartTimer(TimeSpan.FromSeconds(0.2), OnTimer);
            //while (true)
            //{
            //    OnTimer(percentage);
            //}
            Xamarin.Forms.Device.StartTimer(TimeSpan.FromSeconds(.02), OnTimer);



        }

        private bool OnTimer()
        {
            var progress = (progressControl.Progress + .01);
            if (progress > percentage)
            {
                return false;
                //progress = 0;
            }
            progressControl.Progress = progress;
            return true;
        }
        
    }
}