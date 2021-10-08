using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

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
            Helpers.LinkHandler.OpenBrowser("https://github.com/rocksdanister/lively");
        }
    }
}
