using System.ComponentModel;
using System.Diagnostics;
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

namespace IceSky.WpfConverters.Sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this; 
            btnHelp.Click += (o, e) =>
            {
                var url = "https://iceskydev.github.io/AppDoc/dev/en/WpfConverters.html";
                Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
            };
        }
    }

    public enum TestEnum
    {
        [Description("选项一")] Option1,
        [Description("选项二")] Option2,
        [Description("选项三")] Option3
    }
}