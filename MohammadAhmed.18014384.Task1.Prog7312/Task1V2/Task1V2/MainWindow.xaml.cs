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

namespace Task1V2
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

        private void RepBtn_Click(object sender, RoutedEventArgs e)
        {
            ReplacingBooks p = new ReplacingBooks();
            p.Show();// Shows the new window for replacing books
                     // Abdul Rasheed Feroz Khan (2021) Create a New Window in WPF
                     // [Source Code] https://www.c-sharpcorner.com/blogs/create-a-new-window-in-wpf 

        }

        private void IdenBtn_Click(object sender, RoutedEventArgs e)
        {
            IdentifyingAreas p = new IdentifyingAreas();
            p.Show();

            //string message = "Not Available";
            //string title = "Identifying Areas";
            //MessageBox.Show(message, title);// Has been disabled


        }

        private void FcnBtn_Click(object sender, RoutedEventArgs e)
        {
            string message = "Not Available";
            string title = "Finding Call Numbers";
            MessageBox.Show(message, title);// Has been disabled
        }
    }
}
