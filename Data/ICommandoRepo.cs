using System.Collections.Generic;
using Commando.Models;

namespace Commando.Data
{
    public interface ICommandoRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById();

    }
}