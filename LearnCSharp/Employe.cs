namespace LearnCSharp
{
    public class Employe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (!(obj is Employe)) return false;

            var emp = obj as Employe;
            return this.Id == emp.Id && this.Name == emp.Name;
        }

          public override int GetHashCode() => this.Id.GetHashCode() ^ this.Name.GetHashCode();

       
        public static bool operator ==(Employe emp1, Employe emp2) => emp1.Equals(emp2);
        public static bool operator !=(Employe emp1, Employe emp2) => !emp1.Equals(emp2);

        /*
         var emp = new Employe { Id = 1, Name = "Employee 1" };
            var emp2 = new Employe { Id = 1, Name = "Employee 1" };

            Console.WriteLine(emp == emp2);
            Console.WriteLine(emp.GetHashCode());
            Console.WriteLine(emp2.GetHashCode());
         */

    }







}
