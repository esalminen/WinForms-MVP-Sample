using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_RJCode.Views
{
    public partial class ParcelView : Form, IParcelView
    {
        private string _message;
        private bool _isSuccesful;
        private bool _isEdit;

        public ParcelView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControlParcel.TabPages.Remove(tabPageDetail);
        }

        private void AssociateAndRaiseViewEvents()
        {
            buttonSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            buttonClose.Click += delegate { Close(); };
            textBoxSeach.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            buttonAddNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControlParcel.TabPages.Remove(tabPageList);
                tabControlParcel.TabPages.Add(tabPageDetail);
                tabPageDetail.Text = "Add new parcel";
            };

            buttonEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControlParcel.TabPages.Remove(tabPageList);
                tabControlParcel.TabPages.Add(tabPageDetail);
                tabPageDetail.Text = "Edit parcel";
            };

            buttonSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccesful)
                {
                    tabControlParcel.TabPages.Remove(tabPageDetail);
                    tabControlParcel.TabPages.Add(tabPageList);
                }
                MessageBox.Show(Message);
            };

            buttonCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControlParcel.TabPages.Remove(tabPageDetail);
                tabControlParcel.TabPages.Add(tabPageList);
            };

            buttonDelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected parcel?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        public string Address { get => textBoxAddress.Text; set => textBoxAddress.Text = value; }
        public string ParcelId { get => textBoxParcelId.Text; set => textBoxParcelId.Text = value; }
        public string ProductTypeId { get => textBoxProductTypeId.Text; set => textBoxProductTypeId.Text = value; }
        public string ProductTypeName { get => textBoxProductTypeName.Text; set => textBoxProductTypeName.Text = value; }
        public string SearchValue { get => textBoxSeach.Text; set => textBoxSeach.Text = value; }
        public bool IsEdit { get => _isEdit; set => _isEdit = value; }
        public bool IsSuccesful { get => _isSuccesful; set => _isSuccesful = value; }
        public string Message { get => _message; set => _message = value; }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler CloseEvent;

        public void SetParcelListBindingSource(BindingSource parcelList)
        {
            dataGridViewParcels.DataSource = parcelList;
        }

        // Singleton pattern. Only one instance is allowed
        private static ParcelView instance;
        public static ParcelView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ParcelView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
    }
}
