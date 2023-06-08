using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticaListBoxWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Municipio> municipios = new List<Municipio>();
            municipios.AddRange(new Municipio[] {
                new Municipio(){ Nombre= "Monterrey", Temperatura= 42},
                new Municipio(){ Nombre= "Guadalupe", Temperatura= 40},
                new Municipio(){ Nombre= "Escobedo", Temperatura= 38},
                new Municipio(){ Nombre= "Cadereyta", Temperatura= 34},
                new Municipio(){ Nombre= "Santa Catarina", Temperatura= 34},
                new Municipio(){ Nombre= "Juarez", Temperatura= 36},
                new Municipio(){ Nombre= "García", Temperatura= 37},
                new Municipio(){ Nombre= "El Carmen", Temperatura= 35}
            });

            lstMunicipios.ItemsSource = municipios;
        }
    }
}
