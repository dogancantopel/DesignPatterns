using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class EFProductDal : IProductDal
    {
        public void Save()
        {
            Console.WriteLine("Save with ef");
        }
    }
}
