using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SF2022UserLibrary;

namespace SF2022UserTests
{
    [TestClass]
    public class CalculationsTest
    {
        /// <summary>
        /// Проверка вводимых данных на пустую строку
        /// </summary>
        [TestMethod]
        public void CheckingTheTime_StringEmpty_ReturnedFalse()
        {
            //Arrange
            string textString = "";
            //Act
        bool actual= Calculations.CheckingTheTime(textString);
            //Assert
            Assert.IsFalse(actual);
            
        }
        /// <summary>
        /// Проверка вводимых данных на пробел
        /// </summary>
        [TestMethod]
        public void CheckingTheTime_StringSpace_ReturnedFalse()
        {
            //Arrange
            string textString = " ";
            //Act
            bool actual = Calculations.CheckingTheTime(textString);
            //Assert
            Assert.IsFalse(actual);

        }
        /// <summary>
        /// Проверка вводимых данных на буквы
        /// </summary>
        [TestMethod]
        public void CheckingTheTime_StringLetters_ReturnedFalse()
        {
            //Arrange
            string textString = "tatatrat";
            //Act
            bool actual = Calculations.CheckingTheTime(textString);
            //Assert
            Assert.IsFalse(actual);

        }
        /// <summary>
        /// Проверка вводимых данных на цифры без форматирования
        /// </summary>
        [TestMethod]
        public void CheckingTheTime_StringNumbersNotFormated_ReturnedFalse()
        {
            //Arrange
            string textString = "1212";
            //Act
            bool actual = Calculations.CheckingTheTime(textString);
            //Assert
            Assert.IsFalse(actual);

        }
        /// <summary>
        /// Проверка вводимых данных на цифры с форматированием
        /// </summary>
        [TestMethod]
        public void CheckingTheTime_StringNumbersFormated_ReturnedTrue()
        {
            //Arrange
            string textString = "12:12";
            //Act
            bool actual = Calculations.CheckingTheTime(textString);
            //Assert
            Assert.IsTrue(actual);

        }
        /// <summary>
        /// Проверка вводимых данных на отрицательные числа
        /// </summary>
        [TestMethod]
        public void CheckingTheTime_StringNumberNegative_ReturnedFalse()
        {
            //Arrange
            string textString = "-1212";
            //Act
            bool actual = Calculations.CheckingTheTime(textString);
            //Assert
            Assert.IsFalse(actual);

        }
        /// <summary>
        /// Проверка вводимых данных на отрицательные числа
        /// </summary>
        [TestMethod]
        public void CheckingTheTime_StringNumberFormatedNegative_ReturnedFalse()
        {
            //Arrange
            string textString = "-12:12";
            //Act
            bool actual = Calculations.CheckingTheTime(textString);
            //Assert
            Assert.IsFalse(actual);

        }
        /// <summary>
        /// Проверка вводимых данных на отрицательные числа
        /// </summary>
        [TestMethod]
        public void CheckingDuration_StringEmpty_ReturnedFalse()
        {
            //Arrange
            string textString = "";
            //Act
            bool actual = Calculations.CheckingDuration(textString);
            //Assert
            Assert.IsFalse(actual);

        }
        /// <summary>
        /// Проверка вводимых данных на отрицательные числа
        /// </summary>
        [TestMethod]
        public void CheckingDuration_NumbersLessThanZero_ReturnedFalse()
        {
            //Arrange
            string textString = "-11";
            //Act
            bool actual = Calculations.CheckingDuration(textString);
            //Assert
            Assert.IsFalse(actual);

        }
        /// <summary>
        /// Проверка вводимых данных на отрицательные числа(с форматированием).
        /// </summary>
        [TestMethod]
        public void CheckingDuration_NumbersMoreThanHour_ReturnedFalse()
        {
            //Arrange
            string textString = "61";
            //Act
            bool actual = Calculations.CheckingDuration(textString);
            //Assert
            Assert.IsFalse(actual);

        }
        /// <summary>
        /// Проверка вводимых данных на отрицательные числа(с форматированием).
        /// </summary>
        [TestMethod]
        public void CheckingDuration_NumberRight_ReturnedTrue()
        {
            //Arrange
            string textString = "40";
            //Act
            bool actual = Calculations.CheckingDuration(textString);
            //Assert
            Assert.IsTrue(actual);

        } /// <summary>
          /// Проверка на ввод цифр и букв.
          /// </summary>
        [TestMethod]
        public void CheckingDuration_LettersAndNumbers_ReturnedFalse()
        {
            //Arrange
            string textString = "40математика";
            //Act
            bool actual = Calculations.CheckingDuration(textString);
            //Assert
            Assert.IsFalse(actual);

        }/// <summary>
         /// Проверка на ввод только букв.
         /// </summary>
        [TestMethod]
        public void CheckingDuration_OnlyLetters_ReturnedFalse()
        {
            //Arrange
            string textString = "математика";
            //Act
            bool actual = Calculations.CheckingDuration(textString);
            //Assert
            Assert.IsFalse(actual);

        }
    }
}
