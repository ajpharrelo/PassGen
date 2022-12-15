using System;
using System.Windows;
using System.Windows.Controls;

namespace PassGen.Controls
{
    /// <summary>
    /// Interaction logic for PasswordOptions.xaml
    /// </summary>
    public partial class PasswordOptionsControl : UserControl
    {
        private PasswordOptions _passwordOptions;

        public PasswordOptionsControl(PasswordOptions options)
        {
            InitializeComponent();
            _passwordOptions = options;
            DataContext = _passwordOptions;
        }

        public PasswordOptionsControl()
        {

        }
    }
}
