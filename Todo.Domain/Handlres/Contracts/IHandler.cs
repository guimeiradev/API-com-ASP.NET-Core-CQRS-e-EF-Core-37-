using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Handlres.Contracts
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
