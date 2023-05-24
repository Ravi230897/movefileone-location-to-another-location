using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.IO;

namespace movefile
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFileName = @"D:\Move1\Test.txt.txt";
            string destFileName = @"D:\Move2\Test.txt.txt";
            File.Move(sourceFileName, destFileName);
        }
    }
}
