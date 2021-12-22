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
    public partial class TablaTelefonos : Form


    {

        public int? id;
        public int? segundoID;




        public TablaTelefonos(int? id = null)
        {
            InitializeComponent();
            this.id = id;


            if (id != null)
            {
                actualizarDatosTelefono();
            }
        }

        private void actualizarDatosTelefono()
        {
            using (DBPlenarioEntities db = new DBPlenarioEntities())
            {

                Personas oPersonas = db.Personas.Find(id);
                txtNombrePersonaTlf.Text = oPersonas.Nombre;

            }
        }

        #region OBTENER EL ID

        private int? obtenerTelefonosID()
        {
            try
            {
                return int.Parse(dataGridTlf.Rows[dataGridTlf.CurrentRow.Index].Cells[0].Value.ToString());

            }
            catch
            {

                return null;
            }
        }

        private int? ObtenerPersonasID()
        {

            try
            {
                return int.Parse(dataGridTlf.Rows[dataGridTlf.CurrentRow.Index].Cells[1].Value.ToString());
            }
            catch
            {
                return null;

            }
        }

        //}

        #endregion

        private void agregarTelefono()
        {
            using (DBPlenarioEntities db = new DBPlenarioEntities())
            {
                Personas oPersonas = db.Personas.Find(id);
                Telefonos oTelefonos = new Telefonos();
                oTelefonos.PersonaID = oPersonas.PersonaID;
                oTelefonos.Telefono = txtAgregarTLF.Text;

                db.Telefonos.Add(oTelefonos);
                db.SaveChanges();
                refrescarTablaTlf();

            }

        }

        private void AgregarTelefonos_Load(object sender, EventArgs e)
        {
            //Refrescar tabla
            refrescarTablaTlf();
        }

        private void refrescarTablaTlf()
        {

            using (DBPlenarioEntities db = new DBPlenarioEntities())
            {
                Personas oPersonas = db.Personas.Find(id);
                Telefonos oTelefonos = db.Telefonos.Find(id);

                    var lista = from d in db.Telefonos
                                select d;

                    dataGridTlf.DataSource = lista.ToList();

                    this.dataGridTlf.Columns["Personas"].Visible = false;






            }







        }
        private void btnBorrarTlf_Click(object sender, EventArgs e)
        {
            int? id = obtenerTelefonosID();
            if (id != null)
            {



                using (DBPlenarioEntities db = new DBPlenarioEntities())
                {
                    Telefonos oTelefonos = db.Telefonos.Find(id);


                    db.Telefonos.Remove(oTelefonos);
                    db.SaveChanges();
                    refrescarTablaTlf();
                }






            }


        }

        private void btnAgregarTlf_Click(object sender, EventArgs e)
        {
            agregarTelefono();
        }

        private void btnEditarTlf_Click(object sender, EventArgs e)
        {
            int? segundoID = obtenerTelefonosID();
            if (segundoID != null)
            {
                Presentacion.EditarTelefonos oEditarTelefonos = new Presentacion.EditarTelefonos(segundoID);
                oEditarTelefonos.ShowDialog();


            }
        }

        private void dataGridTlf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
