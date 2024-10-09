﻿using Supermarket_mvp_v2._Repositories;
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
    }
}
