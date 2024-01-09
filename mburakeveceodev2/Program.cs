namespace mburakeveceodev2
{
    internal class Program
    {
      
        
            static void Main(string[] args)
            {
                Random rnd = new Random();
                Console.WriteLine("How Many Number Do You Want?");
                byte sayac = byte.Parse(Console.ReadLine());

                Console.WriteLine("Enter Starting Number! ");
                byte basla = byte.Parse(Console.ReadLine());

                Console.WriteLine("Enter an Ending Number!");
                byte bit = byte.Parse(Console.ReadLine());

                int[] numbers = new int[sayac];
                int num;

                for (int i = 0; i < numbers.Length; i++)
                {
                    num = rnd.Next(basla,bit);
                    if (i == 0)
                    {
                        numbers[i] = num;
                    }

                    for (int m = 0; m < i; m++)
                    {
                        if (numbers[m] == num)
                        {

                            i--;

                            break;
                        }
                        else
                        {
                            numbers[i] = num;
                        }
                    }
                }

                Array.Sort(numbers);

                for (int i = 0; i < numbers.Length; i++)
                {
                  Console.WriteLine("the numbers you want are here");
                    Console.WriteLine(numbers[i]);
                }

            
        }
    }
}
