using System.Collections.Generic;
using Commando.Models;

namespace Commando.Data{
    public class MockCommandoRepo : ICommandoRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            return new List<Command>{
                new Command{Id =  0,HowTo = "Take 1",Line = "1",Platform = "5"},
                new Command{Id =  0,HowTo = "Take 1",Line = "1",Platform = "5"},
                new Command{Id =  0,HowTo = "Take 1",Line = "1",Platform = "5"},
                new Command{Id =  0,HowTo = "Take 1",Line = "1",Platform = "5"},
                new Command{Id =  0,HowTo = "Take 1",Line = "1",Platform = "5"},
                new Command{Id =  0,HowTo = "Take 1",Line = "1",Platform = "5"},
                new Command{Id =  0,HowTo = "Take 1",Line = "1",Platform = "5"},
                new Command{Id =  0,HowTo = "Take 1",Line = "1",Platform = "5"},
                new Command{Id =  0,HowTo = "Take 1",Line = "1",Platform = "5"},
                new Command{Id =  0,HowTo = "Take 1",Line = "1",Platform = "5"},
                new Command{Id =  0,HowTo = "Take 1",Line = "1",Platform = "5"},
                new Command{Id =  0,HowTo = "Take 1",Line = "1",Platform = "5"},
                new Command{Id =  0,HowTo = "Take 1",Line = "1",Platform = "5"},
            };
        }

        public Command GetCommandById()
        {
            return new Command
            {
                Id =  0,
                HowTo = "Take 1",
                Line = "1",
                Platform = "5"
            };
        }
    }
}