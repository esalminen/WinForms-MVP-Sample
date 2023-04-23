namespace MVP_RJCode.Views
{
    partial class ParcelView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelParcel = new System.Windows.Forms.Label();
            this.panelParcel = new System.Windows.Forms.Panel();
            this.tabControlParcel = new System.Windows.Forms.TabControl();
            this.tabPageList = new System.Windows.Forms.TabPage();
            this.dataGridViewParcels = new System.Windows.Forms.DataGridView();
            this.textBoxSeach = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.tabPageDetail = new System.Windows.Forms.TabPage();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxProductTypeName = new System.Windows.Forms.TextBox();
            this.textBoxProductTypeId = new System.Windows.Forms.TextBox();
            this.textBoxParcelId = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelProductTypeId = new System.Windows.Forms.Label();
            this.labelParcelId = new System.Windows.Forms.Label();
            this.labelProductTypeName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelParcel.SuspendLayout();
            this.tabControlParcel.SuspendLayout();
            this.tabPageList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParcels)).BeginInit();
            this.tabPageDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelParcel
            // 
            this.labelParcel.AutoSize = true;
            this.labelParcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParcel.Location = new System.Drawing.Point(12, 17);
            this.labelParcel.Name = "labelParcel";
            this.labelParcel.Size = new System.Drawing.Size(110, 25);
            this.labelParcel.TabIndex = 0;
            this.labelParcel.Text = "PARCELS";
            // 
            // panelParcel
            // 
            this.panelParcel.BackColor = System.Drawing.Color.White;
            this.panelParcel.Controls.Add(this.buttonClose);
            this.panelParcel.Controls.Add(this.labelParcel);
            this.panelParcel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelParcel.Location = new System.Drawing.Point(0, 0);
            this.panelParcel.Name = "panelParcel";
            this.panelParcel.Size = new System.Drawing.Size(800, 59);
            this.panelParcel.TabIndex = 1;
            // 
            // tabControlParcel
            // 
            this.tabControlParcel.Controls.Add(this.tabPageList);
            this.tabControlParcel.Controls.Add(this.tabPageDetail);
            this.tabControlParcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlParcel.Location = new System.Drawing.Point(0, 59);
            this.tabControlParcel.Name = "tabControlParcel";
            this.tabControlParcel.SelectedIndex = 0;
            this.tabControlParcel.Size = new System.Drawing.Size(800, 391);
            this.tabControlParcel.TabIndex = 0;
            // 
            // tabPageList
            // 
            this.tabPageList.Controls.Add(this.dataGridViewParcels);
            this.tabPageList.Controls.Add(this.textBoxSeach);
            this.tabPageList.Controls.Add(this.labelSearch);
            this.tabPageList.Controls.Add(this.buttonSearch);
            this.tabPageList.Controls.Add(this.buttonDelete);
            this.tabPageList.Controls.Add(this.buttonEdit);
            this.tabPageList.Controls.Add(this.buttonAddNew);
            this.tabPageList.Location = new System.Drawing.Point(4, 22);
            this.tabPageList.Name = "tabPageList";
            this.tabPageList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageList.Size = new System.Drawing.Size(792, 365);
            this.tabPageList.TabIndex = 0;
            this.tabPageList.Text = "Parcel list";
            this.tabPageList.UseVisualStyleBackColor = true;
            // 
            // dataGridViewParcels
            // 
            this.dataGridViewParcels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewParcels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewParcels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParcels.Location = new System.Drawing.Point(9, 49);
            this.dataGridViewParcels.Name = "dataGridViewParcels";
            this.dataGridViewParcels.Size = new System.Drawing.Size(680, 308);
            this.dataGridViewParcels.TabIndex = 6;
            // 
            // textBoxSeach
            // 
            this.textBoxSeach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSeach.Location = new System.Drawing.Point(9, 21);
            this.textBoxSeach.Name = "textBoxSeach";
            this.textBoxSeach.Size = new System.Drawing.Size(599, 20);
            this.textBoxSeach.TabIndex = 5;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(6, 6);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(76, 13);
            this.labelSearch.TabIndex = 4;
            this.labelSearch.Text = "Search parcel:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Location = new System.Drawing.Point(614, 19);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(709, 78);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Location = new System.Drawing.Point(709, 49);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddNew.Location = new System.Drawing.Point(709, 20);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNew.TabIndex = 0;
            this.buttonAddNew.Text = "Add new";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            // 
            // tabPageDetail
            // 
            this.tabPageDetail.Controls.Add(this.buttonCancel);
            this.tabPageDetail.Controls.Add(this.buttonSave);
            this.tabPageDetail.Controls.Add(this.textBoxProductTypeName);
            this.tabPageDetail.Controls.Add(this.textBoxProductTypeId);
            this.tabPageDetail.Controls.Add(this.textBoxParcelId);
            this.tabPageDetail.Controls.Add(this.textBoxAddress);
            this.tabPageDetail.Controls.Add(this.labelProductTypeId);
            this.tabPageDetail.Controls.Add(this.labelParcelId);
            this.tabPageDetail.Controls.Add(this.labelProductTypeName);
            this.tabPageDetail.Controls.Add(this.labelAddress);
            this.tabPageDetail.Location = new System.Drawing.Point(4, 22);
            this.tabPageDetail.Name = "tabPageDetail";
            this.tabPageDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetail.Size = new System.Drawing.Size(792, 365);
            this.tabPageDetail.TabIndex = 1;
            this.tabPageDetail.Text = "Parcel detail";
            this.tabPageDetail.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(184, 251);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(28, 251);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // textBoxProductTypeName
            // 
            this.textBoxProductTypeName.Location = new System.Drawing.Point(159, 169);
            this.textBoxProductTypeName.Name = "textBoxProductTypeName";
            this.textBoxProductTypeName.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductTypeName.TabIndex = 7;
            // 
            // textBoxProductTypeId
            // 
            this.textBoxProductTypeId.Location = new System.Drawing.Point(159, 126);
            this.textBoxProductTypeId.Name = "textBoxProductTypeId";
            this.textBoxProductTypeId.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductTypeId.TabIndex = 6;
            // 
            // textBoxParcelId
            // 
            this.textBoxParcelId.Location = new System.Drawing.Point(159, 79);
            this.textBoxParcelId.Name = "textBoxParcelId";
            this.textBoxParcelId.Size = new System.Drawing.Size(100, 20);
            this.textBoxParcelId.TabIndex = 5;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(159, 32);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress.TabIndex = 4;
            // 
            // labelProductTypeId
            // 
            this.labelProductTypeId.AutoSize = true;
            this.labelProductTypeId.Location = new System.Drawing.Point(25, 129);
            this.labelProductTypeId.Name = "labelProductTypeId";
            this.labelProductTypeId.Size = new System.Drawing.Size(88, 13);
            this.labelProductTypeId.TabIndex = 3;
            this.labelProductTypeId.Text = "Product Type ID:";
            // 
            // labelParcelId
            // 
            this.labelParcelId.AutoSize = true;
            this.labelParcelId.Location = new System.Drawing.Point(25, 82);
            this.labelParcelId.Name = "labelParcelId";
            this.labelParcelId.Size = new System.Drawing.Size(54, 13);
            this.labelParcelId.TabIndex = 2;
            this.labelParcelId.Text = "Parcel ID:";
            // 
            // labelProductTypeName
            // 
            this.labelProductTypeName.AutoSize = true;
            this.labelProductTypeName.Location = new System.Drawing.Point(25, 176);
            this.labelProductTypeName.Name = "labelProductTypeName";
            this.labelProductTypeName.Size = new System.Drawing.Size(105, 13);
            this.labelProductTypeName.TabIndex = 1;
            this.labelProductTypeName.Text = "Product Type Name:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(25, 35);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(48, 13);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Address:";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(713, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // ParcelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlParcel);
            this.Controls.Add(this.panelParcel);
            this.Name = "ParcelView";
            this.Text = "ParcelView";
            this.panelParcel.ResumeLayout(false);
            this.panelParcel.PerformLayout();
            this.tabControlParcel.ResumeLayout(false);
            this.tabPageList.ResumeLayout(false);
            this.tabPageList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParcels)).EndInit();
            this.tabPageDetail.ResumeLayout(false);
            this.tabPageDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelParcel;
        private System.Windows.Forms.Panel panelParcel;
        private System.Windows.Forms.TabControl tabControlParcel;
        private System.Windows.Forms.TabPage tabPageList;
        private System.Windows.Forms.TabPage tabPageDetail;
        private System.Windows.Forms.Label labelProductTypeId;
        private System.Windows.Forms.Label labelParcelId;
        private System.Windows.Forms.Label labelProductTypeName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxSeach;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxProductTypeName;
        private System.Windows.Forms.TextBox textBoxProductTypeId;
        private System.Windows.Forms.TextBox textBoxParcelId;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.DataGridView dataGridViewParcels;
        private System.Windows.Forms.Button buttonClose;
    }
}