using Autofac;

namespace EquationSolver
{
    public class Program
    {
        static void Main(string[] args)
        {
            new UserInteraction().Menu();

            var container = BuilderStatus().Build();
            using (var scope = container.BeginLifetimeScope())
            {
                var component = scope.Resolve<IEquationSolver>();
                //component.SolveEquation();
            }
        }

        private static ContainerBuilder BuilderStatus()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<OneUnknown>().As<IEquationSolver>();

            return builder;
        }
    }
}
