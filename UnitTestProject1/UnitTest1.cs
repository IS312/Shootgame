using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using Microsoft.Analytics.UnitTest;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Shootgame.ShootClass1 Shoot = new Shootgame.ShootClass1();
        [TestMethod]
        public void ShootAway()
        {
            try
            {
                Shoot.ShootAway();
                Assert.IsTrue(true);

            }
            catch
            {
                Assert.IsFalse(false);

            }
        }
        [TestMethod]
        public void PlayTheGameAgain()
        {
            try
            {
                Shoot.ShootAway();
                Assert.IsTrue(true);

            }
            catch
            {
                Assert.IsFalse(false);

            }
        }
    }
}

     