namespace LearnCSharp
{
    internal partial class Program
    {
        public interface ITaxCalculator
        {
            public int calculateTax(double amount);
        }

    }

    //public static ITaxCalculator getTaxCalculator()
    //{
    //    return new TaxCalculator2019();
    //}





}
