using Xamarin.Forms;

namespace class_schedule.Views
{
    public partial class Login : ContentPage
    {
       
        
        public Login()
        {
            InitializeComponent();
            DataWebView.Source = "https://prodweb.snu.in/psp/CSPROD/EMPLOYEE/HRMS/h/?tab=DEFAULT&cmd=login&errorCode=106&languageCd=ENG";           



        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            //DataWebView.Source = "https://prodweb.snu.in/psp/CSPROD/EMPLOYEE/HRMS/h/?tab=DEFAULT&cmd=login&errorCode=106&languageCd=ENG";
            string user = "rk827";
            string password = "Silpruf20@";
            string evaluate = "document.getElementById('userid').value = '" + user + "'";
            //DataWebView.Eval(evaluate);

            string evaluate2 = "document.getElementById('pwd').value = '" + password + "'";
            //DataWebView.Eval(evaluate2);

            string login = "document.getElementsByName(\"Submit\")[0].click()";
            DataWebView.Eval(evaluate + ';'+evaluate2+';'+login+';');
        }
    }
}
