using System.Collections.ObjectModel;
using System.Collections.Generic;
using Commando.Models;

namespace Commando.Data
{
    public class CommandoRepo : ICommandoRepo
    {
         public IEnumerable<Command> GetAppCommands()
         {
             throw new System.NotImplementedException();
         }
         public Command GetCommandById()
         {
             throw new System.NotImplementedException();
         }
    }
}