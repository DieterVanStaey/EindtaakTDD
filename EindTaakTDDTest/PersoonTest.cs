using System;
using System.Collections.Generic;
using EindtaakTDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace EindTaakTDDTest
{
    [TestClass]
    public class PersoonTest
    {
        //[TestMethod]
        //public void TestMethod1()
        //{

        //}
        // list zonder namen is NOK
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void LijstZonderNamen_IsVerkeerd()
        {
            // arrange
            // act
            // assert
            new Persoon(new List<string>{ });
        }
        // lijst die 1 naam meermaals heeft is NOK
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void LijstMetDubbeleNamen_IsVerkeerd()
        {
            // arrange
            // act
            // assert
            new Persoon(new List<string> {"Aaa", "Aaa"});
        }
        // lijst die null is is NOK
        [TestMethod, ExpectedException((typeof(ArgumentNullException)))]
        public void LijstIsNull_IsVerkeerd()
        {
            // arrange
            // act
            // assert
            new Persoon(null);
        }
        // als naam leeg is is NOK
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NaamIsLeeg_IsVerkeerd()
        {
            // arrange
            // act
            // assert
            new Persoon(new List<string>{"Naam", String.Empty, "Naampje"});
        }
        // Method Tostring() moet alle namen weergeven met spaties tussen 
        [TestMethod]
        public void String_NamenMetSpaties_ToString()
        {
            // arrange
            var persoon = new Persoon(new List<string> {"Dieter", "Ingrid", "Samuel"});
            // act
            // assert
            Assert.AreEqual(persoon.ToString(), "Dieter Ingrid Samuel ");
        }

    }
}
