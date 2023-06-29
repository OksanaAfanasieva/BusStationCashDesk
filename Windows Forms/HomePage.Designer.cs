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
            this.listRoute = new System.Windows.Forms.ListBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.Location = new System.Drawing.Point(45, 234);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(117, 40);
            this.buttonSearch.TabIndex = 19;
            this.buttonSearch.Text = "Пошук";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonBuy
            // 
            this.buttonBuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBuy.Location = new System.Drawing.Point(628, 408);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(160, 32);
            this.buttonBuy.TabIndex = 18;
            this.buttonBuy.Text = "Купити";
            this.buttonBuy.UseVisualStyleBackColor = true;
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
            // listRoute
            // 
            this.listRoute.FormattingEnabled = true;
            this.listRoute.ItemHeight = 15;
            this.listRoute.Location = new System.Drawing.Point(274, 10);
            this.listRoute.Name = "listRoute";
            this.listRoute.Size = new System.Drawing.Size(514, 394);
            this.listRoute.TabIndex = 15;
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
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.linkLabelMyTravels);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.listRoute);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.textBoxFrom);
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
        private ListBox listRoute;
        private DateTimePicker dateTimePicker;
        private TextBox textBoxTo;
        private Label labelTo;
        private Label labelFrom;
        private TextBox textBoxFrom;
    }
}