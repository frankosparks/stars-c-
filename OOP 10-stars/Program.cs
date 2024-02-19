namespace OOP_10_stars;
class Program
{
    static void Main()
    {
       Console.WriteLine("Enter a number:");
       int n=Convert.ToInt32(Console.ReadLine()); 
       for(int i = 1;i<=n;i++){
        for(int j = 1;j<=i;j++){
            Console.Write("*");
        }
        Console.WriteLine();
       }
    }
}
