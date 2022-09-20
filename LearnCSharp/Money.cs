namespace LearnCSharp
{
    public class Money
    {
        public int Amount { get; set; }

        public Money(int amount)
        {
            Amount = amount;
        }


        public override string ToString()
        {
            return $"Amount:{Amount}";
        }

        public static Money operator +(Money money1, Money money2)
        {
            return new Money(money1.Amount + money2.Amount);
        }
        public static Money operator -(Money money1, Money money2)
        {
            return new Money(money1.Amount - money2.Amount);
        }

        public static Money operator ++(Money money)
        {
            return new Money(money.Amount + 1);
        }
        public static Money operator --(Money money)
        {
            return new Money(money.Amount - 1);
        }

    }




}
