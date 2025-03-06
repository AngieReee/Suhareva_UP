using ClassLibrary;
using NUnit.Framework;
using System.Diagnostics;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Проверка метода для расчёта кол-ва продукции на использование несуществующего типа продукции
        /// </summary>
        [TestMethod]
        public void NonExistentProductType()
        {
            int count = 15;
            float width = 20;
            float length = 45;
            int product_type = 4;
            int material_type = 1;
            int except = -1;
            Calc calc = new Calc();
            int actual = calc.GetQuantityForProduct(count, width, length, product_type, material_type);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(except, actual);
        }


        /// <summary>
        /// Проверка метода для расчёта кол-ва продукции на использование несуществующего типа материалов
        /// </summary>
        [TestMethod]
        public void NonExistentMaterialType()
        {
            int count = 15;
            float width = 20;
            float length = 45;
            int product_type = 3;
            int material_type = 6;
            int except = -1;
            Calc calc = new Calc();
            int actual = calc.GetQuantityForProduct(count, width, length, product_type, material_type);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(except, actual);
        }


        /// <summary>
        /// Проверка метода для расчёта кол-ва продукции на правильность вычислений
        /// </summary>
        [TestMethod]
        public void CalculationsAreEqual()
        {
            int count = 15;
            float width = 20;
            float length = 45;
            int product_type = 3;
            int material_type = 1;
            int except = 238991;
            Calc calc = new Calc();
            int actual = calc.GetQuantityForProduct(count, width, length, product_type, material_type);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(except, actual);
        }

        /// <summary>
        /// Проверка метода для расчёта кол-ва продукции на возврат не нулевого значения
        /// </summary>
        [TestMethod]
        public void CalculationsIsNotNull()
        {
            int count = Convert.ToInt32(null);
            float width = 20;
            float length = 45;
            int product_type = 3;
            int material_type = 1;
            int except = 238991;
            Calc calc = new Calc();
            int actual = calc.GetQuantityForProduct(count, width, length, product_type, material_type);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(actual);
        }


        /// <summary>
        /// Проверка метода для расчёта кол-ва продукции на возврат целочисленного значения
        /// </summary>
        [TestMethod]
        public void CalculationsIsInt()
        {
            int count = 15;
            float width = 20;
            float length = 45;
            int product_type = 3;
            int material_type = 1;
            int except;
            Calc calc = new Calc();
            int actual = calc.GetQuantityForProduct(count, width, length, product_type, material_type);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsInstanceOfType(actual, typeof(int));
        }

        /// <summary>
        /// Проверка метода для расчёта кол-ва продукции на возврат не вещественного значения
        /// </summary>
        [TestMethod]
        public void CalculationsIsNotDouble()
        {
            int count = 15;
            float width = 20;
            float length = 45;
            int product_type = 3;
            int material_type = 1;
            int except;
            Calc calc = new Calc();
            int actual = calc.GetQuantityForProduct(count, width, length, product_type, material_type);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotInstanceOfType(actual, typeof(double));
        }

        /// <summary>
        /// Проверка метода для расчёта кол-ва продукции на возврат не булевого значения
        /// </summary>
        [TestMethod]
        public void CalculationsIsNotBool()
        {
            int count = 15;
            float width = 20;
            float length = 45;
            int product_type = 3;
            int material_type = 1;
            int except;
            Calc calc = new Calc();
            int actual = calc.GetQuantityForProduct(count, width, length, product_type, material_type);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotInstanceOfType(actual, typeof(bool));
        }


        /// <summary>
        /// Проверка метода для расчёта кол-ва продукции на возврат значения, соответсвующего критериям (не 0 и больше 0)
        /// </summary>
        [TestMethod]
        public void CalculationsIsTrue()
        {
            int count = 15;
            float width = 20;
            float length = 45;
            int product_type = 3;
            int material_type = 1;
            bool except = false;
            Calc calc = new Calc();
            int actual = calc.GetQuantityForProduct(count, width, length, product_type, material_type);
            if (actual != 0 && actual > 0)
            {
                except = true;
            }
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(except);
        }


        /// <summary>
        /// Проверка метода для расчёта кол-ва продукции на возврат значения, входящего в заданные границы
        /// </summary>
        [TestMethod]
        public void CalculationsInRange()
        {
            int count = 15;
            float width = 20;
            float length = 45;
            int product_type = 3;
            int material_type = 1;
            int low = 238990;
            int high = 238993;
            Calc calc = new Calc();
            int actual = calc.GetQuantityForProduct(count, width, length, product_type, material_type);
            NUnit.Framework.Assert.That(actual, Is.InRange(low, high));
        }


        /// <summary>
        /// Проверка метода для расчёта кол-ва продукции на возврат значения, не входящего в заданные границы
        /// </summary>
        [TestMethod]
        public void CalculationsNotInRange()
        {
            int count = 15;
            float width = 20;
            float length = 45;
            int product_type = 3;
            int material_type = 1;
            int low = 114145;
            int high = 114146;
            Calc calc = new Calc();
            int actual = calc.GetQuantityForProduct(count, width, length, product_type, material_type);
            NUnit.Framework.Assert.That(actual, Is.Not.InRange(low, high));
        }

        /// <summary>
        /// Проверка метода для расчёта кол-ва продукции на возврат исключения, вызванного шириной, равной 0
        /// </summary>
        [TestMethod]
        public void CalculationsWidthExeption()
        {
            int count = 15;
            float width = 0;
            float length = 45;
            int product_type = 3;
            int material_type = 1;
            Calc calc = new Calc();
            NUnit.Framework.Assert.Throws<ArgumentOutOfRangeException>(() => calc.GetQuantityForProduct(count, width, length, product_type, material_type));

        }

        /// <summary>
        /// Проверка метода для расчёта кол-ва продукции на возврат исключения, вызванного длиной, равной 0
        /// </summary>
        [TestMethod]
        public void CalculationsLengthExeption()
        {
            int count = 15;
            float width = 20;
            float length = 0;
            int product_type = 3;
            int material_type = 1;
            Calc calc = new Calc();
            NUnit.Framework.Assert.Throws<ArgumentOutOfRangeException>(() => calc.GetQuantityForProduct(count, width, length, product_type, material_type));
        }

        /// <summary>
        /// Проверка метода для расчёта кол-ва продукции на рассчёт с первым типом материала 
        /// </summary>
        [TestMethod]
        public void CalculationsCheckMaterialType1()
        {
            int count = 10;
            float width = 1;
            float length = 1;
            int product_type = 1;
            int material_type = 1;
            Calc calc = new Calc();
            int actual = calc.GetQuantityForProduct(count, width, length, product_type, material_type);
            int except = 12;
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(except, actual);
        }


        /// <summary>
        /// Проверка метода для расчёта кол-ва продукции на возврат исключения, вызванного отрицательной длиной
        /// </summary>
        [TestMethod]
        public void CalculationsNegativeLengthExeption()
        {
            int count = 15;
            float width = 20;
            float length = -45;
            int product_type = 3;
            int material_type = 1;
            Calc calc = new Calc();
            NUnit.Framework.Assert.Throws<ArgumentOutOfRangeException>(() => calc.GetQuantityForProduct(count, width, length, product_type, material_type));
        }

        /// <summary>
        /// Проверка метода для расчёта кол-ва продукции на возврат исключения, вызванного отрицательной шириной
        /// </summary>
        [TestMethod]
        public void CalculationsNegativeWidthExeption()
        {
            int count = 15;
            float width = -20;
            float length = 45;
            int product_type = 3;
            int material_type = 1;
            Calc calc = new Calc();
            NUnit.Framework.Assert.Throws<ArgumentOutOfRangeException>(() => calc.GetQuantityForProduct(count, width, length, product_type, material_type));
        }
    }
}