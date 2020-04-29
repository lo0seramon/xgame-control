using Xgame.Domain.Arguments.Console;

namespace Xgame.Domain.Interfaces.Services
{
    public interface IConsoleService
    {
        AddConsoleResponse AddConsole(AddConsoleRequest request);
    }
}
