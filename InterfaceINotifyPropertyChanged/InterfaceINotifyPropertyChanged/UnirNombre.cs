using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceINotifyPropertyChanged
{
    public class UnirNombre : INotifyPropertyChanged
    {
        private string nombre;
        private string apellido;
        private string nombreCompleto;
        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public string Nombre {
            get { return this.nombre; }
            set { this.nombre = value;
                OnPropertyChanged(this.nombre);
            }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; 
                OnPropertyChanged(this.apellido);
            }
        }

        public string NombreCompleto
        {
            get { return this.Nombre + " " + this.Apellido; }
            set { }
        }
    }
}
