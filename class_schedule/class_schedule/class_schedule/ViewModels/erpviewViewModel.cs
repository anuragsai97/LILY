using Prism.Commands;
using Prism.Mvvm;
using System.Net;
//using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Xamarin.Forms;

namespace class_schedule.ViewModels
{
    public class erpviewViewModel : BindableBase
    {
        public erpviewViewModel()
        {
        }
        private string _HTML;
        public string HTML
        {
            get { return _HTML; }
            set { SetProperty(ref _HTML, value); }
        }

        private DelegateCommand _GetHTMLCommand;
        public DelegateCommand GetHTMLCommand =>
            _GetHTMLCommand ?? (_GetHTMLCommand = new DelegateCommand(GetHTML, CanGetHTML));

        private bool CanGetHTML()
        {
            return true;
        }

        private void GetHTML()
        {
            var url = "https://prodweb.snu.in/psp/CSPROD/EMPLOYEE/HRMS/?cmd=login";
            //var url = "https://www.google.com";
            WebRequest request = WebRequest.Create(url);
            request.BeginGetResponse((result) =>
            {
                try
                {
                    Stream stream = request.EndGetResponse(result).GetResponseStream();
                    StreamReader reader = new StreamReader(stream);

                    Device.BeginInvokeOnMainThread(() =>
                    {

                        HTML = reader.ReadToEnd();
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
        



     

