using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {

        private readonly Models.MonsterViewModel _vm = new Models.MonsterViewModel();
        public MainPage()
        {
            BindingContext = _vm;
            InitializeComponent();
        }
    }
}
