using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosSecuenciales_Indexos_Directos_WF
{
    internal class AccesoDirectoFileManager
    {
        private List<string> registros = new List<string>();

        // Método para buscar un registro directamente por su posición
        public string SearchRecordByPosition(int position)
        {
            if (position >= 0 && position < registros.Count)
                return "Registro encontrado: " + registros[position];
            else
                return "Registro no encontrado";
        }

        // Método para insertar un registro en una posición específica
        public void InsertRecordAtPosition(string recordData, int position)
        {
            if (position >= 0 && position <= registros.Count)
                registros.Insert(position, recordData);
        }

        // Método para eliminar un registro en una posición específica
        public void DeleteRecordAtPosition(int position)
        {
            if (position >= 0 && position < registros.Count)
                registros.RemoveAt(position);
        }
    }
}
