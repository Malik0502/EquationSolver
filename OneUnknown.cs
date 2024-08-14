using System.ComponentModel.Design;

namespace EquationSolver
{
    public class OneUnknown : IEquationSolver
    {

        // X muss an erster Stelle stehen
        // Muss noch irgendwie fixxen, dass X hier immer als erstes angesehen wird
        // Ansonsten sind einfache Gleichungen mit einer Unbekannten schon möglich.
        // Klammer noch nicht

        // a1 x +/- a2 +/-an... = a3 +/- an
        public decimal SolveEquation(decimal[] leftSide, decimal[] rightSide)
        {
            decimal result = 0;
            var num = leftSide[0];

            leftSide = SimplifyLeftSide(leftSide);
            rightSide = SimplifyRightSide(rightSide);
            for (int i = 0; i < leftSide.Length; i++)
            {
                if (rightSide.Count() == 1) rightSide[0] = rightSide[0] / leftSide[0];
                else rightSide[i] = rightSide[i] / leftSide[i];

                for (int j = 1; j < leftSide.Length; j++)
                {
                    leftSide[j] = leftSide[j] / leftSide[0];
                }
                leftSide[0] = leftSide[0] / leftSide[0];

                if (leftSide.Length > 1)
                {
                    if (rightSide.Count() == 1) rightSide[0] = rightSide[0] + leftSide[i + 1] * -1;
                    else rightSide[i] = rightSide[i] + leftSide[i + 1] * -1;

                    leftSide[i + 1] = leftSide[i + 1] + leftSide[i + 1] * -1;
                }

                leftSide = leftSide.Where(x => x != 0).ToArray();
                if (rightSide.Length == 1 && leftSide.Length == 1 && leftSide[0] == 1)
                {
                    result = rightSide[0];
                }
            }
            Console.WriteLine(Decimal.Round(result, 1));
            return Decimal.Round(result, 3);
        }

        private decimal[] SimplifyLeftSide(decimal[] leftSide)
        {
            if (leftSide.Length > 2)
            {
                for (int i = 1; i <= leftSide.Length - 1; i++)
                {
                    if (i == 1) continue;
                    leftSide[1] += leftSide[i];
                    leftSide[i] = 0;
                    if (i == leftSide.Length - 1) leftSide = leftSide.Where(x => x != 0).ToArray();
                }
            }
            return leftSide;
        }

        private decimal[] SimplifyRightSide(decimal[] rightSide)
        {
            if (rightSide.Length > 1)
            {
                for (int i = 0; i <= rightSide.Length - 1; i++)
                {
                    if (i == 0) continue;
                    rightSide[0] += rightSide[i];
                    rightSide[i] = 0;
                    if (i == rightSide.Length - 1) rightSide = rightSide.Where(x => x != 0).ToArray();
                }
            }
            return rightSide;
        }
    }
}
