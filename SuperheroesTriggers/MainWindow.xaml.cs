using System.Security.AccessControl;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SuperheroesTriggers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private List<Superheroe> listaSuperheroes;
        private MainWindowVM vm;
        public MainWindow()
        {
            InitializeComponent();

            vm = new MainWindowVM();
            this.DataContext = vm;

            //listaSuperheroes = Superheroe.GetSamples(); // Obtiene la lista de superhéroes.
            //superheroeDockPanel.DataContext = listaSuperheroes.FirstOrDefault(); // Muestra el primer superhéroe de la lista.
            //actualTextBlock.Text = "1"; // Inicializa el contador de superhéroes. Tomará valores de 1 a 3.
            //totalTextBlock.Text = listaSuperheroes.Count.ToString();
        }

        private void leftImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            vm.Anterior();

            //int actual = Int32.Parse(actualTextBlock.Text);

            //// Entra únicamente si "actual" es mayor que 1.
            //if (actual > 1)
            //{
            //    superheroeDockPanel.DataContext = listaSuperheroes[actual - 2]; // Muestra el superhéroe anterior.
            //    actualTextBlock.Text = (actual - 1).ToString(); // Decrementa el contador de la vista.
            //}
        }

        private void rightImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            vm.Siguiente();

            //int actual = Int32.Parse(actualTextBlock.Text);

            //if (actual < listaSuperheroes.Count)
            //{
            //    superheroeDockPanel.DataContext = listaSuperheroes[actual];
            //    actualTextBlock.Text = (actual + 1).ToString();
            //}
        }
    }
}