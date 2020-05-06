using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPMusicLibrary.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPMusicLibrary
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Music> music;
        public MainPage()
        {
            this.InitializeComponent();
            music = new ObservableCollection<Music>();
            MusicManager.GetAllMusic(music);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CategoryTextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void AdvertisementGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AdvertisementGridView_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AppBarToggleButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AppBarToggleButton_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AppBarButton_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void AppBarButton_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void AppBarButton_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void AppBarButton_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void AppBarButton_Click_5(object sender, RoutedEventArgs e)
        {

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UserButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemsListView_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void MusicGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var music = (Music)e.ClickedItem;
            MyMediaElement.Source = new Uri(this.BaseUri, music.FileName);

        }

        private void AppBarButton_LikeClick(object sender, RoutedEventArgs e)
        {

        }

        private void AppBarButton_Click_6(object sender, RoutedEventArgs e)
        {

        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            MyMediaElement.Play();
            if (MyMediaElement.CurrentState == MediaElementState.Playing)
            {
                Symbol pico = Symbol.Play;
                SymbolIcon spico = new SymbolIcon(pico);
                Play.Icon = spico;
                MyMediaElement.Pause();
            }
            else
            {
                Symbol pico = Symbol.Pause;
                SymbolIcon spico = new SymbolIcon(pico);
                Play.Icon = spico;
                MyMediaElement.Play();
            }

        }

        private void ForwardButton_Click(object sender, RoutedEventArgs e)
        {

            MyMediaElement.Position += TimeSpan.FromSeconds(10);



        }

        private void ShuffleButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RepeatButton_Click_1(object sender, RoutedEventArgs e)
        {
            Symbol repico = Symbol.RepeatOne;
            SymbolIcon srepico = new SymbolIcon(repico);
            repButton.Icon = srepico;
            repButton.IsChecked = true;
        }

        private void LikeButton_LikeClick(object sender, RoutedEventArgs e)
        {

        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            MyMediaElement.Stop();
        }

        private void BackButton_MediaClick(object sender, RoutedEventArgs e)
        {
            MyMediaElement.Position -= TimeSpan.FromMinutes(1);
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}