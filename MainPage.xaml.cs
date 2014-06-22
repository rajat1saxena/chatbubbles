using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace WP_nosilverlight_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ObservableCollection<Message> allmessages;
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

            allmessages = new ObservableCollection<Message>();
            allmessages.Add(new Message { TextMessage = "Hello Rita,how are you?", Time = DateTime.Now.ToString(), Status = "Sent", tofrom = true });
            allmessages.Add(new Message { TextMessage = "Hello Raj,I am fine.Wbu?", Time = DateTime.Now.ToString(), Status = "Sent", tofrom = false });
            allmessages.Add(new Message { TextMessage = "Everything is great at my end.Where are you?I heard it's so cold out there.Are you coming to India soon?", Time = DateTime.Now.ToString(), Status = "Sent", tofrom = true });
            allmessages.Add(new Message { TextMessage = "I'm in Australia these days", Time = DateTime.Now.ToString(), Status = "Sent", tofrom = false });
            allmessages.Add(new Message { TextMessage = "Great!", Time = DateTime.Now.ToString(), Status = "Sent", tofrom = true });
            allmessages.Add(new Message { TextMessage = "I am leaving my hometown in 2-3 days", Time = DateTime.Now.ToString(), Status = "Failed", tofrom = true });

            this.myChat.ItemsSource = allmessages;
            System.Diagnostics.Debug.WriteLine(allmessages.Count);
            //this.myChat.DataContext = allmessages;

            //setting colors of various controls
            //Color colord = (Color)Application.Current.Resources["PhoneAccentBrush"];
            
            //System.Diagnostics.Debug.WriteLine(strHexa);
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void meClick_Click(object sender, RoutedEventArgs e)
        {
            allmessages.Add(new Message { TextMessage = "This is an extra ME bubble", Time = DateTime.Now.ToString(), Status = "Sent", tofrom = true });
        }

        private void youClick_Click(object sender, RoutedEventArgs e)
        {
            allmessages.Add(new Message { TextMessage = "This is an extra YOU bubble", Time = DateTime.Now.ToString(), Status = "Sent", tofrom = false });
        }
    }
}
