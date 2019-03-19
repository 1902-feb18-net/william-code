using MyWcfConsumer.ServiceReference1;
using MyWcfConsumer.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWcfConsumer
{
    class Program
    {
        static async Task Main(string[] args)
        {

            using (var client = new Service1Client())
            {
                client.Open();

               var version = await client.GetServiceVersionAsync();

                Console.WriteLine(version);

                Console.WriteLine("Enter number: ");
                if (int.TryParse(Console.ReadLine(),out var num))
                {
                    //
                    var doubled = await client.DoubleNumberAsync(num);

                    Console.WriteLine($"Doubled: {doubled}");
                }
                else
                {
                    Console.WriteLine("Not a number!");
                }
            }

            using (var client = new Service2Client())
            {
                client.Open();

                var que = new Question { QuestionId = 2, Category = "random", Rating = 5 };

                await client.AddQuestionAsync(que);

                var queList = await client.GetQuestionsAsync();

                foreach(var item in queList)
                {
                    Console.WriteLine(item.Category);
                }

                Console.WriteLine("Edit?");
                var que2 = await client.GetQuestionByIdAsync(que.QuestionId);
                que2.Category = "Something";

                await client.EditQuestionAsync(que2);

                Console.WriteLine((await client.GetQuestionByIdAsync(que.QuestionId)).Category);

                await client.DeleteQuestionAsync((await client.GetQuestionsAsync()).Last().QuestionId);
            }
            Console.ReadKey();
        }
    }
}
