namespace EquationSolver
{
    public interface IEquationSolver
    {
        decimal SolveEquation(decimal[] leftSide, decimal[] rightSide);

        void SimplifyEquation();
    }
}
