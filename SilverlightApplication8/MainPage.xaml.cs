using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace SilverlightApplication8
{
    public partial class MainPage : UserControl
    {
        Random rdm = new Random();
        DispatcherTimer timer = new DispatcherTimer();
        Rectangle rect;


        public MainPage()
        {
            InitializeComponent();
            aa();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (rect != null) LayoutRoot.Children.Remove(rect);

            rect = new Rectangle
            {
                Fill = new SolidColorBrush(Color.FromArgb(255, (byte)rdm.Next(1, 255), (byte)rdm.Next(1, 255), (byte)rdm.Next(1, 255))),
                Margin = new Thickness(2),
                Cursor = Cursors.Hand
            };

            Grid.SetColumn(rect,rdm.Next(0,10));
            Grid.SetRow(rect, rdm.Next(0,10));
            LayoutRoot.Children.Add(rect);


        }

        private void aa()
        {
              


            for (int i = 0; i < 10; i++)
            {
                LayoutRoot.RowDefinitions.Add(new RowDefinition());
                LayoutRoot.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int r = 0; r < 11; r++)
            {
                for (int c = 0; c < 11; c++)
                {
                    Rectangle rect = new Rectangle()
                    {
                        Fill = new SolidColorBrush(Color.FromArgb(255,(byte)rdm.Next(1,255), (byte)rdm.Next(1, 255), (byte)rdm.Next(1, 255))),

                        Margin = new Thickness(2),
                        Cursor = Cursors.Hand
                    };
                    Grid.SetRow(rect, r);
                    Grid.SetColumn(rect, c);
                    LayoutRoot.Children.Add(rect);
                    
                }
            }

        }
    }
}
