using FumeLab.Fume.Core.Commands;

namespace FumeLab.Fume.Core
{
    public interface ICommandRouter
    {
        void Route(ICommand command);
    }
}
