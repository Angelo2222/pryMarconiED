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
    public partial class frmBD : Form
    {
        public frmBD()
        {
            InitializeComponent();
        }
        clsBaseDatos ObjBD = new clsBaseDatos();
        String varSQL;

        private void btnProSimple_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT TITULO FROM LIBRO ORDER BY 1 DESC";
            ObjBD.Listar(dgvDatos, varSQL);
        }

        private void btnProMulti_Click(object sender, EventArgs e)
        {

        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT * FROM Libro, Idioma " +
                "WHERE Libro.IdIdioma = Idioma.IdIdioma";
            ObjBD.Listar(dgvDatos, varSQL);
        }

        private void btnSelecSimplee_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT * FROM Libro WHERE IdAutor = 2";
            ObjBD.Listar(dgvDatos, varSQL);
        }

        private void btnSelecMulti_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT * FROM Libro WHERE IdAutor > 10 " +
                "INTERSECT SELECT * FROM Libro WHERE IdIdioma > 5";
            ObjBD.Listar(dgvDatos, varSQL);
        }

        private void btnConvolucin_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT * FROM " +
                "(SELECT * FROM Libro AS T1 WHERE T1.IdIdioma > 5 ) " +
                "AS T2 WHERE T2.IdAutor > 10";
            ObjBD.Listar(dgvDatos, varSQL);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT * FROM libro WHERE IdAutor = 2 " +
               "UNION SELECT * FROM libro WHERE IdAutor = 5 " +
               "UNION SELECT * FROM libro WHERE IdAutor = 3";
            ObjBD.Listar(dgvDatos, varSQL);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT * FROM libro " +
                "WHERE idIdioma = 2 AND " +
                "idLibro in " +
                "(SELECT idLibro FROM libro WHERE IdPais = 3 ) " +
                "ORDER BY 1 ASC ";
            ObjBD.Listar(dgvDatos, varSQL);
        }

        private void btnDif_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT * FROM libro WHERE IdIdioma " +
               "NOT IN " +
               "(SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5 ) ";
            ObjBD.Listar(dgvDatos, varSQL);
        }
    }
}
