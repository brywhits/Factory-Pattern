using System;
namespace FactoryPattern
{
	public class Motorcycles : IVehicle
	{

		public void Drive()
		{
			Console.WriteLine("Motorcycle is going super fast!");
		}
	}
}

