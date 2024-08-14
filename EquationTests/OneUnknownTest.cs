using EquationSolver;

namespace EquationTests
{
    [TestClass]
    public class OneUnknownTest
    {
        [TestMethod]
        public void XPlusTwoEqualFour_ReturnsTrue()
        {
            decimal[] leftSide = { 1 ,+2 };
            decimal[] rightSide = { 4 };
            var equationSolver = new OneUnknown();

            var result = equationSolver.SolveEquation(leftSide, rightSide);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Minus2XEqualSix_ReturnsTrue()
        {
            decimal[] leftSide = { -2};
            decimal[] rightSide = { 6 };
            var equationSolver = new OneUnknown();

            var result = equationSolver.SolveEquation(leftSide, rightSide);

            Assert.AreEqual(-3, result);
        }

        [TestMethod]
        public void TwoThirdOfXEquals5_ReturnsTrue()
        {
            decimal[] leftSide = { 0.66M };
            decimal[] rightSide = { 5 };
            var equationSolver = new OneUnknown();

            var result = equationSolver.SolveEquation(leftSide, rightSide);

            Assert.AreEqual(7.576M, result);
        }

        [TestMethod]
        public void TwoXPlus2Equals7_ReturnsTrue()
        {
            decimal[] leftSide = { 2, +2};
            decimal[] rightSide = { 7 };
            var equationSolver = new OneUnknown();

            var result = equationSolver.SolveEquation(leftSide, rightSide);

            Assert.AreEqual(2.5M, result);
        }

        [TestMethod]
        public void XPlus58Equals128_ReturnsTrue()
        {
            decimal[] leftSide = { 1, 58 };
            decimal[] rightSide = { 128 };
            var equationSolver = new OneUnknown();

            var result = equationSolver.SolveEquation(leftSide, rightSide);

            Assert.AreEqual(70, result);
        }

        [TestMethod]
        public void XPlus60Equals6_ReturnsTrue()
        {
            decimal[] leftSide = { 1, 60 };
            decimal[] rightSide = { 6 };
            var equationSolver = new OneUnknown();

            var result = equationSolver.SolveEquation(leftSide, rightSide);

            Assert.AreEqual(-54, result);
        }

        [TestMethod]
        public void XMinusFourtyThreeEqualsMinus15_ReturnsTrue()
        {
            decimal[] leftSide = { -1, +43 };
            decimal[] rightSide = { -15 };
            var equationSolver = new OneUnknown();

            var result = equationSolver.SolveEquation(leftSide, rightSide);

            Assert.AreEqual(58, result);
        }

        [TestMethod]
        public void XPlusMinusSeventyThreeEqualsMinusFiftyEight_ReturnsTrue()
        {
            decimal[] leftSide = { 1, +-73 };
            decimal[] rightSide = { -58 };
            var equationSolver = new OneUnknown();

            var result = equationSolver.SolveEquation(leftSide, rightSide);

            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void XPlusMinusSeventyTwoEqualsMinusThirtyFour_ReturnsTrue()
        {
            decimal[] leftSide = { 1, +-72 };
            decimal[] rightSide = { -34 };
            var equationSolver = new OneUnknown();

            var result = equationSolver.SolveEquation(leftSide, rightSide);

            Assert.AreEqual(38, result);
        }

        [TestMethod]
        public void TwoXPlusOneEqualsTwelfe_ReturnsTrue()
        {
            decimal[] leftSide = { 2, 1 };
            decimal[] rightSide = { 12 };
            var equationSolver = new OneUnknown();

            var result = equationSolver.SolveEquation(leftSide, rightSide);

            Assert.AreEqual(5.5M, result);
        }

        [TestMethod]
        public void MinusThreeXMinus5EqualsThree_ReturnsTrue()
        {
            decimal[] leftSide = { -3, -5 };
            decimal[] rightSide = { +3 };
            var equationSolver = new OneUnknown();

            var result = equationSolver.SolveEquation(leftSide, rightSide);

            Assert.AreEqual(-2.667M, result);
        }

        [TestMethod]
        public void ThreeXPlusTwoPlus3EqualsEight_ReturnsTrue()
        {
            decimal[] leftSide = { 3, 2, 3 };
            decimal[] rightSide = { 8 };
            var equationSolver = new OneUnknown();

            var result = equationSolver.SolveEquation(leftSide, rightSide);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ThreeXPlusThreePlusFivePlusSixEqualsSixteen_ReturnsTrue()
        {
            decimal[] leftSide = { 3, 3, 5, 6 };
            decimal[] rightSide = { 16 };
            var equationSolver = new OneUnknown();

            var result = equationSolver.SolveEquation(leftSide, rightSide);

            Assert.AreEqual(0.667M, result);
        }

        [TestMethod]
        public void MinusSevXPlusThreeFiveSixNineEqualsFive_ReturnsTrue()
        {
            decimal[] leftSide = { -7, 3, 5, 6, 9};
            decimal[] rightSide = { 5 };
            var equationSolver = new OneUnknown();

            var result = equationSolver.SolveEquation(leftSide, rightSide);

            Assert.AreEqual(2.571M, result);
        }

        [TestMethod]
        public void MinusSixTeenXPlusFourMinusThreePlusTenEqualsMinusFivePlusEighteen_ReturnsTrue()
        {
            decimal[] leftSide = { -16, 4, -3, 10};
            decimal[] rightSide = { -5, 18 };
            var equationSolver = new OneUnknown();

            var result = equationSolver.SolveEquation(leftSide, rightSide);

            Assert.AreEqual(-0.125M, result);
        }

        [TestMethod]
        public void MinusSixPlusFourMinusThreeEqualsSevenMinusTwentyThree_ReturnsTrue()
        {
            decimal[] leftSide = { -6, 4, -3};
            decimal[] rightSide = { 7, -23 };
            var equationSolver = new OneUnknown();

            var result = equationSolver.SolveEquation(leftSide, rightSide);

            Assert.AreEqual(2.833M, result);
        }

        [TestMethod]
        public void Equation_ReturnsFalse()
        {
            decimal[] leftSide = { -16, 4, -3, 10 };
            decimal[] rightSide = { -5, 15 };
            var equationSolver = new OneUnknown();

            var result = equationSolver.SolveEquation(leftSide, rightSide);

            Assert.AreNotEqual(-0.125M, result);
        }
    }
}