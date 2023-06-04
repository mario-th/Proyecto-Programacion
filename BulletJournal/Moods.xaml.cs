using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BulletJournal
{
    /// <summary>
    /// Lógica de interacción para Moods.xaml
    /// </summary>
    public partial class Moods : Page
    {
        public Moods()
        {
            InitializeComponent();
            MostrarMoods();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mario\source\repos\BulletJournal\BulletJournal\Database1.mdf;Integrated Security=True");

        public void MostrarMoods()
        {
            SqlCommand command = new SqlCommand("SELECT Dia, Mes, Año, ComoTeSentiste, QueHicisteParaSentirteMejor FROM Moods", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DatosMoods.ItemsSource = dataTable.DefaultView;
        }

        public void GuardarMoods()
        {
            string valorDia = txtDia.Text;
            string valorMes = txtMes.Text;
            string valorAno = txtAno.Text;
            string valorComoSentiste = txtComoTeSentiste.Text;
            string valorQueHiciste = txtQueHiciste.Text;

            string guardarMood = $"INSERT INTO Moods (Dia, Mes, Año, ComoTeSentiste, QueHicisteParaSentirteMejor) VALUES (@ValorDia, @ValorMes, @ValorAno, @ValorComoSentiste, @ValorQueHiciste)";
            SqlCommand command = new SqlCommand(guardarMood, conn);
            conn.Open();
            command.Parameters.AddWithValue("@ValorDia", valorDia);
            command.Parameters.AddWithValue("@ValorMes", valorMes);
            command.Parameters.AddWithValue("@ValorAno", valorAno);
            command.Parameters.AddWithValue("@ValorComoSentiste", valorComoSentiste);
            command.Parameters.AddWithValue("@ValorQueHiciste", valorQueHiciste);
            command.ExecuteNonQuery();
            conn.Close();

            txtDia.Text = "";
            txtMes.Text = "";
            txtAno.Text = "";
            txtComoTeSentiste.Text = "";
            txtQueHiciste.Text = "";   
            MostrarMoods();
        }

        private void GuardarMood_Click(object sender, RoutedEventArgs e)
        {
            GuardarMoods();  
        }
    }
}
