using Movil_App.Model;
using Movil_App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Movil_App.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonaPage : ContentPage
    {
        PersonaViewModel contexto = new PersonaViewModel();
        public PersonaPage()
        {
            InitializeComponent();
            BindingContext = contexto;
            LvPersonas.ItemSelected += LvPersonas_ItemSelected;
        }

        public void LvPersonas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                PersonaModel modelo = (PersonaModel)e.SelectedItem;
                Navigation.PushModalAsync(new DetallePage(modelo));

                contexto.Nombre = modelo.Nombre;
                contexto.Apellido = modelo.Apellido;
                contexto.Numero = modelo.Numero;
                contexto.Edad = modelo.Edad;
                contexto.Fecha = modelo.Fecha;
                contexto.Hora = modelo.Hora;
                contexto.Id = modelo.Id;

            }
        }

        async void btnCancelar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        async void btnMenu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}