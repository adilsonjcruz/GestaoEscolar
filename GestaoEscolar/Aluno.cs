using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEscolar
{
    public class Aluno: Pessoa
    {
        private int id_aluno;
        private String nm_aluno;
        private DateTime dt_nasc_aluno;
        private String end_aluno;
     
        public int ID_Aluno { get { return id_aluno; } set { id_aluno = value; } }
        public String NM_Aluno { get { return nm_aluno; } set { nm_aluno = value; } }
        public DateTime DT_Nas_Aluno { get { return dt_nasc_aluno; } set { dt_nasc_aluno = value; } }
        public String End_Aluno { get { return end_aluno; } set { end_aluno = value; } }

        public Aluno (int id_aluno, String nm_aluno, DateTime dt_nasc_aluno, String end_aluno){

            this.id_aluno = id_aluno;
            this.nm_aluno = nm_aluno;
            this.dt_nasc_aluno = dt_nasc_aluno;
            this.end_aluno = end_aluno;

        }

    }
}
