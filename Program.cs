using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVP_RJCode.Models;
using MVP_RJCode.Views;
using MVP_RJCode.Presenters;
using MVP_RJCode._Repositories;
using System.Configuration;

namespace MVP_RJCode
{
    internal static class Program
    {
        //https://www.youtube.com/watch?v=WSBy_Ypgk38
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string connectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            IMainView view = new MainView();
            new MainPresenter(view, connectionString);
            Application.Run((Form)view);
        }
    }
}
