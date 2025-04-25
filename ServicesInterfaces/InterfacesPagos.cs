using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect_Restaurante.Services
{
    public interface InterfacesPagos
    {
        void AddPay();
        void ShowPay();
        void ModifyPay(int id);
        void DelitePay(int id);

    }
}
