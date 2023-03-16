using Movil_App.Model;
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

    public partial class DetallePage : ContentPage
    {
        public DetallePage(PersonaModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}