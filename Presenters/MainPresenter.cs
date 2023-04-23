using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVP_RJCode.Views;
using MVP_RJCode.Models;
using MVP_RJCode._Repositories;

namespace MVP_RJCode.Presenters
{
    internal class MainPresenter
    {
        private IMainView _mainView;
        private readonly string _sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            _mainView = mainView;
            _sqlConnectionString = sqlConnectionString;
            _mainView.ShowParcelView += ShowParcelView;
        }

        private void ShowParcelView(object sender, EventArgs e)
        {
            IParcelView view = ParcelView.GetInstance((MainView)_mainView);
            IParcelRepository repository = new ParcelRepository(_sqlConnectionString);
            new ParcelPresenter(view, repository);
        }
    }
}
