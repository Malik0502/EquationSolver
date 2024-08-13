namespace EquationSolver
{
    public class OneUnknown : IEquationSolver
    {

        // X muss an erster Stelle stehen
        // Muss noch irgendwie fixxen, dass X hier immer als erstes angesehen wird
        // Ansonsten sind einfache Gleichungen mit einer Unbekannten schon möglich.
        // Klammer noch nicht

        // a1 x + a2 = a3
        public decimal SolveEquation(decimal[] leftSide, decimal[] rightSide)
        {
            decimal result = 0;
            var num = leftSide[0];
            for (int i = 0; i < leftSide.Length; i++)
            {
                rightSide[i] = rightSide[i] / leftSide[0];
                leftSide[0] = leftSide[0] / leftSide[0];
                
                for (int j = 1; j < leftSide.Length; j++)
                {
                    leftSide[j] = leftSide[j] / num;
                }
                for (int k = 0; k < rightSide.Length; k++)
                {
                    rightSide[k] = rightSide[k] / leftSide[0];
                }

                if (leftSide.Length > 1)
                {
                    rightSide[i] = rightSide[i] + leftSide[i + 1] * -1;
                    leftSide[i + 1] = leftSide[i + 1] + leftSide[i + 1] * -1;
                }
                leftSide = leftSide.Where(x => x != 0).ToArray();
                rightSide = rightSide.Where(x => x != 0).ToArray();
                if (rightSide.Length == 1 && leftSide.Length == 1 && leftSide[0] == 1)
                {
                    result = rightSide[0];
                }
            }

            Console.WriteLine(Decimal.Round(result, 1));
            return Decimal.Round(result, 1);
        }
        public void SimplifyEquation()
        {
            throw new NotImplementedException();
        }

    }
}
