namespace BusStationCashDesk.Windows_Forms
{
    partial class InformationRoute
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
            this.textBoxNumberRoute = new System.Windows.Forms.TextBox();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxFreePlace = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelFreePlace = new System.Windows.Forms.Label();
            this.labelTimeTo = new System.Windows.Forms.Label();
            this.labelDateTo = new System.Windows.Forms.Label();
            this.labelTimeFrom = new System.Windows.Forms.Label();
            this.labelDateFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelNumberRoute = new System.Windows.Forms.Label();
            this.listViewStop = new System.Windows.Forms.ListView();
            this.stop = new System.Windows.Forms.ColumnHeader();
            this.time = new System.Windows.Forms.ColumnHeader();
            this.textBoxTimeFrom = new System.Windows.Forms.TextBox();
            this.textBoxTimeTo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxNumberRoute
            // 
            this.textBoxNumberRoute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumberRoute.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNumberRoute.Location = new System.Drawing.Point(148, 24);
            this.textBoxNumberRoute.Name = "textBoxNumberRoute";
            this.textBoxNumberRoute.ReadOnly = true;
            this.textBoxNumberRoute.Size = new System.Drawing.Size(79, 24);
            this.textBoxNumberRoute.TabIndex = 109;
            this.textBoxNumberRoute.TabStop = false;
            this.textBoxNumberRoute.TextChanged += new System.EventHandler(this.textBoxNumberRoute_TextChanged);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Enabled = false;
            this.dateTimePickerTo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerTo.Location = new System.Drawing.Point(371, 116);
            this.dateTimePickerTo.MinDate = new System.DateTime(2023, 6, 28, 0, 0, 0, 0);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(196, 31);
            this.dateTimePickerTo.TabIndex = 106;
            this.dateTimePickerTo.TabStop = false;
            this.dateTimePickerTo.Value = new System.DateTime(2023, 6, 28, 0, 0, 0, 0);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Enabled = false;
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerFrom.Location = new System.Drawing.Point(92, 116);
            this.dateTimePickerFrom.MinDate = new System.DateTime(2023, 6, 28, 0, 0, 0, 0);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(196, 31);
            this.dateTimePickerFrom.TabIndex = 105;
            this.dateTimePickerFrom.TabStop = false;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPrice.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPrice.Location = new System.Drawing.Point(487, 348);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(80, 24);
            this.textBoxPrice.TabIndex = 104;
            this.textBoxPrice.TabStop = false;
            // 
            // textBoxFreePlace
            // 
            this.textBoxFreePlace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFreePlace.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFreePlace.ForeColor = System.Drawing.Color.Black;
            this.textBoxFreePlace.Location = new System.Drawing.Point(223, 348);
            this.textBoxFreePlace.Name = "textBoxFreePlace";
            this.textBoxFreePlace.ReadOnly = true;
            this.textBoxFreePlace.Size = new System.Drawing.Size(51, 24);
            this.textBoxFreePlace.TabIndex = 103;
            this.textBoxFreePlace.TabStop = false;
            // 
            // textBoxTo
            // 
            this.textBoxTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTo.Location = new System.Drawing.Point(371, 80);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.ReadOnly = true;
            this.textBoxTo.Size = new System.Drawing.Size(196, 24);
            this.textBoxTo.TabIndex = 102;
            this.textBoxTo.TabStop = false;
            this.textBoxTo.TextChanged += new System.EventHandler(this.textBoxTo_TextChanged);
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFrom.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFrom.Location = new System.Drawing.Point(92, 79);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.ReadOnly = true;
            this.textBoxFrom.Size = new System.Drawing.Size(196, 24);
            this.textBoxFrom.TabIndex = 101;
            this.textBoxFrom.TabStop = false;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(429, 346);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(52, 25);
            this.labelPrice.TabIndex = 100;
            this.labelPrice.Text = "Ціна:";
            // 
            // labelFreePlace
            // 
            this.labelFreePlace.AutoSize = true;
            this.labelFreePlace.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFreePlace.Location = new System.Drawing.Point(17, 346);
            this.labelFreePlace.Name = "labelFreePlace";
            this.labelFreePlace.Size = new System.Drawing.Size(200, 25);
            this.labelFreePlace.TabIndex = 99;
            this.labelFreePlace.Text = "Кількість вільних місць:";
            this.labelFreePlace.Click += new System.EventHandler(this.labelFreePlace_Click);
            // 
            // labelTimeTo
            // 
            this.labelTimeTo.AutoSize = true;
            this.labelTimeTo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimeTo.Location = new System.Drawing.Point(320, 154);
            this.labelTimeTo.Name = "labelTimeTo";
            this.labelTimeTo.Size = new System.Drawing.Size(45, 25);
            this.labelTimeTo.TabIndex = 98;
            this.labelTimeTo.Text = "Час:";
            // 
            // labelDateTo
            // 
            this.labelDateTo.AutoSize = true;
            this.labelDateTo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDateTo.Location = new System.Drawing.Point(312, 120);
            this.labelDateTo.Name = "labelDateTo";
            this.labelDateTo.Size = new System.Drawing.Size(53, 25);
            this.labelDateTo.TabIndex = 97;
            this.labelDateTo.Text = "Дата:";
            // 
            // labelTimeFrom
            // 
            this.labelTimeFrom.AutoSize = true;
            this.labelTimeFrom.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimeFrom.Location = new System.Drawing.Point(41, 154);
            this.labelTimeFrom.Name = "labelTimeFrom";
            this.labelTimeFrom.Size = new System.Drawing.Size(45, 25);
            this.labelTimeFrom.TabIndex = 96;
            this.labelTimeFrom.Text = "Час:";
            // 
            // labelDateFrom
            // 
            this.labelDateFrom.AutoSize = true;
            this.labelDateFrom.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDateFrom.Location = new System.Drawing.Point(33, 120);
            this.labelDateFrom.Name = "labelDateFrom";
            this.labelDateFrom.Size = new System.Drawing.Size(53, 25);
            this.labelDateFrom.TabIndex = 95;
            this.labelDateFrom.Text = "Дата:";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTo.Location = new System.Drawing.Point(312, 79);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(55, 25);
            this.labelTo.TabIndex = 94;
            this.labelTo.Text = "Куди:";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFrom.Location = new System.Drawing.Point(17, 79);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(69, 25);
            this.labelFrom.TabIndex = 93;
            this.labelFrom.Text = "Звідки:";
            // 
            // labelNumberRoute
            // 
            this.labelNumberRoute.AutoSize = true;
            this.labelNumberRoute.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNumberRoute.Location = new System.Drawing.Point(17, 19);
            this.labelNumberRoute.Name = "labelNumberRoute";
            this.labelNumberRoute.Size = new System.Drawing.Size(125, 28);
            this.labelNumberRoute.TabIndex = 92;
            this.labelNumberRoute.Text = "Маршрут №";
            // 
            // listViewStop
            // 
            this.listViewStop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stop,
            this.time});
            this.listViewStop.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewStop.Location = new System.Drawing.Point(17, 199);
            this.listViewStop.Name = "listViewStop";
            this.listViewStop.Size = new System.Drawing.Size(550, 137);
            this.listViewStop.TabIndex = 110;
            this.listViewStop.TabStop = false;
            this.listViewStop.UseCompatibleStateImageBehavior = false;
            this.listViewStop.View = System.Windows.Forms.View.Details;
            // 
            // stop
            // 
            this.stop.Text = "Зупинки";
            this.stop.Width = 350;
            // 
            // time
            // 
            this.time.Text = "Час";
            this.time.Width = 190;
            // 
            // textBoxTimeFrom
            // 
            this.textBoxTimeFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTimeFrom.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTimeFrom.Location = new System.Drawing.Point(92, 154);
            this.textBoxTimeFrom.Name = "textBoxTimeFrom";
            this.textBoxTimeFrom.ReadOnly = true;
            this.textBoxTimeFrom.Size = new System.Drawing.Size(196, 24);
            this.textBoxTimeFrom.TabIndex = 111;
            this.textBoxTimeFrom.TabStop = false;
            // 
            // textBoxTimeTo
            // 
            this.textBoxTimeTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTimeTo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTimeTo.Location = new System.Drawing.Point(371, 155);
            this.textBoxTimeTo.Name = "textBoxTimeTo";
            this.textBoxTimeTo.ReadOnly = true;
            this.textBoxTimeTo.Size = new System.Drawing.Size(196, 24);
            this.textBoxTimeTo.TabIndex = 112;
            this.textBoxTimeTo.TabStop = false;
            // 
            // InformationRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(584, 391);
            this.Controls.Add(this.textBoxTimeTo);
            this.Controls.Add(this.textBoxTimeFrom);
            this.Controls.Add(this.listViewStop);
            this.Controls.Add(this.textBoxNumberRoute);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxFreePlace);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelFreePlace);
            this.Controls.Add(this.labelTimeTo);
            this.Controls.Add(this.labelDateTo);
            this.Controls.Add(this.labelTimeFrom);
            this.Controls.Add(this.labelDateFrom);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.labelNumberRoute);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 430);
            this.MinimumSize = new System.Drawing.Size(600, 430);
            this.Name = "InformationRoute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Маршрут";
            this.Load += new System.EventHandler(this.InformationRoute_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxNumberRoute;
        private DateTimePicker dateTimePickerTo;
        private DateTimePicker dateTimePickerFrom;
        private TextBox textBoxPrice;
        private TextBox textBoxFreePlace;
        private TextBox textBoxTo;
        private TextBox textBoxFrom;
        private Label labelPrice;
        private Label labelFreePlace;
        private Label labelTimeTo;
        private Label labelDateTo;
        private Label labelTimeFrom;
        private Label labelDateFrom;
        private Label labelTo;
        private Label labelFrom;
        private Label labelNumberRoute;
        private ListView listViewStop;
        private ColumnHeader stop;
        private ColumnHeader time;
        private TextBox textBoxTimeFrom;
        private TextBox textBoxTimeTo;
    }
}