using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void burger_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            BurgerWindow burgerWindow = new BurgerWindow();
            
            burgerWindow.Show();
            this.Hide();
        }
    }
}