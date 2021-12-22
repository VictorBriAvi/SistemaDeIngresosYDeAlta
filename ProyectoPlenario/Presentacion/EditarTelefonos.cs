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
    public partial class EditarTelefonos : Form
    {
        public int? id;

        Telefonos oTelefonos = null;


        public EditarTelefonos(int? id = null)
        {
            InitializeComponent();
            this.id = id;

            if (id != null)
            {
                ActualizarDatosModificar();
            }
        }

        private void ActualizarDatosModificar()
        {
            using (DBPlenarioEntities db = new DBPlenarioEntities())
            {
                oTelefonos = db.Telefonos.Find(id);
                txtMostraTLF.Text = oTelefonos.Telefono;
                txtPersonaID.Text = oTelefonos.PersonaID.ToString();
                txtTelefonoID.Text = oTelefonos.TelefonoID.ToString();

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditarTelefonos_Load(object sender, EventArgs e)
        {
            ActualizarDatosModificar();
        }

        private void modificarTLF()
        {

            //MODIFICAR TELEFONO DE LA Personas

            using (DBPlenarioEntities db = new DBPlenarioEntities())
            {
 
                if (id == null)
                {
                    oTelefonos = new Telefonos();

                }

                oTelefonos.Telefono = txtModificarTlf.Text;

                if (id == null)
                {
                    db.Telefonos.Add(oTelefonos);

                }
                else
                {
                    db.Entry(oTelefonos).State = System.Data.Entity.EntityState.Modified;

                }

                db.SaveChanges();

                this.Close();





            }
        }

        private void btnGuardarModificacionTelefono_Click(object sender, EventArgs e)
        {
            modificarTLF();
        }
    }
}



