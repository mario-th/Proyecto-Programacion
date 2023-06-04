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
using System.Reflection;


namespace BulletJournal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            
        }
        

        

        private void AbrirPaginaCalendario_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Calendarios());
        }

        private void AbrirPaginaMoods_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Moods());
        }

        private void AbrirPaginaHabitos_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Habitos());
        }

        private void AbrirPaginaTareas_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Tareas());
        }
    }
}
