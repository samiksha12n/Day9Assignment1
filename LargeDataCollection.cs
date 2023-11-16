using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;

namespace Day9Assignment1
{
    public class LargeDataCollection
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public string Type { get; set; }
        public double MFee { get; set; }

    }
    public class LargeData : IDisposable
    {
        List<LargeData> list = null;
        static int totalFiles = 0;
        bool disposedvalue;
        public LargeData(string fileName)
        {
            if (list == null)
            {
                totalFiles++;
                List<LargeData> list = new List<LargeData>();
            }
            Console.WriteLine("File Created");
            Console.WriteLine("Number of files are: " + totalFiles);

        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedvalue)
            {
                if (disposing)
                {
                    totalFiles = 0;
                }
                Console.WriteLine("List {0} has been disposed", list);
                list = null;
                disposedvalue = true;

            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

        }
        public void GetListDetails()
        {
            Console.WriteLine(list + "list has been created Successfully");
        }
        ~LargeData()
        {
            Dispose(false);
        }
    }
}
