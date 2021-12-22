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
using ProyectoPlenario.Presentacion;

namespace ProyectoPlenario
{
    public partial class Form1 : Form
    {

        public int? id;

        public Form1()
        {
            InitializeComponent();


        }

        #region Obtene el id

        private int? obtenerID()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());

            }
            catch
            {

                return null;
            }
        }



        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Presentacion.FrmAgregarClientes oFrmAgregar = new Presentacion.FrmAgregarClientes();
            oFrmAgregar.ShowDialog();

            refrescarTabla();
        }



        private void refrescarTabla()
        {
            using (DBPlenarioEntities db = new DBPlenarioEntities())
            {
                var lista = from d in db.Personas
                            select d;
                dataGridView1.DataSource = lista.ToList();
                //this.dataGridView1.Columns["PersonaID"].Visible = false;

                this.dataGridView1.Columns["Telefonos"].Visible = false;


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refrescarTabla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            int? id = obtenerID();
            if (id != null)
            {
                Presentacion.FrmAgregarClientes oFrmAgregar = new Presentacion.FrmAgregarClientes(id);
                oFrmAgregar.ShowDialog();
                refrescarTabla();

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = obtenerID();
            if (id != null)
            {
                using (DBPlenarioEntities db = new DBPlenarioEntities())
                {
                    Personas oPersonas = db.Personas.Find(id);


                    db.Personas.Remove(oPersonas);
                    db.SaveChanges();
                    refrescarTabla();
                }

            }
            
        }

        private void btnTelefonos_Click(object sender, EventArgs e)
        {


            int? id = obtenerID();
            if (id != null)
            {
                Presentacion.TablaTelefonos oAgregarTelefonos = new Presentacion.TablaTelefonos(id);
                oAgregarTelefonos.ShowDialog();
                refrescarTabla();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
