using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace retoCRUD.PRESENTACION.REPORTES
{
    public partial class Form2_REPORTE_LIST_CLI : Form
    {
        public Form2_REPORTE_LIST_CLI()
        {
            InitializeComponent();
        }

        private void Form2_REPORTE_LIST_CLI_Load(object sender, EventArgs e)
        {
            this.sP_LECTURA_CLIENTETableAdapter.Fill(this.dS_Reportes.SP_LECTURA_CLIENTE,cTexto:Txt_01.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
