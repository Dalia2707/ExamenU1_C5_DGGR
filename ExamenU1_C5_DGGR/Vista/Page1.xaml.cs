using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenU1_C5_DGGR.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenU1_C5_DGGR.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            BindingContext = new VMpage1(Navigation);
        }
    }
}