using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkSynopsis.PersonClasses.FemaleClasses;
using EntityFrameworkSynopsis.PersonClasses.MaleClasses;

namespace EntityFrameworkSynopsis
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EFSContext ctx = new EFSContext())
            {
                ctx.Database.CreateIfNotExists();

                

                ctx.SaveChanges();
            }

            Console.ReadKey();
        }
    }
}
