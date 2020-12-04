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
    public partial class vndEditar : ContentPage
    {
        public event EventHandler EditarArmy;
        public vndEditar()
        {
            InitializeComponent();
        }

        private void ToolbEditar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
            EditarArmy.Invoke(this, new EventArgs());
        }
    }
}