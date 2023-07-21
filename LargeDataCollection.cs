using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposableAssignment
{
    public class LargeDataCollection : IDisposable
    {
        private List<string> Arraylist = new List<string>();
        int ArrayCount;
        bool disposedValue = false;
        public LargeDataCollection()
        {
            Console.WriteLine("Enter the Name:");
            ArrayCount = int.Parse(Console.ReadLine());
            for(int i = 0; i < ArrayCount; i++)
            {
                Arraylist.Add(Console.ReadLine());
            }
        }
        public void Add(String Name)
        {
            Arraylist.Add(Name);
            ArrayCount++;
        }
        public void Remove(String Name)
        {
            int index = Arraylist.IndexOf(Name);
            if (index != -1) { Arraylist.Remove(Name); }
            else { Console.WriteLine("number is not in list"); }
        }
        public void Display()
        {
            Console.WriteLine("elements in array as follow:");
            foreach(var item in Arraylist)
            {
                Console.WriteLine(item);
            }
        }
        public virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    ArrayCount = 0;
                }
                Arraylist = null;
                disposedValue = true;
                Console.WriteLine($"the Array list has been Disposed");
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
