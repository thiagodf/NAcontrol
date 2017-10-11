using NAControl.Common.Commands;

namespace NAControl.Domain.Commands.Results
{
    public class RegisterGroupCommandResult : ICommandResult
    {
        public RegisterGroupCommandResult()
        {

        }
        public RegisterGroupCommandResult(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
