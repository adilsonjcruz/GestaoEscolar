using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoEscolar
{
    public partial class frmCadastroAlunos : Form
    {

        private List<Aluno> lstAlunos;

        public frmCadastroAlunos()
        {
            InitializeComponent();
        }

        private void frmCadastroAlunos_Load(object sender, EventArgs e)
        {
            
        }

        private void frmCadastroAlunos_Shown(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(1, "Adilson", Convert.ToDateTime("19/08/2019"), "Rua Antonio João, 1289");
            edtCodigo.Text = aluno.ID_Aluno.ToString();
            edtNome.Text = aluno.NM_Aluno;
            edtDtNasc.Text = String.Format("{0:MM/dd/yyyy}", aluno.DT_Nas_Aluno);
            edtEndereco.Text = aluno.End_Aluno;
                
        }

        private void limparCampos() {

            edtCodigo.Clear();
            edtNome.Clear();
            edtDtNasc.Clear();
            edtEndereco.Clear();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            edtCodigo.Focus();
        }
    }
}
