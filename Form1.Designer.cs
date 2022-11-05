namespace MenuContextualEnWindowsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblid = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblautor = new System.Windows.Forms.Label();
            this.lblidvalue = new System.Windows.Forms.Label();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.txtautor = new System.Windows.Forms.TextBox();
            this.cbxespublico = new System.Windows.Forms.CheckBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgvdatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(12, 9);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(74, 15);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "Identificador";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(133, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(37, 15);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "Titulo";
            // 
            // lblautor
            // 
            this.lblautor.AutoSize = true;
            this.lblautor.Location = new System.Drawing.Point(271, 9);
            this.lblautor.Name = "lblautor";
            this.lblautor.Size = new System.Drawing.Size(37, 15);
            this.lblautor.TabIndex = 2;
            this.lblautor.Text = "Autor";
            // 
            // lblidvalue
            // 
            this.lblidvalue.AutoSize = true;
            this.lblidvalue.Location = new System.Drawing.Point(12, 38);
            this.lblidvalue.Name = "lblidvalue";
            this.lblidvalue.Size = new System.Drawing.Size(0, 15);
            this.lblidvalue.TabIndex = 3;
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(118, 35);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(130, 23);
            this.txttitulo.TabIndex = 4;
            // 
            // txtautor
            // 
            this.txtautor.Location = new System.Drawing.Point(271, 35);
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(130, 23);
            this.txtautor.TabIndex = 5;
            // 
            // cbxespublico
            // 
            this.cbxespublico.AutoSize = true;
            this.cbxespublico.Checked = true;
            this.cbxespublico.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxespublico.Location = new System.Drawing.Point(434, 40);
            this.cbxespublico.Name = "cbxespublico";
            this.cbxespublico.Size = new System.Drawing.Size(80, 19);
            this.cbxespublico.TabIndex = 6;
            this.cbxespublico.Text = "Es publico";
            this.cbxespublico.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(540, 37);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "Guardar";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgvdatos
            // 
            this.dgvdatos.AllowUserToAddRows = false;
            this.dgvdatos.AllowUserToDeleteRows = false;
            this.dgvdatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatos.Location = new System.Drawing.Point(12, 74);
            this.dgvdatos.MultiSelect = false;
            this.dgvdatos.Name = "dgvdatos";
            this.dgvdatos.ReadOnly = true;
            this.dgvdatos.RowTemplate.Height = 25;
            this.dgvdatos.ShowCellToolTips = false;
            this.dgvdatos.ShowEditingIcon = false;
            this.dgvdatos.Size = new System.Drawing.Size(603, 242);
            this.dgvdatos.TabIndex = 8;
            this.dgvdatos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvdatos_CellMouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 328);
            this.Controls.Add(this.dgvdatos);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cbxespublico);
            this.Controls.Add(this.txtautor);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.lblidvalue);
            this.Controls.Add(this.lblautor);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.lblid);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblid;
        private Label lbltitulo;
        private Label lblautor;
        private Label lblidvalue;
        private TextBox txttitulo;
        private TextBox txtautor;
        private CheckBox cbxespublico;
        private Button btnadd;
        private DataGridView dgvdatos;
    }
}