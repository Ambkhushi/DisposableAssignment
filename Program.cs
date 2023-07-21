using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposableAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            string choice;
            LargeDataCollection largeDataCollection = new LargeDataCollection();

            do
            {
                Console.WriteLine("Enter the operations:");
                Console.WriteLine("1.Add\n2. Remove\n 3. show");
                int opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        {
                            Console.WriteLine("enter the number you want to add:");
                            string Name = Console.ReadLine();
                            largeDataCollection.Add(Name);
                            break;
                        }
                    case 2:
                        {

                            Console.WriteLine("enter the number you want to remove:");
                            string Name = Console.ReadLine();
                            largeDataCollection.Remove(Name);
                            break;
                        }
                    case 4:
                        {
                            largeDataCollection.Display();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Input");
                            break;
                        }
                }
                Console.WriteLine("choose y if u want to continue");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
            Console.WriteLine("All Data has been Disposed");
            largeDataCollection.Dispose();
            Console.ReadKey();
           
        }
    }
}
