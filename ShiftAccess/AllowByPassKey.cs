using Microsoft.Office.Interop.Access.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShiftAccess
{
    public class AllowByPassKey : IDisposable
    {
        private string _caminho;
        private bool _valor;
        private Database _db;

        public AllowByPassKey(string caminho, bool valor)
        {
            _caminho = caminho;
            _valor = valor;
            Executar();
        }

        private void Executar()
        { 
            var dbe = new DBEngine();
            _db = dbe.OpenDatabase(_caminho);

            if (hasProperty(_db, "AllowByPassKey"))
                _db.Properties.Delete("AllowByPassKey");

            var prop = _db.CreateProperty("AllowByPassKey", 1, _valor);
            _db.Properties.Append(prop);
        }

        private static bool hasProperty(Database db, string nome)
        {
            foreach (dynamic property in db.Properties)
            {
                if (property.Name == "AllowByPassKey")
                    return true;
            }

            return false;
        }

        public void Dispose()
        {
            if (_db != null)
                _db.Close();
        }
    }
}
