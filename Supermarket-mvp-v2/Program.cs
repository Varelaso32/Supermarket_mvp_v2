using System;
using Supermarket_mvp_v2._Repositories;
using Supermarket_mvp_v2.Models;
using Supermarket_mvp_v2.Presenters;
using Supermarket_mvp_v2.Properties;
using Supermarket_mvp_v2.Views;

namespace Supermarket_mvp_v2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string sqlConnectionString = Settings.Default.SqlConnection;
            IPayModeView view = new PayModeView();
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);

            Application.Run((Form)view);
        }
    }
}