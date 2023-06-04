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

namespace BulletJournal
{
    /// <summary>
    /// Lógica de interacción para Calendarios.xaml
    /// </summary>
    public partial class Calendarios : Page
    {
        public Calendarios()
        {
            InitializeComponent();
        }

        /* private void SeleccionarFecha(object sender, SelectionChangedEventArgs e)
         {
             DateTime selectedDate = calendario.SelectedDate.GetValueOrDefault();

             // Lógica para obtener las notas correspondientes a la fecha seleccionada y mostrarlas en el TextBox
             string notes = GetNotesForDate(selectedDate);
             noteTextBox.Text = notes;
         }

         private string GetNotesForDate(DateTime date)
         {
             // Lógica para obtener las notas de la base de datos para la fecha especificada
             // Retorna las notas correspondientes como una cadena de texto
             Console.WriteLine("hola");
         }

         private void SaveNotesForDate(DateTime date, string notes)
         {
             // Lógica para guardar las notas en la base de datos para la fecha especificada
         }
         */
    }
}
