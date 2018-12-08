using FumeLab.Fume.Core.Commands;

namespace FumeLab.Fume.Core
{
    public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        void Handle(TCommand command);
    }
}
