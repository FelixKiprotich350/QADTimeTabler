using System.Windows;
using System.Windows.Controls;
using Unitimer.Navigation;

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
            //SetUpMenu();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SetUpMenu();
            //MainContentArea.Navigate(new Home());
            ClosableTabitem theTabItem = new ClosableTabitem
            {
                Title = "Home"

            };
            MainContentTabControl.Items.Add(theTabItem);
            theTabItem.Focus();
        }

        private void SetUpMenu()
        { 
            var m = ModulesCollection.GetModules();
            foreach (MenuModule x in m)
            {
                MainNavigationMenu.Items.Add(new MenuItem() { Header=x.GroupName,Tag=x.GroupCode });
            }
            foreach(MenuItem x in MainNavigationMenu.Items)
            {
              //load sub items
            }
            
        }
         
    }
}
