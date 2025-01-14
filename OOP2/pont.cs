using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
	internal class Pont
	{
		private int X;
		private int Y;
		private string Nev;
		public int x
		{
			get { return X; }
			set { X = value; }
		}
		public int y
		{
			get { return Y; }
			set { Y = value; }
		}
		public string nev
		{
			get { return Nev; }
			set { Nev = value; }
		}
		public Pont(int x, int y, string nev = "pont")
		{
			X = x;
			Y = y;
			Nev = nev;
		}
		public Pont()
		{
			Nev = "pont1";
			X = 1;
			Y = 3;
		}
		public Pont(int interv)
		{
			Random random = new Random();
			int randomNumberX = random.Next(-interv, interv);
			X = randomNumberX;
			int randomNumberY = random.Next(-interv, interv);
			Y = randomNumberY;
            Console.WriteLine($"X: {X} Y:{Y}");
        }
		public double tavolsagmeres(Pont MasikPont)
		{
			int kulonbsegX=x-MasikPont.x;
			int kulonbsegY=y-MasikPont.y;
			return Math.Sqrt(Math.Pow(kulonbsegX, 2)+Math.Pow(kulonbsegY,2));
		}
		public void PontCsere()
		{
			int temp = x;
			x = y;
			y = temp;
            Console.WriteLine("A pontcsere sikeres.");
        }
		public void Nagyobbitas(int szorzo)
		{
			x=x*szorzo;
			y=y*szorzo;
            Console.WriteLine("A nagyobbítás sikeres");
        }
		public bool IsOr()
		{
			return x == 0 && y == 0;
		}
	}
}
