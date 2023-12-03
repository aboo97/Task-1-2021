using System;
using System.Collections;
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
using System.Windows.Shapes;

namespace Task1V2
{
    /// <summary>
    /// Interaction logic for ReplacingBooks.xaml
    /// </summary>
    public partial class ReplacingBooks : Window
    {
        public ReplacingBooks()
        {
            InitializeComponent();
        }

        Random RGen = new Random();

        private void RnBtn_Click(object sender, RoutedEventArgs e)
        {
            double num1, num2, num3, num4, num5, num6, num7, num8, num9, num10;
            
            
            num1 = (RGen.Next(1, 1000)*1.12);
            num2 = (RGen.Next(1, 1000) * 1.12);
            num3 = (RGen.Next(1, 1000) * 1.12);
            num4 = (RGen.Next(1, 1000) * 1.12);
            num5 = (RGen.Next(1, 1000) * 1.12);
            num6 = (RGen.Next(1, 1000) * 1.12);
            num7 = (RGen.Next(1, 1000) * 1.12);
            num8 = (RGen.Next(1, 1000) * 1.12);
            num9 = (RGen.Next(1, 1000) * 1.12);
            num10 = (RGen.Next(1, 1000) * 1.12);



            Tb1.Text = num1.ToString();
            Tb2.Text = num2.ToString();
            Tb3.Text = num3.ToString();
            Tb4.Text = num4.ToString();
            Tb5.Text = num5.ToString();
            Tb6.Text = num6.ToString();
            Tb7.Text = num7.ToString();
            Tb8.Text = num8.ToString();
            Tb9.Text = num9.ToString();
            Tb10.Text = num10.ToString();
            // This would generate the 10 call numbers
            // StackOverflow (2014) Out Put Random Numbers to TextBox (Version 1.0)
            // [Source code] https://stackoverflow.com/questions/21615351/out-put-random-numbers-to-textbox


            /*List<TextBox> textBoxes = new List<TextBox>() { Tb1, Tb2, Tb3, Tb4, Tb5, Tb6, Tb7, Tb8, Tb9, Tb10 };
            textBoxes.ForEach(x => x.Text = RGen.Next(1,1000).ToString());*/
            // This is trying to make a list for call numbers


        }


        public void Sort(double []a)
        {
            double n = a.Length;
            for (int i = 0; i < n - 1; i++)
              for (int j = 0; j < n - i-1; j++)
                   if (a[j] > a[j + 1])
                    {
                        double temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }

        }

        public string Print (double[] a)
        {
             double n = a.Length;
            string msg = "";

            for (int k = 0; k < n; ++k)
            {
                msg = a[k] + "";
                
            }

            return msg;
            // sorting algorithim
            // Ankur (2020) Bubble Sort C# (Version 4.0)
            // {Source code] https://www.codegrepper.com/code-examples/csharp/bubble+sort+csharp
        }




        private void SubBtn_Click(object sender, RoutedEventArgs e)
        {

            double t1 = double.Parse(Tb1.Text);
            double t2 = double.Parse(Tb2.Text);
            double t3 = double.Parse(Tb3.Text);
            double t4 = double.Parse(Tb4.Text);
            double t5 = double.Parse(Tb5.Text);
            double t6 = double.Parse(Tb6.Text);
            double t7 = double.Parse(Tb7.Text);
            double t8 = double.Parse(Tb8.Text);
            double t9 = double.Parse(Tb9.Text);
            double t10 = double.Parse(Tb10.Text);

            double [] a = {t1,t2,t3,t4,t5,t6,t7,t8,t9,t10};
            Sort(a);
            string display = Print(a);
            lbl1.Content = display;// Trying to match the sorted call numbers

            string message = "Congrats, You got 10/10";// Gamifications
            string title = "Replacing Books";
            MessageBox.Show(message, title);

            //Tb11.Text = t1.ToString();
            //Tb12.Text = t2.ToString();
            //Tb13.Text = t3.ToString();
            //Tb14.Text = t4.ToString();
            //Tb15.Text = t5.ToString();
            //Tb16.Text = t6.ToString();
            //Tb17.Text = t7.ToString();
            //Tb18.Text = t8.ToString();
            //Tb19.Text = t9.ToString();
            //Tb20.Text = t10.ToString();
            
        }
    }
}
