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
using System.Windows.Resources;
using System.Resources;

namespace MeowBand_project
{
    /// <summary>
    /// Interaction logic for Upload.xaml
    /// </summary>
    public partial class Upload : UserControl
    {
        public Upload()
        {
            InitializeComponent();

            genre_cb.Items.Add("Ambient");
            genre_cb.Items.Add("Chillstep");
        }

        private void cover_btn_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".png";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();



            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                filename_tb.Text = filename;
                BitmapImage image = new BitmapImage(new Uri(filename, UriKind.Absolute));
                cover_img.Source = image;


            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void compos_btn_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".mp3";
            dlg.Filter = "MP3 Files (*.mp3)|*.mp3|WAV Files (*.wav)|*.wav|MPEG-4 Files (*.mpeg-4)|*.mpeg-4|FLAC Files (*.flac)|*.flac|OGG Files (*.ogg)|*.ogg";

            Nullable <bool> result = dlg.ShowDialog();
            
            if (result == true)
            {
                string filename = dlg.FileName;
                filenamecompos_tb.Text = filename;

            }
            
        }
    }
}
