using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEscolar
{
    public class Pessoa
    {
        private int id_pessoa;
        private String tipo_pessoa;
        private String cpf_cnpj;
        private String nome_pessoa;
        private String end_pessoa;
        private String bairro_pessoa;
        private String cidade_pessoa;
        private DateTime dt_nascimento;
        private String escolaridade;
        
        public int ID_Pessoa { get { return id_pessoa; } set { id_pessoa = value; } }
        public String Tipo_Pessoa { get { return tipo_pessoa; } set { tipo_pessoa = value; } }
        public String Cpf_Cnpj { get { return cpf_cnpj; } set { cpf_cnpj = value; } }
        public String Nome_Pessoa { get { return nome_pessoa; } set { nome_pessoa = value; } }
        public String End_Pessoa { get { return end_pessoa; } set { end_pessoa = value; } }
        public String Bairro_Pessoa { get { return bairro_pessoa; } set { bairro_pessoa = value; } }
        public String Cidade_Pessoa { get { return cidade_pessoa; } set { cidade_pessoa = value; } }
        public DateTime DT_Nascimento { get { return dt_nascimento; } set { dt_nascimento = value; } }
        public String Escolaridade { get { return escolaridade; } set { escolaridade = value; } }
        
        public Pessoa() { }

    }
}
