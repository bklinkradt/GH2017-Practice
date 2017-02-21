using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoogleHash2017.Simulator.Inputs;

namespace GoogleHash2017.Tests.Input
{
    [TestClass]
    public class InputReaderTests
    {
        #region Instance Methods

        [TestMethod]
        public void InputReader_ValidContent_ReturnCorrectResult()
        {
            // Arrange
            InputReader inputReader = new InputReader();

            // Act
            var result = inputReader.Parse(InputReaderTestCases.ValidInput);

            // Assert
            Assert.IsNotNull(result);
            // Guidance: Test your inputs...
        }

        // Guidance - Replicate a reasonable file.
        [TestMethod]
        public void InputReader_ValidInputFile_ReturnCorrectResult()
        {
            // Arrange
            InputReader inputReader = new InputReader();

            // Act
            var result = inputReader.ParseFromFile("../../../Data/02 - Replicated Test File.in");

            // Assert
            Assert.IsNotNull(result);
        }

        #endregion
    }
}

