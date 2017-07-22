using NAControl.Common.Resources;
using NAControl.Common.Validation;

namespace NAControl.Domain.Models
{
    public class Group
    {
        #region Ctor

        public Group(){ }

        public Group(string name, Address adress)
        {
            this.Name = name;
            this.Adress = adress;
        }

        #endregion

        #region Properties

        public int Id { get; private set; }

        public string Name { get; private set; }

        public virtual Address Address { get; private set; }

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
