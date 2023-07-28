internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("vize notunu giriniz:");
        int vize=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("final notunu giriniz:");
        int final=Convert.ToInt32(Console.ReadLine());

        int ort = Convert.ToInt32(vize * 0.4 + final * 0.6);

        Console.WriteLine("Ortalamanız = {0}", ort);

        if (ort < 50) 
        { 
            Console.WriteLine("KALDINIZ");
        }
        else
        {
            Console.WriteLine("GEÇTİNİZ");
        }
        Console.ReadLine();










    }
}