using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatematikaKalkulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematikaKalkulator.Tests
{
    [TestClass()]
    public class MatematikaTests
    {
        [TestMethod()]
        public void UserTest()
        {
            Calculator mtk = new Calculator();
            Assert.AreEqual("Naufal Gita M", mtk.User("Naufal Gita M"));
        }

        [TestMethod()]
        public void TambahTest()
        {
            Calculator mtk = new Calculator();
            Assert.AreEqual(20, mtk.Tambah(10,10));
        }

        [TestMethod()]
        public void KurangTest()
        {
            Calculator mtk = new Calculator();
            Assert.AreEqual(20, mtk.Kurang(30, 10));
        }
    }
}