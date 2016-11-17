using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //ParameterizedThreadStart ts = 
            //    new ParameterizedThreadStart
            //        (new Visitor().RequestInstance);
            //Thread[] thread = new Thread[100];
            //Random random = new Random();
            //for (int i = 0; i < 100; i++)
            //{
            //    thread[i] = new Thread(ts);
            //    thread[i].Start(random.Next(1000));
            //}

            //Data inconsistency
            //ThreadStart ts = new ThreadStart(new Visitor().SeqData);
            //Thread[] thread = new Thread[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    thread[i] = new Thread(ts);
            //    thread[i].Start();
            //}
            //Task
            Task<int> task = new Task<int>(() 
                => new Visitor().getNumberBySeed(1000));
            task.Start();
            Console.WriteLine("Task fetches result from method call as----> {0}",task.Result);


            Task<List<Customer>> instask = new Task<List<Customer>>(()=>new InsuranceContext().getCustomerByIndex("99"));
            instask.Start();
            foreach(Customer customer in instask.Result)
            {
                Console.WriteLine("Name{0}------MobileNo{1}", customer.Name, customer.MobileNo);
            }
            Console.ReadKey();

        }
    }
}
