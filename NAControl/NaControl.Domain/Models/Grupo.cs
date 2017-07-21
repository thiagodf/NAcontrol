using NAControl.Common.Resources;
using NAControl.Common.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAControl.Domain.Models
{
    public class Grupo
    {
        #region Ctor

        public Grupo(){ }

        public Grupo(string nome)
        {
            this.Nome = nome;
        }

        #endregion

        #region Properties

        public int Id { get; private set; }

        public string Nome { get; private set; }

        #endregion

        #region Methods

        public void AlteraNome(string nome)
        {
            this.Nome = nome;
        }
        public void Validar()
        {
            AssertionConcern.AssertArgumentLength(this.Nome, 3, 100, Errors.InvalidUserName);
        }

        #endregion
    }
}
