using nst.coe.mediator.cli.enums;

namespace nst.coe.mediator.cli.interfaces
{
	public interface IMediator
	{
		void Notify(object sender, AircraftAction? action = null);
	}
}
