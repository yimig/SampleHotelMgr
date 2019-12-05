namespace HotelMgr2017101999
{
    partial class ClientForm
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
            this.components = new System.ComponentModel.Container();
            this.txtQueryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.clientGridView = new System.Windows.Forms.DataGridView();
            this.hotelDataSet = new HotelMgr2017101999.hotelDataSet();
            this.registerRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registerRoomTableAdapter = new HotelMgr2017101999.hotelDataSetTableAdapters.RegisterRoomTableAdapter();
            this.inIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foregiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delMarkDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCertType = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCertId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPersonNum = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerRoomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQueryName
            // 
            this.txtQueryName.Location = new System.Drawing.Point(74, 12);
            this.txtQueryName.Name = "txtQueryName";
            this.txtQueryName.Size = new System.Drawing.Size(200, 21);
            this.txtQueryName.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "旅客姓名";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(280, 10);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // clientGridView
            // 
            this.clientGridView.AllowUserToAddRows = false;
            this.clientGridView.AllowUserToDeleteRows = false;
            this.clientGridView.AutoGenerateColumns = false;
            this.clientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inIdDataGridViewTextBoxColumn,
            this.roomIdDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.foregiftDataGridViewTextBoxColumn,
            this.inTimeDataGridViewTextBoxColumn,
            this.outTimeDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.sexDataGridViewCheckBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.certTypeDataGridViewTextBoxColumn,
            this.certIdDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.personNumDataGridViewTextBoxColumn,
            this.operDataGridViewTextBoxColumn,
            this.delMarkDataGridViewCheckBoxColumn});
            this.clientGridView.DataSource = this.registerRoomBindingSource;
            this.clientGridView.Location = new System.Drawing.Point(13, 42);
            this.clientGridView.MultiSelect = false;
            this.clientGridView.Name = "clientGridView";
            this.clientGridView.ReadOnly = true;
            this.clientGridView.RowTemplate.Height = 23;
            this.clientGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientGridView.Size = new System.Drawing.Size(563, 338);
            this.clientGridView.TabIndex = 21;
            this.clientGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.clientGridView_CellFormatting);
            this.clientGridView.SelectionChanged += new System.EventHandler(this.clientGridView_SelectionChanged);
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "hotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registerRoomBindingSource
            // 
            this.registerRoomBindingSource.DataMember = "RegisterRoom";
            this.registerRoomBindingSource.DataSource = this.hotelDataSet;
            // 
            // registerRoomTableAdapter
            // 
            this.registerRoomTableAdapter.ClearBeforeFill = true;
            // 
            // inIdDataGridViewTextBoxColumn
            // 
            this.inIdDataGridViewTextBoxColumn.DataPropertyName = "inId";
            this.inIdDataGridViewTextBoxColumn.HeaderText = "inId";
            this.inIdDataGridViewTextBoxColumn.Name = "inIdDataGridViewTextBoxColumn";
            this.inIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomIdDataGridViewTextBoxColumn
            // 
            this.roomIdDataGridViewTextBoxColumn.DataPropertyName = "roomId";
            this.roomIdDataGridViewTextBoxColumn.HeaderText = "房间号";
            this.roomIdDataGridViewTextBoxColumn.Name = "roomIdDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "价格";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // foregiftDataGridViewTextBoxColumn
            // 
            this.foregiftDataGridViewTextBoxColumn.DataPropertyName = "foregift";
            this.foregiftDataGridViewTextBoxColumn.HeaderText = "押金";
            this.foregiftDataGridViewTextBoxColumn.Name = "foregiftDataGridViewTextBoxColumn";
            // 
            // inTimeDataGridViewTextBoxColumn
            // 
            this.inTimeDataGridViewTextBoxColumn.DataPropertyName = "inTime";
            this.inTimeDataGridViewTextBoxColumn.HeaderText = "入住时间";
            this.inTimeDataGridViewTextBoxColumn.Name = "inTimeDataGridViewTextBoxColumn";
            // 
            // outTimeDataGridViewTextBoxColumn
            // 
            this.outTimeDataGridViewTextBoxColumn.DataPropertyName = "outTime";
            this.outTimeDataGridViewTextBoxColumn.HeaderText = "离开时间";
            this.outTimeDataGridViewTextBoxColumn.Name = "outTimeDataGridViewTextBoxColumn";
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "clientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "客户姓名";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewCheckBoxColumn
            // 
            this.sexDataGridViewCheckBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewCheckBoxColumn.HeaderText = "性别";
            this.sexDataGridViewCheckBoxColumn.Name = "sexDataGridViewCheckBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "电话";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // certTypeDataGridViewTextBoxColumn
            // 
            this.certTypeDataGridViewTextBoxColumn.DataPropertyName = "certType";
            this.certTypeDataGridViewTextBoxColumn.HeaderText = "身份类型";
            this.certTypeDataGridViewTextBoxColumn.Name = "certTypeDataGridViewTextBoxColumn";
            // 
            // certIdDataGridViewTextBoxColumn
            // 
            this.certIdDataGridViewTextBoxColumn.DataPropertyName = "certId";
            this.certIdDataGridViewTextBoxColumn.HeaderText = "身份号";
            this.certIdDataGridViewTextBoxColumn.Name = "certIdDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "地址";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // personNumDataGridViewTextBoxColumn
            // 
            this.personNumDataGridViewTextBoxColumn.DataPropertyName = "personNum";
            this.personNumDataGridViewTextBoxColumn.HeaderText = "入住人数";
            this.personNumDataGridViewTextBoxColumn.Name = "personNumDataGridViewTextBoxColumn";
            // 
            // operDataGridViewTextBoxColumn
            // 
            this.operDataGridViewTextBoxColumn.DataPropertyName = "Oper";
            this.operDataGridViewTextBoxColumn.HeaderText = "操作员";
            this.operDataGridViewTextBoxColumn.Name = "operDataGridViewTextBoxColumn";
            // 
            // delMarkDataGridViewCheckBoxColumn
            // 
            this.delMarkDataGridViewCheckBoxColumn.DataPropertyName = "delMark";
            this.delMarkDataGridViewCheckBoxColumn.HeaderText = "delMark";
            this.delMarkDataGridViewCheckBoxColumn.Name = "delMarkDataGridViewCheckBoxColumn";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(74, 399);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(183, 21);
            this.txtClientName.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "旅客姓名";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(158, 425);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(35, 16);
            this.rbFemale.TabIndex = 26;
            this.rbFemale.Text = "女";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(82, 426);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(35, 16);
            this.rbMale.TabIndex = 25;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "男";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "性别";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 28;
            this.label7.Text = "证件类型";
            // 
            // cmbCertType
            // 
            this.cmbCertType.FormattingEnabled = true;
            this.cmbCertType.Items.AddRange(new object[] {
            "居民身份证",
            "军官证",
            "警官证",
            "学生证",
            "工作证"});
            this.cmbCertType.Location = new System.Drawing.Point(74, 452);
            this.cmbCertType.Name = "cmbCertType";
            this.cmbCertType.Size = new System.Drawing.Size(183, 20);
            this.cmbCertType.TabIndex = 27;
            this.cmbCertType.Text = "居民身份证";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(74, 478);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(502, 21);
            this.txtAddress.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 481);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 29;
            this.label10.Text = "证件地址";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(376, 424);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 21);
            this.txtPhone.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(315, 427);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 31;
            this.label11.Text = "联系电话";
            // 
            // txtCertId
            // 
            this.txtCertId.Location = new System.Drawing.Point(376, 451);
            this.txtCertId.Name = "txtCertId";
            this.txtCertId.Size = new System.Drawing.Size(200, 21);
            this.txtCertId.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(315, 454);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 33;
            this.label9.Text = "证件号码";
            // 
            // txtPersonNum
            // 
            this.txtPersonNum.Location = new System.Drawing.Point(74, 505);
            this.txtPersonNum.Name = "txtPersonNum";
            this.txtPersonNum.Size = new System.Drawing.Size(95, 21);
            this.txtPersonNum.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 508);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 35;
            this.label13.Text = "住宿人数";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(501, 503);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 533);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPersonNum);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCertId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbCertType);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clientGridView);
            this.Controls.Add(this.txtQueryName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuery);
            this.Name = "ClientForm";
            this.Text = "旅客信息";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerRoomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQueryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView clientGridView;
        private hotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource registerRoomBindingSource;
        private hotelDataSetTableAdapters.RegisterRoomTableAdapter registerRoomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn inIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foregiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sexDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn certTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn certIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn delMarkDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCertType;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCertId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPersonNum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSave;
    }
}