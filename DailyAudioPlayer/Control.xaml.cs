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
using System.IO;
using Microsoft.Win32;
using System.Windows.Threading;
using System.Windows.Media.Animation;

namespace DailyAudioPlayer
{
    /// <summary>
    /// Interaction logic for Control.xaml
    /// </summary>
    public partial class Control : UserControl
    {
        public Control()
        {
            InitializeComponent();
        }

        private MediaPlayer mediaPlayer = new MediaPlayer();
        private static bool status = false;
        private string songName;

        public void btnOpenAudioFile_Click(object sender, RoutedEventArgs e)
        {
            DailyAudioPlayer.AudioAppManager aM = new AudioAppManager();

                songName = aM.openFile(mediaPlayer);
                lblStatus.Content = "Playing - " + System.IO.Path.GetFileName(songName);
                lblBigStatus.Content = "PLAYING";

                DispatcherTimer timer = new DispatcherTimer();
                timer.Interval = TimeSpan.FromSeconds(1);
                timer.Tick += timer_Tick;
                timer.Start();

                lblBigStatus.Visibility = Visibility.Visible;
                status = true;
        }

        public void btnPlayPause_Click(object sender, RoutedEventArgs e)
        {
            if(songName!=null)
            {
                if (status != true)
                {
                    mediaPlayer.Play();
                    lblStatus.Content = "Playing - " + System.IO.Path.GetFileName(songName);
                    lblBigStatus.Content = "PLAYING";
                    status = true;
                }
                else
                {
                    mediaPlayer.Pause();
                    lblStatus.Content = "Paused - " + System.IO.Path.GetFileName(songName);
                    lblBigStatus.Content = "PAUSED";
                    status = false;
                }
            }
            else
            {
                lblStatus.Content = "Select a file to play.";
                status = false;
            }
            
        }

        public void btnStop_Click(object sender, RoutedEventArgs e)
        {
            if(songName!=null)
            {
                mediaPlayer.Stop();
                lblStatus.Content = "Stopped - " + System.IO.Path.GetFileName(songName);
                lblBigStatus.Content = "STOPPED";
                status = false;
            }
            else
            {
                lblStatus.Content = "Select a file to play.";
                status = false;
            }
        }

        public void timer_Tick(object sender, EventArgs e)
        {
            if (mediaPlayer.Source != null)
            {
                try
                {
                    lblTimer.Content = String.Format("{0} / {1}", mediaPlayer.Position.ToString(@"mm\:ss"), mediaPlayer.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
                }
                catch (Exception err)
                {
                    lblStatus.Content = "Error: "+err;
                }
                
            }
            else
                lblTimer.Content = "No file selected...";
        }

    }
}


