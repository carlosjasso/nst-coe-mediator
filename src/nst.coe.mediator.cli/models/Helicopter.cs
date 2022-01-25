using nst.coe.mediator.cli.enums;

namespace nst.coe.mediator.cli.models
{
	public class Helicopter : Aircraft
	{
		public void Land()
		{
			DoAction(this, AircraftAction.Land);
		}

		public void Depart()
		{
			DoAction(this, AircraftAction.Depart);
		}

		public void TurnAround()
		{
			DoAction(this, AircraftAction.TurnAround);
		}

		public void Stay()
		{
			DoAction(this, AircraftAction.Stay);
		}
	}
}
