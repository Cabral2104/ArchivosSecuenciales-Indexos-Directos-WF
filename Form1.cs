using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ArchivosSecuenciales_Indexos_Directos_WF
{
    public partial class Form1 : Form
    {
        private SecuencialesFileManager secuencialesFileManager;
        private SecuencialesIndexadosFileManager secuencialesIndexadosFileManager;
        private AccesoDirectoFileManager accesoDirectoFileManager;

        public Form1()
        {
            InitializeComponent();

            // Inicializar las instancias de las clases de gestión de archivos
            secuencialesFileManager = new SecuencialesFileManager();
            secuencialesIndexadosFileManager = new SecuencialesIndexadosFileManager();
            accesoDirectoFileManager = new AccesoDirectoFileManager();
        }

        private void btnSecuencialesInsert_Click_1(object sender, EventArgs e)
        {
            string recordData = txtSecuencialesData.Text;
            secuencialesFileManager.InsertRecord(recordData);
            MessageBox.Show("Registro insertado en archivo secuencial.");
        }

        private void btnSecuencialesSearch_Click_1(object sender, EventArgs e)
        {
            string searchData = txtSecuencialesSearch.Text;
            string result = secuencialesFileManager.SearchRecord(searchData);
            MessageBox.Show(result);
        }

        private void btnSecuencialesIndexadosSearch_Click_1(object sender, EventArgs e)
        {
            string key = txtSecuencialesIndexadosSearch.Text;
            string result = secuencialesIndexadosFileManager.SearchRecordUsingIndex(key);
            MessageBox.Show(result);
        }

        private void btnAccesoDirectoSearch_Click_1(object sender, EventArgs e)
        {
            int position;
            if (int.TryParse(txtAccesoDirectoPosition.Text, out position))
            {
                string result = accesoDirectoFileManager.SearchRecordByPosition(position);
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una posición válida.");
            }
        }

        private void btnAccesoDirectoDelete_Click_1(object sender, EventArgs e)
        {
            int position;
            if (int.TryParse(txtAccesoDirectoPosition.Text, out position))
            {
                accesoDirectoFileManager.DeleteRecordAtPosition(position);
                MessageBox.Show("Registro eliminado en posición especificada en acceso directo.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una posición válida.");
            }
        }

        private void btnAccesoDirectoInsert_Click_1(object sender, EventArgs e)
        {
            string recordData = txtAccesoDirectoData.Text;
            int position;
            if (int.TryParse(txtAccesoDirectoPosition.Text, out position))
            {
                accesoDirectoFileManager.InsertRecordAtPosition(recordData, position);
                MessageBox.Show("Registro insertado en posición especificada en acceso directo.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una posición válida.");
            }
        }
    }
}
