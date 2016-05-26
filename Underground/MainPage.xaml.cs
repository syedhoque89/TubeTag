using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Underground
{
    /// <summary>
    ///     An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void HamburgerButton_OnClick(object sender, RoutedEventArgs e)
        {
           MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;

        }

        private async void IconListBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MyProgressRing.IsActive = true;
            var res = await tflFacade.GetTubeStatusAsync();
            MySplitView.IsPaneOpen = false;
            var selection = IconListBox.SelectedIndex.ToString();
            MyProgressRing.IsActive = false;
            try
            {
                switch (selection)
                {
                    //Bakerloo line
                    case "0":
                        MyMainGrid.Background = new SolidColorBrush(Colors.Sienna);
                        TitleTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        DetailsTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        ReasonTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        TitleTextBlock.Text = res[0].name;
                        DetailsTextBlock.Text = res[0].lineStatuses[0].statusSeverityDescription;
                        if (res[0].lineStatuses[0].reason != null)
                        {
                            ReasonTextBlock.Text = res[0].lineStatuses[0].reason;
                        }
                        else
                        {
                            ReasonTextBlock.Text = "";
                        }
                        break;
                    //Central line
                    case "1":
                        MyMainGrid.Background = new SolidColorBrush(Colors.DarkRed);
                        TitleTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        DetailsTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        ReasonTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        TitleTextBlock.Text = res[1].name;
                        DetailsTextBlock.Text = res[1].lineStatuses[0].statusSeverityDescription;
                        if (res[1].lineStatuses[0].reason != null)
                        {
                            ReasonTextBlock.Text = res[1].lineStatuses[0].reason;
                        }
                        else
                        {
                            ReasonTextBlock.Text = "";
                        }
                        break;
                    //Circle line
                    case "2":
                        MyMainGrid.Background = new SolidColorBrush(Colors.Gold);
                        TitleTextBlock.Foreground = new SolidColorBrush(Colors.MidnightBlue);
                        DetailsTextBlock.Foreground = new SolidColorBrush(Colors.MidnightBlue);
                        ReasonTextBlock.Foreground = new SolidColorBrush(Colors.MidnightBlue);
                        TitleTextBlock.Text = res[2].name;
                        DetailsTextBlock.Text = res[2].lineStatuses[0].statusSeverityDescription;
                        if (res[2].lineStatuses[0].reason != null)
                        {
                            ReasonTextBlock.Text = res[2].lineStatuses[0].reason;
                        }
                        else
                        {
                            ReasonTextBlock.Text = "";
                        }
                        break;
                    //District line
                    case "3":
                        MyMainGrid.Background = new SolidColorBrush(Colors.DarkGreen);
                        TitleTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        DetailsTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        ReasonTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        TitleTextBlock.Text = res[3].name;
                        DetailsTextBlock.Text = res[3].lineStatuses[0].statusSeverityDescription;
                        if (res[3].lineStatuses[0].reason != null)
                        {
                            ReasonTextBlock.Text = res[3].lineStatuses[0].reason;
                        }
                        else
                        {
                            ReasonTextBlock.Text = "";
                        }
                        break;
                    //DLR
                    case "4":
                        MyMainGrid.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                        TitleTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        DetailsTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        ReasonTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        TitleTextBlock.Text = res[4].name;
                        DetailsTextBlock.Text = res[4].lineStatuses[0].statusSeverityDescription;
                        if (res[4].lineStatuses[0].reason != null)
                        {
                            ReasonTextBlock.Text = res[4].lineStatuses[0].reason;
                        }
                        else
                        {
                            ReasonTextBlock.Text = "";
                        }
                        break;
                    //Hammersmith & City
                    case "5":
                        MyMainGrid.Background = new SolidColorBrush(Colors.LightPink);
                        TitleTextBlock.Foreground = new SolidColorBrush(Colors.MidnightBlue);
                        DetailsTextBlock.Foreground = new SolidColorBrush(Colors.MidnightBlue);
                        ReasonTextBlock.Foreground = new SolidColorBrush(Colors.MidnightBlue);
                        TitleTextBlock.Text = res[5].name;
                        DetailsTextBlock.Text = res[5].lineStatuses[0].statusSeverityDescription;
                        if (res[5].lineStatuses[0].reason != null)
                        {
                            ReasonTextBlock.Text = res[5].lineStatuses[0].reason;
                        }
                        else
                        {
                            ReasonTextBlock.Text = "";
                        }
                        break;
                    //Jubilee line
                    case "6":
                        MyMainGrid.Background = new SolidColorBrush(Colors.Silver);
                        TitleTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        DetailsTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        ReasonTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        TitleTextBlock.Text = res[6].name;
                        DetailsTextBlock.Text = res[6].lineStatuses[0].statusSeverityDescription;
                        if (res[6].lineStatuses[0].reason != null)
                        {
                            ReasonTextBlock.Text = res[6].lineStatuses[0].reason;
                        }
                        else
                        {
                            ReasonTextBlock.Text = "";
                        }
                        break;
                    //Metropolitan line
                    case "7":
                        MyMainGrid.Background = new SolidColorBrush(Colors.DarkMagenta);
                        TitleTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        DetailsTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        ReasonTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        TitleTextBlock.Text = res[8].name;
                        DetailsTextBlock.Text = res[8].lineStatuses[0].statusSeverityDescription;
                        if (res[8].lineStatuses[0].reason != null)
                        {
                            ReasonTextBlock.Text = res[8].lineStatuses[0].reason;
                        }
                        else
                        {
                            ReasonTextBlock.Text = "";
                        }
                        break;

                    //Northern line
                    case "8":
                        MyMainGrid.Background = new SolidColorBrush(Colors.White);
                        TitleTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        DetailsTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        ReasonTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        TitleTextBlock.Text = res[9].name;
                        DetailsTextBlock.Text = res[9].lineStatuses[0].statusSeverityDescription;
                        if (res[9].lineStatuses[0].reason != null)
                        {
                            ReasonTextBlock.Text = res[9].lineStatuses[0].reason;
                        }
                        else
                        {
                            ReasonTextBlock.Text = "";
                        }
                        break;
                    //Overground
                    case "9":
                        MyMainGrid.Background = new SolidColorBrush(Colors.DarkOrange);
                        TitleTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        DetailsTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        ReasonTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        TitleTextBlock.Text = res[7].name;
                        DetailsTextBlock.Text = res[7].lineStatuses[0].statusSeverityDescription;
                        if (res[7].lineStatuses[0].reason != null)
                        {
                            ReasonTextBlock.Text = res[7].lineStatuses[0].reason;
                        }
                        else
                        {
                            ReasonTextBlock.Text = "";
                        }
                        break;
                    //Piccadilly line
                    case "10":
                        MyMainGrid.Background = new SolidColorBrush(Colors.DarkBlue);
                        TitleTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        DetailsTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        ReasonTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        TitleTextBlock.Text = res[10].name;
                        DetailsTextBlock.Text = res[10].lineStatuses[0].statusSeverityDescription;
                        if (res[10].lineStatuses[0].reason != null)
                        {
                            ReasonTextBlock.Text = res[10].lineStatuses[0].reason;
                        }
                        else
                        {
                            ReasonTextBlock.Text = "";
                        }
                        break;
                    //Victoria line
                    case "11":
                        MyMainGrid.Background = new SolidColorBrush(Colors.LightSkyBlue);
                        TitleTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        DetailsTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        ReasonTextBlock.Foreground = new SolidColorBrush(Colors.White);
                        TitleTextBlock.Text = res[11].name;
                        DetailsTextBlock.Text = res[11].lineStatuses[0].statusSeverityDescription;
                        if (res[11].lineStatuses[0].reason != null)
                        {
                            ReasonTextBlock.Text = res[11].lineStatuses[0].reason;
                        }
                        else
                        {
                            ReasonTextBlock.Text = "";
                        }
                        break;
                    //Waterloo & City line
                    case "12":
                        MyMainGrid.Background = new SolidColorBrush(Colors.PowderBlue);
                        TitleTextBlock.Foreground = new SolidColorBrush(Colors.MidnightBlue);
                        DetailsTextBlock.Foreground = new SolidColorBrush(Colors.MidnightBlue);
                        ReasonTextBlock.Foreground = new SolidColorBrush(Colors.MidnightBlue);
                        TitleTextBlock.Text = res[12].name;
                        DetailsTextBlock.Text = res[12].lineStatuses[0].statusSeverityDescription;
                        if (res[12].lineStatuses[0].reason != null)
                        {
                            ReasonTextBlock.Text = res[12].lineStatuses[0].reason;
                        }
                        else
                        {
                            ReasonTextBlock.Text = "";
                        }
                        break;
                }
            }
            catch
            {
                TitleTextBlock.Text = "Error!!!";
                DetailsTextBlock.Text = "Couldn't Retrieve Tube Status..";
                ReasonTextBlock.Text = "";

            }
        }

        private void MySplitView_PaneClosed(SplitView sender, object args)
        {
         
        }
        private void MainPage_OnLoaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void MainPage_OnLoading(FrameworkElement sender, object args)
        {
            
        }
    }
}