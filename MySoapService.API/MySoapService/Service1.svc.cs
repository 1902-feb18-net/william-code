using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MySoapService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public static readonly string Version = "1.0.0";
        public static readonly Question _question = new Question { QuestionId = 1, Category = "Math", Rating = 3, DateModified = DateTime.Now};

        public int DoubleNumber(int num)
        {
            return num * 2;
        }

        public string GetServiceVersion()
        {
            return Version;
        }

        public Question GetQuestion(int id)
        {
            if(id == 1)
            {
                return _question;
            }
            else
            {
                throw new FaultException<InvalidOperationException>(
                    new InvalidOperationException("no question found with that id"), "invalid");
            }
        }
    }
}
