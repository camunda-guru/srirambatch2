using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    class MonthlySheet
    {
     
     public void Jan(Dictionary<DateTime, String> gh)
     {
         DateTime date;
         int flag = 0;
         string reason = null;
         string daystr = null;
        
         Console.WriteLine("\n");
         Console.WriteLine("January 2017");
         Console.WriteLine("\n");
         for (int i = 1; i <= 31; i++)
         {
             flag = 0;
             foreach (DateTime x in gh.Keys)
             {
                 date = new DateTime(2017, 1, i);
                 daystr = date.ToString();
                 if (date == x)
                 {
                     flag = 1;
                     reason = (string)gh[x];

                 }


             }
             if (i % 7 != 0)
             {
                 if (flag == 1)
                 {
                     
                     Console.Write(i);
                     Console.Write("[" + reason + "]");
                 }
                 else
                 {
                     Console.Write(i + "\t");
                    
                 }
             }
             else
             {
                 Console.Write(i);
                 if (flag == 1)
                     Console.Write("[" + reason + "]");
                 
                 Console.WriteLine("\n");
             }
         }
         
 

     }
     public void Feb(Dictionary<DateTime, String> gh)
     {

     }
     public void Mar(Dictionary<DateTime, String> gh)
     {

     }
    }
}
