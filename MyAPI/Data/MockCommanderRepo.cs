using System.Collections.Generic;
using MyAPI.Models;

namespace MyAPI.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boil an egg", Line="Just cook it", Platform="Kitchen"},
                new Command{Id=1, HowTo="Cook tea", Line="Place teabag in cup", Platform="Kitchen"},
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Just cook it", Platform = "Kitchen" };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}