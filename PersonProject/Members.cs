using Apttus.Assignment.DataAccessLayerr;
using Apttus.Assignment.PersonLibrary;
using System;
using System.Collections.Generic;

using static Apttus.Assignment.PersonLibrary.GenderEnum;

namespace Apttus.Assignment.PersonProject
{
    public class Members : Ticket
    {
        private static void Main(string[] args)
        {
            PersonData data = new PersonData();
			Dictionary<string, IPerson> persons = new Dictionary<string, IPerson>();
			Console.WriteLine("Members in the family..!");

			PersonData call = new PersonData();
			persons = call.GetDetails();


            foreach (KeyValuePair<string, IPerson> member in persons)
            {
                Console.WriteLine(string.Format("Name:{0}, Age:{1}", member.Value.Name, member.Value.Age));
            }

            Console.WriteLine("Book tickets");
            Console.WriteLine("Enter name of the members to book ticket");

            List<String> list1 = new List<String>();
            String ans = "y";
            while (ans == "y")
            {
                String name = Console.ReadLine();
                list1.Add(name);
                Console.WriteLine("Do you want to book more? y/n ");
                ans = Console.ReadLine();

                for (int i = 0; i < list1.Count; i++)
                {
                    Console.WriteLine("Members going to movie: " + list1[i]);
                }
                Console.WriteLine("Enter name: ");
            }

            Console.ReadKey();
            TotalCost(list1, persons);
            Console.ReadLine();
        }

        public static int TotalCost(List<String> list2, Dictionary<string, IPerson> dictionary)
        {
            Ticket book = new Ticket();
            int cost = book.GetCost();
            int TotalCost = book.totalCost();

            foreach (string temp in list2)
            {
                if (dictionary.ContainsKey(temp))
                {
                    IPerson CA = dictionary[temp];
                    if (CA.Age >= 60)
                    {
                        cost = cost - (cost * (30) / 100);
                    }
                    else
                    {
                        cost = cost;
                    }
                    TotalCost += cost;
                }
            }
            Console.WriteLine("Total Cost of Ticket = " + TotalCost);

            return TotalCost;
        }
    }
}