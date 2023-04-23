using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVP_RJCode.Models;
using MVP_RJCode.Views;

namespace MVP_RJCode.Presenters
{
    public class ParcelPresenter
    {
        private IParcelView _view;
        private IParcelRepository _repository;
        private BindingSource _parcelsBindingSource;
        private IEnumerable<ParcelModel> _parcelList;

        public ParcelPresenter(IParcelView view, IParcelRepository repository)
        {
            _parcelsBindingSource = new BindingSource();
            _view = view;
            _repository = repository;

            _view.SearchEvent += SearchParcel;
            _view.AddNewEvent += AddNewParcel;
            _view.EditEvent += LoadSelectedParcelToEdit;
            _view.DeleteEvent += DeleteSelectedParcel;
            _view.SaveEvent += SaveParcel;
            _view.CancelEvent += CancelAction;

            _view.SetParcelListBindingSource(_parcelsBindingSource);

            LoadAllParcelList();

            _view.Show();

        }

        private void LoadAllParcelList()
        {
            _parcelList = _repository.GetAll();
            _parcelsBindingSource.DataSource = _parcelList;
        }
        private void SearchParcel(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(_view.SearchValue);
            if (!emptyValue)
            {
                _parcelList = _repository.GetByValue(_view.SearchValue);
            }
            else _parcelList = _repository.GetAll();
            _parcelsBindingSource.DataSource = _parcelList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveParcel(object sender, EventArgs e)
        {
            var model = new ParcelModel();
            model.Address = _view.Address;
            model.ParcelId = _view.ParcelId;
            model.ProductTypeId = _view.ProductTypeId;
            model.ProductTypeName = _view.ProductTypeName;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (_view.IsEdit)
                {
                    _repository.Edit(model);
                    _view.Message = "Parcel edited succesfully";
                }
                else
                {
                    _repository.Add(model);
                    _view.Message = "Parcel added succesfully";
                }
                _view.IsSuccesful = true;
                LoadAllParcelList();
                CleanViewFields();
            }
            catch (Exception ex)
            {

                _view.IsSuccesful = false;
                _view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            _view.Address = string.Empty;
            _view.ParcelId = string.Empty;
            _view.ProductTypeId = string.Empty;
            _view.ProductTypeName = string.Empty;
        }

        private void DeleteSelectedParcel(object sender, EventArgs e)
        {
            try
            {
                var parcel = (ParcelModel)_parcelsBindingSource.Current;
                _repository.Delete(parcel.ParcelId);
                _view.IsSuccesful = true;
                _view.Message = "Parcel deleted succesfully";
                LoadAllParcelList();
            }
            catch (Exception ex)
            {
                _view.IsSuccesful= false;
                _view.Message = ex.Message;
            }
        }

        private void LoadSelectedParcelToEdit(object sender, EventArgs e)
        {
            var parcel = (ParcelModel)_parcelsBindingSource.Current;
            _view.Address = parcel.Address;
            _view.ParcelId = parcel.ParcelId;
            _view.ProductTypeId = parcel.ProductTypeId;
            _view.ProductTypeName = parcel.ProductTypeName;
            _view.IsEdit = true;
        }

        private void AddNewParcel(object sender, EventArgs e)
        {
            _view.IsEdit = false;
        }

    }
}
