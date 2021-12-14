using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using lively.Common.Helpers;

namespace lively.Views.Pages
{
    public partial class AboutPage : UserControl
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void OnSrcButtonClick(object sender, RoutedEventArgs e)
        {
            LinkHandler.OpenBrowser("https://github.com/rocksdanister/lively");
        }
    }
}
