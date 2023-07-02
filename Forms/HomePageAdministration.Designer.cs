namespace BusStationCashDesk.Windows_Forms
{
    partial class HomePageAdministration
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
            this.create = new System.Windows.Forms.Button();
            this.boardingList = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.listRoute = new System.Windows.Forms.ListView();
            this.number = new System.Windows.Forms.ColumnHeader();
            this.from = new System.Windows.Forms.ColumnHeader();
            this.to = new System.Windows.Forms.ColumnHeader();
            this.dateFrom = new System.Windows.Forms.ColumnHeader();
            this.timeFrom = new System.Windows.Forms.ColumnHeader();
            this.freeSeat = new System.Windows.Forms.ColumnHeader();
            this.allRoute = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // create
            // 
            this.create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.create.AutoSize = true;
            this.create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.create.ForeColor = System.Drawing.Color.White;
            this.create.Location = new System.Drawing.Point(515, 401);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(112, 37);
            this.create.TabIndex = 34;
            this.create.Text = "Створити";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // boardingList
            // 
            this.boardingList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.boardingList.AutoSize = true;
            this.boardingList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.boardingList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boardingList.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boardingList.ForeColor = System.Drawing.Color.White;
            this.boardingList.Location = new System.Drawing.Point(866, 401);
            this.boardingList.Name = "boardingList";
            this.boardingList.Size = new System.Drawing.Size(195, 37);
            this.boardingList.TabIndex = 33;
            this.boardingList.Text = "Посадкова відомість";
            this.boardingList.UseVisualStyleBackColor = false;
            this.boardingList.Click += new System.EventHandler(this.buttonBoardingList_Click);
            // 
            // edit
            // 
            this.edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edit.AutoSize = true;
            this.edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.edit.ForeColor = System.Drawing.Color.White;
            this.edit.Location = new System.Drawing.Point(631, 401);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(114, 37);
            this.edit.TabIndex = 32;
            this.edit.Text = "Редагувати";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // search
            // 
            this.search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.search.AutoSize = true;
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(12, 206);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(203, 39);
            this.search.TabIndex = 31;
            this.search.Text = "Пошук";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // remove
            // 
            this.remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.remove.AutoSize = true;
            this.remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remove.ForeColor = System.Drawing.Color.White;
            this.remove.Location = new System.Drawing.Point(751, 401);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(112, 37);
            this.remove.TabIndex = 30;
            this.remove.Text = "Видалити";
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.dateLabel.Location = new System.Drawing.Point(12, 129);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(47, 23);
            this.dateLabel.TabIndex = 29;
            this.dateLabel.Text = "Дата";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker.Location = new System.Drawing.Point(12, 157);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(189, 31);
            this.dateTimePicker.TabIndex = 27;
            // 
            // toTextBox
            // 
            this.toTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.toTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toTextBox.Location = new System.Drawing.Point(12, 97);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(189, 29);
            this.toTextBox.TabIndex = 26;
            // 
            // toLabel
            // 
            this.toLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.toLabel.Location = new System.Drawing.Point(12, 69);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(32, 23);
            this.toLabel.TabIndex = 25;
            this.toLabel.Text = "До";
            // 
            // fromLabel
            // 
            this.fromLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fromLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.fromLabel.Location = new System.Drawing.Point(12, 9);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(34, 23);
            this.fromLabel.TabIndex = 24;
            this.fromLabel.Text = "Від";
            // 
            // fromTextBox
            // 
            this.fromTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fromTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromTextBox.Location = new System.Drawing.Point(12, 37);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(189, 29);
            this.fromTextBox.TabIndex = 23;
            // 
            // listRoute
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
            this.listRoute.FullRowSelect = true;
            this.listRoute.Location = new System.Drawing.Point(221, 7);
            this.listRoute.Name = "listRoute";
            this.listRoute.Size = new System.Drawing.Size(840, 390);
            this.listRoute.TabIndex = 35;
            this.listRoute.UseCompatibleStateImageBehavior = false;
            this.listRoute.View = System.Windows.Forms.View.Details;
            this.listRoute.DoubleClick += new System.EventHandler(this.listRoute_DoubleClick);
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
            this.allRoute.Location = new System.Drawing.Point(12, 251);
            this.allRoute.Name = "allRoute";
            this.allRoute.Size = new System.Drawing.Size(203, 39);
            this.allRoute.TabIndex = 38;
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
            this.logOut.Location = new System.Drawing.Point(14, 406);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(109, 35);
            this.logOut.TabIndex = 39;
            this.logOut.Text = "Вийти";
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // HomePageAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1073, 450);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.allRoute);
            this.Controls.Add(this.listRoute);
            this.Controls.Add(this.create);
            this.Controls.Add(this.boardingList);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.search);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.fromTextBox);
            this.MinimumSize = new System.Drawing.Size(1089, 489);
            this.Name = "HomePageAdministration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Головна сторінка";
            this.Load += new System.EventHandler(this.HomePageAdministration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button create;
        private Button boardingList;
        private Button edit;
        private Button search;
        private Button remove;
        private Label dateLabel;
        private DateTimePicker dateTimePicker;
        private TextBox toTextBox;
        private Label toLabel;
        private Label fromLabel;
        private TextBox fromTextBox;
        private ListView listRoute;
        private ColumnHeader number;
        private ColumnHeader from;
        private ColumnHeader to;
        private ColumnHeader dateFrom;
        private ColumnHeader timeFrom;
        private ColumnHeader freeSeat;
        private Button allRoute;
        private Button logOut;
    }
}