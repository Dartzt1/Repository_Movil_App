using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Movil_App.Model
{
    public class PersonaModel:INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        public void OnPropertyChanged([CallerMemberName]string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }

		private bool isBusy=false;

		public bool Isbusy
		{
			get { return isBusy=false; }
			set { isBusy= value;
                OnPropertyChanged();
            }
		}


		private string id;

		public string Id
		{
			get { return id; }
			set { 
				id = value;
				OnPropertyChanged();
			}
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(NombreCompleto));
            }
		}


		private string apellido;

		public string Apellido
		{
			get { return apellido; }
			set { apellido = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(NombreCompleto));
            }
		}

        private int numero;

        public int Numero
        {
            get { return numero; }
            set
            {
                numero = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }

        private int edad;

		public int Edad
		{
			get { return edad; }
			set { edad = value;
                OnPropertyChanged();
            }
		}

		private string nombreCompleto;

		public string NombreCompleto
		{
			get { return $"{Nombre} {Apellido} {numero}"; 
			
			}
			set { nombreCompleto = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Mensaje));
            }
		}

		private string mensaje;

        public string Mensaje
		{
			get {
				return $"Tu nombre es {NombreCompleto}";
				}
		}

    }
}
