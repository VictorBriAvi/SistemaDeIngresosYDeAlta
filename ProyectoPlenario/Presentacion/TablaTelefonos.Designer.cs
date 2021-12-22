
namespace ProyectoPlenario.Presentacion
{
    partial class TablaTelefonos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtAgregarTLF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombrePersonaTlf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBorrarTlf = new System.Windows.Forms.Button();
            this.btnEditarTlf = new System.Windows.Forms.Button();
            this.btnAgregarTlf = new System.Windows.Forms.Button();
            this.dataGridTlf = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTlf)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtAgregarTLF);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtNombrePersonaTlf);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnBorrarTlf);
            this.splitContainer1.Panel1.Controls.Add(this.btnEditarTlf);
            this.splitContainer1.Panel1.Controls.Add(this.btnAgregarTlf);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridTlf);
            this.splitContainer1.Size = new System.Drawing.Size(658, 440);
            this.splitContainer1.SplitterDistance = 291;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtAgregarTLF
            // 
            this.txtAgregarTLF.Location = new System.Drawing.Point(126, 111);
            this.txtAgregarTLF.Name = "txtAgregarTLF";
            this.txtAgregarTLF.Size = new System.Drawing.Size(135, 20);
            this.txtAgregarTLF.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Agregar Telefono";
            // 
            // txtNombrePersonaTlf
            // 
            this.txtNombrePersonaTlf.Location = new System.Drawing.Point(63, 51);
            this.txtNombrePersonaTlf.Name = "txtNombrePersonaTlf";
            this.txtNombrePersonaTlf.ReadOnly = true;
            this.txtNombrePersonaTlf.Size = new System.Drawing.Size(140, 20);
            this.txtNombrePersonaTlf.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del cliente";
            // 
            // btnBorrarTlf
            // 
            this.btnBorrarTlf.Location = new System.Drawing.Point(12, 347);
            this.btnBorrarTlf.Name = "btnBorrarTlf";
            this.btnBorrarTlf.Size = new System.Drawing.Size(118, 46);
            this.btnBorrarTlf.TabIndex = 0;
            this.btnBorrarTlf.Text = "Borrar Telefono";
            this.btnBorrarTlf.UseVisualStyleBackColor = true;
            this.btnBorrarTlf.Click += new System.EventHandler(this.btnBorrarTlf_Click);
            // 
            // btnEditarTlf
            // 
            this.btnEditarTlf.Location = new System.Drawing.Point(136, 347);
            this.btnEditarTlf.Name = "btnEditarTlf";
            this.btnEditarTlf.Size = new System.Drawing.Size(131, 46);
            this.btnEditarTlf.TabIndex = 0;
            this.btnEditarTlf.Text = "Editar Telefono";
            this.btnEditarTlf.UseVisualStyleBackColor = true;
            this.btnEditarTlf.Click += new System.EventHandler(this.btnEditarTlf_Click);
            // 
            // btnAgregarTlf
            // 
            this.btnAgregarTlf.Location = new System.Drawing.Point(126, 146);
            this.btnAgregarTlf.Name = "btnAgregarTlf";
            this.btnAgregarTlf.Size = new System.Drawing.Size(135, 41);
            this.btnAgregarTlf.TabIndex = 0;
            this.btnAgregarTlf.Text = "Agregar Telefono";
            this.btnAgregarTlf.UseVisualStyleBackColor = true;
            this.btnAgregarTlf.Click += new System.EventHandler(this.btnAgregarTlf_Click);
            // 
            // dataGridTlf
            // 
            this.dataGridTlf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTlf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTlf.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridTlf.Location = new System.Drawing.Point(0, 0);
            this.dataGridTlf.Name = "dataGridTlf";
            this.dataGridTlf.ReadOnly = true;
            this.dataGridTlf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTlf.Size = new System.Drawing.Size(363, 440);
            this.dataGridTlf.TabIndex = 0;
            this.dataGridTlf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTlf_CellContentClick);
            // 
            // TablaTelefonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 440);
            this.Controls.Add(this.splitContainer1);
            this.Name = "TablaTelefonos";
            this.Text = "AgregarTelefonos";
            this.Load += new System.EventHandler(this.AgregarTelefonos_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTlf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAgregarTlf;
        private System.Windows.Forms.DataGridView dataGridTlf;
        private System.Windows.Forms.TextBox txtNombrePersonaTlf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBorrarTlf;
        private System.Windows.Forms.Button btnEditarTlf;
        private System.Windows.Forms.TextBox txtAgregarTLF;
        private System.Windows.Forms.Label label2;
    }
}