﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp_v2.Views
{
    internal interface IMainView
    {
        event EventHandler ShowPayModeView;
        event EventHandler ShowProductsView;
        event EventHandler ShowCustomersView;
        event EventHandler ShowCategoriesView;
    }
}
