using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputeHighestGrade()
        {
            GradeBook grades = new GradeBook();
            grades.Add(10);
            grades.Add(90);
            GradeStatistics result = grades.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade);
        }

        [TestMethod]
        public void ComputeAverageGrade()
        {
            GradeBook grades = new GradeBook();
            grades.Add(10);
            grades.Add(90);
            GradeStatistics result = grades.ComputeStatistics();
            Assert.AreEqual(50, result.AverageGrade);
        }

        [TestMethod]
        public void ComputeLowestGrade()
        {
            GradeBook grades = new GradeBook();
            grades.Add(10.5f);
            grades.Add(90.5f);
            GradeStatistics result = grades.ComputeStatistics();
            Assert.AreEqual(50.5, result.AverageGrade);
        }

        [TestMethod]
        public void ComputeWhenZeroGrade()
        {
            GradeBook grades = new GradeBook();
            grades.Add(0);
            grades.Add(0);
            GradeStatistics result = grades.ComputeStatistics();
            Assert.AreEqual(0, result.HighestGrade);
            Assert.AreEqual(0, result.AverageGrade);
            Assert.AreEqual(0, result.LowestGrade);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void ComputeWhenNoGrades()
        {
            GradeBook grades = new GradeBook();
            GradeStatistics result = grades.ComputeStatistics();
        }

        [TestMethod]
        public void EmptyNameTest()
        {
            var grades = new GradeBook();
            Assert.IsTrue(grades.Name == "");
        }

        [TestMethod]
        public void ValidNameTest()
        {
            var grades = new GradeBook();
            grades.Name = "My GradeBook";
            Assert.IsNotNull(grades.Name);
            Assert.AreEqual("My GradeBook", grades.Name);
        }

        [TestMethod]
        public void NameWithSpaceTest()
        {
            var grades = new GradeBook();
            grades.Name = "  ";
            Assert.IsNotNull(grades.Name);
            Assert.AreEqual("  ", grades.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NullNameThrowsArgumentExceptionTest()
        {
            var grades = new GradeBook();
            grades.Name = null;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyNameThrowsArgumentExceptionTest()
        {
            var grades = new GradeBook();
            grades.Name = "";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StringEmptyNameThrowsArgumentExceptionTest()
        {
            var grades = new GradeBook();
            grades.Name = string.Empty;
        }

        [TestMethod]
        public void LetterGradeATest()
        {
            var grades = new GradeBook();
            grades.Add(99);
            grades.Add(99);
            grades.Add(99);
            var stats = grades.ComputeStatistics();
            Assert.AreEqual("A", stats.LetterGrade);
        }

        [TestMethod]
        public void LetterGradeBTest()
        {
            var grades = new GradeBook();
            grades.Add(80);
            grades.Add(80);
            grades.Add(80);
            var stats = grades.ComputeStatistics();
            Assert.AreEqual("B", stats.LetterGrade);
        }

        [TestMethod]
        public void LetterGradeCTest()
        {
            var grades = new GradeBook();
            grades.Add(70);
            grades.Add(70);
            grades.Add(75);
            var stats = grades.ComputeStatistics();
            Assert.AreEqual("C", stats.LetterGrade);
        }

        [TestMethod]
        public void LetterGradeDTest()
        {
            var grades = new GradeBook();
            grades.Add(60);
            grades.Add(60);
            grades.Add(65);
            var stats = grades.ComputeStatistics();
            Assert.AreEqual("D", stats.LetterGrade);
        }

        [TestMethod]
        public void LetterGradeFTest()
        {
            var grades = new GradeBook();
            grades.Add(40);
            grades.Add(50);
            grades.Add(44);
            var stats = grades.ComputeStatistics();
            Assert.AreEqual("F", stats.LetterGrade);
        }

        [TestMethod]
        public void LetterGradeADescriptionTest()
        {
            var grades = new GradeBook();
            grades.Add(99);
            grades.Add(99);
            grades.Add(99);
            var stats = grades.ComputeStatistics();
            Assert.AreEqual("Excellent", stats.Description);
        }

        [TestMethod]
        public void LetterGradeBDescriptionTest()
        {
            var grades = new GradeBook();
            grades.Add(80);
            grades.Add(80);
            grades.Add(80);
            var stats = grades.ComputeStatistics();
            Assert.AreEqual("Very Good", stats.Description);
        }

        [TestMethod]
        public void LetterGradeCDescriptionTest()
        {
            var grades = new GradeBook();
            grades.Add(70);
            grades.Add(70);
            grades.Add(75);
            var stats = grades.ComputeStatistics();
            Assert.AreEqual("Good", stats.Description);
        }

        [TestMethod]
        public void LetterGradeDDescriptionTest()
        {
            var grades = new GradeBook();
            grades.Add(60);
            grades.Add(60);
            grades.Add(65);
            var stats = grades.ComputeStatistics();
            Assert.AreEqual("Average", stats.Description);
        }

        [TestMethod]
        public void LetterGradeFDescriptionTest()
        {
            var grades = new GradeBook();
            grades.Add(40);
            grades.Add(50);
            grades.Add(44);
            var stats = grades.ComputeStatistics();
            Assert.AreEqual("Fail", stats.Description);
        }

    }
}
