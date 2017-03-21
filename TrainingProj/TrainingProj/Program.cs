using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace TrainingProj
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadUrl("http://www.abv.bg", "C:\Users\Viktor\Desktop");

            string ReadUrl(string url, string path)
            {
                path = path.Replace(@"\", @"\\");
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                StreamReader sr = new StreamReader(resp.GetResponseStream());
                string tmp = sr.ReadToEnd();
                sr.Close();
                File.WriteAllText(path, tmp);
                return "File Updated";
            }
        }
    }
}
