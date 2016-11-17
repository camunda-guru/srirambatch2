using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesandEvents
{
    class MCQ
    {

        public List<Question> createQuestions()
        {
            List<Question> questionList = new List<Question>();
            List<Answer> answerList = new List<Answer>();
            Question questn = new Question { QID = 1, QText = "Which country brixit?", CorrectAnswer = "3" };
            answerList.Add(new Answer { AnswerId=1,AnswerText="India",question=questn});
            answerList.Add(new Answer { AnswerId = 2, AnswerText = "Pakistan", question = questn });
            answerList.Add(new Answer { AnswerId = 3, AnswerText = "England", question = questn });
            answerList.Add(new Answer { AnswerId = 4, AnswerText = "Scotland", question = questn });
            questn.AnswerList = answerList; 
            questionList.Add(questn);
            answerList = new List<Answer>();
            questn = new Question { QID = 2, QText = "Which feature got added in MVC5?", CorrectAnswer = "A" };
            answerList.Add(new Answer { AnswerId = 1, AnswerText = "Oauth", question = questn });
            answerList.Add(new Answer { AnswerId = 2, AnswerText = "Owin", question = questn });
            answerList.Add(new Answer { AnswerId = 3, AnswerText = "WebApI", question = questn });
 
            questn.AnswerList = answerList;
            questionList.Add(questn);
            answerList = new List<Answer>();
            questn = new Question { QID = 3, QText = "Which currency got banned in India ?", CorrectAnswer = "B" };
            answerList.Add(new Answer { AnswerId = 1, AnswerText = "50", question = questn });
            answerList.Add(new Answer { AnswerId = 2, AnswerText = "500 and 1000", question = questn });
            
            questn.AnswerList = answerList;
            questionList.Add(questn);


            return questionList;

        }

    }
}
