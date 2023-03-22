using System;
namespace Inheritance
{
	public class Reptile : Animal
	{
		public Reptile()
		{
            LegCount = 0;
            IsMammal = false;
            Diet = "carniverous";
            Amphibious = true;
        }

		public int HeartChambers { get; set; }
		public bool IsScaly  { get; set; }
		public string Habitat { get; set; }
		public bool TailRegeneration { get; set; }
	}
}

