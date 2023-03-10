namespace OTKService.Forms
{
    partial class CreateOrderForm
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
            this.ReturnButton = new System.Windows.Forms.Button();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.OrdersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Table = new System.Windows.Forms.DataGridView();
            this.NewOrderGroup = new System.Windows.Forms.GroupBox();
            this.PercentLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ServiceLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.OrderIdLabel = new System.Windows.Forms.Label();
            this.SaveOrderButton = new System.Windows.Forms.Button();
            this.PercentBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.ServiceSelector = new System.Windows.Forms.ComboBox();
            this.UserSelector = new System.Windows.Forms.ComboBox();
            this.OrderId = new System.Windows.Forms.TextBox();
            this.OrderDatePicker = new System.Windows.Forms.DateTimePicker();
            this.OrdersId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PercentField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.NewOrderGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(775, 41);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(192, 23);
            this.ReturnButton.TabIndex = 0;
            this.ReturnButton.Text = "На страницу авторизации";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.OnReturnButtonClick);
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Location = new System.Drawing.Point(47, 45);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(80, 15);
            this.HelloLabel.TabIndex = 1;
            this.HelloLabel.Text = "Здравствуйте";
            // 
            // OrdersPanel
            // 
            this.OrdersPanel.Controls.Add(this.Table);
            this.OrdersPanel.Location = new System.Drawing.Point(47, 100);
            this.OrdersPanel.Name = "OrdersPanel";
            this.OrdersPanel.Size = new System.Drawing.Size(920, 152);
            this.OrdersPanel.TabIndex = 2;
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrdersId,
            this.Date,
            this.UserField,
            this.ServiceField,
            this.PercentField,
            this.PriceField});
            this.Table.Location = new System.Drawing.Point(3, 3);
            this.Table.Name = "Table";
            this.Table.RowTemplate.Height = 25;
            this.Table.Size = new System.Drawing.Size(917, 153);
            this.Table.TabIndex = 0;
            // 
            // NewOrderGroup
            // 
            this.NewOrderGroup.Controls.Add(this.PercentLabel);
            this.NewOrderGroup.Controls.Add(this.PriceLabel);
            this.NewOrderGroup.Controls.Add(this.ServiceLabel);
            this.NewOrderGroup.Controls.Add(this.UserLabel);
            this.NewOrderGroup.Controls.Add(this.DateLabel);
            this.NewOrderGroup.Controls.Add(this.OrderIdLabel);
            this.NewOrderGroup.Controls.Add(this.SaveOrderButton);
            this.NewOrderGroup.Controls.Add(this.PercentBox);
            this.NewOrderGroup.Controls.Add(this.PriceBox);
            this.NewOrderGroup.Controls.Add(this.ServiceSelector);
            this.NewOrderGroup.Controls.Add(this.UserSelector);
            this.NewOrderGroup.Controls.Add(this.OrderId);
            this.NewOrderGroup.Controls.Add(this.OrderDatePicker);
            this.NewOrderGroup.Location = new System.Drawing.Point(47, 276);
            this.NewOrderGroup.Name = "NewOrderGroup";
            this.NewOrderGroup.Size = new System.Drawing.Size(920, 264);
            this.NewOrderGroup.TabIndex = 3;
            this.NewOrderGroup.TabStop = false;
            this.NewOrderGroup.Text = "Создание нового заказа";
            // 
            // PercentLabel
            // 
            this.PercentLabel.AutoSize = true;
            this.PercentLabel.Location = new System.Drawing.Point(330, 216);
            this.PercentLabel.Name = "PercentLabel";
            this.PercentLabel.Size = new System.Drawing.Size(116, 15);
            this.PercentLabel.TabIndex = 12;
            this.PercentLabel.Text = "с учетом скидки, %:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(17, 216);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(99, 15);
            this.PriceLabel.TabIndex = 11;
            this.PriceLabel.Text = "Стоимость, руб.:";
            // 
            // ServiceLabel
            // 
            this.ServiceLabel.AutoSize = true;
            this.ServiceLabel.Location = new System.Drawing.Point(17, 169);
            this.ServiceLabel.Name = "ServiceLabel";
            this.ServiceLabel.Size = new System.Drawing.Size(47, 15);
            this.ServiceLabel.TabIndex = 10;
            this.ServiceLabel.Text = "Услуга:";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(17, 123);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(49, 15);
            this.UserLabel.TabIndex = 9;
            this.UserLabel.Text = "Клиент:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(17, 82);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(88, 15);
            this.DateLabel.TabIndex = 8;
            this.DateLabel.Text = "Дата создания:";
            // 
            // OrderIdLabel
            // 
            this.OrderIdLabel.AutoSize = true;
            this.OrderIdLabel.Location = new System.Drawing.Point(17, 38);
            this.OrderIdLabel.Name = "OrderIdLabel";
            this.OrderIdLabel.Size = new System.Drawing.Size(85, 15);
            this.OrderIdLabel.TabIndex = 7;
            this.OrderIdLabel.Text = "Номер заказа:";
            // 
            // SaveOrderButton
            // 
            this.SaveOrderButton.Location = new System.Drawing.Point(728, 213);
            this.SaveOrderButton.Name = "SaveOrderButton";
            this.SaveOrderButton.Size = new System.Drawing.Size(165, 34);
            this.SaveOrderButton.TabIndex = 6;
            this.SaveOrderButton.Text = "Сохранить заказ";
            this.SaveOrderButton.UseVisualStyleBackColor = true;
            this.SaveOrderButton.Click += new System.EventHandler(this.OnSaveOrderButtonClick);
            // 
            // PercentBox
            // 
            this.PercentBox.Location = new System.Drawing.Point(452, 213);
            this.PercentBox.Name = "PercentBox";
            this.PercentBox.Size = new System.Drawing.Size(100, 23);
            this.PercentBox.TabIndex = 5;
            this.PercentBox.TextChanged += new System.EventHandler(this.PercentBox_TextChanged);
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(182, 213);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.ReadOnly = true;
            this.PriceBox.Size = new System.Drawing.Size(100, 23);
            this.PriceBox.TabIndex = 4;
            // 
            // ServiceSelector
            // 
            this.ServiceSelector.FormattingEnabled = true;
            this.ServiceSelector.Location = new System.Drawing.Point(182, 166);
            this.ServiceSelector.Name = "ServiceSelector";
            this.ServiceSelector.Size = new System.Drawing.Size(264, 23);
            this.ServiceSelector.TabIndex = 3;
            this.ServiceSelector.SelectedIndexChanged += new System.EventHandler(this.ServiceSelector_SelectedIndexChanged);
            // 
            // UserSelector
            // 
            this.UserSelector.FormattingEnabled = true;
            this.UserSelector.Location = new System.Drawing.Point(182, 120);
            this.UserSelector.Name = "UserSelector";
            this.UserSelector.Size = new System.Drawing.Size(264, 23);
            this.UserSelector.TabIndex = 2;
            // 
            // OrderId
            // 
            this.OrderId.Location = new System.Drawing.Point(182, 35);
            this.OrderId.Name = "OrderId";
            this.OrderId.Size = new System.Drawing.Size(200, 23);
            this.OrderId.TabIndex = 1;
            // 
            // OrderDatePicker
            // 
            this.OrderDatePicker.Location = new System.Drawing.Point(182, 76);
            this.OrderDatePicker.Name = "OrderDatePicker";
            this.OrderDatePicker.Size = new System.Drawing.Size(200, 23);
            this.OrderDatePicker.TabIndex = 0;
            // 
            // OrdersId
            // 
            this.OrdersId.HeaderText = "OrderId";
            this.OrdersId.Name = "OrdersId";
            this.OrdersId.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // UserField
            // 
            this.UserField.HeaderText = "User";
            this.UserField.Name = "UserField";
            this.UserField.ReadOnly = true;
            // 
            // ServiceField
            // 
            this.ServiceField.HeaderText = "Service";
            this.ServiceField.Name = "ServiceField";
            this.ServiceField.ReadOnly = true;
            // 
            // PercentField
            // 
            this.PercentField.HeaderText = "Percent";
            this.PercentField.Name = "PercentField";
            this.PercentField.ReadOnly = true;
            // 
            // PriceField
            // 
            this.PriceField.HeaderText = "Price";
            this.PriceField.Name = "PriceField";
            this.PriceField.ReadOnly = true;
            // 
            // CreateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.NewOrderGroup);
            this.Controls.Add(this.OrdersPanel);
            this.Controls.Add(this.HelloLabel);
            this.Controls.Add(this.ReturnButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.Name = "CreateOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СистемаОТК-Список заказов";
            this.OrdersPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.NewOrderGroup.ResumeLayout(false);
            this.NewOrderGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ReturnButton;
        private Label HelloLabel;
        private FlowLayoutPanel OrdersPanel;
        private GroupBox NewOrderGroup;
        private DateTimePicker OrderDatePicker;
        private ComboBox UserSelector;
        private TextBox OrderId;
        private ComboBox ServiceSelector;
        private TextBox PriceBox;
        private TextBox PercentBox;
        private Button SaveOrderButton;
        private Label OrderIdLabel;
        private Label DateLabel;
        private Label UserLabel;
        private Label ServiceLabel;
        private Label PriceLabel;
        private Label PercentLabel;
        private DataGridView Table;
        private DataGridViewTextBoxColumn OrdersId;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn UserField;
        private DataGridViewTextBoxColumn ServiceField;
        private DataGridViewTextBoxColumn PercentField;
        private DataGridViewTextBoxColumn PriceField;
    }
}