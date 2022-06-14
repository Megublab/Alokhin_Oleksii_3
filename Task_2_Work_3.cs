using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAb
{
    public class Task_2_Work_3
    { 
        public void Start()
        {
            try
            {
                List<Toys> Lis = new List<Toys>();
                string[] Names = new string[4] { "ball", "doll", "cube", "car" };
                Console.WriteLine("Enter max toys amount (Rec 5-15): ");
                int amount = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter max coast for toys:");
                int money = int.Parse(Console.ReadLine());
                Random run = new Random();
                int count = 0;
                for (int i = 0; i < amount; i++)
                {
                    int price = run.Next(50, 700);
                    if (money - price > 0)
                    {
                        money = money - price;
                        Toys toy_1 = new Toys(run.Next(1, 5), price, run.Next(1, 4), Names[run.Next(0, 4)]);
                        Lis.Add(toy_1);
                        count += price;
                    }
                    else if (money - price <= 0)
                    {
                        Console.WriteLine("Not enought money");
                        break;
                    }
                }
                string s1 = " ";
                string s2 = " ";
                foreach (var item in Lis)
                {
                    if(item.Age == 1)
                    {
                        s1 = "0-3";
                    }
                    else if (item.Age == 2)
                    {
                        s1 = "4-7";
                    }
                    else if (item.Age == 3)
                    {
                        s1 = "8-12";
                    }
                    else if (item.Age == 4)
                    {
                        s1 = "13+";
                    }
                    if(item.Size == 1)
                    {
                        s2 = "Small";
                    }
                    else if (item.Size == 2)
                    {
                        s2 = "Medium";
                    }
                    else if (item.Size == 3)
                    {
                        s2 = "Big";
                    }
                    Console.WriteLine("Age: " + s1 + " Price: " + item.Coast + "$" + " Size: " + s2 + " Type: " + item.Type);
                }
                Console.WriteLine("Price: " + count + "$");
                Sort_Toys(Lis);
            }
            catch (SystemException)
            {
                Console.WriteLine("Something went wrong");
            }
        }
        public void Sort_Toys(List<Toys> Lis)
        {
            try
            {
                List<Toys> Sor_LIs = new List<Toys>();
                Console.WriteLine("____________________________________________________________");
                Console.WriteLine("|                                                          |");
                Console.WriteLine("|    Sort: 1 => Age | 2 => Price | 3 => Size | 4 => Type   |");
                Console.WriteLine("|__________________________________________________________|");
                Console.WriteLine();
                Console.WriteLine("Eneter Sort Type: ");
                int sorter = int.Parse(Console.ReadLine());
                switch (sorter)
                {
                    case 1:
                        /*
                        for (int i = 0; i < Lis.Count; i++)
                        {
                            if(Lis[i].Age == 1)
                            {
                                Sor_LIs.Add(Lis[i]);
                            }
                        }
                        for (int i = 0; i < Lis.Count; i++)
                        {
                            if (Lis[i].Age == 2)
                            {
                                Sor_LIs.Add(Lis[i]);
                            }
                        }
                        for (int i = 0; i < Lis.Count; i++)
                        {
                            if (Lis[i].Age == 3)
                            {
                                Sor_LIs.Add(Lis[i]);
                            }
                        }
                        for (int i = 0; i < Lis.Count; i++)
                        {
                            if (Lis[i].Age == 4)
                            {
                                Sor_LIs.Add(Lis[i]);
                            }
                        }
                        */
                        Sor_LIs.AddRange(Get_LIST_Age(Lis, 1));
                        Sor_LIs.AddRange(Get_LIST_Age(Lis, 2));
                        Sor_LIs.AddRange(Get_LIST_Age(Lis, 3));
                        Sor_LIs.AddRange(Get_LIST_Age(Lis, 4));
                        break;
                    case 2:
                        Sor_LIs.AddRange(Lis);
                        Sor_LIs.Sort();
                        break;
                    case 3:
                        for (int i = 0; i < Lis.Count; i++)
                        {
                            if (Lis[i].Size == 1)
                            {
                                Sor_LIs.Add(Lis[i]);
                            }
                        }
                        for (int i = 0; i < Lis.Count; i++)
                        {
                            if (Lis[i].Size == 2)
                            {
                                Sor_LIs.Add(Lis[i]);
                            }
                        }
                        for (int i = 0; i < Lis.Count; i++)
                            {
                            if (Lis[i].Size == 3)
                            {
                                Sor_LIs.Add(Lis[i]);
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("________________________________________");
                        Console.WriteLine("|                                      |");
                        Console.WriteLine("|    Types: doll | ball | cube | car   |");
                        Console.WriteLine("|______________________________________|");
                        string s = Console.ReadLine();
                        s = s.ToLower();
                        if (s == "doll" || s == "ball" || s == "car" || s == "cube")
                        {
                            for (int i = 0; i < Lis.Count; i++)
                            {
                                if (Lis[i].Type == s)
                                {
                                    Sor_LIs.Add(Lis[i]);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("No such Type");
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong number");
                        break;
                }
                string s1 = " ";
                string s2 = " ";
                foreach (var item in Sor_LIs)
                {
                    if (item.Age == 1)
                    {
                        s1 = "0-3";
                    }
                    else if (item.Age == 2)
                    {
                        s1 = "4-7";
                    }
                    else if (item.Age == 3)
                    {
                        s1 = "8-12";
                    }
                    else if (item.Age == 4)
                    {
                        s1 = "13+";
                    }
                    if (item.Size == 1)
                    {
                        s2 = "Small";
                    }
                    else if (item.Size == 2)
                    {
                        s2 = "Medium";
                    }
                    else if (item.Size == 3)
                    {
                        s2 = "Big";
                    }
                    Console.WriteLine("Age: " + s1 + " Price: " + item.Coast + "$" + " Size: " + s2 + " Type: " + item.Type);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong");
                Console.WriteLine(e.Message);
            }
        }
        private List<Toys> Get_LIST_Age (List<Toys> Lis , int Age)
        {
            var test = from i in Lis
                       where i.Age == Age
                       select i;
            return test.ToList<Toys>();
        }
    }
    public class Toys : IComparable
    {
        public int Age { get; set; }
        public int Coast { get; set; }
        public int Size { get; set; }
        public string Type { get; set; }
        public Toys(int Age , int Coast , int Size , string Type)
        {
            this.Age = Age;
            this.Coast = Coast;
            this.Size = Size;
            this.Type = Type;
        }
        public int CompareTo(object obj)
        {
            if (obj is Toys t)
            {
                 if (Coast < t.Coast)
                 {
                     return -1;
                 }
                 else if (Coast > t.Coast)
                 {
                     return 1;
                 }
                 else
                 {
                     return 0;
                 }
            }
            else
            {
                throw new ArgumentException("Wrong Type");
            }
        }
    }



}
