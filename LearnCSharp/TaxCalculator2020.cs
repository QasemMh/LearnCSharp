namespace LearnCSharp
{
    internal partial class Program
    {
        public class TaxCalculator2020: ITaxCalculator
        {
            public int calculateTax(double amount)
            {
                return (int)(amount * 0.05);
            }

            public void printTaxReport()
            {
                //print
            }
        }

    }





}
