namespace LearnCSharp
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal TotalSale { get; set; }
        public Gender Gender { get; set; }



       
        
    }


    public enum Gender
    {
        Male,
        Female
    }


}
