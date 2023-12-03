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
using System.Windows.Shapes;

namespace Task1V2
{
    /// <summary>
    /// Interaction logic for IdentifyingAreas.xaml
    /// </summary>
    public partial class IdentifyingAreas : Window
    {
        
        public IdentifyingAreas()
        {
            InitializeComponent();

            
            
            
            
        }

        static Random RQues = new Random();

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            String[] question = { "A", "Philosophy,Physchology, Religion", "C", "History - General", "E", "US Loacl History and Latin American",
                "G", "Social Science", "J", "Law", "L", "Music", "N", "Language & Literature", "Q", "Medicine", "S", "Technology", "U", "Naval Science", "Z"};



            int iSelect1 = RQues.Next(0, 9); C1.Text = question[iSelect1];
            int iSelect2 = RQues.Next(0, 9); C2.Text = question[iSelect2];
            int iSelect3 = RQues.Next(0, 9); C3.Text = question[iSelect3];
            int iSelect4 = RQues.Next(0, 9); C4.Text = question[iSelect4];
            int iSelect5 = RQues.Next(0, 9); C5.Text = question[iSelect5];
            int iSelect6 = RQues.Next(0, 9); C6.Text = question[iSelect6];
            int iSelect7 = RQues.Next(0, 9); C7.Text = question[iSelect7];
            int iSelect8 = RQues.Next(0, 9); C8.Text = question[iSelect8];
            int iSelect9 = RQues.Next(0, 9); C9.Text = question[iSelect9];
            
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            String[] answers = { "General Works", "B", "History - Civilization", "D", "US History", "F", "Geography, Anthropology, Recreation", "H", "Political Science", "K", "Education", "M",
                                    "Fine Arts", "P", "Science", "R", "Agricukture", "T", "Military Science", "V", "Information Science"};

            int iSelect10 = RQues.Next(0, 21); C10.Text = answers[iSelect10];
            int iSelect11 = RQues.Next(0, 21); C11.Text = answers[iSelect11];
            int iSelect12 = RQues.Next(0, 21); C12.Text = answers[iSelect12];
            int iSelect13 = RQues.Next(0, 21); C13.Text = answers[iSelect13];
            int iSelect14 = RQues.Next(0, 21); C14.Text = answers[iSelect14];
            int iSelect15 = RQues.Next(0, 21); C15.Text = answers[iSelect15];
            int iSelect16 = RQues.Next(0, 21); C16.Text = answers[iSelect16];
            int iSelect17 = RQues.Next(0, 21); C17.Text = answers[iSelect17];
            int iSelect18 = RQues.Next(0, 21); C18.Text = answers[iSelect18];
            int iSelect19 = RQues.Next(0, 21); C19.Text = answers[iSelect19];
            int iSelect20 = RQues.Next(0, 21); C20.Text = answers[iSelect20];
            int iSelect21 = RQues.Next(0, 21); C21.Text = answers[iSelect21];

        }
    }
}
