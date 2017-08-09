using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KeyPress
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> keys = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(MainWindow_KeyDown);
            Button BR_0_C1 = new Button();
            BR_0_C1.FontSize = 20;
            BR_0_C1.Width = 40;
            BR_0_C1.Height = 40;
            BR_0_C1.Content = "ADV-";
            BR_0_C1.Background = Brushes.Bisque;
            LB_0_C1.Items.Add(BR_0_C1);
            Button BR_0_C2 = new Button();
            BR_0_C2.FontSize = 20;
            BR_0_C2.Width = 40;
            BR_0_C2.Height = 40;
            BR_0_C2.Content = "ADV+";
            BR_0_C2.Background = Brushes.Bisque;
            LB_0_C2.Items.Add(BR_0_C2);
            Button BR_0_C3 = new Button();
            BR_0_C3.FontSize = 20;
            BR_0_C3.Width = 40;
            BR_0_C3.Height = 40;
            BR_0_C3.Content = "ADV-";
            BR_0_C3.Background = Brushes.Aqua;
            LB_0_C3.Items.Add(BR_0_C3);
            Button BR_0_C4 = new Button();
            BR_0_C4.FontSize = 20;
            BR_0_C4.Width = 40;
            BR_0_C4.Height = 40;
            BR_0_C4.Content = "ADV+";
            BR_0_C4.Background = Brushes.Aqua;
            LB_0_C4.Items.Add(BR_0_C4);
            Button BR_1_C1 = new Button();
            BR_1_C1.FontSize = 20;
            BR_1_C1.Width = 40;
            BR_1_C1.Height = 40;
            BR_1_C1.Content = "PEN-";
            BR_1_C1.Background = Brushes.Bisque;
            LB_1_C1.Items.Add(BR_1_C1);
            Button BR_1_C2 = new Button();
            BR_1_C2.FontSize = 20;
            BR_1_C2.Width = 40;
            BR_1_C2.Height = 40;
            BR_1_C2.Content = "PEN+";
            BR_1_C2.Background = Brushes.Bisque;
            LB_1_C2.Items.Add(BR_1_C2);
            Button BR_1_C3 = new Button();
            BR_1_C3.FontSize = 20;
            BR_1_C3.Width = 40;
            BR_1_C3.Height = 40;
            BR_1_C3.Content = "PEN-";
            BR_1_C3.Background = Brushes.Aqua;
            LB_1_C3.Items.Add(BR_1_C3);
            Button BR_1_C4 = new Button();
            BR_1_C4.FontSize = 20;
            BR_1_C4.Width = 40;
            BR_1_C4.Height = 40;
            BR_1_C4.Content = "PEN+";
            BR_1_C4.Background = Brushes.Aqua;
            LB_1_C4.Items.Add(BR_1_C4);
            Button BR_2_C1 = new Button();
            BR_2_C1.FontSize = 20;
            BR_2_C1.Width = 40;
            BR_2_C1.Height = 40;
            BR_2_C1.Content = "4-";
            BR_2_C1.Background = Brushes.Bisque;
            LB_2_C1.Items.Add(BR_2_C1);
            Button BR_2_C2 = new Button();
            BR_2_C2.FontSize = 20;
            BR_2_C2.Width = 40;
            BR_2_C2.Height = 40;
            BR_2_C2.Content = "4+";
            BR_2_C2.Background = Brushes.Bisque;
            LB_2_C2.Items.Add(BR_2_C2);
            Button BR_2_C3 = new Button();
            BR_2_C3.FontSize = 20;
            BR_2_C3.Width = 40;
            BR_2_C3.Height = 40;
            BR_2_C3.Content = "4-";
            BR_2_C3.Background = Brushes.Aqua;
            LB_2_C3.Items.Add(BR_2_C3);
            Button BR_2_C4 = new Button();
            BR_2_C4.FontSize = 20;
            BR_2_C4.Width = 40;
            BR_2_C4.Height = 40;
            BR_2_C4.Content = "4+";
            BR_2_C4.Background = Brushes.Aqua;
            LB_2_C4.Items.Add(BR_2_C4);
            Button BR_3_C1 = new Button();
            BR_3_C1.FontSize = 20;
            BR_3_C1.Width = 40;
            BR_3_C1.Height = 40;
            BR_3_C1.Content = "3-";
            BR_3_C1.Background = Brushes.Bisque;
            LB_3_C1.Items.Add(BR_3_C1);
            Button BR_3_C2 = new Button();
            BR_3_C2.FontSize = 20;
            BR_3_C2.Width = 40;
            BR_3_C2.Height = 40;
            BR_3_C2.Content = "3+";
            BR_3_C2.Background = Brushes.Bisque;
            LB_3_C2.Items.Add(BR_3_C2);
            Button BR_3_C3 = new Button();
            BR_3_C3.FontSize = 20;
            BR_3_C3.Width = 40;
            BR_3_C3.Height = 40;
            BR_3_C3.Content = "3-";
            BR_3_C3.Background = Brushes.Aqua;
            LB_3_C3.Items.Add(BR_3_C3);
            Button BR_3_C4 = new Button();
            BR_3_C4.FontSize = 20;
            BR_3_C4.Width = 40;
            BR_3_C4.Height = 40;
            BR_3_C4.Content = "3+";
            BR_3_C4.Background = Brushes.Aqua;
            LB_3_C4.Items.Add(BR_3_C4);
            Button BR_4_C1 = new Button();
            BR_4_C1.FontSize = 20;
            BR_4_C1.Width = 40;
            BR_4_C1.Height = 40;
            BR_4_C1.Content = "2-";
            BR_4_C1.Background = Brushes.Bisque;
            LB_4_C1.Items.Add(BR_4_C1);
            Button BR_4_C2 = new Button();
            BR_4_C2.FontSize = 20;
            BR_4_C2.Width = 40;
            BR_4_C2.Height = 40;
            BR_4_C2.Content = "2+";
            BR_4_C2.Background = Brushes.Bisque;
            LB_4_C2.Items.Add(BR_4_C2);
            Button BR_4_C3 = new Button();
            BR_4_C3.FontSize = 20;
            BR_4_C3.Width = 40;
            BR_4_C3.Height = 40;
            BR_4_C3.Content = "2-";
            BR_4_C3.Background = Brushes.Aqua;
            LB_4_C3.Items.Add(BR_4_C3);
            Button BR_4_C4 = new Button();
            BR_4_C4.FontSize = 20;
            BR_4_C4.Width = 40;
            BR_4_C4.Height = 40;
            BR_4_C4.Content = "2+";
            BR_4_C4.Background = Brushes.Aqua;
            LB_4_C4.Items.Add(BR_4_C4);


        }

        void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Subtract)
            {
                // Do something
                int i = 1;
            }
            Target.Text = e.Key.ToString() ;
            keys.Add(e.Key.ToString());
        }

    
    }
}
