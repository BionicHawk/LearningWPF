using System.Windows;

namespace LearningWPF
{
    public partial class MainWindow : Window
    {
        private int count = 0;

        public MainWindow()
        {
            InitializeComponent();
            tbHello.Text = $"Hello world {count}";
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            tbHello.Text = $"Hello world {++count}";
        }
    }
}