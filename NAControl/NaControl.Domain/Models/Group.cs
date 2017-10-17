using NAControl.Common.Resources;
using NAControl.Common.Validation;
using System.Collections.Generic;

namespace NAControl.Domain.Models
{
    public class Group : BaseModel
    {
        #region Ctor

        public Group(){ }

        public Group(string name, Address address, ICollection<Meeting> meetingList)
        {
            this.Name = name;
            this.Address = address;
            this.MeetingList = meetingList;
        }

        #endregion

        #region Properties

        public int GroId { get; private set; }

        public string Name { get; private set; }

        //public int Grou_AddId { get; private set; }

        public virtual Address Address { get; private set; }

        public ICollection<Meeting> MeetingList { get; private set; }

        #endregion

        #region Methods

        public void ChangeNome(string name)
        {
            this.Name = name;
        }
        public void Validar()
        {
            AssertionConcern.AssertArgumentLength(this.Name, 3, 100, Errors.InvalidUserName);
        }

        #endregion
    }
}
