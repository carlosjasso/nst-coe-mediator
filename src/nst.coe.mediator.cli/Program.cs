using nst.coe.mediator.cli.enums;
using nst.coe.mediator.cli.models;

namespace nst.coe.mediator.cli
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			var airplane = new Airplane();
			var helicopter = new Helicopter();
			var tower = new ControlTower(airplane, helicopter);

			Console.WriteLine($"Program triggering {airplane.GetType().Name} {AircraftAction.Land}");
			airplane.Land();

			Console.WriteLine($"Program triggering {helicopter.GetType().Name} {AircraftAction.Depart}");
			helicopter.Depart();
		}
	}
}
