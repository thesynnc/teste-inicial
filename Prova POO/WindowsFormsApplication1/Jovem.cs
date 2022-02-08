using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Jovem : Entrevistado   
    {

        static List<Jovem> EntrevistadosList = new List<Jovem>();

        #region Construtores

        static int MaxId = 0;      

        public Jovem(string nome, SituaçãoTrab situação, SexoP sexo) : base(nome, situação, sexo)
        {
        }

        public Jovem(int id, string nome, SituaçãoTrab situação, SexoP sexo) : base(id, nome, situação, sexo)
        {
        }


        public Jovem(int id)
        {
            Jovem tc = EntrevistadosList.Find(c => c.Id == id);
            _Id = tc.Id;
            _Nome = tc.Nome;
            _Situação = tc.Situação;
            _Sexo = tc.Sexo;
        }
       
        #endregion


        #region Calculo Entrevistados
        public static int ResultadoMasculinoEmpregado()
        {
            int resultadoMasculinoEmpregado = 0;
            foreach (Jovem c in EntrevistadosList)
            {
                if (c.Sexo == SexoP.Masculino && c.Situação == SituaçãoTrab.Empregado)
                {
                    resultadoMasculinoEmpregado++;
                }
            }
            return resultadoMasculinoEmpregado;
        }

        public static int ResultadoMasculinoDesempregado()
        {
            int resultadoMasculinoDesempregado = 0;
            foreach (Jovem c in EntrevistadosList)
            {
                if (c.Sexo == SexoP.Masculino && c.Situação == SituaçãoTrab.Desempregado)
                {
                    resultadoMasculinoDesempregado++;
                }
            }
            return resultadoMasculinoDesempregado;
        }

        public static int ResultadoFemininoEmpregado()
        {
            int resultadoFemininoEmpregado = 0;
            foreach (Jovem c in EntrevistadosList)
            {
                if (c.Sexo == SexoP.Feminino && c.Situação == SituaçãoTrab.Empregado)
                {
                    resultadoFemininoEmpregado++;
                }
            }
            return resultadoFemininoEmpregado;
        }

        public static int ResultadoFemininoDesempregado()
        {
            int resultadoFemininoDesempregado = 0;
            foreach (Jovem c in EntrevistadosList)
            {
                if (c.Sexo == SexoP.Feminino && c.Situação == SituaçãoTrab.Desempregado)
                {
                    resultadoFemininoDesempregado++;
                }
            }
            return resultadoFemininoDesempregado;
        }

        public static int TotalDeEntrevistados()
        {
            int quantidadeDeEntrevistados = EntrevistadosList.Count;
            return quantidadeDeEntrevistados;
        }

        #region Porcentagem
        public static float PorcentHomemEmp()
        {
            float quantidadeDeEntrevistados = EntrevistadosList.Count;
	        float MaximoHEmpre = ResultadoMasculinoEmpregado() / quantidadeDeEntrevistados * 100;
            return MaximoHEmpre;
        }
        public static float PorcentHomemDesem()
        {
            float quantidadeDeEntrevistados = EntrevistadosList.Count;
            float MaximoHDesm = ResultadoMasculinoDesempregado() / quantidadeDeEntrevistados * 100;
            return MaximoHDesm;
        }

        public static float PorcentMulherEmp()
        {
            float quantidadeDeEntrevistados = EntrevistadosList.Count;
            float MaximoMEmpre = ResultadoFemininoEmpregado() / quantidadeDeEntrevistados * 100;
            return MaximoMEmpre;
        }

        public static float PorcentMulherDesem()
        {
            float quantidadeDeEntrevistados = EntrevistadosList.Count;
            float MaximoMDesm = ResultadoFemininoDesempregado() / quantidadeDeEntrevistados * 100;
            return MaximoMDesm;
        }
        #endregion
        #endregion


        #region Acesso a Dados

        public void Incluir()
        {
            MaxId++;
            _Id = MaxId;
            EntrevistadosList.Add(this);
        }

        public static List<Jovem> Consultar()
        {
            return EntrevistadosList;
        }

        public static List<Jovem> Consultar(string nome)
        {
            return EntrevistadosList.FindAll(c => c.Nome.Contains(nome));
        }

        public void Alterar()
        {
            int i;
            i = EntrevistadosList.FindIndex(c => c.Id == _Id);
            EntrevistadosList[i].Nome = _Nome;
            EntrevistadosList[i].Situação = _Situação;
            EntrevistadosList[i].Sexo = _Sexo;

        }

        public static void Exluir(int id)
        {
            int i;
            i = EntrevistadosList.FindIndex(c => c.Id == id);
            EntrevistadosList.Remove(EntrevistadosList[i]);
        }

        public static void LimparGrid()
        {
            MaxId = 0;
        }

        #region Dados Preenchimento Automatico
        public static void Preencher()
        {
            Jovem c;
            c = new Jovem("Lucas Alexandre", SituaçãoTrab.Empregado, SexoP.Masculino);
            c.Incluir();
            c = new Jovem("Alexandre Ottoni", SituaçãoTrab.Desempregado, SexoP.Masculino);
            c.Incluir();
            c = new Jovem("Marlusi Silva", SituaçãoTrab.Desempregado, SexoP.Feminino);
            c.Incluir();
            c = new Jovem("Alexandre Gaulês", SituaçãoTrab.Desempregado, SexoP.Masculino);
            c.Incluir();
            c = new Jovem("James Webb", SituaçãoTrab.Desempregado, SexoP.Masculino);
            c.Incluir();
            c = new Jovem("Alice Guimaraes", SituaçãoTrab.Empregado, SexoP.Feminino);
            c.Incluir();
            c = new Jovem("Alan Shepard", SituaçãoTrab.Desempregado, SexoP.Masculino);
            c.Incluir();
            c = new Jovem("Eric Jacquin", SituaçãoTrab.Empregado, SexoP.Masculino);
            c.Incluir();
            c = new Jovem("Jaqueline Silva", SituaçãoTrab.Empregado, SexoP.Feminino);
            c.Incluir();
            c = new Jovem("Felipe Maia", SituaçãoTrab.Desempregado, SexoP.Masculino);
            c.Incluir();
        }
        #endregion

        #endregion
     }
}
