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

namespace WpfEventsApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string str = "sender: " + (sender as Button).Name.ToString() + "\n";
            string str = "source: " + (e.Source as Button).Name.ToString() + "\n";
            str += "original source: " + (e.OriginalSource as Button).Name.ToString() + "\n\n";

            tablo.Text += str;
        }

        //private void pink_PreviewMouseDown(object sender, RoutedEventArgs e)
        //{
        //    string str = "sender: " + (sender as Button).Name.ToString() + "\n";
        //    str += "source: " + (e.Source as Button).Name.ToString() + "\n\n";
        //    //str += "original source: " + (e.OriginalSource as Button).Name.ToString() + "\n\n";

        //    tablo.Text += str;
        //}

        //private void pink_PreviewKeyDown(object sender, RoutedEventArgs e)
        //{
        //    string str = "sender: " + (sender as Button).Name.ToString() + "\n";
        //    str += "source: " + (e.Source as Button).Name.ToString() + "\n";
        //    str += "original source: " + (e.OriginalSource as Button).Name.ToString() + "\n\n";

        //    tablo.Text += str;
        //}
    }
}