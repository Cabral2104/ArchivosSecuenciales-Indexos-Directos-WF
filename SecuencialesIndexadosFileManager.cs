using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosSecuenciales_Indexos_Directos_WF
{
    internal class SecuencialesIndexadosFileManager
    {
        private Dictionary<string, string> indice = new Dictionary<string, string>();

        // Método para crear un índice
        public void CreateIndex(List<string> registros)
        {
            foreach (string registro in registros)
            {
                // Suponemos que la clave del índice es el primer carácter del registro
                string key = registro.Substring(0, 1);
                if (!indice.ContainsKey(key))
                    indice.Add(key, registro);
            }
     
        }
        // Método para buscar un registro utilizando el índice
        public string SearchRecordUsingIndex(string key)
        {
            if (indice.ContainsKey(key))
                return "Registro encontrado: " + indice[key];
            else
                return "Registro no encontrado";
        }
    }
}
