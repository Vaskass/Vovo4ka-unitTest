using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vovo4ka;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1() //проверка на 1 раз
        {
            int variant = 1;
            string expected = "—текло не разбилось";

            Vova vova = new Vova();
            vova.Nomer = variant;

            string actual = vova.who();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test2()//проверка на 2 раз
        {
            int variant = 2;
            string expected = "Ќовое стекло вставл€л папа ¬овочки";

            Vova vova = new Vova();
            vova.Nomer = variant;

            string actual = vova.who();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test3()//проверка на 3 раз
        {
            int variant = 3;
            string expected = "—текло не разбилось";

            Vova vova = new Vova();
            vova.Nomer = variant;

            string actual = vova.who();

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Test4()//проверка на 4 раз
        {
            int variant = 4;
            string expected = "ћилиционеры вставл€ли новое стекло";

            Vova vova = new Vova();
            vova.Nomer = variant;

            string actual = vova.who();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test5()//проверка на 5 раз
        {
            int variant = 5;
            string expected = "Ќовое стекло вставл€л папа ¬овочки";

            Vova vova = new Vova();
            vova.Nomer = variant;

            string actual = vova.who();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test6()//проверка на 6 раз
        {
            int variant = 6;
            string expected = "ћилиционеры вставл€ли новое стекло";

            Vova vova = new Vova();
            vova.Nomer = variant;

            string actual = vova.who();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test7()//проверка на 7 раз
        {
            int variant = 7;
            string expected = "ћилиционеры вставл€ли новое стекло";

            Vova vova = new Vova();
            vova.Nomer = variant;

            string actual = vova.who();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test8()//проверка на несуществующий раз
        {
            int variant = 8;
            string expected = "“акого раза не было (пока что)";

            Vova vova = new Vova();
            vova.Nomer = variant;

            string actual = vova.who();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMinus8()//проверка на несуществующий отрицательный раз
        {
            int variant = -8;
            string expected = "“акого раза не было (пока что)";

            Vova vova = new Vova();
            vova.Nomer = variant;

            string actual = vova.who();

            Assert.AreEqual(expected, actual);
        }
    }
}
