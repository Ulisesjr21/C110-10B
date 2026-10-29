
using System.Windows;

namespace HelloWpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SayHello_Click(object sender,
            RoutedEventArgs e)
        {
            Greeting greeting = new Greeting("Ulises");
            MessageText.Text = greeting.BuildMessage();
        }
    }
}
