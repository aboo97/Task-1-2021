using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1V2
{
    class DictionDataAnswers
    {

    
    public string Answers { get; set; }

        public DictionDataAnswers(string answ)
        {
            
            Answers = answ;

        }

        public static Dictionary<string, DictionDataAnswers> GetQuestion()
        {
            var question = new Dictionary<string, DictionDataAnswers>();
            var theQuestion = new DictionDataAnswers("General Works");
            question.Add("A", theQuestion);
            theQuestion = new DictionDataAnswers("B");
            question.Add("Philosophy, Psychology, Religion", theQuestion);
            theQuestion = new DictionDataAnswers("History - Civilization");
            question.Add("C", theQuestion);
            theQuestion = new DictionDataAnswers("D");
            question.Add("History - General", theQuestion);
            theQuestion = new DictionDataAnswers("US History"); //       
            //  "", "", "", "", "", "", "", "", ""
            question.Add("E", theQuestion);
            theQuestion = new DictionDataAnswers("F");
            question.Add("US Loacl History and Latin American", theQuestion);
            theQuestion = new DictionDataAnswers("Geography, Anthropology, Recreation");
            question.Add("G", theQuestion);
            theQuestion = new DictionDataAnswers("H");
            question.Add("Social Science", theQuestion);
            theQuestion = new DictionDataAnswers("Political Science");
            question.Add("J", theQuestion);
            theQuestion = new DictionDataAnswers("K");
            question.Add("Law", theQuestion);
            theQuestion = new DictionDataAnswers("Education");
            question.Add("L", theQuestion);
            theQuestion = new DictionDataAnswers("M");
            question.Add("Music", theQuestion);
            theQuestion = new DictionDataAnswers("Fine Arts");
            question.Add("N", theQuestion);
            theQuestion = new DictionDataAnswers("P");
            question.Add("Language & Literature", theQuestion);
            theQuestion = new DictionDataAnswers("Science");
            question.Add("Q", theQuestion);
            theQuestion = new DictionDataAnswers("R");
            question.Add("Medicine", theQuestion);
            theQuestion = new DictionDataAnswers("Agricukture");
            question.Add("S", theQuestion);
            theQuestion = new DictionDataAnswers("T");
            question.Add("Technology", theQuestion);
            theQuestion = new DictionDataAnswers("Military Science");
            question.Add("U", theQuestion);
            theQuestion = new DictionDataAnswers("V");
            question.Add("Naval Science", theQuestion);
            theQuestion = new DictionDataAnswers("Information Science");
            question.Add("Z", theQuestion);

            return question;


        }
    }
}
