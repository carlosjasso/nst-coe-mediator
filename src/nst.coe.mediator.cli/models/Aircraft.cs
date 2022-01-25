using nst.coe.mediator.cli.enums;
using nst.coe.mediator.cli.interfaces;

namespace nst.coe.mediator.cli.models
{
	public class Aircraft
	{
		protected IMediator _mediator;
		public IMediator Mediator
		{
			set
			{
				this._mediator = value;
			}
		}

		public Aircraft(IMediator? mediator = null)
		{
			this._mediator = mediator;
		}

		protected void DoAction(Aircraft caller, AircraftAction action)
		{
			Console.WriteLine($"{caller.GetType().Name} does {action}...");
			this._mediator.Notify(this, action);
		}
	}
}
