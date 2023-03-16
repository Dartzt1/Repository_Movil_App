using Movil_App.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movil_App.Servicio
{
    public class PersonaServicio
    {
        public ObservableCollection<PersonaModel> personas { get; set; }

        public PersonaServicio() 
        { 
            if (personas==null)
            {
                personas = new ObservableCollection<PersonaModel>();
            }
        }

        public ObservableCollection<PersonaModel> Consultar() {
            return personas;
        }

        public void Guardar(PersonaModel modelo)
        {
            personas.Add(modelo);
        }

        public void Modificar(PersonaModel modelo) 
        { 
            for (int i = 0; i < personas.Count; i++) 
            { 
                if (personas[i].Id==modelo.Id)
                {
                    personas[i] = modelo;
                }
            }
        }

        public void Eliminar(string idPersonas)
        {
            PersonaModel model = personas.FirstOrDefault(p=>p.Id == idPersonas);
            personas.Remove(model);
        }


    }
}
