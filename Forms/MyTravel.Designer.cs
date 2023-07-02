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
            this.returnTicket = new System.Windows.Forms.Button();
            this.backLinkLabel = new System.Windows.Forms.LinkLabel();
            this.listTicket = new System.Windows.Forms.ListView();
            this.number = new System.Windows.Forms.ColumnHeader();
            this.from = new System.Windows.Forms.ColumnHeader();
            this.to = new System.Windows.Forms.ColumnHeader();
            this.dateFrom = new System.Windows.Forms.ColumnHeader();
            this.timeFrom = new System.Windows.Forms.ColumnHeader();
            this.seat = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // returnTicket
            // 
            this.returnTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.returnTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.returnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnTicket.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.returnTicket.ForeColor = System.Drawing.Color.White;
            this.returnTicket.Location = new System.Drawing.Point(793, 391);
            this.returnTicket.Name = "returnTicket";
            this.returnTicket.Size = new System.Drawing.Size(208, 49);
            this.returnTicket.TabIndex = 4;
            this.returnTicket.Text = "Повернути квиток";
            this.returnTicket.UseVisualStyleBackColor = false;
            this.returnTicket.Click += new System.EventHandler(this.buttonReturnTicket_Click);
            // 
            // backLinkLabel
            // 
            this.backLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.backLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backLinkLabel.AutoSize = true;
            this.backLinkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backLinkLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.backLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.backLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.backLinkLabel.Location = new System.Drawing.Point(12, 412);
            this.backLinkLabel.Name = "backLinkLabel";
            this.backLinkLabel.Size = new System.Drawing.Size(68, 28);
            this.backLinkLabel.TabIndex = 3;
            this.backLinkLabel.TabStop = true;
            this.backLinkLabel.Text = "Назад";
            this.backLinkLabel.VisitedLinkColor = System.Drawing.Color.Black;
            this.backLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBack_LinkClicked);
            // 
            // listTicket
            // 
            this.listTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listTicket.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.from,
            this.to,
            this.dateFrom,
            this.timeFrom,
            this.seat});
            this.listTicket.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listTicket.FullRowSelect = true;
            this.listTicket.Location = new System.Drawing.Point(12, 12);
            this.listTicket.Name = "listTicket";
            this.listTicket.Size = new System.Drawing.Size(989, 373);
            this.listTicket.TabIndex = 37;
            this.listTicket.UseCompatibleStateImageBehavior = false;
            this.listTicket.View = System.Windows.Forms.View.Details;
            this.listTicket.DoubleClick += new System.EventHandler(this.listTicket_DoubleClick);
            // 
            // number
            // 
            this.number.Text = "Номер маршруту";
            this.number.Width = 160;
            // 
            // from
            // 
            this.from.Text = "Місто відправлення";
            this.from.Width = 180;
            // 
            // to
            // 
            this.to.Text = "Місто призначення";
            this.to.Width = 180;
            // 
            // dateFrom
            // 
            this.dateFrom.Text = "Дата";
            this.dateFrom.Width = 120;
            // 
            // timeFrom
            // 
            this.timeFrom.Text = "Час відправлення";
            this.timeFrom.Width = 160;
            // 
            // seat
            // 
            this.seat.Text = "Заброньовано місць";
            this.seat.Width = 180;
            // 
            // MyTravel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1013, 450);
            this.Controls.Add(this.listTicket);
            this.Controls.Add(this.returnTicket);
            this.Controls.Add(this.backLinkLabel);
            this.MinimumSize = new System.Drawing.Size(1029, 489);
            this.Name = "MyTravel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мої подорожі";
            this.Load += new System.EventHandler(this.MyTravel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button returnTicket;
        private LinkLabel backLinkLabel;
        private ListView listTicket;
        private ColumnHeader number;
        private ColumnHeader from;
        private ColumnHeader to;
        private ColumnHeader dateFrom;
        private ColumnHeader timeFrom;
        private ColumnHeader seat;
    }
}