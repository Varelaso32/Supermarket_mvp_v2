using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp_v2.Models
{
    internal interface IProductsRepository
    {
        void Add(ProductsModels productModel);
        void Edit(ProductsModels productModel);
        void Delete(int id);
        IEnumerable<ProductsModels> GetAll();
        IEnumerable<ProductsModels> GetByCategory(string value);

    } // Fin de la interfaz
}
