using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<LargeDataCollection> list = new List<LargeDataCollection>()
            {
                new LargeDataCollection{ID=1, Name="MSD",Team="CSK",MFee=4000000, Type="WicketKeeper/Batsman"},
                new LargeDataCollection{ID=2, Name="Shami",Team="CSK",MFee=35000000, Type="WicketKeeper/Batsman"},
                new LargeDataCollection{ID=3, Name="Dawid Warner",Team="Punjab",MFee=2500000, Type="Batsman"},
                new LargeDataCollection{ID=4, Name="Rohit Sharma",Team="MI",MFee=5000000, Type="Batsman"},
                new LargeDataCollection{ID=5, Name="Shubham Gill",Team="MI",MFee=3500000, Type="Batsman"},
                new LargeDataCollection{ID=7, Name="V.Kohli",Team="RCB",MFee=5000000, Type="Batsman"},
                new LargeDataCollection{ID=8, Name="MSD",Team="CSK",MFee=4000000, Type="WicketKeeper/Batsman"},
                new LargeDataCollection{ID=9, Name="MSD",Team="CSK",MFee=4000000, Type="WicketKeeper/Batsman"},
                new LargeDataCollection{ID=10, Name="MSD",Team="CSK",MFee=4000000, Type="WicketKeeper/Batsman"},
            };
            Console.WriteLine("Number of Collections: " + list.Count);
            Console.WriteLine("ID \t Name \t\t Team \t fee \t Collection Type");
            foreach (LargeDataCollection p in list)
            {
                Console.WriteLine(p.ID + "\t" + p.Name + "\t\t" + p.Team + "\t" + p.MFee + "\t" + p.Type);
            }
            Console.WriteLine("Enter Id to find out details of a Collection");
            int id = int.Parse(Console.ReadLine());
            LargeDataCollection LargeDataCollection = list.Find(p => p.ID == id);
            if (LargeDataCollection != null)
            {
                Console.WriteLine("LargeDataCollection Details as follows!!!");
                Console.WriteLine("ID \t Name \t\t Team \t fee \t LargeDataCollection Type");
                Console.WriteLine(LargeDataCollection.ID + "\t" + LargeDataCollection.Name + "\t\t" + LargeDataCollection.Team + "\t" + LargeDataCollection.MFee + "\t" + LargeDataCollection.Type);
                
            }
            else
            {
                Console.WriteLine($"No Such ID {id} exists");
            }
            
            Console.ReadKey();

        }
    }
}
