using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesandEvents
{
    class Question
    {
        public int QID { get; set; }
        public String QText { get; set; }
        public String CorrectAnswer { get; set; }
        public List<Answer> AnswerList { get; set; }
    }
}
