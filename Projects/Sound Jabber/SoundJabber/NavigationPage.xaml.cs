using Microsoft.Phone.Controls;
using System;
using System.Windows.Navigation;

namespace SoundJabber
{
    public partial class NavigationPage : PhoneApplicationPage
    {
        public NavigationPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml?pivotItem=custom", UriKind.RelativeOrAbsolute));
        }
    }
}