using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesandEvents
{
    class Answer
    {
        public int AnswerId { get; set; }
        public String AnswerText { get; set; }
        public Question question { get; set; }
    }
}
