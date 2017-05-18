using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace MeowBand_project
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Window
    {
        public MainPage()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
            meowPlayer.Source = new Uri(@"Resources\LoginScreenLoop.mp3", UriKind.Relative);

            

        }
        private bool mediaPlayerIsPlaying = false;
        private bool userIsDraggingSlider = false;
        

        private void timer_Tick(object sender, EventArgs e)
        {
            if ((meowPlayer.Source != null) && (meowPlayer.NaturalDuration.HasTimeSpan) && (!userIsDraggingSlider))
            {
                composProgress.Minimum = 0;
                composProgress.Maximum = meowPlayer.NaturalDuration.TimeSpan.TotalSeconds;
                composProgress.Value = meowPlayer.Position.TotalSeconds;
            }
        }

        private void Play_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (meowPlayer != null) && (meowPlayer.Source != null);
        }

        private void Play_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            meowPlayer.Play();
            mediaPlayerIsPlaying = true;
        }

        private void Pause_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = mediaPlayerIsPlaying;
        }

        private void Pause_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            meowPlayer.Pause();
        }

        private void Stop_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = mediaPlayerIsPlaying;
        }

        private void Stop_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            meowPlayer.Stop();
        }
               
        private void composProgress_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblProgressStatus.Text = TimeSpan.FromSeconds(composProgress.Value).ToString(@"hh\:mm\:ss");
            meowPlayer.Pause();
            meowPlayer.Position = TimeSpan.FromSeconds(composProgress.Value);
            meowPlayer.Play();
        }

        private void Grid_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            meowPlayer.Volume += (e.Delta > 0) ? 0.1 : -0.1;
        }

        private void composProgress_DragEnter(object sender, DragEventArgs e)
        {
            userIsDraggingSlider = true;
        }

        private void composProgress_DragLeave(object sender, DragEventArgs e)
        {
            userIsDraggingSlider = false;
            meowPlayer.Position = TimeSpan.FromSeconds(composProgress.Value);
        }

        private void composProgress_DragOver(object sender, DragEventArgs e)
        {
            userIsDraggingSlider = false;
            meowPlayer.Position = TimeSpan.FromSeconds(composProgress.Value);
        }

        private void player_play_Click(object sender, RoutedEventArgs e)
        {
            meowPlayer.Play();
        }
    }
}
