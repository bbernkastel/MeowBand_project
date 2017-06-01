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
    /// Interaction logic for Composition.xaml
    /// </summary>
    public partial class Composition : UserControl
    {
        public Composition()
        {
            InitializeComponent();
        }

        private void go_back_btn_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow.FindName("home_frame") as Frame).NavigationService.GoBack();
        }
    }
}
