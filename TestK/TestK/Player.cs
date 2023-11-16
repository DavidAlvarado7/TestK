using System;
namespace TestK
{
	public class Player
	{

		public string Name { get; set; }
		public string Value { get; set; }

		public Player(string name, string value)
		{
			name = Name;
			value = Value;

		}


		static void RandomValue()
		{


		}
	}


	public class RockPlayer : Player
	{
		public string Rock { get; set; }

		public RockPlayer(string name, string value)
		{
			name = Name;
			value = Value;


        }

        public override string ToString()
		{

		}

    }
}

