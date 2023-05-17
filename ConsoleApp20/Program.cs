namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money;
            int crystalsInInventory;
            int crystalsPrice = 10;

            Console.WriteLine("Эй, путник! У меня есть кристаллы для тебя. Всего по " + crystalsPrice + " монет.");
            Console.Write("Сколько у вас золота: ");
            money = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько вам нужно кристаллов: ");
            crystalsInInventory = Convert.ToInt32(Console.ReadLine());

            money -= crystalsInInventory * crystalsPrice;

            Console.WriteLine("У вас в сумке - " + crystalsInInventory + " кристаллов и " + money + " монет.");
        }
    }
}