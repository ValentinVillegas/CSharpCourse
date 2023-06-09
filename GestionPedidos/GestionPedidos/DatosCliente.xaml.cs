using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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
using System.Windows.Shapes;

namespace GestionPedidos
{
    /// <summary>
    /// Lógica de interacción para DatosCliente.xaml
    /// </summary>
    public partial class DatosCliente : Window
    {
        SqlConnection miConexionSQL;
        int idCliente;

        public DatosCliente(int idCliente)
        {
            InitializeComponent();
            this.idCliente = idCliente;
            string cadenaConexion = ConfigurationManager.ConnectionStrings["GestionPedidos.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;
            miConexionSQL = new SqlConnection(cadenaConexion);
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los datos del cliente?", "Confirmación de guardado", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    string sql = "UPDATE Cliente SET Nombre = @nombre WHERE Id = @idCte";
                    SqlCommand comando = new SqlCommand(sql, miConexionSQL);
                    miConexionSQL.Open();
                    comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    comando.Parameters.AddWithValue("@idCte", idCliente);
                    comando.ExecuteNonQuery();
                    miConexionSQL.Close();
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
