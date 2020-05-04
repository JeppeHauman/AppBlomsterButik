using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBlomsterButik
{
   public class OrdreBlomst
    {
		private string navn;

		public string Navn
		{
			get { return navn; }
			set { navn = value; }
		}

		private int antal;

		public int Antal
		{
			get { return antal; }
			set { antal = value; }
		}

		private string farve;

		public string Farve
		{
			get { return farve; }
			set { farve = value; }
		}

		public OrdreBlomst(string navn, int antal, string farve)
		{
			this.Navn = navn;
			this.Antal = antal;
			this.Farve = farve;

		}
		public OrdreBlomst()
		{
			
		}

	}
}
