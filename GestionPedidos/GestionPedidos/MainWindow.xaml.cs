using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Data.SqlClient;
using System.Data;

namespace GestionPedidos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection miConexionSQL;

        public MainWindow()
        {
            InitializeComponent();
            string cadenaConexion = ConfigurationManager.ConnectionStrings["GestionPedidos.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;
            miConexionSQL = new SqlConnection(cadenaConexion);
            CargarClientes();
        }

        private void CargarClientes()
        {
            string sql = "SELECT * FROM Cliente";
            SqlDataAdapter adaptador = new SqlDataAdapter(sql, miConexionSQL);

            using (adaptador)
            {
                DataTable dtClientes = new DataTable();
                adaptador.Fill(dtClientes);

                lstClientes.DisplayMemberPath = "Nombre";
                lstClientes.SelectedValuePath = "Id";
                lstClientes.ItemsSource = dtClientes.DefaultView;
            }
        }

        private void CargarPedidosCliente()
        {
            string sql = "SELECT * FROM Pedido WHERE CveCliente = @CveCliente";

            SqlCommand comando = new SqlCommand(sql, miConexionSQL);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            using (adaptador)
            {
                comando.Parameters.AddWithValue("@CveCliente", lstClientes.SelectedValue);

                DataTable dtPedidos = new DataTable();
                adaptador.Fill(dtPedidos);

                lstPedidosCte.DisplayMemberPath = "FechaPedido";
                lstPedidosCte.SelectedValuePath = "Id";
                lstPedidosCte.ItemsSource = dtPedidos.DefaultView;
            }
        }

        private void lstClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CargarPedidosCliente();
        }
    }
}
