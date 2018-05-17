using Microsoft.Win32;
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
            //meowPlayer.Source = new Uri(@"https://drive.google.com/uc?export=download&id=1PNXXk_ySpiV7ddBrJUK35FaJKoX_oCDT",UriKind.Absolute); 


        }
        


        //since we can't get a current state from the MediaElement control, we have to keep track of the current state ourselves
        //local variable mediaPlayerIsPlaying : regularly check to see if the Pause and Stop buttons should be enabled
        private bool mediaPlayerIsPlaying = false;

        //userIsDraggingSlider tells the timer not to update the Slider while we drag
        //and to skip to the designated part when the user releases the mouse button
        private bool userIsDraggingSlider = false;

        private double pos = 0;
        
        /// <summary>
        /// Composition slider progress
        /// </summary>
        private void timer_Tick(object sender, EventArgs e)
        {
            if ((meowPlayer.Source != null) && (meowPlayer.NaturalDuration.HasTimeSpan) && (!userIsDraggingSlider))
            {
                composProgress.Minimum = 0;
                composProgress.Maximum = meowPlayer.NaturalDuration.TimeSpan.TotalSeconds;
                composProgress.Value = meowPlayer.Position.TotalSeconds;
            }
        }

        /// <summary>
        /// If play button can be pressed
        /// </summary>
        private void Play_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            //player source must be !=null
            e.CanExecute = (meowPlayer != null) && (meowPlayer.Source != null);
        }

        /// <summary>
        /// Play button
        /// </summary>
        private void Play_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (pos>0)
                meowPlayer.Position = TimeSpan.FromSeconds(composProgress.Value);



            meowPlayer.Play();
            mediaPlayerIsPlaying = true;
            //player_play.IsEnabled = false;
        }

        /// <summary>
        /// If pause button can be pressed
        /// </summary>
        private void Pause_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = mediaPlayerIsPlaying;
        }

        /// <summary>
        /// Pause button
        /// </summary>
        private void Pause_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // аве кривым костылям
            meowPlayer.Pause();
            pos = composProgress.Value;
            meowPlayer.Close();
            //player_pause.IsEnabled = false;
            //player_play.IsEnabled = true;

        }

        /// <summary>
        /// If stop button can be pressed 
        /// </summary>
        private void Stop_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = mediaPlayerIsPlaying;
        }

        /// <summary>
        /// Stop button
        /// </summary>
        private void Stop_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            composProgress.Value = 0;
            meowPlayer.Stop();
            mediaPlayerIsPlaying = false;
            meowPlayer.Close();
            //player_pause.IsEnabled = false;
        }
               
        /// <summary>
        /// Composition progress change
        /// </summary>
        private void composProgress_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblProgressStatus.Text = TimeSpan.FromSeconds(composProgress.Value).ToString(@"hh\:mm\:ss");
            meowPlayer.Pause();
            meowPlayer.Position = TimeSpan.FromSeconds(composProgress.Value);
            meowPlayer.Play();
        }

        private void volumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            meowPlayer.Volume = (double)volumeSlider.Value;
        }

        /// <summary>
        /// Volume (as progress bar) change
        /// </summary>
        //private void Grid_MouseWheel(object sender, MouseWheelEventArgs e)
        //{
        //    meowPlayer.Volume += (e.Delta > 0) ? 0.1 : -0.1;
        //}


        private void composProgress_DragEnter(object sender, DragEventArgs e)
        {
            userIsDraggingSlider = true;
        }


        private void composProgress_DragLeave(object sender, DragEventArgs e)
        {
            userIsDraggingSlider = false;
            meowPlayer.Position = TimeSpan.FromSeconds(composProgress.Value);
        }

        /// <summary>
        /// Stopped dragging and set composition time to dragged value
        /// </summary>
        private void composProgress_DragOver(object sender, DragEventArgs e)
        {
            userIsDraggingSlider = false;
            meowPlayer.Position = TimeSpan.FromSeconds(composProgress.Value);
        }
        
    }
}
