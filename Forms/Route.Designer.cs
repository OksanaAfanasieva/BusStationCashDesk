﻿namespace BusStationCashDesk.Windows_Forms
{
    partial class Route
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
            this.timePickerStop = new System.Windows.Forms.DateTimePicker();
            this.timePickerTo = new System.Windows.Forms.DateTimePicker();
            this.timePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAddStop = new System.Windows.Forms.Button();
            this.labelTimeStop = new System.Windows.Forms.Label();
            this.labelNameStop = new System.Windows.Forms.Label();
            this.textBoxNameStop = new System.Windows.Forms.TextBox();
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
            this.buttonRemoveStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timePickerStop
            // 
            this.timePickerStop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePickerStop.Location = new System.Drawing.Point(201, 315);
            this.timePickerStop.MinDate = new System.DateTime(2023, 6, 19, 0, 0, 0, 0);
            this.timePickerStop.Name = "timePickerStop";
            this.timePickerStop.ShowUpDown = true;
            this.timePickerStop.Size = new System.Drawing.Size(178, 23);
            this.timePickerStop.TabIndex = 119;
            // 
            // timePickerTo
            // 
            this.timePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePickerTo.Location = new System.Drawing.Point(371, 147);
            this.timePickerTo.MinDate = new System.DateTime(2023, 6, 19, 0, 0, 0, 0);
            this.timePickerTo.Name = "timePickerTo";
            this.timePickerTo.ShowUpDown = true;
            this.timePickerTo.Size = new System.Drawing.Size(196, 23);
            this.timePickerTo.TabIndex = 118;
            // 
            // timePickerFrom
            // 
            this.timePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePickerFrom.Location = new System.Drawing.Point(92, 145);
            this.timePickerFrom.MinDate = new System.DateTime(2023, 6, 19, 0, 0, 0, 0);
            this.timePickerFrom.Name = "timePickerFrom";
            this.timePickerFrom.ShowUpDown = true;
            this.timePickerFrom.Size = new System.Drawing.Size(196, 23);
            this.timePickerFrom.TabIndex = 117;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(277, 392);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(142, 40);
            this.buttonCancel.TabIndex = 116;
            this.buttonCancel.Text = "Скасувати";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(425, 392);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(142, 40);
            this.buttonSave.TabIndex = 115;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click_1);
            // 
            // buttonAddStop
            // 
            this.buttonAddStop.Location = new System.Drawing.Point(385, 292);
            this.buttonAddStop.Name = "buttonAddStop";
            this.buttonAddStop.Size = new System.Drawing.Size(88, 45);
            this.buttonAddStop.TabIndex = 94;
            this.buttonAddStop.Text = "Додати зупинку";
            this.buttonAddStop.UseVisualStyleBackColor = true;
            this.buttonAddStop.Click += new System.EventHandler(this.buttonAddStop_Click_1);
            // 
            // labelTimeStop
            // 
            this.labelTimeStop.AutoSize = true;
            this.labelTimeStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimeStop.Location = new System.Drawing.Point(201, 290);
            this.labelTimeStop.Name = "labelTimeStop";
            this.labelTimeStop.Size = new System.Drawing.Size(36, 21);
            this.labelTimeStop.TabIndex = 114;
            this.labelTimeStop.Text = "Час";
            // 
            // labelNameStop
            // 
            this.labelNameStop.AutoSize = true;
            this.labelNameStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNameStop.Location = new System.Drawing.Point(12, 290);
            this.labelNameStop.Name = "labelNameStop";
            this.labelNameStop.Size = new System.Drawing.Size(52, 21);
            this.labelNameStop.TabIndex = 113;
            this.labelNameStop.Text = "Назва";
            // 
            // textBoxNameStop
            // 
            this.textBoxNameStop.Location = new System.Drawing.Point(12, 314);
            this.textBoxNameStop.Name = "textBoxNameStop";
            this.textBoxNameStop.Size = new System.Drawing.Size(178, 23);
            this.textBoxNameStop.TabIndex = 112;
            this.textBoxNameStop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNameStop_KeyPress);
            // 
            // textBoxNumberRoute
            // 
            this.textBoxNumberRoute.Location = new System.Drawing.Point(148, 27);
            this.textBoxNumberRoute.Name = "textBoxNumberRoute";
            this.textBoxNumberRoute.Size = new System.Drawing.Size(79, 23);
            this.textBoxNumberRoute.TabIndex = 110;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(371, 113);
            this.dateTimePickerTo.MinDate = new System.DateTime(2023, 6, 12, 0, 0, 0, 0);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(196, 23);
            this.dateTimePickerTo.TabIndex = 109;
            this.dateTimePickerTo.Value = new System.DateTime(2023, 6, 29, 0, 0, 0, 0);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(92, 111);
            this.dateTimePickerFrom.MinDate = new System.DateTime(2023, 6, 19, 0, 0, 0, 0);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(196, 23);
            this.dateTimePickerFrom.TabIndex = 108;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(487, 358);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(80, 23);
            this.textBoxPrice.TabIndex = 107;
            // 
            // textBoxFreePlace
            // 
            this.textBoxFreePlace.Location = new System.Drawing.Point(223, 355);
            this.textBoxFreePlace.Name = "textBoxFreePlace";
            this.textBoxFreePlace.Size = new System.Drawing.Size(51, 23);
            this.textBoxFreePlace.TabIndex = 106;
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(371, 73);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(196, 23);
            this.textBoxTo.TabIndex = 105;
            this.textBoxTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTo_KeyPress);
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(92, 73);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(196, 23);
            this.textBoxFrom.TabIndex = 104;
            this.textBoxFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFrom_KeyPress);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(429, 355);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(52, 25);
            this.labelPrice.TabIndex = 103;
            this.labelPrice.Text = "Ціна:";
            // 
            // labelFreePlace
            // 
            this.labelFreePlace.AutoSize = true;
            this.labelFreePlace.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFreePlace.Location = new System.Drawing.Point(17, 355);
            this.labelFreePlace.Name = "labelFreePlace";
            this.labelFreePlace.Size = new System.Drawing.Size(200, 25);
            this.labelFreePlace.TabIndex = 102;
            this.labelFreePlace.Text = "Кількість вільних місць:";
            // 
            // labelTimeTo
            // 
            this.labelTimeTo.AutoSize = true;
            this.labelTimeTo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimeTo.Location = new System.Drawing.Point(320, 145);
            this.labelTimeTo.Name = "labelTimeTo";
            this.labelTimeTo.Size = new System.Drawing.Size(45, 25);
            this.labelTimeTo.TabIndex = 101;
            this.labelTimeTo.Text = "Час:";
            // 
            // labelDateTo
            // 
            this.labelDateTo.AutoSize = true;
            this.labelDateTo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDateTo.Location = new System.Drawing.Point(312, 111);
            this.labelDateTo.Name = "labelDateTo";
            this.labelDateTo.Size = new System.Drawing.Size(53, 25);
            this.labelDateTo.TabIndex = 100;
            this.labelDateTo.Text = "Дата:";
            // 
            // labelTimeFrom
            // 
            this.labelTimeFrom.AutoSize = true;
            this.labelTimeFrom.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimeFrom.Location = new System.Drawing.Point(41, 145);
            this.labelTimeFrom.Name = "labelTimeFrom";
            this.labelTimeFrom.Size = new System.Drawing.Size(45, 25);
            this.labelTimeFrom.TabIndex = 99;
            this.labelTimeFrom.Text = "Час:";
            // 
            // labelDateFrom
            // 
            this.labelDateFrom.AutoSize = true;
            this.labelDateFrom.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDateFrom.Location = new System.Drawing.Point(33, 111);
            this.labelDateFrom.Name = "labelDateFrom";
            this.labelDateFrom.Size = new System.Drawing.Size(53, 25);
            this.labelDateFrom.TabIndex = 98;
            this.labelDateFrom.Text = "Дата:";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTo.Location = new System.Drawing.Point(312, 70);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(55, 25);
            this.labelTo.TabIndex = 97;
            this.labelTo.Text = "Куди:";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFrom.Location = new System.Drawing.Point(17, 70);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(69, 25);
            this.labelFrom.TabIndex = 96;
            this.labelFrom.Text = "Звідки:";
            // 
            // labelNumberRoute
            // 
            this.labelNumberRoute.AutoSize = true;
            this.labelNumberRoute.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNumberRoute.Location = new System.Drawing.Point(17, 19);
            this.labelNumberRoute.Name = "labelNumberRoute";
            this.labelNumberRoute.Size = new System.Drawing.Size(125, 28);
            this.labelNumberRoute.TabIndex = 95;
            this.labelNumberRoute.Text = "Маршрут №";
            // 
            // listViewStop
            // 
            this.listViewStop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stop,
            this.time});
            this.listViewStop.FullRowSelect = true;
            this.listViewStop.GridLines = true;
            this.listViewStop.Location = new System.Drawing.Point(12, 176);
            this.listViewStop.Name = "listViewStop";
            this.listViewStop.Size = new System.Drawing.Size(556, 111);
            this.listViewStop.TabIndex = 120;
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
            // buttonRemoveStop
            // 
            this.buttonRemoveStop.Location = new System.Drawing.Point(479, 293);
            this.buttonRemoveStop.Name = "buttonRemoveStop";
            this.buttonRemoveStop.Size = new System.Drawing.Size(88, 45);
            this.buttonRemoveStop.TabIndex = 121;
            this.buttonRemoveStop.Text = "Видалити зупинку";
            this.buttonRemoveStop.UseVisualStyleBackColor = true;
            this.buttonRemoveStop.Click += new System.EventHandler(this.button1_Click);
            // 
            // Route
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(584, 451);
            this.Controls.Add(this.buttonRemoveStop);
            this.Controls.Add(this.listViewStop);
            this.Controls.Add(this.timePickerStop);
            this.Controls.Add(this.timePickerTo);
            this.Controls.Add(this.timePickerFrom);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAddStop);
            this.Controls.Add(this.labelTimeStop);
            this.Controls.Add(this.labelNameStop);
            this.Controls.Add(this.textBoxNameStop);
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
            this.MinimumSize = new System.Drawing.Size(600, 490);
            this.Name = "Route";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Маршрут";
            this.Load += new System.EventHandler(this.Route_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker timePickerStop;
        private DateTimePicker timePickerTo;
        private DateTimePicker timePickerFrom;
        private Button buttonCancel;
        private Button buttonSave;
        private Button buttonAddStop;
        private Label labelTimeStop;
        private Label labelNameStop;
        private TextBox textBoxNameStop;
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
        private Button buttonRemoveStop;
    }
}