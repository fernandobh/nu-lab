namespace NuLab.Domain.Interfaces
{
    public class PrimeNumberCheckerUseCase : IPrimeNumberCheckerUseCase
    {
        public bool Execute(int value)
        {
            int cont = 1;

            if (value < 0)
            {
                return false;
            }

            for (int i = 1; i < value; i++)
            {
                if (value % i == 0)
                {
                    cont++;
                }
            }

            return (cont == 2);
        }
    }
}