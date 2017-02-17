using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace jsonObj
{
    class Program
    {
        static void Main(string[] args)
        {
			/* comments entered using dev_20170216 branch */
            var content = readFile();
            var jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(content);
            Console.ReadLine();
        }

        static string readFile()
        {
            var file = File.OpenText(@"C:\Projects\_DotNet\jsonObj\jsonObj\json.txt");
            var content = file.ReadToEnd();
            file.Close();
            return content;
        }
    }
}
