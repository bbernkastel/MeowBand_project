using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace MeowBand_project
{
    /// <summary>
    /// Interaction logic for MyUploads.xaml
    /// </summary>
    public partial class MyUploads : UserControl
    {
        public MyUploads()
        {
            InitializeComponent();
        }

        private void edit_btn_Click(object sender, RoutedEventArgs e)
        {
            // < Frame x: Name = "myuploads_frame" Source = "MyUploads.xaml" NavigationUIVisibility = "Automatic" HorizontalAlignment = "Stretch" VerticalAlignment = "Stretch" HorizontalContentAlignment = "Stretch" />
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new Uri("Edit.xaml", UriKind.Relative));
            

        }
    }
}
