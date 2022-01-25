using nst.coe.mediator.cli.enums;
using nst.coe.mediator.cli.interfaces;

namespace nst.coe.mediator.cli.models
{
	public class ControlTower : IMediator
	{
		private Airplane _airplane;
		private Helicopter _helicopter;

		public ControlTower(Airplane airplane, Helicopter helicopter)
		{
			this._airplane = airplane;
			this._airplane.Mediator = this;
			this._helicopter = helicopter;
			this._helicopter.Mediator = this;
		}

		public void Notify(Aircraft sender, AircraftAction action)
		{
			if (action == AircraftAction.Depart || action == AircraftAction.Land)
			{
				Console.WriteLine($"Control Tower reacting to {sender.GetType().Name} doing {action}");
				if (sender is Airplane)
				{
					this._helicopter.Stay();
					this._helicopter.TurnAround();
				}
				else if (sender is Helicopter)
				{
					this._airplane.Stay();
				}
			}
		}
	}
}
