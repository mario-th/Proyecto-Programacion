using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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

namespace BulletJournal
{
    /// <summary>
    /// Lógica de interacción para Tareas.xaml
    /// </summary>
    public partial class Tareas : Page
    {
        public Tareas()
        {
            InitializeComponent();
            MostrarDatos();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mario\source\repos\BulletJournal\BulletJournal\Database1.mdf;Integrated Security=True");
        private void MostrarDatos()
        {
            SqlCommand command = new SqlCommand("SELECT Id, Dia, Mes, Tarea FROM Tareas", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            VerDatos.ItemsSource = dataTable.DefaultView;

        }

        public void GuardarDatos()
        {
            string valorID = txtId.Text;
            string valorDia = txtDia.Text;
            string valorMes = txtMes.Text;
            string valorTarea = txtTarea.Text;

            
            string guardarData = $"INSERT INTO Tareas (Id, Dia, Mes, Tarea) VALUES (@ValorId, @ValorDia, @ValorMes, @ValorTarea)";
            SqlCommand command = new SqlCommand(guardarData, conn);
            conn.Open();

            command.Parameters.AddWithValue("@ValorId", valorID);
            command.Parameters.AddWithValue("@ValorDia", valorDia);
            command.Parameters.AddWithValue("@ValorMes", valorMes);
            command.Parameters.AddWithValue("@ValorTarea", valorTarea);
            
            command.ExecuteNonQuery();
            conn.Close();
            txtId.Text = "";
            txtDia.Text = "";
            txtMes.Text = "";
            txtTarea.Text = "";
            MostrarDatos();
        }

        public void eliminarDatos()
        {
            conn.Open();
            string valorID = txtId.Text;
            string eliminarData = "DELETE FROM Tareas WHERE Id = @ValorId";
            SqlCommand command = new SqlCommand(eliminarData, conn);
            command.Parameters.AddWithValue("@ValorId", valorID);
            command.ExecuteNonQuery();
            conn.Close();
            txtId.Text = "";
            MostrarDatos();
        }

        private void GuardarInfo_Click(object sender, RoutedEventArgs e)
        {
            GuardarDatos();
        }

        private void EliminarInfo_Click(object sender, RoutedEventArgs e)
        {
            eliminarDatos();
        }
    }
}
