using NAControl.Common.Resources;
using NAControl.Common.Validation;
using System.Collections.Generic;

namespace NAControl.Domain.Models
{
    public class Group
    {
        #region Ctor

        public Group(){ }

        public Group(string name)
        {
            this.Name = name;
            
        }

        #endregion

        #region Properties

        public int GroId { get; private set; }

        public string Name { get; private set; }

        public virtual Address Adress { get; private set; }

        public ICollection<Meeting> MeetingList { get; set; }

        #endregion

        #region Methods

        public void AlteraNome(string name)
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
