using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Unitimer
{
    class ClosableTabitem : TabItem
    {


        // Constructor
        public ClosableTabitem()
        {
            // Create an instance of the usercontrol
            ClosableTabHeader closableTabHeader = new ClosableTabHeader();

            // Assign the usercontrol to the tab header
            this.Header = closableTabHeader;

            // Attach to the ClosableTabHeader events (Mouse Enter/Leave, Button Click, and Label resize)
            closableTabHeader.Button_Close.MouseEnter += new MouseEventHandler(Button_close_MouseEnter);
            closableTabHeader.Button_Close.MouseLeave += new MouseEventHandler(Button_close_MouseLeave);
            closableTabHeader.Button_Close.Click += new RoutedEventHandler(Button_close_Click);
            closableTabHeader.Label_TabTitle.SizeChanged += new SizeChangedEventHandler(Label_TabTitle_SizeChanged);
        }



        /// <summary>
        /// Property - Set the Title of the Tab
        /// </summary>
        public string Title
        {
            set
            {
                ((ClosableTabHeader)this.Header).Label_TabTitle.Content = value;
            }
        }




        //
        // - - - Overrides  - - -
        //


        // Override OnSelected - Show the Close Button
        protected override void OnSelected(RoutedEventArgs e)
        {
            base.OnSelected(e);
            ((ClosableTabHeader)this.Header).Button_Close.Visibility = Visibility.Visible;
        }

        // Override OnUnSelected - Hide the Close Button
        protected override void OnUnselected(RoutedEventArgs e)
        {
            base.OnUnselected(e);
            ((ClosableTabHeader)this.Header).Button_Close.Visibility = Visibility.Hidden;
        }

        // Override OnMouseEnter - Show the Close Button
        protected override void OnMouseEnter(MouseEventArgs e)
        {
            base.OnMouseEnter(e);
            ((ClosableTabHeader)this.Header).Button_Close.Visibility = Visibility.Visible;
        }

        // Override OnMouseLeave - Hide the Close Button (If it is NOT selected)
        protected override void OnMouseLeave(MouseEventArgs e)
        {
            base.OnMouseLeave(e);
            if (!this.IsSelected)
            {
                ((ClosableTabHeader)this.Header).Button_Close.Visibility = Visibility.Hidden;
            }
        }





        //
        // - - - Event Handlers  - - -
        //


        // Button MouseEnter - When the mouse is over the button - change color to Red
        void Button_close_MouseEnter(object sender, MouseEventArgs e)
        {
            ((ClosableTabHeader)this.Header).Button_Close.Foreground = Brushes.Red;
        }

        // Button MouseLeave - When mouse is no longer over button - change color back to black
        void Button_close_MouseLeave(object sender, MouseEventArgs e)
        {
            ((ClosableTabHeader)this.Header).Button_Close.Foreground = Brushes.Black;
        }


        // Button Close Click - Remove the Tab - (or raise an event indicating a "CloseTab" event has occurred)
        void Button_close_Click(object sender, RoutedEventArgs e)
        {
            ((TabControl)this.Parent).Items.Remove(this);
        }


        // Label SizeChanged - When the Size of the Label changes (due to setting the Title) set position of button properly
        void Label_TabTitle_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ((ClosableTabHeader)this.Header).Button_Close.Margin = new Thickness(((ClosableTabHeader)this.Header).Label_TabTitle.ActualWidth + 5, 3, 4, 0);
        }





    }
}
