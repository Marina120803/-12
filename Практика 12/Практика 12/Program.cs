namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            int summ = 0;
            Console.WriteLine("Для завершения ввода нажмите 0");
            do
            {
                Console.WriteLine("Введите число");
                index = int.Parse(Console.ReadLine());
                summ += index;
            }
            while (index != 0);
            Console.WriteLine("Сумма всех элементов = {0}", summ);
            Console.WriteLine("Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}