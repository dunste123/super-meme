using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KentekenShit.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KentekenShit.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LookupPage : ContentPage
    {
        LookupViewModel viewModel;
        
        public LookupPage()
        {
            InitializeComponent();
            
            BindingContext = viewModel = new LookupViewModel();
        }
    }
}