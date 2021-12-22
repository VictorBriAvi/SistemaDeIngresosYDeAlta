using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPlenario.Models;

namespace ProyectoPlenario.Presentacion
{
    public partial class FrmAgregarClientes : Form

    {
        public int? id;

        Personas oPersonas = null;
        public FrmAgregarClientes(int? id = null)
        {
            InitializeComponent();
            this.id = id;

            if (id != null)
            {
                actualizarDatos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void FrmAgregar_Load(object sender, EventArgs e)
        {

        }

        private void actualizarDatos()
        {
            using (DBPlenarioEntities db = new DBPlenarioEntities())
            {


                oPersonas = db.Personas.Find(id);

                txtNombre.Text = oPersonas.Nombre;
                dateTimePicker1.Value = oPersonas.FechaNacimiento;
                txtCreditoMaximo.Text = oPersonas.CreditoMaximo.ToString();

            }
        }

        private void agregar()
        {
            using (DBPlenarioEntities db = new DBPlenarioEntities())
            {

                if (id == null) 
                {
                    oPersonas = new Personas();
                }
                oPersonas.Nombre = txtNombre.Text;
                oPersonas.FechaNacimiento = dateTimePicker1.Value;
                oPersonas.CreditoMaximo = Convert.ToDecimal(txtCreditoMaximo.Text);


                if (id == null)
                {
                    db.Personas.Add(oPersonas);
                }
                else
                {
                    db.Entry(oPersonas).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            agregar();
        }
    }
}
