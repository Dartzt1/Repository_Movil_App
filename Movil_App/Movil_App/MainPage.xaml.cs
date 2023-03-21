using Movil_App.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Movil_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            MainPage selectItem = e.SelectedItem as MainPage;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            MainPage selectItem = e.Item as MainPage;
        }

        async void btnAgendar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PersonaPage());
        }
    }
}
