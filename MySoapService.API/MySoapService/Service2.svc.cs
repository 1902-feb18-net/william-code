using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MySoapService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service2" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service2.svc or Service2.svc.cs at the Solution Explorer and start debugging.
    public class Service2 : IService2
    {

        static List<Question> questions = new List<Question>();

        public void AddQuestion(Question question)
        {
            questions.Add(question);
        }

        public void DeleteQuestion(int id)
        {
            questions.Remove(GetQuestionById(id));
        }

        public void EditQuestion(Question question)
        {
            var q = GetQuestionById(question.QuestionId);
            q.Category = question.Category;
            q.Rating = question.Rating;
            q.DateModified = DateTime.Now;
        }

        public Question GetQuestionById(int id)
        {
            return questions.Find(o => o.QuestionId == id);
        }

        public ICollection<Question> GetQuestions()
        {
            return questions;
        }
    }
}
