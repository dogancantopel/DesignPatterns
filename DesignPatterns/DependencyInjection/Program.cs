using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IProductDal>().To<EFProductDal>().InSingletonScope() ;
            var productManager = new ProductManager(kernel.Get<IProductDal>());
            productManager.Save();

            //Null object deseni eğer bir işlem yapılmadan sadece product manageri çağırmak istiyorsak boş class oluşturulur singleton kullanılarak.
            var productManager1 = new ProductManager(StubDal.GetStubDal());
            productManager1.Save();

            Console.ReadLine();
        }
    }
}
