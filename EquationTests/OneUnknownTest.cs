using EquationSolver;

namespace EquationTests
{
    [TestClass]
    public class OneUnknownTest
    {
        [TestMethod]
        public void XPlusTwoEqualFour_ReturnsXEqualTwo()
        {
            decimal[] leftSide = { 1 ,+2 };
            decimal[] rightSide = { 4 };
            var equationSolver = new OneUnknown();

            var result = equationSolver.SolveEquation(leftSide, rightSide);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Minus2XEqualSix_ReturnsMinusThree()
        {
            decimal[] leftSide = { -2};
            decimal[] rightSide = { 6 };
            var equationSolver = new OneUnknown();

            var result = equationSolver.SolveEquation(leftSide, rightSide);

            Assert.AreEqual(-3, result);
        }

        [TestMethod]
        public void TwoThirdOfXEquals5_ReturnsSevenPointFive()
        {
            decimal[] leftSide = { 0.66M };
            decimal[] rightSide = { 5 };
            var equationSolver = new OneUnknown();

            var result = equationSolver.SolveEquation(leftSide, rightSide);

            Assert.AreEqual(7.6M, result);
        }

        [TestMethod]
        public void TwoXPlus2Equals7_ReturnsTwoPointFive()
        {
            decimal[] leftSide = { 2, +2};
            decimal[] rightSide = { 7 };
            var equationSolver = new OneUnknown();

            var result = equationSolver.SolveEquation(leftSide, rightSide);

            Assert.AreEqual(2.5M, result);
        }

        [TestMethod]
        public void XPlus58Equals128_ReturnsXEqual70()
        {
            decimal[] leftSide = { 1, 58 };
            decimal[] rightSide = { 128 };
            var equationSolver = new OneUnknown();

            var result = equationSolver.SolveEquation(leftSide, rightSide);

            Assert.AreEqual(70, result);
        }

        [TestMethod]
        public void XPlus60Equals6_ReturnsMinusFiftyFour()
        {
            decimal[] leftSide = { 1, 60 };
            decimal[] rightSide = { 6 };
            var equationSolver = new OneUnknown();

            var result = equationSolver.SolveEquation(leftSide, rightSide);

            Assert.AreEqual(-54, result);
        }

        [TestMethod]
        public void XMinusFourtyThreeEqualsMinus15_Returns()
        {
            decimal[] leftSide = { -1, +43 };
            decimal[] rightSide = { -15 };
            var equationSolver = new OneUnknown();

            var result = equationSolver.SolveEquation(leftSide, rightSide);

            Assert.AreEqual(58, result);
        }

        [TestMethod]
        public void XPlusMinusSeventyThreeEqualsMinusFiftyEight_ReturnsFifteen()
        {
            decimal[] leftSide = { 1, +-73 };
            decimal[] rightSide = { -58 };
            var equationSolver = new OneUnknown();

            var result = equationSolver.SolveEquation(leftSide, rightSide);

            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void XPlusMinusSeventyTwoEqualsMinusThirtyFour_ReturnsThirtyEight()
        {
            decimal[] leftSide = { 1, +-72 };
            decimal[] rightSide = { -34 };
            var equationSolver = new OneUnknown();

            var result = equationSolver.SolveEquation(leftSide, rightSide);

            Assert.AreEqual(38, result);
        }

        [TestMethod]
        public void TwoXPlus2Equals7_ReturnsTwoPointFiveTakeTwo()
        {
            decimal[] leftSide = { 2, (1 + 1) };
            decimal[] rightSide = { 7 };
            var equationSolver = new OneUnknown();

            var result = equationSolver.SolveEquation(leftSide, rightSide);

            Assert.AreEqual(2.5M, result);
        }

        [TestMethod]
        public void TwoXPlusOneEqualsTwelfe_ReturnsFivePointFive()
        {
            decimal[] leftSide = { 2, 1 };
            decimal[] rightSide = { 12 };
            var equationSolver = new OneUnknown();

            var result = equationSolver.SolveEquation(leftSide, rightSide);

            Assert.AreEqual(5.5M, result);
        }


    }
}