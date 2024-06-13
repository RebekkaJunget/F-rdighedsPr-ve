namespace FærdighedsPrøve
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Member member = new Member(1, "Alice", "Lov vej 1", "12345678", "hj@mail.dk"); 
            Dog dog = new Dog(1,"Lucy", "Pit","4. April 2020");

            Console.WriteLine($"{ member}, { dog}");


        }
    }
}
