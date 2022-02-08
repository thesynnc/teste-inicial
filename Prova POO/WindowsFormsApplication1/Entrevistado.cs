using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication1
{
    class Entrevistado
    {
        public enum SexoP { Masculino, Feminino }
        public enum SituaçãoTrab { Empregado, Desempregado }

        protected int _Id;
        protected string _Nome;
        protected SituaçãoTrab _Situação;
        protected SexoP _Sexo;

        #region Construtores

        public Entrevistado()
        {
            _Id = 0;
            _Nome = "";
            _Situação = SituaçãoTrab.Empregado;
            _Sexo = SexoP.Masculino;
        }

        public Entrevistado(int id, string nome, SituaçãoTrab situação, SexoP sexo)
        {
            _Id = id;
            _Nome = nome;
            _Situação = situação;
            _Sexo = sexo;
        }
        public Entrevistado(string nome, SituaçãoTrab situação, SexoP sexo)
        {
            _Id = 0;
            _Nome = nome;
            _Situação = situação;
            _Sexo = sexo;
        }
        #endregion

        #region Propriedades
        public int Id
        {
            set { _Id = value; }
            get { return _Id; }
        }

        public string Nome
        {
            set { _Nome = value; }
            get { return _Nome; }
        }

        public SituaçãoTrab Situação
        {
            set { _Situação = value; }
            get { return _Situação; }
        }

        public SexoP Sexo
        {
            set { _Sexo = value; }
            get { return _Sexo; }
        }
        #endregion
    }
}
