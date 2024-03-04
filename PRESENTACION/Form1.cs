using retoCRUD.DATOS;
using retoCRUD.ENTIDADES;
using retoCRUD.PRESENTACION.REPORTES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace retoCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region "VAR"
        //1 -- nuevo registro(guadar) , 2 -- actualizacion 
        int nEstadoGuardar = 0;//inicializamos 
        int vCodigo_cli = 0; // para saber que cliente es 
        #endregion

        #region "METODOS"
        private void LimpiarTexto()
        {
            Txt_dni.Text = "";
            Txt_nombre.Text = "";
            Txt_apellido.Text = "";
            Txt_telefono.Text = "";
            Txt_direccion.Text = "";
            Txt_buscar.Text = "";
            Cmb_grupo.Text = "";
            Cmb_doc.Text = "";
        }
        private void EstadoTexto(bool lEstado)
        {
            Txt_dni.Enabled = lEstado;
            Txt_nombre.Enabled = lEstado;
            Txt_apellido.Enabled = lEstado;
            Txt_telefono.Enabled = lEstado;
            Txt_direccion.Enabled = lEstado;
            Txt_buscar.Enabled = lEstado;
            Cmb_grupo.Enabled = lEstado;
            Cmb_doc.Enabled = lEstado;
        }
        private void EstadoBotones(bool lEstado)
        {
            btn_cancelar.Visible = !lEstado;
            btn_guardar.Visible = !lEstado;

            btn_nuevo.Enabled = lEstado;
            btn_actualizar.Enabled = lEstado;
            btn_eliminar.Enabled = lEstado;
            btn_reporte.Enabled = lEstado;
            btn_salir.Enabled = lEstado;

            btn_buscar.Enabled = lEstado;
            Txt_buscar.Enabled = lEstado;
            Dgv_lista_clientes.Enabled = lEstado;
        }
        private void Cargar_Doc()
        {
            Datos_clientes datos = new Datos_clientes();
            Cmb_doc.DataSource = datos.Lectura_Doc();
            Cmb_doc.ValueMember = "idDocSunat";
            Cmb_doc.DisplayMember = "tipodeDocumento";
        }
        private void Cargar_Grupo()
        {
            Datos_clientes datos = new Datos_clientes();
            Cmb_grupo.DataSource = datos.Lectura_Grupo();
            Cmb_grupo.ValueMember = "idGrupo";
            Cmb_grupo.DisplayMember = "descrGrupo";
        }
        private void Formato_cli()
        {
            Dgv_lista_clientes.Columns[0].Width = 30;
            Dgv_lista_clientes.Columns[0].HeaderText = "Id";

            Dgv_lista_clientes.Columns[1].Width = 80;
            Dgv_lista_clientes.Columns[1].HeaderText = "Dni";

            Dgv_lista_clientes.Columns[2].Width = 80;
            Dgv_lista_clientes.Columns[2].HeaderText = "Nombre";

            Dgv_lista_clientes.Columns[3].Width = 80;
            Dgv_lista_clientes.Columns[3].HeaderText = "Apellido";

            Dgv_lista_clientes.Columns[4].Width = 60;
            Dgv_lista_clientes.Columns[4].HeaderText = "Telefono";

            Dgv_lista_clientes.Columns[5].Width = 100;
            Dgv_lista_clientes.Columns[5].HeaderText = "Direccion";

            Dgv_lista_clientes.Columns[6].Width = 100;
            Dgv_lista_clientes.Columns[6].HeaderText = "Grupo";

            Dgv_lista_clientes.Columns[7].Width = 100;
            Dgv_lista_clientes.Columns[7].HeaderText = "Tipo de Documento";

            Dgv_lista_clientes.Columns[8].Visible = false;
            Dgv_lista_clientes.Columns[9].Visible = false;


        }
        private void Listado_cli(string cTexto)
        {
            Datos_clientes datos = new Datos_clientes();
            Dgv_lista_clientes.DataSource = datos.Lectura_cli(cTexto);
            this.Formato_cli();

        }
        private void Seleccion_item_cli()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_lista_clientes.CurrentRow.Cells["idCliente"].Value)))
            {//cuando no hay seleccion o clientes registrados
                MessageBox.Show("No hay informacion para visualizar",
                                            "Aviso del sistema",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Exclamation);
            }
            else
            {
                this.vCodigo_cli = Convert.ToInt32(Dgv_lista_clientes.CurrentRow.Cells["idCliente"].Value);
                Txt_dni.Text = Convert.ToString(Dgv_lista_clientes.CurrentRow.Cells["dni"].Value);
                Txt_nombre.Text = Convert.ToString(Dgv_lista_clientes.CurrentRow.Cells["nombre"].Value);
                Txt_apellido.Text = Convert.ToString(Dgv_lista_clientes.CurrentRow.Cells["apellido"].Value);
                Txt_telefono.Text = Convert.ToString(Dgv_lista_clientes.CurrentRow.Cells["telefono"].Value);
                Txt_direccion.Text = Convert.ToString(Dgv_lista_clientes.CurrentRow.Cells["direccion"].Value);
                Cmb_grupo.Text = Convert.ToString(Dgv_lista_clientes.CurrentRow.Cells["descrGrupo"].Value);
                Cmb_doc.Text = Convert.ToString(Dgv_lista_clientes.CurrentRow.Cells["tipodeDocumento"].Value);
            }
        }

        #endregion


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Cargar_Doc();
            this.Cargar_Grupo();
            this.Listado_cli("%");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            this.nEstadoGuardar = 1; //NUEVO REGISTRO
            this.vCodigo_cli = 0;
            this.LimpiarTexto();
            this.EstadoTexto(true);
            this.EstadoBotones(false);
            Txt_nombre.Select();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarTexto();
            this.EstadoTexto(false);
            this.EstadoBotones(true);
            
        }


        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            if (Txt_nombre.Text == string.Empty ||
                Txt_dni.Text == string.Empty ||
                Txt_telefono.Text == string.Empty ||
                Cmb_doc.Text == string.Empty ||
                Cmb_grupo.Text == string.Empty)
            {//condicionar que los textos esten llenados
                MessageBox.Show("Ingrese los datos en los campos requeridos (*)",
                                            "Aviso del sistema",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Exclamation);
            }
            else
            { //GUARDAR 
                string Rpta = "";

                E_clientes oProp = new E_clientes();
                oProp.IdCliente = this.vCodigo_cli;
                oProp.Dni = Convert.ToDecimal(Txt_dni.Text);
                oProp.Nombre = Txt_nombre.Text;
                oProp.Apellido = Txt_apellido.Text;
                oProp.Telefono = Convert.ToDecimal(Txt_telefono.Text);
                oProp.Direccion = Txt_direccion.Text;
                oProp.CodGrupo = Convert.ToInt32(Cmb_grupo.SelectedValue);
                oProp.CodDoc = Convert.ToInt32(Cmb_doc.SelectedValue);

                Datos_clientes datos = new Datos_clientes();

                Rpta = datos.Cr_Up_cli(nEstadoGuardar, oProp);
                if (Rpta == "OK")
                {
                    this.Listado_cli("%");
                    MessageBox.Show("Datos guardados",
                                            "Aviso del sistema",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                    this.vCodigo_cli = 0;
                    this.LimpiarTexto();
                    this.EstadoTexto(false);
                    this.EstadoBotones(true);
                }
            }
        }

        private void Dgv_lista_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Seleccion_item_cli();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            this.nEstadoGuardar = 2; //ACTUALIZAR
            this.EstadoTexto(true);
            this.EstadoBotones(false);
            Txt_nombre.Select();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_cli(Txt_buscar.Text);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (Dgv_lista_clientes.RowCount <= 0 ||
                string.IsNullOrEmpty(Convert.ToString(Dgv_lista_clientes.CurrentRow.Cells["idCliente"].Value)))
            {
                MessageBox.Show("No hay clientes registrados",
                                            "Aviso del sistema",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Exclamation);
            }
            else
            {//debe existir un registro sobre el proceso que llevo esa informacion, 
                string Rpta = "";
                Datos_clientes datos = new Datos_clientes();
                Rpta = datos.Del_activo_cli(vCodigo_cli, false);
                if (Rpta == "OK")
                {
                    this.Listado_cli("%");
                    this.LimpiarTexto();
                    vCodigo_cli = 0;
                    MessageBox.Show("Registro Eliminado",
                                            "Aviso del sistema",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                }
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            Form2_REPORTE_LIST_CLI oFrm_rpt =new Form2_REPORTE_LIST_CLI();
            oFrm_rpt.Txt_01.Text = Txt_buscar.Text;
            oFrm_rpt.ShowDialog();
        }
    }
}
