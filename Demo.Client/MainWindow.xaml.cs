using System.Windows;

namespace Demo.Client
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnDoSomething(object sender, RoutedEventArgs e)
        {
            var proxy = new Demo.Proxies.ProcessClient();
            this.lblOutput.Content = proxy.DoSomething();
            proxy.Close();
        }
    }
}
