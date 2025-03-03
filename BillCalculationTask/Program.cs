namespace ThemeParkCalculationTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("Please enter the number of people in the group: ");          
            int numberOfPeople = int.Parse(Console.ReadLine());
            int price = 15;
            int totalCharge = numberOfPeople * price;
            int reduction = 5;
            if (numberOfPeople >= 6)
            {
                totalCharge -= reduction; 
            }
            Console.WriteLine("The total charge is £" + totalCharge);
        }
    }
}
			
