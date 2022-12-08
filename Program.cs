using System.IO.Pipes;

namespace TipTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            int randomnum;
            Random random = new Random();
            randomnum = random.Next(1, 101);
            Console.WriteLine("Zadejte číslo mezi 1-100");
            int pokus = 0;
            while (true)
            {                
                //Console.WriteLine(randomnum);
                int tip = Convert.ToInt32(Console.ReadLine());
                if (tip == randomnum)
                {
                    Console.WriteLine("výhra");
                    Console.WriteLine(" počet pokusů: " + pokus);
                    Console.WriteLine("chceš hrát znovu? Ano/Ne");
                    var input = Console.ReadLine();
                    if (input == "Ano")
                    {
                        goto start;
                    }
                    else
                    {
                        break;
                    }
                    
                }
                else if (tip < randomnum)
                {
                    Console.WriteLine("číslo je větší");
                    pokus++;
                }
                else if (tip > randomnum)
                {
                    Console.WriteLine("číslo je menší");
                    pokus++;
                }
                else
                {
                    Console.WriteLine("si dement, jen čísla!");
                }
            }
        }
    }
}