using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect_Restaurante.ServicesInterfaces
{
    public interface InterfacesOrdenes
    {
        void AddOrder();
        void ShowOrder();
        void ModifyOrder(int id);
        void DeliteOrder(int id);

    }
}
