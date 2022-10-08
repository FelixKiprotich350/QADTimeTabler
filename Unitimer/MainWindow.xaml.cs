using System.Windows;

namespace Unitimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           // MainNavigationMenu.Items
            //  MainContentArea.Navigate(new Home());
            ClosableTabitem theTabItem = new ClosableTabitem();
            theTabItem.Title = "Small title";
            MainContentTabControl.Items.Add(theTabItem);
            theTabItem.Focus();
        }

        private void SetUpMenu()
        {

        }
         
    }
}
