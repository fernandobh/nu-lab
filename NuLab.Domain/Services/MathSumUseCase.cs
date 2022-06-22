namespace NuLab.Domain.Interfaces
{
    public class MathSumUseCase : IMathSumUseCase
    {
        public int Execute(int valueA, int valueB)
        {
            return valueA + valueB;

        }
    }
}