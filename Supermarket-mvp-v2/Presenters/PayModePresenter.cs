using Supermarket_mvp_v2.Models;
using Supermarket_mvp_v2.Views;
using Supermarketmvp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp_v2.Presenters
{
    internal class PayModePresenter
    {
        private IPayModeView view;
        private IPayModeRepository repository;
        private BindingSource payModeBindingSource;
        private IEnumerable<PayModeModel> payModeList;

        public PayModePresenter(IPayModeView view, IPayModeRepository repository)
        {
            this.payModeBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchPayMode;
            this.view.AddNewEvent += AddNewPayMode;
            this.view.EditEvent += LoadSelectPayModeToEdit;
            this.view.DeletEvent += DeleteSelectedPayMode;
            this.view.SaveEvent += SavePayMode;
            this.view.CancelEvent += CancelAction;

            this.view.SetPayModeListBildingSource(payModeBindingSource);

            loadAllPayModeList();

            this.view.Show();

        }//Fin de la clase

        private void loadAllPayModeList()
        {
            payModeList = repository.GetAll();
            payModeBindingSource.DataSource = payModeList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            throw new NotImplementedException();

        }//Fin de la clase

        private void SavePayMode(object sender, EventArgs e)
        {
            throw new NotImplementedException();

        }//Fin de la clase

        private void DeleteSelectedPayMode(object sender, EventArgs e)
        {
            throw new NotImplementedException();

        }//Fin de la clase

        private void LoadSelectPayModeToEdit(object sender, EventArgs e)
        {
            throw new NotImplementedException();

        }//Fin de la clase

        private void AddNewPayMode(object sender, EventArgs e)
        {
            throw new NotImplementedException();

        }//Fin de la clase

        private void SearchPayMode(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                payModeList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                payModeList = repository.GetAll();
            }
            payModeBindingSource.DataSource = payModeList;

        }//Fin de la clase

    }//Fin de la clase

}
