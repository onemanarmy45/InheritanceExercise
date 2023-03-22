using System;
namespace Inheritance
{
	public class Bird : Animal
	{
		public Bird()
		{
			LegCount= 2;
			IsMammal = false;
			Diet = "herbiverous";
			Amphibious = false;
		}

		public bool CareForYoung { get; set; }
        public double BeakLength { get; set; }
        public bool Migratory { get; set; }
        public bool Monogamous { get; set; }
    }
}

