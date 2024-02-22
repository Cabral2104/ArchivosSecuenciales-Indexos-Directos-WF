using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosSecuenciales_Indexos_Directos_WF
{
    internal class SecuencialesFileManager
    {
        private List<string> registros = new List<string>();

        // Método para insertar un registro en el archivo secuencial
        public void InsertRecord(string recordData)
        {
            registros.Add(recordData);
        }

        // Método para buscar un registro en el archivo secuencial
        public string SearchRecord(string searchData)
        {
            foreach (string registro in registros)
            {
                if (registro == searchData)
                    return "Registro encontrado: " + registro;
            }
            return "Registro no encontrado";
        }
    }
}
