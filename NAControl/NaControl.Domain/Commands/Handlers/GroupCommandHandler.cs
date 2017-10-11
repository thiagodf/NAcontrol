using NAControl.Common.Commands;
using NAControl.Domain.Commands.Inputs;
using NAControl.Domain.Commands.Results;
using NAControl.Domain.Contracts.Repositories;
using NAControl.Domain.Models;

namespace NAControl.Domain.Commands.Handlers
{
    public class GroupCommandHandler : ICommandHandler<RegisterGroupCommand>
    {
        private readonly IGroupRepository _groupRepository;
        public ICommandResult Handle(RegisterGroupCommand command)
        {
            var name = command.Name;
            //var address = new Address(command.Address.Addresses,command.Address.Complement, command.Address.City, command.Address.Latitude, command.Address.Longitude);
            //var email = new Email(command.Email);
            var group = new Group(name, command.Address, command.MeetingList);
            
            _groupRepository.Add(group);

            return new RegisterGroupCommandResult(group.GroId, group.Name);

        }
    }
}
