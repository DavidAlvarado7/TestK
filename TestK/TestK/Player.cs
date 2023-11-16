using System;
namespace TestK
{
	public class Player
	{

		public string Name { get; set; }
		public string Value { get; set; }


		public Player()
		{
			Name = string.Empty;
			Value = string.Empty;
		}

		public Player(string name)
		{
			name = Name;
			

		}


		static void RandomValue()
		{


		}
	}


	public class RockPlayer : Player
	{
		public string Rock { get; set; }

		public RockPlayer(string name)
		{
			name = Name;
			Value = Rosh.Rock.ToString();


        }

       
    }
}

