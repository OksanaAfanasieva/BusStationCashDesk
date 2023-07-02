namespace BusStationCashDesk.Windows_Forms
{
    partial class MyTravel
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
            this.buttonReturnTicket = new System.Windows.Forms.Button();
            this.linkLabelBack = new System.Windows.Forms.LinkLabel();
            this.listTicket = new System.Windows.Forms.ListView();
            this.number = new System.Windows.Forms.ColumnHeader();
            this.from = new System.Windows.Forms.ColumnHeader();
            this.to = new System.Windows.Forms.ColumnHeader();
            this.dateFrom = new System.Windows.Forms.ColumnHeader();
            this.timeFrom = new System.Windows.Forms.ColumnHeader();
            this.seat = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // buttonReturnTicket
            // 
            this.buttonReturnTicket.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReturnTicket.Location = new System.Drawing.Point(580, 391);
            this.buttonReturnTicket.Name = "buttonReturnTicket";
            this.buttonReturnTicket.Size = new System.Drawing.Size(208, 49);
            this.buttonReturnTicket.TabIndex = 4;
            this.buttonReturnTicket.Text = "Повернути квиток";
            this.buttonReturnTicket.UseVisualStyleBackColor = true;
            // 
            // linkLabelBack
            // 
            this.linkLabelBack.AutoSize = true;
            this.linkLabelBack.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelBack.LinkColor = System.Drawing.Color.Black;
            this.linkLabelBack.Location = new System.Drawing.Point(12, 412);
            this.linkLabelBack.Name = "linkLabelBack";
            this.linkLabelBack.Size = new System.Drawing.Size(66, 28);
            this.linkLabelBack.TabIndex = 3;
            this.linkLabelBack.TabStop = true;
            this.linkLabelBack.Text = "Назад";
            this.linkLabelBack.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabelBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBack_LinkClicked);
            // 
            // listTicket
            // 
            this.listTicket.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.from,
            this.to,
            this.dateFrom,
            this.timeFrom,
            this.seat});
            this.listTicket.Location = new System.Drawing.Point(12, 12);
            this.listTicket.Name = "listTicket";
            this.listTicket.Size = new System.Drawing.Size(776, 373);
            this.listTicket.TabIndex = 37;
            this.listTicket.UseCompatibleStateImageBehavior = false;
            this.listTicket.View = System.Windows.Forms.View.Details;
            this.listTicket.DoubleClick += new System.EventHandler(this.listTicket_DoubleClick);
            // 
            // number
            // 
            this.number.Text = "Номер маршруту";
            this.number.Width = 120;
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
            // seat
            // 
            this.seat.Text = "Заброньовано місць";
            this.seat.Width = 130;
            // 
            // MyTravel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listTicket);
            this.Controls.Add(this.buttonReturnTicket);
            this.Controls.Add(this.linkLabelBack);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MyTravel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мої подорожі";
            this.Load += new System.EventHandler(this.MyTravel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonReturnTicket;
        private LinkLabel linkLabelBack;
        private ListView listTicket;
        private ColumnHeader number;
        private ColumnHeader from;
        private ColumnHeader to;
        private ColumnHeader dateFrom;
        private ColumnHeader timeFrom;
        private ColumnHeader seat;
    }
}