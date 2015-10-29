using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using WP_Clicker.Resources;

namespace WP_Clicker
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();


        }




        

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {

            PlaySound.Stop();
            //PlaySound.AutoPlay = true;
            PlaySound.Play();
            PlaySound.IsMuted = false;
            
          
        }

       
            
      

        private void btnclick_Click(object sender, RoutedEventArgs e)
        {
            //stops exisiting
            PlaySound.Stop();
            PlaySound.Source = null;
            //hide buttons
            btnclick.Visibility = System.Windows.Visibility.Collapsed;
            btnpop.Visibility = System.Windows.Visibility.Collapsed;
            btnmore.Visibility = System.Windows.Visibility.Collapsed;
            btnsnap.Visibility = System.Windows.Visibility.Collapsed;
            btncrackle.Visibility = System.Windows.Visibility.Collapsed;
            btnding.Visibility = System.Windows.Visibility.Collapsed;
            btndrip.Visibility = System.Windows.Visibility.Collapsed;
            btndoorbell.Visibility = System.Windows.Visibility.Collapsed;
            btndrop.Visibility = System.Windows.Visibility.Collapsed;
            btnsqeak.Visibility = System.Windows.Visibility.Collapsed;
            btnblast.Visibility = System.Windows.Visibility.Collapsed;
            btnsiren.Visibility = System.Windows.Visibility.Collapsed;
            btnchime.Visibility = System.Windows.Visibility.Collapsed;
            clicktype.Visibility = System.Windows.Visibility.Collapsed;
            btnback.Visibility = System.Windows.Visibility.Visible;
            Dog_Bone.Visibility = System.Windows.Visibility.Collapsed;
            PlaySound.Source = new Uri("/Assets/Sounds/click.wav", UriKind.Relative);
            //PlaySound.Play();
            PlaySound.IsMuted = true;

            btnPlay.Visibility = System.Windows.Visibility.Visible;
        }

        private void btnmore_Click(object sender, RoutedEventArgs e)
        {
            //hide buttons
            btnclick.Visibility = System.Windows.Visibility.Collapsed;
            btnpop.Visibility = System.Windows.Visibility.Collapsed;
            btnmore.Visibility = System.Windows.Visibility.Collapsed;
            btnsnap.Visibility = System.Windows.Visibility.Collapsed;
            btncrackle.Visibility = System.Windows.Visibility.Collapsed;
            btnding.Visibility = System.Windows.Visibility.Collapsed;
            btndrip.Visibility = System.Windows.Visibility.Collapsed;
            btndoorbell.Visibility = System.Windows.Visibility.Collapsed;
            btndrop.Visibility = System.Windows.Visibility.Collapsed;
            btnsqeak.Visibility = System.Windows.Visibility.Collapsed;
            btnblast.Visibility = System.Windows.Visibility.Collapsed;
            btnsiren.Visibility = System.Windows.Visibility.Collapsed;
            btnchime.Visibility = System.Windows.Visibility.Collapsed;
            clicktype.Visibility = System.Windows.Visibility.Visible;
            btnback2.Visibility = System.Windows.Visibility.Visible;
            btnback3.Visibility = System.Windows.Visibility.Collapsed;
            btnbite.Visibility = System.Windows.Visibility.Visible;
            btnsplat.Visibility = System.Windows.Visibility.Visible;
            btncrash.Visibility = System.Windows.Visibility.Visible;
            btnwoosh.Visibility = System.Windows.Visibility.Visible;
            btnblop.Visibility = System.Windows.Visibility.Visible;
            btncoin.Visibility = System.Windows.Visibility.Visible;
            btngong.Visibility = System.Windows.Visibility.Visible;
            btnthunder.Visibility = System.Windows.Visibility.Visible;
            btnpool.Visibility = System.Windows.Visibility.Visible;
            btnpunch.Visibility = System.Windows.Visibility.Visible;
            btngunshot.Visibility = System.Windows.Visibility.Visible;
            btnspin.Visibility = System.Windows.Visibility.Visible;
            clicktype.Visibility = System.Windows.Visibility.Visible;
        }

        private void btnpop_Click(object sender, RoutedEventArgs e)
        {
            //stops exisiting
            PlaySound.Stop();
            PlaySound.Source = null;
            //hide buttons
            btnclick.Visibility = System.Windows.Visibility.Collapsed;
            btnpop.Visibility = System.Windows.Visibility.Collapsed;
            btnmore.Visibility = System.Windows.Visibility.Collapsed;
            btnsnap.Visibility = System.Windows.Visibility.Collapsed;
            btncrackle.Visibility = System.Windows.Visibility.Collapsed;
            btnding.Visibility = System.Windows.Visibility.Collapsed;
            btndrip.Visibility = System.Windows.Visibility.Collapsed;
            btndoorbell.Visibility = System.Windows.Visibility.Collapsed;
            btndrop.Visibility = System.Windows.Visibility.Collapsed;
            btnsqeak.Visibility = System.Windows.Visibility.Collapsed;
            btnblast.Visibility = System.Windows.Visibility.Collapsed;
            btnsiren.Visibility = System.Windows.Visibility.Collapsed;
            btnchime.Visibility = System.Windows.Visibility.Collapsed;
            btnPlay.Visibility = System.Windows.Visibility.Visible;
            clicktype.Visibility = System.Windows.Visibility.Collapsed;
            btnback.Visibility = System.Windows.Visibility.Visible;
            Dog_Bone.Visibility = System.Windows.Visibility.Collapsed;
            PlaySound.IsMuted = true;
            PlaySound.Source = new Uri("/Assets/Sounds/pop.wav", UriKind.Relative);
            //PlaySound.Play();

        }

        private void btnsnap_Click(object sender, RoutedEventArgs e)
        {
            //stops exisiting
            PlaySound.Stop();
            PlaySound.Source = null;
            //hide buttons
            btnclick.Visibility = System.Windows.Visibility.Collapsed;
            btnpop.Visibility = System.Windows.Visibility.Collapsed;
            btnmore.Visibility = System.Windows.Visibility.Collapsed;
            btnsnap.Visibility = System.Windows.Visibility.Collapsed;
            btncrackle.Visibility = System.Windows.Visibility.Collapsed;
            btnding.Visibility = System.Windows.Visibility.Collapsed;
            btndrip.Visibility = System.Windows.Visibility.Collapsed;
            btndoorbell.Visibility = System.Windows.Visibility.Collapsed;
            btndrop.Visibility = System.Windows.Visibility.Collapsed;
            btnsqeak.Visibility = System.Windows.Visibility.Collapsed;
            btnblast.Visibility = System.Windows.Visibility.Collapsed;
            btnsiren.Visibility = System.Windows.Visibility.Collapsed;
            btnchime.Visibility = System.Windows.Visibility.Collapsed;
            btnPlay.Visibility = System.Windows.Visibility.Visible;
            clicktype.Visibility = System.Windows.Visibility.Collapsed;
            btnback.Visibility = System.Windows.Visibility.Visible;
            Dog_Bone.Visibility = System.Windows.Visibility.Collapsed;
            PlaySound.IsMuted = true;
            PlaySound.Source = new Uri("/Assets/Sounds/snap.wav", UriKind.Relative);
            //PlaySound.Play();
        }

        private void btncrackle_Click(object sender, RoutedEventArgs e)
        {
            //stops exisiting
            PlaySound.Stop();
            PlaySound.Source = null;
            //hide buttons
            btnclick.Visibility = System.Windows.Visibility.Collapsed;
            btnpop.Visibility = System.Windows.Visibility.Collapsed;
            btnmore.Visibility = System.Windows.Visibility.Collapsed;
            btnsnap.Visibility = System.Windows.Visibility.Collapsed;
            btncrackle.Visibility = System.Windows.Visibility.Collapsed;
            btnding.Visibility = System.Windows.Visibility.Collapsed;
            btndrip.Visibility = System.Windows.Visibility.Collapsed;
            btndoorbell.Visibility = System.Windows.Visibility.Collapsed;
            btndrop.Visibility = System.Windows.Visibility.Collapsed;
            btnsqeak.Visibility = System.Windows.Visibility.Collapsed;
            btnblast.Visibility = System.Windows.Visibility.Collapsed;
            btnsiren.Visibility = System.Windows.Visibility.Collapsed;
            btnchime.Visibility = System.Windows.Visibility.Collapsed;
            btnPlay.Visibility = System.Windows.Visibility.Visible;
            clicktype.Visibility = System.Windows.Visibility.Collapsed;
            btnback.Visibility = System.Windows.Visibility.Visible;
            Dog_Bone.Visibility = System.Windows.Visibility.Collapsed;
            PlaySound.IsMuted = true;
            PlaySound.Source = new Uri("/Assets/Sounds/crackle.wav", UriKind.Relative);
            //PlaySound.Play();
        }

        private void btnding_Click(object sender, RoutedEventArgs e)
        {
            //stops exisiting
            PlaySound.Stop();
            PlaySound.Source = null;
            //hide buttons
            btnclick.Visibility = System.Windows.Visibility.Collapsed;
            btnpop.Visibility = System.Windows.Visibility.Collapsed;
            btnmore.Visibility = System.Windows.Visibility.Collapsed;
            btnsnap.Visibility = System.Windows.Visibility.Collapsed;
            btncrackle.Visibility = System.Windows.Visibility.Collapsed;
            btnding.Visibility = System.Windows.Visibility.Collapsed;
            btndrip.Visibility = System.Windows.Visibility.Collapsed;
            btndoorbell.Visibility = System.Windows.Visibility.Collapsed;
            btndrop.Visibility = System.Windows.Visibility.Collapsed;
            btnsqeak.Visibility = System.Windows.Visibility.Collapsed;
            btnblast.Visibility = System.Windows.Visibility.Collapsed;
            btnsiren.Visibility = System.Windows.Visibility.Collapsed;
            btnchime.Visibility = System.Windows.Visibility.Collapsed;
            btnPlay.Visibility = System.Windows.Visibility.Visible;
            clicktype.Visibility = System.Windows.Visibility.Collapsed;
            btnback.Visibility = System.Windows.Visibility.Visible;
            Dog_Bone.Visibility = System.Windows.Visibility.Collapsed;
            PlaySound.IsMuted = true;
            PlaySound.Source = new Uri("/Assets/Sounds/ding.wav", UriKind.Relative);
            //PlaySound.Play();
        }

        private void btnsiren_Click(object sender, RoutedEventArgs e)
        {
            //stops exisiting
            PlaySound.Stop();
            PlaySound.Source = null;
            //hide buttons
            btnclick.Visibility = System.Windows.Visibility.Collapsed;
            btnpop.Visibility = System.Windows.Visibility.Collapsed;
            btnmore.Visibility = System.Windows.Visibility.Collapsed;
            btnsnap.Visibility = System.Windows.Visibility.Collapsed;
            btncrackle.Visibility = System.Windows.Visibility.Collapsed;
            btnding.Visibility = System.Windows.Visibility.Collapsed;
            btndrip.Visibility = System.Windows.Visibility.Collapsed;
            btndoorbell.Visibility = System.Windows.Visibility.Collapsed;
            btndrop.Visibility = System.Windows.Visibility.Collapsed;
            btnsqeak.Visibility = System.Windows.Visibility.Collapsed;
            btnblast.Visibility = System.Windows.Visibility.Collapsed;
            btnsiren.Visibility = System.Windows.Visibility.Collapsed;
            btnchime.Visibility = System.Windows.Visibility.Collapsed;
            btnPlay.Visibility = System.Windows.Visibility.Visible;
            clicktype.Visibility = System.Windows.Visibility.Collapsed;
            btnback.Visibility = System.Windows.Visibility.Visible;
            Dog_Bone.Visibility = System.Windows.Visibility.Collapsed;
            PlaySound.IsMuted = true;
            PlaySound.Source = new Uri("/Assets/Sounds/siren.wav", UriKind.Relative);
            //PlaySound.Play();
        }

        private void btndrip_Click(object sender, RoutedEventArgs e)
        {
            //stops exisiting
            PlaySound.Stop();
            PlaySound.Source = null;
            //hide buttons
            btnclick.Visibility = System.Windows.Visibility.Collapsed;
            btnpop.Visibility = System.Windows.Visibility.Collapsed;
            btnmore.Visibility = System.Windows.Visibility.Collapsed;
            btnsnap.Visibility = System.Windows.Visibility.Collapsed;
            btncrackle.Visibility = System.Windows.Visibility.Collapsed;
            btnding.Visibility = System.Windows.Visibility.Collapsed;
            btndrip.Visibility = System.Windows.Visibility.Collapsed;
            btndoorbell.Visibility = System.Windows.Visibility.Collapsed;
            btndrop.Visibility = System.Windows.Visibility.Collapsed;
            btnsqeak.Visibility = System.Windows.Visibility.Collapsed;
            btnblast.Visibility = System.Windows.Visibility.Collapsed;
            btnsiren.Visibility = System.Windows.Visibility.Collapsed;
            btnchime.Visibility = System.Windows.Visibility.Collapsed;
            btnPlay.Visibility = System.Windows.Visibility.Visible;
            clicktype.Visibility = System.Windows.Visibility.Collapsed;
            btnback.Visibility = System.Windows.Visibility.Visible;
            Dog_Bone.Visibility = System.Windows.Visibility.Collapsed;
            PlaySound.IsMuted = true;
            PlaySound.Source = new Uri("/Assets/Sounds/drip.wav", UriKind.Relative);
            //PlaySound.Play();
        }

        private void btndoorbell_Click(object sender, RoutedEventArgs e)
        {
            //stops exisiting
            PlaySound.Stop();
            PlaySound.Source = null;
            //hide buttons
            btnclick.Visibility = System.Windows.Visibility.Collapsed;
            btnpop.Visibility = System.Windows.Visibility.Collapsed;
            btnmore.Visibility = System.Windows.Visibility.Collapsed;
            btnsnap.Visibility = System.Windows.Visibility.Collapsed;
            btncrackle.Visibility = System.Windows.Visibility.Collapsed;
            btnding.Visibility = System.Windows.Visibility.Collapsed;
            btndrip.Visibility = System.Windows.Visibility.Collapsed;
            btndoorbell.Visibility = System.Windows.Visibility.Collapsed;
            btndrop.Visibility = System.Windows.Visibility.Collapsed;
            btnsqeak.Visibility = System.Windows.Visibility.Collapsed;
            btnblast.Visibility = System.Windows.Visibility.Collapsed;
            btnsiren.Visibility = System.Windows.Visibility.Collapsed;
            btnchime.Visibility = System.Windows.Visibility.Collapsed;
            btnPlay.Visibility = System.Windows.Visibility.Visible;
            clicktype.Visibility = System.Windows.Visibility.Collapsed;
            btnback.Visibility = System.Windows.Visibility.Visible;
            Dog_Bone.Visibility = System.Windows.Visibility.Collapsed;
            PlaySound.IsMuted = true;
            PlaySound.Source = new Uri("/Assets/Sounds/doorbell.wav", UriKind.Relative);
            //PlaySound.Play();
        }

        private void btndrop_Click(object sender, RoutedEventArgs e)
        {
            //stops exisiting
            PlaySound.Stop();
            PlaySound.Source = null;
            //hide buttons
            btnclick.Visibility = System.Windows.Visibility.Collapsed;
            btnpop.Visibility = System.Windows.Visibility.Collapsed;
            btnmore.Visibility = System.Windows.Visibility.Collapsed;
            btnsnap.Visibility = System.Windows.Visibility.Collapsed;
            btncrackle.Visibility = System.Windows.Visibility.Collapsed;
            btnding.Visibility = System.Windows.Visibility.Collapsed;
            btndrip.Visibility = System.Windows.Visibility.Collapsed;
            btndoorbell.Visibility = System.Windows.Visibility.Collapsed;
            btndrop.Visibility = System.Windows.Visibility.Collapsed;
            btnsqeak.Visibility = System.Windows.Visibility.Collapsed;
            btnblast.Visibility = System.Windows.Visibility.Collapsed;
            btnsiren.Visibility = System.Windows.Visibility.Collapsed;
            btnchime.Visibility = System.Windows.Visibility.Collapsed;
            btnPlay.Visibility = System.Windows.Visibility.Visible;
            clicktype.Visibility = System.Windows.Visibility.Collapsed;
            btnback.Visibility = System.Windows.Visibility.Visible;
            Dog_Bone.Visibility = System.Windows.Visibility.Collapsed;
            PlaySound.IsMuted = true;
            PlaySound.Source = new Uri("/Assets/Sounds/drop.wav", UriKind.Relative);
            //PlaySound.Play();
        }

        private void btnsqeak_Click(object sender, RoutedEventArgs e)
        {
            //stops exisiting
            PlaySound.Stop();
            PlaySound.Source = null;
            //hide buttons
            btnclick.Visibility = System.Windows.Visibility.Collapsed;
            btnpop.Visibility = System.Windows.Visibility.Collapsed;
            btnmore.Visibility = System.Windows.Visibility.Collapsed;
            btnsnap.Visibility = System.Windows.Visibility.Collapsed;
            btncrackle.Visibility = System.Windows.Visibility.Collapsed;
            btnding.Visibility = System.Windows.Visibility.Collapsed;
            btndrip.Visibility = System.Windows.Visibility.Collapsed;
            btndoorbell.Visibility = System.Windows.Visibility.Collapsed;
            btndrop.Visibility = System.Windows.Visibility.Collapsed;
            btnsqeak.Visibility = System.Windows.Visibility.Collapsed;
            btnblast.Visibility = System.Windows.Visibility.Collapsed;
            btnsiren.Visibility = System.Windows.Visibility.Collapsed;
            btnchime.Visibility = System.Windows.Visibility.Collapsed;
            btnPlay.Visibility = System.Windows.Visibility.Visible;
            clicktype.Visibility = System.Windows.Visibility.Collapsed;
            Dog_Bone.Visibility = System.Windows.Visibility.Collapsed;
            btnback.Visibility = System.Windows.Visibility.Visible;
            Dog_Bone.Visibility = System.Windows.Visibility.Collapsed;
            PlaySound.IsMuted = true;
            PlaySound.Source = new Uri("/Assets/Sounds/squeak.wav", UriKind.Relative);
            
        }

        private void btnblast_Click(object sender, RoutedEventArgs e)
        {
            //stops exisiting
            PlaySound.Stop();
            PlaySound.Source = null;
            //hide buttons
            btnclick.Visibility = System.Windows.Visibility.Collapsed;
            btnpop.Visibility = System.Windows.Visibility.Collapsed;
            btnmore.Visibility = System.Windows.Visibility.Collapsed;
            btnsnap.Visibility = System.Windows.Visibility.Collapsed;
            btncrackle.Visibility = System.Windows.Visibility.Collapsed;
            btnding.Visibility = System.Windows.Visibility.Collapsed;
            btndrip.Visibility = System.Windows.Visibility.Collapsed;
            btndoorbell.Visibility = System.Windows.Visibility.Collapsed;
            btndrop.Visibility = System.Windows.Visibility.Collapsed;
            btnsqeak.Visibility = System.Windows.Visibility.Collapsed;
            btnblast.Visibility = System.Windows.Visibility.Collapsed;
            btnsiren.Visibility = System.Windows.Visibility.Collapsed;
            btnchime.Visibility = System.Windows.Visibility.Collapsed;
            btnPlay.Visibility = System.Windows.Visibility.Visible;
            clicktype.Visibility = System.Windows.Visibility.Collapsed;
            btnback.Visibility = System.Windows.Visibility.Visible;
            Dog_Bone.Visibility = System.Windows.Visibility.Collapsed;
            PlaySound.IsMuted = true;
            PlaySound.Source = new Uri("/Assets/Sounds/blast.wav", UriKind.Relative);
            
        }

        private void btnchime_Click(object sender, RoutedEventArgs e)
        {
            //stops exisiting
            PlaySound.Stop();
            PlaySound.Source = null;
            //hide buttons
            btnclick.Visibility = System.Windows.Visibility.Collapsed;
            btnpop.Visibility = System.Windows.Visibility.Collapsed;
            btnmore.Visibility = System.Windows.Visibility.Collapsed;
            btnsnap.Visibility = System.Windows.Visibility.Collapsed;
            btncrackle.Visibility = System.Windows.Visibility.Collapsed;
            btnding.Visibility = System.Windows.Visibility.Collapsed;
            btndrip.Visibility = System.Windows.Visibility.Collapsed;
            btndoorbell.Visibility = System.Windows.Visibility.Collapsed;
            btndrop.Visibility = System.Windows.Visibility.Collapsed;
            btnsqeak.Visibility = System.Windows.Visibility.Collapsed;
            btnblast.Visibility = System.Windows.Visibility.Collapsed;
            btnsiren.Visibility = System.Windows.Visibility.Collapsed;
            btnchime.Visibility = System.Windows.Visibility.Collapsed;
            btnback.Visibility = System.Windows.Visibility.Visible;
            clicktype.Visibility = System.Windows.Visibility.Collapsed;
            btnPlay.Visibility = System.Windows.Visibility.Visible;
            Dog_Bone.Visibility = System.Windows.Visibility.Collapsed;
            PlaySound.IsMuted = true;
            PlaySound.Source = new Uri("/Assets/Sounds/chime.wav", UriKind.Relative);
            PlaySound.Stop();
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            btnclick.Visibility = System.Windows.Visibility.Visible;
            btnpop.Visibility = System.Windows.Visibility.Visible;
            btnmore.Visibility = System.Windows.Visibility.Visible;
            btnsnap.Visibility = System.Windows.Visibility.Visible;
            btncrackle.Visibility = System.Windows.Visibility.Visible;
            btnding.Visibility = System.Windows.Visibility.Visible;
            btndrip.Visibility = System.Windows.Visibility.Visible;
            btndoorbell.Visibility = System.Windows.Visibility.Visible;
            btndrop.Visibility = System.Windows.Visibility.Visible;
            btnsqeak.Visibility = System.Windows.Visibility.Visible;
            btnblast.Visibility = System.Windows.Visibility.Visible;
            btnsiren.Visibility = System.Windows.Visibility.Visible;
            btnchime.Visibility = System.Windows.Visibility.Visible;
            btnback.Visibility = System.Windows.Visibility.Collapsed;
            clicktype.Visibility = System.Windows.Visibility.Visible;
            btnPlay.Visibility = System.Windows.Visibility.Collapsed;
            Dog_Bone.Visibility = System.Windows.Visibility.Visible;
            btnbite.Visibility = System.Windows.Visibility.Collapsed;
            btnsplat.Visibility = System.Windows.Visibility.Collapsed;
            btncrash.Visibility = System.Windows.Visibility.Collapsed;
            btnwoosh.Visibility = System.Windows.Visibility.Collapsed;
            btnblop.Visibility = System.Windows.Visibility.Collapsed;
            btncoin.Visibility = System.Windows.Visibility.Collapsed;
            btngong.Visibility = System.Windows.Visibility.Collapsed;
            btnthunder.Visibility = System.Windows.Visibility.Collapsed;
            btnpool.Visibility = System.Windows.Visibility.Collapsed;
            btnpunch.Visibility = System.Windows.Visibility.Collapsed;
            btngunshot.Visibility = System.Windows.Visibility.Collapsed;
            btnspin.Visibility = System.Windows.Visibility.Collapsed;
            PlaySound.Source = null;
            PlaySound.Stop();
        }

        private void btnback2_Click(object sender, RoutedEventArgs e)
        {
            btnback2.Visibility = System.Windows.Visibility.Collapsed;
            btnback3.Visibility = System.Windows.Visibility.Collapsed;
            btnclick.Visibility = System.Windows.Visibility.Visible;
            btnpop.Visibility = System.Windows.Visibility.Visible;
            btnmore.Visibility = System.Windows.Visibility.Visible;
            btnsnap.Visibility = System.Windows.Visibility.Visible;
            btncrackle.Visibility = System.Windows.Visibility.Visible;
            btnding.Visibility = System.Windows.Visibility.Visible;
            btndrip.Visibility = System.Windows.Visibility.Visible;
            btndoorbell.Visibility = System.Windows.Visibility.Visible;
            btndrop.Visibility = System.Windows.Visibility.Visible;
            btnsqeak.Visibility = System.Windows.Visibility.Visible;
            btnblast.Visibility = System.Windows.Visibility.Visible;
            btnsiren.Visibility = System.Windows.Visibility.Visible;
            btnchime.Visibility = System.Windows.Visibility.Visible;
            btnback.Visibility = System.Windows.Visibility.Collapsed;
            clicktype.Visibility = System.Windows.Visibility.Visible;
            btnPlay.Visibility = System.Windows.Visibility.Collapsed;
            Dog_Bone.Visibility = System.Windows.Visibility.Visible;
            btnbite.Visibility = System.Windows.Visibility.Collapsed;
            btnsplat.Visibility = System.Windows.Visibility.Collapsed;
            btncrash.Visibility = System.Windows.Visibility.Collapsed;
            btnwoosh.Visibility = System.Windows.Visibility.Collapsed;
            btnblop.Visibility = System.Windows.Visibility.Collapsed;
            btncoin.Visibility = System.Windows.Visibility.Collapsed;
            btngong.Visibility = System.Windows.Visibility.Collapsed;
            btnthunder.Visibility = System.Windows.Visibility.Collapsed;
            btnpool.Visibility = System.Windows.Visibility.Collapsed;
            btnpunch.Visibility = System.Windows.Visibility.Collapsed;
            btngunshot.Visibility = System.Windows.Visibility.Collapsed;
            btnspin.Visibility = System.Windows.Visibility.Collapsed;
            PlaySound.Source = null;
            PlaySound.Stop();
        }

        private void btnbite_Click(object sender, RoutedEventArgs e)
        {
            //stops exisiting
            PlaySound.Stop();
            PlaySound.Source = null;
            //hide buttons
            btnclick.Visibility = System.Windows.Visibility.Collapsed;
            btnpop.Visibility = System.Windows.Visibility.Collapsed;
            btnmore.Visibility = System.Windows.Visibility.Collapsed;
            btnsnap.Visibility = System.Windows.Visibility.Collapsed;
            btncrackle.Visibility = System.Windows.Visibility.Collapsed;
            btnding.Visibility = System.Windows.Visibility.Collapsed;
            btndrip.Visibility = System.Windows.Visibility.Collapsed;
            btndoorbell.Visibility = System.Windows.Visibility.Collapsed;
            btndrop.Visibility = System.Windows.Visibility.Collapsed;
            btnsqeak.Visibility = System.Windows.Visibility.Collapsed;
            btnblast.Visibility = System.Windows.Visibility.Collapsed;
            btnsiren.Visibility = System.Windows.Visibility.Collapsed;
            btnchime.Visibility = System.Windows.Visibility.Collapsed;
            btnback3.Visibility = System.Windows.Visibility.Visible;
            btnback2.Visibility = System.Windows.Visibility.Collapsed;
            clicktype.Visibility = System.Windows.Visibility.Collapsed;
            btnPlay.Visibility = System.Windows.Visibility.Visible;
            Dog_Bone.Visibility = System.Windows.Visibility.Collapsed;
            btnbite.Visibility = System.Windows.Visibility.Collapsed;
            btnsplat.Visibility = System.Windows.Visibility.Collapsed;
            btncrash.Visibility = System.Windows.Visibility.Collapsed;
            btnwoosh.Visibility = System.Windows.Visibility.Collapsed;
            btnblop.Visibility = System.Windows.Visibility.Collapsed;
            btncoin.Visibility = System.Windows.Visibility.Collapsed;
            btngong.Visibility = System.Windows.Visibility.Collapsed;
            btnthunder.Visibility = System.Windows.Visibility.Collapsed;
            btnpool.Visibility = System.Windows.Visibility.Collapsed;
            btnpunch.Visibility = System.Windows.Visibility.Collapsed;
            btngunshot.Visibility = System.Windows.Visibility.Collapsed;
            btnspin.Visibility = System.Windows.Visibility.Collapsed;
            PlaySound.IsMuted = true;
            PlaySound.Source = new Uri("/Assets/Sounds/bite.wav", UriKind.Relative);
            PlaySound.Stop();

        }

        private void btnsplat_Click(object sender, RoutedEventArgs e)
        {
            //stops exisiting
            PlaySound.Stop();
            PlaySound.Source = null;
            //hide buttons
            btnclick.Visibility = System.Windows.Visibility.Collapsed;
            btnpop.Visibility = System.Windows.Visibility.Collapsed;
            btnmore.Visibility = System.Windows.Visibility.Collapsed;
            btnsnap.Visibility = System.Windows.Visibility.Collapsed;
            btncrackle.Visibility = System.Windows.Visibility.Collapsed;
            btnding.Visibility = System.Windows.Visibility.Collapsed;
            btndrip.Visibility = System.Windows.Visibility.Collapsed;
            btndoorbell.Visibility = System.Windows.Visibility.Collapsed;
            btndrop.Visibility = System.Windows.Visibility.Collapsed;
            btnsqeak.Visibility = System.Windows.Visibility.Collapsed;
            btnblast.Visibility = System.Windows.Visibility.Collapsed;
            btnsiren.Visibility = System.Windows.Visibility.Collapsed;
            btnchime.Visibility = System.Windows.Visibility.Collapsed;
            btnback3.Visibility = System.Windows.Visibility.Visible;
            clicktype.Visibility = System.Windows.Visibility.Collapsed;
            btnPlay.Visibility = System.Windows.Visibility.Visible;
            Dog_Bone.Visibility = System.Windows.Visibility.Collapsed;
            btnbite.Visibility = System.Windows.Visibility.Collapsed;
            btnsplat.Visibility = System.Windows.Visibility.Collapsed;
            btncrash.Visibility = System.Windows.Visibility.Collapsed;
            btnwoosh.Visibility = System.Windows.Visibility.Collapsed;
            btnblop.Visibility = System.Windows.Visibility.Collapsed;
            btncoin.Visibility = System.Windows.Visibility.Collapsed;
            btngong.Visibility = System.Windows.Visibility.Collapsed;
            btnthunder.Visibility = System.Windows.Visibility.Collapsed;
            btnpool.Visibility = System.Windows.Visibility.Collapsed;
            btnpunch.Visibility = System.Windows.Visibility.Collapsed;
            btngunshot.Visibility = System.Windows.Visibility.Collapsed;
            btnspin.Visibility = System.Windows.Visibility.Collapsed;
            PlaySound.IsMuted = true;
            PlaySound.Source = new Uri("/Assets/Sounds/splat.wav", UriKind.Relative);
            PlaySound.Stop();
        }

        private void btncrash_Click(object sender, RoutedEventArgs e)
        {
            //stops exisiting
            PlaySound.Stop();
            PlaySound.Source = null;
            //hide buttons
            btnclick.Visibility = System.Windows.Visibility.Collapsed;
            btnpop.Visibility = System.Windows.Visibility.Collapsed;
            btnmore.Visibility = System.Windows.Visibility.Collapsed;
            btnsnap.Visibility = System.Windows.Visibility.Collapsed;
            btncrackle.Visibility = System.Windows.Visibility.Collapsed;
            btnding.Visibility = System.Windows.Visibility.Collapsed;
            btndrip.Visibility = System.Windows.Visibility.Collapsed;
            btndoorbell.Visibility = System.Windows.Visibility.Collapsed;
            btndrop.Visibility = System.Windows.Visibility.Collapsed;
            btnsqeak.Visibility = System.Windows.Visibility.Collapsed;
            btnblast.Visibility = System.Windows.Visibility.Collapsed;
            btnsiren.Visibility = System.Windows.Visibility.Collapsed;
            btnchime.Visibility = System.Windows.Visibility.Collapsed;
            btnback3.Visibility = System.Windows.Visibility.Visible;
            clicktype.Visibility = System.Windows.Visibility.Collapsed;
            btnPlay.Visibility = System.Windows.Visibility.Visible;
            Dog_Bone.Visibility = System.Windows.Visibility.Collapsed;
            btnbite.Visibility = System.Windows.Visibility.Collapsed;
            btnsplat.Visibility = System.Windows.Visibility.Collapsed;
            btncrash.Visibility = System.Windows.Visibility.Collapsed;
            btnwoosh.Visibility = System.Windows.Visibility.Collapsed;
            btnblop.Visibility = System.Windows.Visibility.Collapsed;
            btncoin.Visibility = System.Windows.Visibility.Collapsed;
            btngong.Visibility = System.Windows.Visibility.Collapsed;
            btnthunder.Visibility = System.Windows.Visibility.Collapsed;
            btnpool.Visibility = System.Windows.Visibility.Collapsed;
            btnpunch.Visibility = System.Windows.Visibility.Collapsed;
            btngunshot.Visibility = System.Windows.Visibility.Collapsed;
            btnspin.Visibility = System.Windows.Visibility.Collapsed;
            PlaySound.IsMuted = true;
            PlaySound.Source = new Uri("/Assets/Sounds/crash.wav", UriKind.Relative);
            PlaySound.Stop();
        }

        private void btnwoosh_Click(object sender, RoutedEventArgs e)
        {
            //stops exisiting
            PlaySound.Stop();
            PlaySound.Source = null;
            //hide buttons
            btnclick.Visibility = System.Windows.Visibility.Collapsed;
            btnpop.Visibility = System.Windows.Visibility.Collapsed;
            btnmore.Visibility = System.Windows.Visibility.Collapsed;
            btnsnap.Visibility = System.Windows.Visibility.Collapsed;
            btncrackle.Visibility = System.Windows.Visibility.Collapsed;
            btnding.Visibility = System.Windows.Visibility.Collapsed;
            btndrip.Visibility = System.Windows.Visibility.Collapsed;
            btndoorbell.Visibility = System.Windows.Visibility.Collapsed;
            btndrop.Visibility = System.Windows.Visibility.Collapsed;
            btnsqeak.Visibility = System.Windows.Visibility.Collapsed;
            btnblast.Visibility = System.Windows.Visibility.Collapsed;
            btnsiren.Visibility = System.Windows.Visibility.Collapsed;
            btnchime.Visibility = System.Windows.Visibility.Collapsed;
            btnback3.Visibility = System.Windows.Visibility.Visible;
            clicktype.Visibility = System.Windows.Visibility.Collapsed;
            btnPlay.Visibility = System.Windows.Visibility.Visible;
            Dog_Bone.Visibility = System.Windows.Visibility.Collapsed;
            btnbite.Visibility = System.Windows.Visibility.Collapsed;
            btnsplat.Visibility = System.Windows.Visibility.Collapsed;
            btncrash.Visibility = System.Windows.Visibility.Collapsed;
            btnwoosh.Visibility = System.Windows.Visibility.Collapsed;
            btnblop.Visibility = System.Windows.Visibility.Collapsed;
            btncoin.Visibility = System.Windows.Visibility.Collapsed;
            btngong.Visibility = System.Windows.Visibility.Collapsed;
            btnthunder.Visibility = System.Windows.Visibility.Collapsed;
            btnpool.Visibility = System.Windows.Visibility.Collapsed;
            btnpunch.Visibility = System.Windows.Visibility.Collapsed;
            btngunshot.Visibility = System.Windows.Visibility.Collapsed;
            btnspin.Visibility = System.Windows.Visibility.Collapsed;
            PlaySound.IsMuted = true;
            PlaySound.Source = new Uri("/Assets/Sounds/woosh.wav", UriKind.Relative);
            PlaySound.Stop();
        }

        private void btnblop_Click(object sender, RoutedEventArgs e)
        {
            //stops exisiting
            PlaySound.Stop();
            PlaySound.Source = null;
            //hide buttons
            btnclick.Visibility = System.Windows.Visibility.Collapsed;
            btnpop.Visibility = System.Windows.Visibility.Collapsed;
            btnmore.Visibility = System.Windows.Visibility.Collapsed;
            btnsnap.Visibility = System.Windows.Visibility.Collapsed;
            btncrackle.Visibility = System.Windows.Visibility.Collapsed;
            btnding.Visibility = System.Windows.Visibility.Collapsed;
            btndrip.Visibility = System.Windows.Visibility.Collapsed;
            btndoorbell.Visibility = System.Windows.Visibility.Collapsed;
            btndrop.Visibility = System.Windows.Visibility.Collapsed;
            btnsqeak.Visibility = System.Windows.Visibility.Collapsed;
            btnblast.Visibility = System.Windows.Visibility.Collapsed;
            btnsiren.Visibility = System.Windows.Visibility.Collapsed;
            btnchime.Visibility = System.Windows.Visibility.Collapsed;
            btnback3.Visibility = System.Windows.Visibility.Visible;
            clicktype.Visibility = System.Windows.Visibility.Collapsed;
            btnPlay.Visibility = System.Windows.Visibility.Visible;
            Dog_Bone.Visibility = System.Windows.Visibility.Collapsed;
            btnbite.Visibility = System.Windows.Visibility.Collapsed;
            btnsplat.Visibility = System.Windows.Visibility.Collapsed;
            btncrash.Visibility = System.Windows.Visibility.Collapsed;
            btnwoosh.Visibility = System.Windows.Visibility.Collapsed;
            btnblop.Visibility = System.Windows.Visibility.Collapsed;
            btncoin.Visibility = System.Windows.Visibility.Collapsed;
            btngong.Visibility = System.Windows.Visibility.Collapsed;
            btnthunder.Visibility = System.Windows.Visibility.Collapsed;
            btnpool.Visibility = System.Windows.Visibility.Collapsed;
            btnpunch.Visibility = System.Windows.Visibility.Collapsed;
            btngunshot.Visibility = System.Windows.Visibility.Collapsed;
            btnspin.Visibility = System.Windows.Visibility.Collapsed;
            PlaySound.IsMuted = true;
            PlaySound.Source = new Uri("/Assets/Sounds/blop.wav", UriKind.Relative);
            PlaySound.Stop();
        }

        private void btncoin_Click(object sender, RoutedEventArgs e)
        {
            //stops exisiting
            PlaySound.Stop();
            PlaySound.Source = null;
            //hide buttons
            btnclick.Visibility = System.Windows.Visibility.Collapsed;
            btnpop.Visibility = System.Windows.Visibility.Collapsed;
            btnmore.Visibility = System.Windows.Visibility.Collapsed;
            btnsnap.Visibility = System.Windows.Visibility.Collapsed;
            btncrackle.Visibility = System.Windows.Visibility.Collapsed;
            btnding.Visibility = System.Windows.Visibility.Collapsed;
            btndrip.Visibility = System.Windows.Visibility.Collapsed;
            btndoorbell.Visibility = System.Windows.Visibility.Collapsed;
            btndrop.Visibility = System.Windows.Visibility.Collapsed;
            btnsqeak.Visibility = System.Windows.Visibility.Collapsed;
            btnblast.Visibility = System.Windows.Visibility.Collapsed;
            btnsiren.Visibility = System.Windows.Visibility.Collapsed;
            btnchime.Visibility = System.Windows.Visibility.Collapsed;
            btnback3.Visibility = System.Windows.Visibility.Visible;
            clicktype.Visibility = System.Windows.Visibility.Collapsed;
            btnPlay.Visibility = System.Windows.Visibility.Visible;
            Dog_Bone.Visibility = System.Windows.Visibility.Collapsed;
            btnbite.Visibility = System.Windows.Visibility.Collapsed;
            btnsplat.Visibility = System.Windows.Visibility.Collapsed;
            btncrash.Visibility = System.Windows.Visibility.Collapsed;
            btnwoosh.Visibility = System.Windows.Visibility.Collapsed;
            btnblop.Visibility = System.Windows.Visibility.Collapsed;
            btncoin.Visibility = System.Windows.Visibility.Collapsed;
            btngong.Visibility = System.Windows.Visibility.Collapsed;
            btnthunder.Visibility = System.Windows.Visibility.Collapsed;
            btnpool.Visibility = System.Windows.Visibility.Collapsed;
            btnpunch.Visibility = System.Windows.Visibility.Collapsed;
            btngunshot.Visibility = System.Windows.Visibility.Collapsed;
            btnspin.Visibility = System.Windows.Visibility.Collapsed;
            PlaySound.IsMuted = true;
            PlaySound.Source = new Uri("/Assets/Sounds/coin.wav", UriKind.Relative);
            PlaySound.Stop();
        }

        private void btngong_Click(object sender, RoutedEventArgs e)
        {
            //stops exisiting
            PlaySound.Stop();
            PlaySound.Source = null;
            //hide buttons
            btnclick.Visibility = System.Windows.Visibility.Collapsed;
            btnpop.Visibility = System.Windows.Visibility.Collapsed;
            btnmore.Visibility = System.Windows.Visibility.Collapsed;
            btnsnap.Visibility = System.Windows.Visibility.Collapsed;
            btncrackle.Visibility = System.Windows.Visibility.Collapsed;
            btnding.Visibility = System.Windows.Visibility.Collapsed;
            btndrip.Visibility = System.Windows.Visibility.Collapsed;
            btndoorbell.Visibility = System.Windows.Visibility.Collapsed;
            btndrop.Visibility = System.Windows.Visibility.Collapsed;
            btnsqeak.Visibility = System.Windows.Visibility.Collapsed;
            btnblast.Visibility = System.Windows.Visibility.Collapsed;
            btnsiren.Visibility = System.Windows.Visibility.Collapsed;
            btnchime.Visibility = System.Windows.Visibility.Collapsed;
            btnback3.Visibility = System.Windows.Visibility.Visible;
            clicktype.Visibility = System.Windows.Visibility.Collapsed;
            btnPlay.Visibility = System.Windows.Visibility.Visible;
            Dog_Bone.Visibility = System.Windows.Visibility.Collapsed;
            btnbite.Visibility = System.Windows.Visibility.Collapsed;
            btnsplat.Visibility = System.Windows.Visibility.Collapsed;
            btncrash.Visibility = System.Windows.Visibility.Collapsed;
            btnwoosh.Visibility = System.Windows.Visibility.Collapsed;
            btnblop.Visibility = System.Windows.Visibility.Collapsed;
            btncoin.Visibility = System.Windows.Visibility.Collapsed;
            btngong.Visibility = System.Windows.Visibility.Collapsed;
            btnthunder.Visibility = System.Windows.Visibility.Collapsed;
            btnpool.Visibility = System.Windows.Visibility.Collapsed;
            btnpunch.Visibility = System.Windows.Visibility.Collapsed;
            btngunshot.Visibility = System.Windows.Visibility.Collapsed;
            btnspin.Visibility = System.Windows.Visibility.Collapsed;
            PlaySound.IsMuted = true;
            PlaySound.Source = new Uri("/Assets/Sounds/gong.wav", UriKind.Relative);
            PlaySound.Stop();
        }

        private void btnthunder_Click(object sender, RoutedEventArgs e)
        {
            //stops exisiting
            PlaySound.Stop();
            PlaySound.Source = null;
            //hide buttons
            btnclick.Visibility = System.Windows.Visibility.Collapsed;
            btnpop.Visibility = System.Windows.Visibility.Collapsed;
            btnmore.Visibility = System.Windows.Visibility.Collapsed;
            btnsnap.Visibility = System.Windows.Visibility.Collapsed;
            btncrackle.Visibility = System.Windows.Visibility.Collapsed;
            btnding.Visibility = System.Windows.Visibility.Collapsed;
            btndrip.Visibility = System.Windows.Visibility.Collapsed;
            btndoorbell.Visibility = System.Windows.Visibility.Collapsed;
            btndrop.Visibility = System.Windows.Visibility.Collapsed;
            btnsqeak.Visibility = System.Windows.Visibility.Collapsed;
            btnblast.Visibility = System.Windows.Visibility.Collapsed;
            btnsiren.Visibility = System.Windows.Visibility.Collapsed;
            btnchime.Visibility = System.Windows.Visibility.Collapsed;
            btnback3.Visibility = System.Windows.Visibility.Visible;
            clicktype.Visibility = System.Windows.Visibility.Collapsed;
            btnPlay.Visibility = System.Windows.Visibility.Visible;
            Dog_Bone.Visibility = System.Windows.Visibility.Collapsed;
            btnbite.Visibility = System.Windows.Visibility.Collapsed;
            btnsplat.Visibility = System.Windows.Visibility.Collapsed;
            btncrash.Visibility = System.Windows.Visibility.Collapsed;
            btnwoosh.Visibility = System.Windows.Visibility.Collapsed;
            btnblop.Visibility = System.Windows.Visibility.Collapsed;
            btncoin.Visibility = System.Windows.Visibility.Collapsed;
            btngong.Visibility = System.Windows.Visibility.Collapsed;
            btnthunder.Visibility = System.Windows.Visibility.Collapsed;
            btnpool.Visibility = System.Windows.Visibility.Collapsed;
            btnpunch.Visibility = System.Windows.Visibility.Collapsed;
            btngunshot.Visibility = System.Windows.Visibility.Collapsed;
            btnspin.Visibility = System.Windows.Visibility.Collapsed;
            PlaySound.IsMuted = true;
            PlaySound.Source = new Uri("/Assets/Sounds/thunder.wav", UriKind.Relative);
            PlaySound.Stop();
        }

        private void btnpool_Click(object sender, RoutedEventArgs e)
        {
            //stops exisiting
            PlaySound.Stop();
            PlaySound.Source = null;
            //hide buttons
            btnclick.Visibility = System.Windows.Visibility.Collapsed;
            btnpop.Visibility = System.Windows.Visibility.Collapsed;
            btnmore.Visibility = System.Windows.Visibility.Collapsed;
            btnsnap.Visibility = System.Windows.Visibility.Collapsed;
            btncrackle.Visibility = System.Windows.Visibility.Collapsed;
            btnding.Visibility = System.Windows.Visibility.Collapsed;
            btndrip.Visibility = System.Windows.Visibility.Collapsed;
            btndoorbell.Visibility = System.Windows.Visibility.Collapsed;
            btndrop.Visibility = System.Windows.Visibility.Collapsed;
            btnsqeak.Visibility = System.Windows.Visibility.Collapsed;
            btnblast.Visibility = System.Windows.Visibility.Collapsed;
            btnsiren.Visibility = System.Windows.Visibility.Collapsed;
            btnchime.Visibility = System.Windows.Visibility.Collapsed;
            btnback3.Visibility = System.Windows.Visibility.Visible;
            clicktype.Visibility = System.Windows.Visibility.Collapsed;
            btnPlay.Visibility = System.Windows.Visibility.Visible;
            Dog_Bone.Visibility = System.Windows.Visibility.Collapsed;
            btnbite.Visibility = System.Windows.Visibility.Collapsed;
            btnsplat.Visibility = System.Windows.Visibility.Collapsed;
            btncrash.Visibility = System.Windows.Visibility.Collapsed;
            btnwoosh.Visibility = System.Windows.Visibility.Collapsed;
            btnblop.Visibility = System.Windows.Visibility.Collapsed;
            btncoin.Visibility = System.Windows.Visibility.Collapsed;
            btngong.Visibility = System.Windows.Visibility.Collapsed;
            btnthunder.Visibility = System.Windows.Visibility.Collapsed;
            btnpool.Visibility = System.Windows.Visibility.Collapsed;
            btnpunch.Visibility = System.Windows.Visibility.Collapsed;
            btngunshot.Visibility = System.Windows.Visibility.Collapsed;
            btnspin.Visibility = System.Windows.Visibility.Collapsed;
            PlaySound.IsMuted = true;
            PlaySound.Source = new Uri("/Assets/Sounds/pool.wav", UriKind.Relative);
            PlaySound.Stop();
        }

        private void btnpunch_Click(object sender, RoutedEventArgs e)
        {
            //stops exisiting
            PlaySound.Stop();
            PlaySound.Source = null;
            //hide buttons
            btnclick.Visibility = System.Windows.Visibility.Collapsed;
            btnpop.Visibility = System.Windows.Visibility.Collapsed;
            btnmore.Visibility = System.Windows.Visibility.Collapsed;
            btnsnap.Visibility = System.Windows.Visibility.Collapsed;
            btncrackle.Visibility = System.Windows.Visibility.Collapsed;
            btnding.Visibility = System.Windows.Visibility.Collapsed;
            btndrip.Visibility = System.Windows.Visibility.Collapsed;
            btndoorbell.Visibility = System.Windows.Visibility.Collapsed;
            btndrop.Visibility = System.Windows.Visibility.Collapsed;
            btnsqeak.Visibility = System.Windows.Visibility.Collapsed;
            btnblast.Visibility = System.Windows.Visibility.Collapsed;
            btnsiren.Visibility = System.Windows.Visibility.Collapsed;
            btnchime.Visibility = System.Windows.Visibility.Collapsed;
            btnback3.Visibility = System.Windows.Visibility.Visible;
            clicktype.Visibility = System.Windows.Visibility.Collapsed;
            btnPlay.Visibility = System.Windows.Visibility.Visible;
            Dog_Bone.Visibility = System.Windows.Visibility.Collapsed;
            btnbite.Visibility = System.Windows.Visibility.Collapsed;
            btnsplat.Visibility = System.Windows.Visibility.Collapsed;
            btncrash.Visibility = System.Windows.Visibility.Collapsed;
            btnwoosh.Visibility = System.Windows.Visibility.Collapsed;
            btnblop.Visibility = System.Windows.Visibility.Collapsed;
            btncoin.Visibility = System.Windows.Visibility.Collapsed;
            btngong.Visibility = System.Windows.Visibility.Collapsed;
            btnthunder.Visibility = System.Windows.Visibility.Collapsed;
            btnpool.Visibility = System.Windows.Visibility.Collapsed;
            btnpunch.Visibility = System.Windows.Visibility.Collapsed;
            btngunshot.Visibility = System.Windows.Visibility.Collapsed;
            btnspin.Visibility = System.Windows.Visibility.Collapsed;
            PlaySound.IsMuted = true;
            PlaySound.Source = new Uri("/Assets/Sounds/punch.wav", UriKind.Relative);
            PlaySound.Stop();
        }

        private void btngunshot_Click(object sender, RoutedEventArgs e)
        {
            //stops exisiting
            PlaySound.Stop();
            PlaySound.Source = null;
            //hide buttons
            btnclick.Visibility = System.Windows.Visibility.Collapsed;
            btnpop.Visibility = System.Windows.Visibility.Collapsed;
            btnmore.Visibility = System.Windows.Visibility.Collapsed;
            btnsnap.Visibility = System.Windows.Visibility.Collapsed;
            btncrackle.Visibility = System.Windows.Visibility.Collapsed;
            btnding.Visibility = System.Windows.Visibility.Collapsed;
            btndrip.Visibility = System.Windows.Visibility.Collapsed;
            btndoorbell.Visibility = System.Windows.Visibility.Collapsed;
            btndrop.Visibility = System.Windows.Visibility.Collapsed;
            btnsqeak.Visibility = System.Windows.Visibility.Collapsed;
            btnblast.Visibility = System.Windows.Visibility.Collapsed;
            btnsiren.Visibility = System.Windows.Visibility.Collapsed;
            btnchime.Visibility = System.Windows.Visibility.Collapsed;
            btnback3.Visibility = System.Windows.Visibility.Visible;
            clicktype.Visibility = System.Windows.Visibility.Collapsed;
            btnPlay.Visibility = System.Windows.Visibility.Visible;
            Dog_Bone.Visibility = System.Windows.Visibility.Collapsed;
            btnbite.Visibility = System.Windows.Visibility.Collapsed;
            btnsplat.Visibility = System.Windows.Visibility.Collapsed;
            btncrash.Visibility = System.Windows.Visibility.Collapsed;
            btnwoosh.Visibility = System.Windows.Visibility.Collapsed;
            btnblop.Visibility = System.Windows.Visibility.Collapsed;
            btncoin.Visibility = System.Windows.Visibility.Collapsed;
            btngong.Visibility = System.Windows.Visibility.Collapsed;
            btnthunder.Visibility = System.Windows.Visibility.Collapsed;
            btnpool.Visibility = System.Windows.Visibility.Collapsed;
            btnpunch.Visibility = System.Windows.Visibility.Collapsed;
            btngunshot.Visibility = System.Windows.Visibility.Collapsed;
            btnspin.Visibility = System.Windows.Visibility.Collapsed;
            PlaySound.IsMuted = true;
            PlaySound.Source = new Uri("/Assets/Sounds/gun.wav", UriKind.Relative);
            PlaySound.Stop();
        }

        private void btnspin_Click(object sender, RoutedEventArgs e)
        {
            //stops exisiting
            PlaySound.Stop();
            PlaySound.Source = null;
            //hide buttons
            btnclick.Visibility = System.Windows.Visibility.Collapsed;
            btnpop.Visibility = System.Windows.Visibility.Collapsed;
            btnmore.Visibility = System.Windows.Visibility.Collapsed;
            btnsnap.Visibility = System.Windows.Visibility.Collapsed;
            btncrackle.Visibility = System.Windows.Visibility.Collapsed;
            btnding.Visibility = System.Windows.Visibility.Collapsed;
            btndrip.Visibility = System.Windows.Visibility.Collapsed;
            btndoorbell.Visibility = System.Windows.Visibility.Collapsed;
            btndrop.Visibility = System.Windows.Visibility.Collapsed;
            btnsqeak.Visibility = System.Windows.Visibility.Collapsed;
            btnblast.Visibility = System.Windows.Visibility.Collapsed;
            btnsiren.Visibility = System.Windows.Visibility.Collapsed;
            btnchime.Visibility = System.Windows.Visibility.Collapsed;
            btnback3.Visibility = System.Windows.Visibility.Visible;
            clicktype.Visibility = System.Windows.Visibility.Collapsed;
            btnPlay.Visibility = System.Windows.Visibility.Visible;
            Dog_Bone.Visibility = System.Windows.Visibility.Collapsed;
            btnbite.Visibility = System.Windows.Visibility.Collapsed;
            btnsplat.Visibility = System.Windows.Visibility.Collapsed;
            btncrash.Visibility = System.Windows.Visibility.Collapsed;
            btnwoosh.Visibility = System.Windows.Visibility.Collapsed;
            btnblop.Visibility = System.Windows.Visibility.Collapsed;
            btncoin.Visibility = System.Windows.Visibility.Collapsed;
            btngong.Visibility = System.Windows.Visibility.Collapsed;
            btnthunder.Visibility = System.Windows.Visibility.Collapsed;
            btnpool.Visibility = System.Windows.Visibility.Collapsed;
            btnpunch.Visibility = System.Windows.Visibility.Collapsed;
            btngunshot.Visibility = System.Windows.Visibility.Collapsed;
            btnspin.Visibility = System.Windows.Visibility.Collapsed;
            PlaySound.IsMuted = true;
            PlaySound.Source = new Uri("/Assets/Sounds/spin.wav", UriKind.Relative);
            PlaySound.Stop();
        
        }

        private void btnback3_Click(object sender, RoutedEventArgs e)
        {
            btnback3.Visibility = System.Windows.Visibility.Collapsed;
            btnback2.Visibility = System.Windows.Visibility.Visible;
            btnback.Visibility = System.Windows.Visibility.Collapsed;
            PlaySound.Stop();
            PlaySound.Source = null;
            btnbite.Visibility = System.Windows.Visibility.Visible;
            btnsplat.Visibility = System.Windows.Visibility.Visible;
            btncrash.Visibility = System.Windows.Visibility.Visible;
            btnwoosh.Visibility = System.Windows.Visibility.Visible;
            btnblop.Visibility = System.Windows.Visibility.Visible;
            btncoin.Visibility = System.Windows.Visibility.Visible;
            btngong.Visibility = System.Windows.Visibility.Visible;
            btnthunder.Visibility = System.Windows.Visibility.Visible;
            btnpool.Visibility = System.Windows.Visibility.Visible;
            btnpunch.Visibility = System.Windows.Visibility.Visible;
            btngunshot.Visibility = System.Windows.Visibility.Visible;
            btnspin.Visibility = System.Windows.Visibility.Visible;
            btnclick.Visibility = System.Windows.Visibility.Visible;
            btnpop.Visibility = System.Windows.Visibility.Visible;
            btnmore.Visibility = System.Windows.Visibility.Collapsed;
            btnsnap.Visibility = System.Windows.Visibility.Collapsed;
            btncrackle.Visibility = System.Windows.Visibility.Collapsed;
            btnding.Visibility = System.Windows.Visibility.Collapsed;
            btndrip.Visibility = System.Windows.Visibility.Collapsed;
            btndoorbell.Visibility = System.Windows.Visibility.Collapsed;
            btndrop.Visibility = System.Windows.Visibility.Collapsed;
            btnsqeak.Visibility = System.Windows.Visibility.Collapsed;
            btnblast.Visibility = System.Windows.Visibility.Collapsed;
            btnsiren.Visibility = System.Windows.Visibility.Collapsed;
            btnchime.Visibility = System.Windows.Visibility.Collapsed;
            btnPlay.Visibility = System.Windows.Visibility.Collapsed;
            Dog_Bone.Visibility = System.Windows.Visibility.Visible;
            clicktype.Visibility = System.Windows.Visibility.Visible;

        }

        private void Information_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/About.xaml", UriKind.Relative));
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}