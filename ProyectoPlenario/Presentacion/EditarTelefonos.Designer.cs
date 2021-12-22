
namespace ProyectoPlenario.Presentacion
{
    partial class EditarTelefonos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMostraTLF = new System.Windows.Forms.TextBox();
            this.btnGuardarModificacionTelefono = new System.Windows.Forms.Button();
            this.txtModificarTlf = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPersonaID = new System.Windows.Forms.TextBox();
            this.txtTelefonoID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero a modificar";
            // 
            // txtMostraTLF
            // 
            this.txtMostraTLF.Location = new System.Drawing.Point(187, 45);
            this.txtMostraTLF.MaxLength = 50;
            this.txtMostraTLF.Name = "txtMostraTLF";
            this.txtMostraTLF.ReadOnly = true;
            this.txtMostraTLF.Size = new System.Drawing.Size(132, 20);
            this.txtMostraTLF.TabIndex = 1;
            // 
            // btnGuardarModificacionTelefono
            // 
            this.btnGuardarModificacionTelefono.Location = new System.Drawing.Point(223, 205);
            this.btnGuardarModificacionTelefono.Name = "btnGuardarModificacionTelefono";
            this.btnGuardarModificacionTelefono.Size = new System.Drawing.Size(85, 37);
            this.btnGuardarModificacionTelefono.TabIndex = 2;
            this.btnGuardarModificacionTelefono.Text = "Modificar";
            this.btnGuardarModificacionTelefono.UseVisualStyleBackColor = true;
            this.btnGuardarModificacionTelefono.Click += new System.EventHandler(this.btnGuardarModificacionTelefono_Click);
            // 
            // txtModificarTlf
            // 
            this.txtModificarTlf.Location = new System.Drawing.Point(187, 124);
            this.txtModificarTlf.MaxLength = 50;
            this.txtModificarTlf.Name = "txtModificarTlf";
            this.txtModificarTlf.Size = new System.Drawing.Size(132, 20);
            this.txtModificarTlf.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(53, 205);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 37);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Modificar numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "PersonaID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "TelefonoID";
            // 
            // txtPersonaID
            // 
            this.txtPersonaID.Location = new System.Drawing.Point(187, 71);
            this.txtPersonaID.MaxLength = 50;
            this.txtPersonaID.Name = "txtPersonaID";
            this.txtPersonaID.ReadOnly = true;
            this.txtPersonaID.Size = new System.Drawing.Size(132, 20);
            this.txtPersonaID.TabIndex = 1;
            // 
            // txtTelefonoID
            // 
            this.txtTelefonoID.Location = new System.Drawing.Point(187, 97);
            this.txtTelefonoID.MaxLength = 50;
            this.txtTelefonoID.Name = "txtTelefonoID";
            this.txtTelefonoID.ReadOnly = true;
            this.txtTelefonoID.Size = new System.Drawing.Size(132, 20);
            this.txtTelefonoID.TabIndex = 1;
            // 
            // EditarTelefonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 281);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarModificacionTelefono);
            this.Controls.Add(this.txtTelefonoID);
            this.Controls.Add(this.txtPersonaID);
            this.Controls.Add(this.txtModificarTlf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMostraTLF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditarTelefonos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EditarTelefonos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMostraTLF;
        private System.Windows.Forms.Button btnGuardarModificacionTelefono;
        private System.Windows.Forms.TextBox txtModificarTlf;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPersonaID;
        private System.Windows.Forms.TextBox txtTelefonoID;
    }
}