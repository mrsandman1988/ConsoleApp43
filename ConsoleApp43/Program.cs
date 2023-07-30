namespace ConsoleApp43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 3, 2, 4 };
            var newCollection = numbers.Distinct().ToList();
            
            var dob = DateTime.Now.AddYears(-25);
            Person person1 = new Person()
            {
                FirstName= "Test",
                LastName= "Test",
                DOB = dob,
                ClothesColor = "Red"
            };
            Person person2 = new Person()
            {
                FirstName = "Test",
                LastName = "Test",
                DOB = dob,
                ClothesColor = "Red"
            };
           
            var hash1 = person1.FirstName.GetHashCode();
            var hash2 = person1.LastName.GetHashCode();
            var hash3 = person1.DOB.GetHashCode();
            Console.WriteLine($"{hash1} {hash2} {hash3}");
        }
    }
}