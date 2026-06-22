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

namespace WPF_Layout_Demo
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

        private void btnStackPanel_Click(object sender, RoutedEventArgs e)
        {
            new StackPanelDemo().Show();
        }

        private void btnWrapPanel_Click(object sender, RoutedEventArgs e)
        {
            new WrapPanelDemo().Show();
        }

        private void btnCanvas_Click(object sender, RoutedEventArgs e)
        {
            new CanvasDemo().Show();
        }

        private void btnDockPanel_Click(object sender, RoutedEventArgs e)
        {
            new DockPanelDemo().Show();
        }

        private void btnGrid_Click(object sender, RoutedEventArgs e)
        {
            new GridDemo().Show();
        }
    }
}