using System.Diagnostics;
using System.Threading.Tasks;
using PassGen.Controls;
using System.Windows;
using System.Text.Json;
using System.Windows.Controls;

namespace PassGen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public PasswordOptions Options = new PasswordOptions();

        public MainWindow()
        {
            InitializeComponent();
            PasswordOptionsControl control = new PasswordOptionsControl(Options);
            mainGrid.Children.Add(control);
            control.Margin = new Thickness(5, 5, 5, 5); 
            Grid.SetRow(control, 1);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtPass.Text = PasswordGenerator.GeneratePassword(15, Options);
            BtnCopy.IsEnabled = true;
        }

        private void BtnCopy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(txtPass.Text);
        }
    }
}
