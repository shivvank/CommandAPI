using System.Collections.Generic;
using CommandAPI.Models;
namespace CommandAPI.Data
{
    public class MockCommandAPIRepo : ICommandAPIRepo
    {
        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
        public IEnumerable<Command> GetAllCommands()
        {
            var Commands= new List<Command>
            {
                new Command{
                    Id=0,
                    HowTo="How to Generate Migration",
                    CommandLine="dotet ef migrations add <Name of Migration>",
                    Platform=".Net Core EF"
                },
                new Command{
                    Id=1,
                    HowTo="Run Migration",
                    CommandLine="dotet ef database update",
                    Platform=".Net Core EF"
                },
                new Command{
                    Id=2,
                    HowTo="List Active Migrations",
                    CommandLine="dotet ef migrations list",
                    Platform=".Net Core EF"
                }
            };
            return Commands;
        }
        public Command GetCommandById(int id)
        {
            return new Command{
                    Id=0,
                    HowTo="How to Generate Migration",
                    CommandLine="dotet ef migrations add <Name of Migration>",
                    Platform=".Net Core EF"
                };
        }
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

    }
}