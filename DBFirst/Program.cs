using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BestBioEntities2())
            {
                var query = context.Get_User_Data("mra@stofo.dk").FirstOrDefault();

                Console.WriteLine(query.Name + " " + query.Address + " " + query.PhoneNumber);
                Console.ReadKey();
            }
        }
    }
}
