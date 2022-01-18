using System.Windows;

namespace WindowsKeyExtractor
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TbPassword.Text = KeyExtractor.GetWindowsProductKey();
        }
    }
}
