using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace repaso.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            InitializeComponent();
            txtUsuario.Text = usuario;
        }

        private void btnCalcula_Clicked(object sender, EventArgs e)
        {
            try
            {
                double precio = Convert.ToDouble(txtPrecio.Text);
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                double valor = Convert.ToDouble(precio * cantidad);
                DisplayAlert("VALOR TOTAL DEL PRODUCTO", valor.ToString(), "Cerrar");
            }
            catch (Exception ex)
            {
                DisplayAlert("HA OCURRIDO UN ERROR", ex.Message, "Cerrar");
            }
        }
    }
}