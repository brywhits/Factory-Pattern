using System;
namespace FactoryPattern
{
	public class Car : IVehicle
	{
		public void Drive()
		{
			Console.WriteLine("The car is driving!");
		}
    }
}

