using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEscolar
{
    public class Empresa: Pessoa
    {
        private String   nm_empresa;
        private DateTime dt_fundacao;
        private String   end_empresa;
		private String   cep_empresa;
		private String   cidade_empresa;
		private String   uf_empresa;
		private String   complemento;		
        private String   bairro_empresa;
        private String   escola_aluno;
		private String   telefone_empresa;
		
        public String   Nm_empresa  	 {get {return nm_empresa;       } set {nm_empresa = value; }}
        public DateTime Dt_fundacao 	 {get {return dt_fundacao;      } set {dt_fundacao = value;}}
        public String   End_empresa 	 {get {return end_empresa;      } set {end_empresa = value;}}
		public String   Cep_empresa 	 {get {return cep_empresa;      } set {cep_empresa = value;}}
		public String   Cidade_empresa   {get {return cidade_empresa;   } set {cidade_empresa = value;}}
		public String   Uf_empresa       {get {return uf_empresa;       } set {uf_empresa = value;}}
		public String   Complemento      {get {return complemento;      } set {complemento = value;}}		
        public String   Bairro_empresa   {get {return bairro_empresa;   } set {complemento = bairro_empresa;}}
        public String   Escola_aluno     {get {return escola_aluno;     } set {complemento = escola_aluno;}}
		public String   Telefone_empresa {get {return telefone_empresa; } set {complemento = telefone_empresa;}}
	     
        public Aluno (int id_aluno, String nm_aluno, DateTime dt_nasc_aluno, String end_aluno){

            this.id_aluno = id_aluno;
            this.nm_aluno = nm_aluno;
            this.dt_nasc_aluno = dt_nasc_aluno;
            this.end_aluno = end_aluno;

        }

    }
}
