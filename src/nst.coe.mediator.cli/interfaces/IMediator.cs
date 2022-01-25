using nst.coe.mediator.cli.enums;
using nst.coe.mediator.cli.models;

namespace nst.coe.mediator.cli.interfaces
{
	public interface IMediator
	{
		void Notify(Aircraft sender, AircraftAction action);
	}
}
