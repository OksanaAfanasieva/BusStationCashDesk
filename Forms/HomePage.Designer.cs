namespace BusStationCashDesk.Windows_Forms
{
    partial class HomePage
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.linkLabelMyTravels = new System.Windows.Forms.LinkLabel();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.ColumnHeader();
            this.from = new System.Windows.Forms.ColumnHeader();
            this.to = new System.Windows.Forms.ColumnHeader();
            this.listRoute = new System.Windows.Forms.ListView();
            this.dateFrom = new System.Windows.Forms.ColumnHeader();
            this.timeFrom = new System.Windows.Forms.ColumnHeader();
            this.freeSeat = new System.Windows.Forms.ColumnHeader();
            this.buttonAllRoute = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.Location = new System.Drawing.Point(13, 235);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(189, 39);
            this.buttonSearch.TabIndex = 19;
            this.buttonSearch.Text = "Пошук";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click_1);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBuy.Location = new System.Drawing.Point(758, 412);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(160, 32);
            this.buttonBuy.TabIndex = 18;
            this.buttonBuy.Text = "Купити";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // linkLabelMyTravels
            // 
            this.linkLabelMyTravels.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabelMyTravels.AutoSize = true;
            this.linkLabelMyTravels.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelMyTravels.LinkColor = System.Drawing.Color.Black;
            this.linkLabelMyTravels.Location = new System.Drawing.Point(12, 10);
            this.linkLabelMyTravels.Name = "linkLabelMyTravels";
            this.linkLabelMyTravels.Size = new System.Drawing.Size(111, 21);
            this.linkLabelMyTravels.TabIndex = 17;
            this.linkLabelMyTravels.TabStop = true;
            this.linkLabelMyTravels.Text = "Мої подорожі";
            this.linkLabelMyTravels.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabelMyTravels.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMyTravels_LinkClicked);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(13, 171);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(32, 15);
            this.labelDate.TabIndex = 16;
            this.labelDate.Text = "Дата";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(13, 189);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(189, 23);
            this.dateTimePicker.TabIndex = 14;
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(13, 133);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(189, 23);
            this.textBoxTo.TabIndex = 13;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(13, 115);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(22, 15);
            this.labelTo.TabIndex = 12;
            this.labelTo.Text = "До";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(12, 62);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(23, 15);
            this.labelFrom.TabIndex = 11;
            this.labelFrom.Text = "Від";
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(12, 80);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(190, 23);
            this.textBoxFrom.TabIndex = 10;
            // 
            // number
            // 
            this.number.Text = "Номер рейса";
            this.number.Width = 85;
            // 
            // from
            // 
            this.from.Text = "Місто відправлення";
            this.from.Width = 150;
            // 
            // to
            // 
            this.to.Text = "Місто призначення";
            this.to.Width = 150;
            // 
            // listRoute
            // 
            this.listRoute.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.from,
            this.to,
            this.dateFrom,
            this.timeFrom,
            this.freeSeat});
            this.listRoute.Location = new System.Drawing.Point(222, 10);
            this.listRoute.Name = "listRoute";
            this.listRoute.Size = new System.Drawing.Size(696, 396);
            this.listRoute.TabIndex = 36;
            this.listRoute.UseCompatibleStateImageBehavior = false;
            this.listRoute.View = System.Windows.Forms.View.Details;
            this.listRoute.DoubleClick += new System.EventHandler(this.listRoute_DoubleClick);
            // 
            // dateFrom
            // 
            this.dateFrom.Text = "Дата";
            this.dateFrom.Width = 110;
            // 
            // timeFrom
            // 
            this.timeFrom.Text = "Час відправлення";
            this.timeFrom.Width = 110;
            // 
            // freeSeat
            // 
            this.freeSeat.Text = "Вільні місця";
            this.freeSeat.Width = 80;
            // 
            // buttonAllRoute
            // 
            this.buttonAllRoute.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAllRoute.Location = new System.Drawing.Point(13, 280);
            this.buttonAllRoute.Name = "buttonAllRoute";
            this.buttonAllRoute.Size = new System.Drawing.Size(189, 39);
            this.buttonAllRoute.TabIndex = 37;
            this.buttonAllRoute.Text = "Вивести усі маршрути";
            this.buttonAllRoute.UseVisualStyleBackColor = true;
            this.buttonAllRoute.Click += new System.EventHandler(this.buttonAllRoute_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogOut.Location = new System.Drawing.Point(14, 412);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(109, 32);
            this.buttonLogOut.TabIndex = 38;
            this.buttonLogOut.Text = "Вийти";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 450);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonAllRoute);
            this.Controls.Add(this.listRoute);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.linkLabelMyTravels);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.textBoxFrom);
            this.MinimumSize = new System.Drawing.Size(946, 489);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Головна сторінка";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSearch;
        private Button buttonBuy;
        private LinkLabel linkLabelMyTravels;
        private Label labelDate;
        private DateTimePicker dateTimePicker;
        private TextBox textBoxTo;
        private Label labelTo;
        private Label labelFrom;
        private TextBox textBoxFrom;
        private ColumnHeader number;
        private ColumnHeader from;
        private ColumnHeader to;
        private ListView listRoute;
        private ColumnHeader dateFrom;
        private ColumnHeader timeFrom;
        private ColumnHeader freeSeat;
        private Button buttonAllRoute;
        private Button buttonLogOut;
    }
}