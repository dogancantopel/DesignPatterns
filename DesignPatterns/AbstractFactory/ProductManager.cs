using AbstractFactory.Abstract;
using AbstractFactory.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ProductManager
    {
        CrossCuttingConcernsFactory _crossCuttingConcernsFactory;
        private Logging _logging;
        private Caching _caching;

        public ProductManager(CrossCuttingConcernsFactory crossCuttingConcernsFactory)
        {
            _crossCuttingConcernsFactory = crossCuttingConcernsFactory;
            _logging = _crossCuttingConcernsFactory.CreateLogger();
            _caching = _crossCuttingConcernsFactory.CreateCaching();
        }

        public void GetAll()
        {
            _logging.Log("Logged");
            _caching.Cache("cache");
            Console.WriteLine("Products Listed");
        }
    }
}
