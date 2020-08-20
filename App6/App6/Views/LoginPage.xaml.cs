using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private string _text1 = "";
        public string Text1
        {
            get { return _text1; }
            set
            {
                if (_text1 != value)
                {
                    _text1 = value;
                    OnPropertyChanged(nameof(Text1));
                }
            }
        }

        private string _text2 = "";
        public string Text2
        {
            get { return _text2; }
            set
            {
                if (_text2 != value)
                {
                    _text2 = value;
                    OnPropertyChanged(nameof(Text2));
                }
            }
        }

        public void OnTapMode0(object sender, EventArgs args) { AppShell.Instance.Mode = 0; Text1 = "Login/LastClicked/000"; Text2 = "Login/LastClicked/000"; }
        public void OnTapMode1(object sender, EventArgs args) { AppShell.Instance.Mode = 1; Text1 = "Login/LastClicked/111"; Text2 = "Login/LastClicked/111"; }
        public void OnTapMode2(object sender, EventArgs args) { AppShell.Instance.Mode = 2; Text1 = "Login/LastClicked/222"; Text2 = "Login/LastClicked/222"; }

    }
}