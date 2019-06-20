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

namespace _10_WPF_WrapPanel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeComponent();
            WrapPanel wp = new WrapPanel();
            wp.Orientation = Orientation.Vertical;
            RadioButton r1 = new RadioButton();
            r1.Content = "C#";
            r1.GroupName = "Languages";
            r1.IsChecked = true;
            wp.Children.Add(r1);
            RadioButton r2 = new RadioButton();
            r2.Content = "VB";
            r2.GroupName = "Languages";
            wp.Children.Add(r2);
            RadioButton r3 = new RadioButton();
            r3.Content = "C++";
            r3.GroupName = "Languages";
            wp.Children.Add(r3);
            RadioButton r4 = new RadioButton();
            r4.Content = "WPF";
            r4.GroupName = "Technologies";
            r4.IsChecked = true;
            wp.Children.Add(r4);
            RadioButton r5 = new RadioButton();
            r5.GroupName = "Technologies";
            r5.Content = "WinForms";
            wp.Children.Add(r5);
            RadioButton r6 = new RadioButton();
            r6.Content = "ASP.Net";
            r6.GroupName = "Technologies";
            wp.Children.Add(r6);
            Content = wp;
        }
    }
}
