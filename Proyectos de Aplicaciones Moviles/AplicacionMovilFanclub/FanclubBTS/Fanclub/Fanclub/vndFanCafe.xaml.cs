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
    public partial class vndFanCafe : ContentPage
    {
        Fancafe FC = new Fancafe();
        vndRegistrar vndR = new vndRegistrar();

        public vndFanCafe()
        {
            InitializeComponent();
            FC.Abrir();
            lstArmys.ItemsSource = FC.listaArmy;
            vndR.ArmyAgregado += VndR_ArmyAgregado;

            
        }

        private void VndR_ArmyAgregado(object sender, EventArgs e)
        {
            try
            {
                FC.Agregar((Army)vndR.BindingContext);
                lstArmys.ItemsSource = null;
                lstArmys.ItemsSource = FC.listaArmy;
            }
            catch (Exception m)
            {
                DisplayAlert("Mensaje", m.Message.ToString(), "Aceptar");
            }
        }

        private void ToolAgregar_Clicked(object sender, EventArgs e)
        {
            Army ar = new Army();
            vndR.BindingContext = ar;
            Navigation.PushAsync(vndR);
        }

        private async void BtnEliminar_Clicked(object sender, EventArgs e)
        {
            MenuItem men = (MenuItem)sender;
            Army a = men.BindingContext as Army;
            if (await DisplayAlert("Eliminar Usuario", $"Deseas eliminar al usuario {a.Usuario}?", "Aceptar", "Cancelar"))
            {
                FC.Eliminar(a);
                lstArmys.ItemsSource = null;
                lstArmys.ItemsSource = FC.listaArmy;
            }
        }
        vndVer vndV = new vndVer();
        private void BtnVer_Clicked(object sender, EventArgs e)
        {
            MenuItem m = (MenuItem)sender;
            Army a = m.BindingContext as Army;
            vndV.BindingContext = a;
            Navigation.PushAsync(vndV);
        }
        vndEditar VndE = new vndEditar();
        private void BtnEditar_Clicked(object sender, EventArgs e)
        {
            MenuItem m = (MenuItem)sender;
            Army a = m.BindingContext as Army;
            VndE.BindingContext = a;
            Navigation.PushAsync(VndE);
            VndE.EditarArmy += VndE_EditarArmy;
            
        }

        private void VndE_EditarArmy(object sender, EventArgs e)
        {
            FC.Editar((Army)VndE.BindingContext);
            lstArmys.ItemsSource = null;
            lstArmys.ItemsSource = FC.listaArmy;
        }
    }
}