using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_TP2
{
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
        }

        private void fUNCIONARIOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fUNCIONARIOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.funcionarioDataSet);

        }

        private void CRUD_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'funcionarioDataSet.FUNCIONARIO'. Você pode movê-la ou removê-la conforme necessário.
            this.fUNCIONARIOTableAdapter.Fill(this.funcionarioDataSet.FUNCIONARIO);

        }
    }
}
