namespace CRUD_TP2
{
    partial class CRUD
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD));
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label eMAILLabel;
            System.Windows.Forms.Label tELEFONELabel;
            System.Windows.Forms.Label sETORLabel;
            System.Windows.Forms.Label cARGOLabel;
            this.funcionarioDataSet = new CRUD_TP2.FuncionarioDataSet();
            this.fUNCIONARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fUNCIONARIOTableAdapter = new CRUD_TP2.FuncionarioDataSetTableAdapters.FUNCIONARIOTableAdapter();
            this.tableAdapterManager = new CRUD_TP2.FuncionarioDataSetTableAdapters.TableAdapterManager();
            this.fUNCIONARIOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.fUNCIONARIOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nOMETextBox = new System.Windows.Forms.TextBox();
            this.eMAILTextBox = new System.Windows.Forms.TextBox();
            this.tELEFONETextBox = new System.Windows.Forms.TextBox();
            this.sETORTextBox = new System.Windows.Forms.TextBox();
            this.cARGOTextBox = new System.Windows.Forms.TextBox();
            nOMELabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            tELEFONELabel = new System.Windows.Forms.Label();
            sETORLabel = new System.Windows.Forms.Label();
            cARGOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOBindingNavigator)).BeginInit();
            this.fUNCIONARIOBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // funcionarioDataSet
            // 
            this.funcionarioDataSet.DataSetName = "FuncionarioDataSet";
            this.funcionarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fUNCIONARIOBindingSource
            // 
            this.fUNCIONARIOBindingSource.DataMember = "FUNCIONARIO";
            this.fUNCIONARIOBindingSource.DataSource = this.funcionarioDataSet;
            // 
            // fUNCIONARIOTableAdapter
            // 
            this.fUNCIONARIOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FUNCIONARIOTableAdapter = this.fUNCIONARIOTableAdapter;
            this.tableAdapterManager.UpdateOrder = CRUD_TP2.FuncionarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fUNCIONARIOBindingNavigator
            // 
            this.fUNCIONARIOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fUNCIONARIOBindingNavigator.BindingSource = this.fUNCIONARIOBindingSource;
            this.fUNCIONARIOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fUNCIONARIOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fUNCIONARIOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.fUNCIONARIOBindingNavigatorSaveItem});
            this.fUNCIONARIOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fUNCIONARIOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fUNCIONARIOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fUNCIONARIOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fUNCIONARIOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fUNCIONARIOBindingNavigator.Name = "fUNCIONARIOBindingNavigator";
            this.fUNCIONARIOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fUNCIONARIOBindingNavigator.Size = new System.Drawing.Size(281, 25);
            this.fUNCIONARIOBindingNavigator.TabIndex = 1;
            this.fUNCIONARIOBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // fUNCIONARIOBindingNavigatorSaveItem
            // 
            this.fUNCIONARIOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fUNCIONARIOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fUNCIONARIOBindingNavigatorSaveItem.Image")));
            this.fUNCIONARIOBindingNavigatorSaveItem.Name = "fUNCIONARIOBindingNavigatorSaveItem";
            this.fUNCIONARIOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.fUNCIONARIOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.fUNCIONARIOBindingNavigatorSaveItem.Click += new System.EventHandler(this.fUNCIONARIOBindingNavigatorSaveItem_Click);
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.Location = new System.Drawing.Point(34, 42);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(42, 13);
            nOMELabel.TabIndex = 4;
            nOMELabel.Text = "NOME:";
            // 
            // nOMETextBox
            // 
            this.nOMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fUNCIONARIOBindingSource, "NOME", true));
            this.nOMETextBox.Location = new System.Drawing.Point(82, 39);
            this.nOMETextBox.Name = "nOMETextBox";
            this.nOMETextBox.Size = new System.Drawing.Size(171, 20);
            this.nOMETextBox.TabIndex = 5;
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Location = new System.Drawing.Point(34, 65);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(42, 13);
            eMAILLabel.TabIndex = 6;
            eMAILLabel.Text = "EMAIL:";
            // 
            // eMAILTextBox
            // 
            this.eMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fUNCIONARIOBindingSource, "EMAIL", true));
            this.eMAILTextBox.Location = new System.Drawing.Point(82, 62);
            this.eMAILTextBox.Name = "eMAILTextBox";
            this.eMAILTextBox.Size = new System.Drawing.Size(171, 20);
            this.eMAILTextBox.TabIndex = 7;
            // 
            // tELEFONELabel
            // 
            tELEFONELabel.AutoSize = true;
            tELEFONELabel.Location = new System.Drawing.Point(12, 88);
            tELEFONELabel.Name = "tELEFONELabel";
            tELEFONELabel.Size = new System.Drawing.Size(66, 13);
            tELEFONELabel.TabIndex = 8;
            tELEFONELabel.Text = "TELEFONE:";
            // 
            // tELEFONETextBox
            // 
            this.tELEFONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fUNCIONARIOBindingSource, "TELEFONE", true));
            this.tELEFONETextBox.Location = new System.Drawing.Point(82, 85);
            this.tELEFONETextBox.Name = "tELEFONETextBox";
            this.tELEFONETextBox.Size = new System.Drawing.Size(171, 20);
            this.tELEFONETextBox.TabIndex = 9;
            // 
            // sETORLabel
            // 
            sETORLabel.AutoSize = true;
            sETORLabel.Location = new System.Drawing.Point(28, 114);
            sETORLabel.Name = "sETORLabel";
            sETORLabel.Size = new System.Drawing.Size(47, 13);
            sETORLabel.TabIndex = 10;
            sETORLabel.Text = "SETOR:";
            // 
            // sETORTextBox
            // 
            this.sETORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fUNCIONARIOBindingSource, "SETOR", true));
            this.sETORTextBox.Location = new System.Drawing.Point(82, 130);
            this.sETORTextBox.Name = "sETORTextBox";
            this.sETORTextBox.Size = new System.Drawing.Size(171, 20);
            this.sETORTextBox.TabIndex = 11;
            // 
            // cARGOLabel
            // 
            cARGOLabel.AutoSize = true;
            cARGOLabel.Location = new System.Drawing.Point(28, 137);
            cARGOLabel.Name = "cARGOLabel";
            cARGOLabel.Size = new System.Drawing.Size(48, 13);
            cARGOLabel.TabIndex = 12;
            cARGOLabel.Text = "CARGO:";
            // 
            // cARGOTextBox
            // 
            this.cARGOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fUNCIONARIOBindingSource, "CARGO", true));
            this.cARGOTextBox.Location = new System.Drawing.Point(82, 107);
            this.cARGOTextBox.Name = "cARGOTextBox";
            this.cARGOTextBox.Size = new System.Drawing.Size(171, 20);
            this.cARGOTextBox.TabIndex = 13;
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 162);
            this.Controls.Add(cARGOLabel);
            this.Controls.Add(this.cARGOTextBox);
            this.Controls.Add(sETORLabel);
            this.Controls.Add(this.sETORTextBox);
            this.Controls.Add(tELEFONELabel);
            this.Controls.Add(this.tELEFONETextBox);
            this.Controls.Add(eMAILLabel);
            this.Controls.Add(this.eMAILTextBox);
            this.Controls.Add(nOMELabel);
            this.Controls.Add(this.nOMETextBox);
            this.Controls.Add(this.fUNCIONARIOBindingNavigator);
            this.Name = "CRUD";
            this.Text = "Funcionarios";
            this.Load += new System.EventHandler(this.CRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOBindingNavigator)).EndInit();
            this.fUNCIONARIOBindingNavigator.ResumeLayout(false);
            this.fUNCIONARIOBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FuncionarioDataSet funcionarioDataSet;
        private System.Windows.Forms.BindingSource fUNCIONARIOBindingSource;
        private FuncionarioDataSetTableAdapters.FUNCIONARIOTableAdapter fUNCIONARIOTableAdapter;
        private FuncionarioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fUNCIONARIOBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton fUNCIONARIOBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nOMETextBox;
        private System.Windows.Forms.TextBox eMAILTextBox;
        private System.Windows.Forms.TextBox tELEFONETextBox;
        private System.Windows.Forms.TextBox sETORTextBox;
        private System.Windows.Forms.TextBox cARGOTextBox;
    }
}

