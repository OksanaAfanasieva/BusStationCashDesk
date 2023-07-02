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
            this.search = new System.Windows.Forms.Button();
            this.buy = new System.Windows.Forms.Button();
            this.myTravels = new System.Windows.Forms.LinkLabel();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.ColumnHeader();
            this.from = new System.Windows.Forms.ColumnHeader();
            this.to = new System.Windows.Forms.ColumnHeader();
            this.listRoute = new System.Windows.Forms.ListView();
            this.dateFrom = new System.Windows.Forms.ColumnHeader();
            this.timeFrom = new System.Windows.Forms.ColumnHeader();
            this.freeSeat = new System.Windows.Forms.ColumnHeader();
            this.allRoute = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.search.AutoSize = true;
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(9, 258);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(201, 39);
            this.search.TabIndex = 19;
            this.search.Text = "Пошук";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.buttonSearch_Click_1);
            // 
            // buy
            // 
            this.buy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buy.AutoSize = true;
            this.buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buy.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buy.ForeColor = System.Drawing.Color.White;
            this.buy.Location = new System.Drawing.Point(901, 407);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(160, 37);
            this.buy.TabIndex = 18;
            this.buy.Text = "Купити";
            this.buy.UseVisualStyleBackColor = false;
            this.buy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // myTravels
            // 
            this.myTravels.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.myTravels.AutoSize = true;
            this.myTravels.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.myTravels.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.myTravels.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.myTravels.Location = new System.Drawing.Point(9, 10);
            this.myTravels.Name = "myTravels";
            this.myTravels.Size = new System.Drawing.Size(134, 25);
            this.myTravels.TabIndex = 17;
            this.myTravels.TabStop = true;
            this.myTravels.Text = "Мої подорожі";
            this.myTravels.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.myTravels.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMyTravels_LinkClicked);
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.dateLabel.Location = new System.Drawing.Point(9, 174);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(51, 25);
            this.dateLabel.TabIndex = 16;
            this.dateLabel.Text = "Дата";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker.Location = new System.Drawing.Point(9, 202);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(189, 31);
            this.dateTimePicker.TabIndex = 14;
            // 
            // toTextBox
            // 
            this.toTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.toTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toTextBox.Location = new System.Drawing.Point(9, 138);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(189, 29);
            this.toTextBox.TabIndex = 13;
            // 
            // toLabel
            // 
            this.toLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.toLabel.Location = new System.Drawing.Point(9, 110);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(36, 25);
            this.toLabel.TabIndex = 12;
            this.toLabel.Text = "До";
            // 
            // fromLabel
            // 
            this.fromLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fromLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.fromLabel.Location = new System.Drawing.Point(9, 52);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(38, 25);
            this.fromLabel.TabIndex = 11;
            this.fromLabel.Text = "Від";
            // 
            // fromTextBox
            // 
            this.fromTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fromTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromTextBox.Location = new System.Drawing.Point(9, 80);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(190, 29);
            this.fromTextBox.TabIndex = 10;
            // 
            // number
            // 
            this.number.Text = "Номер рейса";
            this.number.Width = 120;
            // 
            // from
            // 
            this.from.Text = "Місто відправлення";
            this.from.Width = 170;
            // 
            // to
            // 
            this.to.Text = "Місто призначення";
            this.to.Width = 170;
            // 
            // routeList
            // 
            this.listRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listRoute.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.from,
            this.to,
            this.dateFrom,
            this.timeFrom,
            this.freeSeat});
            this.listRoute.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listRoute.ForeColor = System.Drawing.Color.Black;
            this.listRoute.FullRowSelect = true;
            this.listRoute.Location = new System.Drawing.Point(222, 10);
            this.listRoute.Name = "routeList";
            this.listRoute.Size = new System.Drawing.Size(839, 393);
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
            this.timeFrom.Width = 150;
            // 
            // freeSeat
            // 
            this.freeSeat.Text = "Вільні місця";
            this.freeSeat.Width = 110;
            // 
            // allRoute
            // 
            this.allRoute.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.allRoute.AutoSize = true;
            this.allRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.allRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allRoute.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.allRoute.ForeColor = System.Drawing.Color.White;
            this.allRoute.Location = new System.Drawing.Point(9, 303);
            this.allRoute.Name = "allRoute";
            this.allRoute.Size = new System.Drawing.Size(201, 39);
            this.allRoute.TabIndex = 37;
            this.allRoute.Text = "Вивести усі маршрути";
            this.allRoute.UseVisualStyleBackColor = false;
            this.allRoute.Click += new System.EventHandler(this.buttonAllRoute_Click);
            // 
            // logOut
            // 
            this.logOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logOut.AutoSize = true;
            this.logOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOut.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logOut.ForeColor = System.Drawing.Color.White;
            this.logOut.Location = new System.Drawing.Point(9, 407);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(109, 37);
            this.logOut.TabIndex = 38;
            this.logOut.Text = "Вийти";
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1073, 450);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.allRoute);
            this.Controls.Add(this.listRoute);
            this.Controls.Add(this.search);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.myTravels);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.fromTextBox);
            this.MinimumSize = new System.Drawing.Size(1089, 489);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Головна сторінка";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button search;
        private Button buy;
        private LinkLabel myTravels;
        private Label dateLabel;
        private DateTimePicker dateTimePicker;
        private TextBox toTextBox;
        private Label toLabel;
        private Label fromLabel;
        private TextBox fromTextBox;
        private ColumnHeader number;
        private ColumnHeader from;
        private ColumnHeader to;
        private ListView listRoute;
        private ColumnHeader dateFrom;
        private ColumnHeader timeFrom;
        private ColumnHeader freeSeat;
        private Button allRoute;
        private Button logOut;
    }
}