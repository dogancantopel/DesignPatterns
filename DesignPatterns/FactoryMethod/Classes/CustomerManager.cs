﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class CustomerManager
    {
        private ILoggerFactory _loggerFactory;
     
        public CustomerManager(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }
        public void Save()
        {
            Console.WriteLine("Saved");
            ILogger logger = _loggerFactory.CreateLogger();
            logger.Log();
        }
    }
}
