using System;
using Finan.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tdd.Domain
{
    [TestClass]
    public class LocalTest
    {
        private Local _local;

        public LocalTest()
        {
            _local = new Local("Market", 1);
        }


    }
}
