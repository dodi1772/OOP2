namespace OOP2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Pont pont = new Pont();
            Console.WriteLine(pont);
			Pont masodikpont = new Pont(20,30);
            Console.WriteLine($"X: {masodikpont.x} Y: {masodikpont.y}");
            Console.WriteLine(pont.tavolsagmeres(masodikpont));
        }
	}
}
