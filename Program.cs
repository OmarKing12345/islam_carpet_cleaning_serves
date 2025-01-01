namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int small_Coast = 25;
            int large_Coast = 35;
            double Tax = 0.06;
            Console.WriteLine("Estimate for carpet cleaning service ");
            Console.Write("Numper of small carpets: ");
            int numper_of_Small_carpet=Convert.ToInt32(Console.ReadLine());


            Console.Write("Numper of large carpets: ");
            int numper_of_large_carpets=Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"prise per small room : {small_Coast} $");
            Console.WriteLine($"prise per large room : {large_Coast} $");

            int Price_For_small = small_Coast * numper_of_Small_carpet;
            int Price_For_large = large_Coast * numper_of_large_carpets;
            int totalCost=Price_For_large+Price_For_small;
            Console.WriteLine($"total cost : {totalCost}  $");
            double totalTax = totalCost * Tax;
            Console.WriteLine($"Tax:  {totalTax} $");
            Console.WriteLine("========================================================");

            double total_Estmate = totalTax + totalCost;
            Console.WriteLine($"Total Estmate : {total_Estmate} $");
            Console.WriteLine("this estmate is valid for 30 days");


        }
    }
}
