using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp_v2.Models
{
    internal interface ICustomersRepository
    {
        void Add(CustomersModel customerModel);
        void Edit(CustomersModel customerModel);
        void Delete(int id);
        IEnumerable<CustomersModel> GetAll();

        IEnumerable<CustomersModel> GetByValue(string value);


    } // Fin de la interfaz

}
