using Microsoft.VisualStudio.TestTools.UnitTesting;
using kalkulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void EvaluateExpression_Addition()
        {
            // Pengaturan kondisi awal (Arrange)
            string expression = "5 + 3";

            // Melakukan tindakan (Act)
            double result = Program.EvaluateExpression(expression);

            // Memastikan hasil sesuai dengan yang diharapkan (Assert)
            Assert.AreEqual(8, result);
        }

        [TestMethod()]
        public void EvaluateExpression_Subtraction()
        {
            // Pengaturan kondisi awal (Arrange)
            string expression = "10 - 2";

            // Melakukan tindakan (Act)
            double result = Program.EvaluateExpression(expression);

            // Memastikan hasil sesuai dengan yang diharapkan (Assert)
            Assert.AreEqual(8, result);
        }

        [TestMethod()]
        public void EvaluateExpression_Multiplication()
        {
            // Pengaturan kondisi awal (Arrange)
            string expression = "4 * 3";

            // Melakukan tindakan (Act)
            double result = Program.EvaluateExpression(expression);

            // Memastikan hasil sesuai dengan yang diharapkan (Assert)
            Assert.AreEqual(12, result);
        }

        [TestMethod()]
        public void EvaluateExpression_Division()
        {
            // Pengaturan kondisi awal (Arrange)
            string expression = "16 / 4";

            // Melakukan tindakan (Act)
            double result = Program.EvaluateExpression(expression);

            // Memastikan hasil sesuai dengan yang diharapkan (Assert)
            Assert.AreEqual(4, result);
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void EvaluateExpression_DivisionByZero()
        {
            // Pengaturan kondisi awal (Arrange)
            string expression = "10 / 0";

            // Melakukan tindakan (Act)
            double result = Program.EvaluateExpression(expression);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void EvaluateExpression_InvalidExpression()
        {
            // Pengaturan kondisi awal (Arrange)
            string expression = "invalid expression";

            // Melakukan tindakan (Act)
            double result = Program.EvaluateExpression(expression);
        }
    }
}
