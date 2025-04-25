using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect_Restaurante.ServicesInterfaces
{
    public interface InterfacesMesas
    {
        void AddTable();
        void ShowTable();
        void ModifyTable(int id);
        void DeliteTable(int id);

    }
}
