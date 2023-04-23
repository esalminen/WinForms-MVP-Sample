using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_RJCode.Views
{
    public interface IParcelView
    {
        string Address { get; set; }
        string ParcelId { get; set; }
        string ProductTypeId { get; set; }
        string ProductTypeName { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccesful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetParcelListBindingSource(BindingSource parcelList);
        void Show();
    }
}
