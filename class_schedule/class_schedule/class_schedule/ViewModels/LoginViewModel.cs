using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;


using Xamarin.Forms;


namespace class_schedule.ViewModels
{
    public class LoginViewModel : BindableBase
    {
        WebView _WebView = new WebView();
        
        //_SourceWebsite = "https://prodweb.snu.in/psp/CSPROD/EMPLOYEE/HRMS/h/?tab=DEFAULT&cmd=login&errorCode=106&languageCd=ENG";
        public LoginViewModel()
        {

        }

        private DelegateCommand _LoginCommand;
        public DelegateCommand LoginCommand =>
            _LoginCommand ?? (_LoginCommand = new DelegateCommand(Login, CanLogin));

        private bool CanLogin()
        {
            return true;
        }

        private void Login()
        {
            _WebView.Source = "https://prodweb.snu.in/psp/CSPROD/EMPLOYEE/HRMS/h/?tab=DEFAULT&cmd=login&errorCode=106&languageCd=ENG";
            string user = "Enter your user name";
            string password = "Enter Your Password";
            string evaluate = "document.getElementById('userid').value = '" + user + "'";
            _WebView.Eval(evaluate);

            string evaluate2 = "document.getElementById('pwd').value = '" + password + "'";
            _WebView.Eval(evaluate2);

            string login = "document.frmUserLogin.submit.click()";
            _WebView.Eval(login);
        }
        
        



      
        

    }
}

