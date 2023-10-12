using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMarconiEDpresentacion
{
    public partial class frmRepaso : Form
    {
        public frmRepaso()
        {
            InitializeComponent();
        }
        clsBaseDatos objBD = new clsBaseDatos();
        private void btnListar_Click(object sender, EventArgs e)
        {
            String VarSQ1 = "SELECT * FROM LIBRO";
            switch (cmbListar.SelectedIndex)
            {
                case 0:
                    lblEnunciado.Text = cmbListar.Text + ":" + "Paises que no tienen libros";

                    VarSQ1 = "select * from pais where" + "idpais not in" + "(select idpais from libro)";
                    break;
                    case 1:



                    break;
            }
            objBD.Listar(dgvListar, VarSQ1);
        }

        private void frmRepaso_Load(object sender, EventArgs e)
        {
            cmbListar.SelectedIndex = 0;
        }
    }
}
