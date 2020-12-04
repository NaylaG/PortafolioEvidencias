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
    public partial class vndRegistrar : ContentPage
    {
        public event EventHandler ArmyAgregado;
        public vndRegistrar()
        {
            InitializeComponent();
        }

        private void ToolAgregar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
            ArmyAgregado.Invoke(this, new EventArgs());
        }
    }
}