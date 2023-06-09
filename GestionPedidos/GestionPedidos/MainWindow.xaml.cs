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
using Microsoft.IdentityModel.Tokens;

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
            try
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
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarPedidosCliente()
        {
            try
            {
                //string sql = "SELECT * FROM Pedido WHERE CveCliente = @CveCliente";
                string sql = "SELECT Id, ('#' + CAST(Id As varchar) + ' ' + CAST(FechaPedido As varchar) + ' ' + CAST(FormaPago As varchar)) As Pedido FROM Pedido WHERE CveCliente = @CveCliente";

                SqlCommand comando = new SqlCommand(sql, miConexionSQL);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                using (adaptador)
                {
                    comando.Parameters.AddWithValue("@CveCliente", lstClientes.SelectedValue);

                    DataTable dtPedidos = new DataTable();
                    adaptador.Fill(dtPedidos);

                    lstPedidosCte.DisplayMemberPath = "Pedido";
                    lstPedidosCte.SelectedValuePath = "Id";
                    lstPedidosCte.ItemsSource = dtPedidos.DefaultView;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*
        private void lstClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CargarPedidosCliente();
        }
        */

        private void btnEliminarPedido_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string pedido = lstPedidosCte.SelectedValue is null ? "" : lstPedidosCte.SelectedValue.ToString();

                if (string.IsNullOrEmpty(pedido))
                {
                    MessageBox.Show("Seleccione el pedido que desea eliminar.");
                }
                else
                {
                    if (MessageBox.Show($"¿Desea eliminar el pedido #{pedido}?", "Confirmación de eliminación", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        string sql = "DELETE FROM Pedido WHERE Id = @IdPedido";
                        SqlCommand comando = new SqlCommand(sql, miConexionSQL);
                        miConexionSQL.Open();
                        comando.Parameters.AddWithValue("@IdPedido", pedido);
                        comando.ExecuteNonQuery();
                        miConexionSQL.Close();
                        CargarPedidosCliente();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardarCliente_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(MessageBox.Show("¿Desea guardar cliente?", "Confirmación de guardado", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    string sql = "INSERT INTO Cliente (Nombre) VALUES (@nombre)";
                    SqlCommand comando = new SqlCommand( sql, miConexionSQL);
                    miConexionSQL.Open();
                    comando.Parameters.AddWithValue("@nombre", txtCliente.Text);
                    comando.ExecuteNonQuery();
                    miConexionSQL.Close();
                    txtCliente.Clear();
                    CargarClientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminaCte_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string cliente = lstClientes.SelectedValue is null ? "" : lstClientes.SelectedValue.ToString();

                if (string.IsNullOrEmpty(cliente))
                {
                    MessageBox.Show("Seleccione el cliente que desea eliminar.");
                }
                else
                {
                    if (MessageBox.Show("¿Desea eliminar el cliente?", "Confirmación de eliminación", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        string sql = "DELETE FROM Cliente WHERE Id = @IdCte";
                        SqlCommand comando = new SqlCommand(sql, miConexionSQL);
                        miConexionSQL.Open();
                        comando.Parameters.AddWithValue("@IdCte", cliente);
                        comando.ExecuteNonQuery();
                        miConexionSQL.Close();
                        CargarClientes();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstClientes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            CargarPedidosCliente();
        }

        private void btnModificaCte_Click(object sender, RoutedEventArgs e)
        {
            string cliente = lstClientes.SelectedValue is null ? "" : lstClientes.SelectedValue.ToString();

            if (cliente.IsNullOrEmpty())
            {
                MessageBox.Show("Seleccione el cliente que desea modificar.");
                return;
            }
            
            DatosCliente ventanaDatosCte = new DatosCliente(int.Parse(cliente));

            try
            {
                string sql = "SELECT Nombre FROM Cliente WHERE Id = @IdCte";

                SqlCommand comando = new SqlCommand(sql, miConexionSQL);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                using (adaptador)
                {
                    comando.Parameters.AddWithValue("@IdCte", lstClientes.SelectedValue);
                    DataTable datosCliente = new DataTable();
                    adaptador.Fill(datosCliente);

                    ventanaDatosCte.txtNombre.Text = datosCliente.Rows[0]["Nombre"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ventanaDatosCte.ShowDialog();
            CargarClientes();
        }
    }
}
