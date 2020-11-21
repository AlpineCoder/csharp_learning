using System.Collections.Generic;
using MyAPI.Models;

namespace MyAPI.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }
}