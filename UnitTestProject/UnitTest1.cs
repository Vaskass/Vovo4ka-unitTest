using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vovo4ka;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1() //�������� �� 1 ���
        {
            int variant = 1;
            string expected = "������ �� ���������";

            Vova vova = new Vova();
            vova.Nomer = variant;

            string actual = vova.who();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test2()//�������� �� 2 ���
        {
            int variant = 2;
            string expected = "����� ������ �������� ���� �������";

            Vova vova = new Vova();
            vova.Nomer = variant;

            string actual = vova.who();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test3()//�������� �� 3 ���
        {
            int variant = 3;
            string expected = "������ �� ���������";

            Vova vova = new Vova();
            vova.Nomer = variant;

            string actual = vova.who();

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Test4()//�������� �� 4 ���
        {
            int variant = 4;
            string expected = "����������� ��������� ����� ������";

            Vova vova = new Vova();
            vova.Nomer = variant;

            string actual = vova.who();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test5()//�������� �� 5 ���
        {
            int variant = 5;
            string expected = "����� ������ �������� ���� �������";

            Vova vova = new Vova();
            vova.Nomer = variant;

            string actual = vova.who();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test6()//�������� �� 6 ���
        {
            int variant = 6;
            string expected = "����������� ��������� ����� ������";

            Vova vova = new Vova();
            vova.Nomer = variant;

            string actual = vova.who();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test7()//�������� �� 7 ���
        {
            int variant = 7;
            string expected = "����������� ��������� ����� ������";

            Vova vova = new Vova();
            vova.Nomer = variant;

            string actual = vova.who();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test8()//�������� �� �������������� ���
        {
            int variant = 8;
            string expected = "������ ���� �� ���� (���� ���)";

            Vova vova = new Vova();
            vova.Nomer = variant;

            string actual = vova.who();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMinus8()//�������� �� �������������� ������������� ���
        {
            int variant = -8;
            string expected = "������ ���� �� ���� (���� ���)";

            Vova vova = new Vova();
            vova.Nomer = variant;

            string actual = vova.who();

            Assert.AreEqual(expected, actual);
        }
    }
}
