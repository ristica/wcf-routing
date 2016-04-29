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
            if (TxtInput.Text.Length < 1)
            {
                MessageBox.Show("No input to send...");
                return;
            }

            var proxy = new Proxies.ProcessClient();
            this.lblOutput.Content = proxy.DoSomething(this.TxtInput.Text);
            proxy.Close();
        }
    }
}
