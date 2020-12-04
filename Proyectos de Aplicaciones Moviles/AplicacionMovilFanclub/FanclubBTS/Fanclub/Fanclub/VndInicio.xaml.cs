using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fanclub
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VndInicio : ContentPage
    {
        public VndInicio()
        {
            InitializeComponent();
            
        }

        private void BtnEntrar_Clicked(object sender, EventArgs e)
        {
            vndFanCafe fancafe = new vndFanCafe();
            Navigation.PushAsync(fancafe);
        }

        private void BtnBTS_Clicked(object sender, EventArgs e)
        {
            vndBTS qebts = new vndBTS();
            Navigation.PushAsync(qebts);
        }
    }
}