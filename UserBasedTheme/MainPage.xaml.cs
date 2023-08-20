using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using PSPDFKit.UI;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UserBasedTheme
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        
        private void OnUser1Click(object sender, RoutedEventArgs e)
        {
            PdfContainer.Content = new PdfView()
            {
                Css = new Uri("ms-appx-web:///Assets/user1.css"),
                PdfUriSource = new Uri("ms-appx:///Assets/demo.pdf")
            };
        }

        private void OnUser2Click(object sender, RoutedEventArgs e)
        {
            PdfContainer.Content = new PdfView()
            {
                Css = new Uri("ms-appx-web:///Assets/user2.css"),
                PdfUriSource = new Uri("ms-appx:///Assets/demo.pdf")
            };
        }
    }
}
