using Supermarket_mvp_v2._Repositories;
using Supermarket_mvp_v2.Models;
using Supermarket_mvp_v2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp_v2.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowPayModeView += ShowPayModeView;
            this.mainView.ShowProductsView += ShowProductsView;
            this.mainView.ShowCustomersView += ShowCustomersView;
            this.mainView.ShowCategoriesView += ShowCategoriesView;
        }

        private void ShowPayModeView(object? sender, EventArgs e)
        {
            IPayModeView view = PayModeView.GetInstance((MainView)mainView);
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);

        }
        private void ShowProductsView(object? sender, EventArgs e)
        {
            IProductsView view = ProductsView.GetInstance((MainView)mainView);
            IProductsRepository repository = new ProductsRepository(sqlConnectionString);
            new ProductsPresenter(view, repository);
        }

        private void ShowCustomersView(object? sender, EventArgs e)
        {
            ICustomersView view = CustomersView.GetInstance((MainView)mainView);
            ICustomersRepository repository = new CustomersRepository(sqlConnectionString);
            new CustomersPresenter(view, repository);
        }

        private void ShowCategoriesView(object? sender, EventArgs e)
        {
            ICategoriesView view = CategoriesView.GetInstance((MainView)mainView);
            ICategoriesRepository repository = new CategoriesRepository(sqlConnectionString);
            new CategoriesPresenter(view, repository);
        }
    }
}
