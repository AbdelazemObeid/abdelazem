using System.Runtime.InteropServices;
using assinment_2;

internal class Program
{
    static void Main(string[] args)
    {
        Order o1 = new Order(12 , "Ahmed" ,1200,new DateTime(2001,10,10),true);
        Order o2 = new Order(21 , "Ali" ,250, new DateTime(2004, 1, 1),false);
        Order o3 = new Order(32 , "Omar" ,470, new DateTime(2013, 5, 5),true);
        Order o4 = new Order(43 , "Youssef",90, new DateTime(2005, 3, 3),false);
        Order o5 = new Order(54 , "Hassan",70, new DateTime(2017, 1, 1),false);
        Order o6 = new Order(65 , "Mohamed",40, new DateTime(1993, 1, 1),true);
        Order o7 = new Order(76 , "Mostafa",3000, new DateTime(2010, 1, 1),false);
        Order o8 = new Order(87 , "Adham",150, new DateTime(2012, 9, 9),true);
        Order o9 = new Order(98 , "Yasser",200, new DateTime(2015, 1, 1),false);
        Order o10 = new Order(109, "Khaled", 5000, new DateTime(2018, 1, 1), true);
        List<Order> orders = new List<Order> { o1, o2, o3, o4, o5, o6, o7, o8, o9, o10 };
        while (true)
        {
            Console.WriteLine("1- filter by name : ");
            Console.WriteLine("2- filter by is delivered : ");
            Console.WriteLine("3- filter by total price < maxprice : ");
            Console.WriteLine("4- filter by total price > minprice : ");
            Console.WriteLine("5- filter by date < (yyyy,MM,dd) : ");
            Console.WriteLine("6- filter by date > (yyyy,MM,dd) : ");
            Console.WriteLine("7- exit : ");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 7) break;
            switch (choice)
            {
                case 1:
                    {
                        Console.Write("Enter the name to filter by: ");
                        string name = Console.ReadLine();
                        filter(orders, order => order.Name == name);
                        break;
                    }
                case 2:
                    filter(orders, order => order.IsDelivered);
                    break;
                case 3:
                    {
                        Console.Write("Enter the maximum total price: ");
                        int maxPrice = int.Parse(Console.ReadLine());
                        filter(orders, order => order.Totalprice < maxPrice);
                        break;
                    }
                case 4:
                    {
                        Console.Write("Enter the minimum total price: ");
                        int minPrice = int.Parse(Console.ReadLine());
                        filter(orders, order => order.Totalprice > minPrice);
                        break;
                    }               
                case 5:
                    {
                        Console.Write("Enter the date to filter by (yyyy,MM,dd): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        filter(orders, order => order.date < new DateTime(2010, 1, 1));
                        break;
                    }
                case 6:
                    {
                        Console.Write("Enter the date to filter by (yyyy,MM,dd): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        filter(orders, order => order.date > new DateTime(2010, 1, 1));
                        break;
                    }
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
    static void filter<T>(IEnumerable<T> items , Func<T, bool> P)
    {
        foreach (var item in items)
        {
            if (P(item))
            {
                Console.WriteLine(item);
            }
        }
    }
}