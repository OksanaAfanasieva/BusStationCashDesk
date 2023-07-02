namespace BusStationCashDesk.Windows_Forms
{
    partial class BoardingList
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
            this.back = new System.Windows.Forms.LinkLabel();
            this.passengerList = new System.Windows.Forms.ListView();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.surname = new System.Windows.Forms.ColumnHeader();
            this.reservedSeat = new System.Windows.Forms.ColumnHeader();
            this.price = new System.Windows.Forms.ColumnHeader();
            this.numberRouteTextBox = new System.Windows.Forms.TextBox();
            this.numberRouteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.back.AutoSize = true;
            this.back.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.back.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.back.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.back.Location = new System.Drawing.Point(7, 413);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(68, 28);
            this.back.TabIndex = 7;
            this.back.TabStop = true;
            this.back.Text = "Назад";
            this.back.VisitedLinkColor = System.Drawing.Color.Black;
            this.back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBack_LinkClicked);
            // 
            // passengerList
            // 
            this.passengerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passengerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.surname,
            this.reservedSeat,
            this.price});
            this.passengerList.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passengerList.FullRowSelect = true;
            this.passengerList.Location = new System.Drawing.Point(7, 52);
            this.passengerList.Name = "passengerList";
            this.passengerList.Size = new System.Drawing.Size(786, 358);
            this.passengerList.TabIndex = 6;
            this.passengerList.UseCompatibleStateImageBehavior = false;
            this.passengerList.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Ім\'я";
            this.name.Width = 240;
            // 
            // surname
            // 
            this.surname.Text = "Прізвище";
            this.surname.Width = 240;
            // 
            // reservedSeat
            // 
            this.reservedSeat.Text = "Кількість місць";
            this.reservedSeat.Width = 150;
            // 
            // price
            // 
            this.price.Text = "Сума";
            this.price.Width = 150;
            // 
            // numberRouteTextBox
            // 
            this.numberRouteTextBox.BackColor = System.Drawing.Color.White;
            this.numberRouteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numberRouteTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberRouteTextBox.ForeColor = System.Drawing.Color.Black;
            this.numberRouteTextBox.Location = new System.Drawing.Point(138, 14);
            this.numberRouteTextBox.Name = "numberRouteTextBox";
            this.numberRouteTextBox.ReadOnly = true;
            this.numberRouteTextBox.Size = new System.Drawing.Size(100, 23);
            this.numberRouteTextBox.TabIndex = 5;
            this.numberRouteTextBox.TabStop = false;
            // 
            // numberRouteLabel
            // 
            this.numberRouteLabel.AutoSize = true;
            this.numberRouteLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberRouteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.numberRouteLabel.Location = new System.Drawing.Point(7, 9);
            this.numberRouteLabel.Name = "numberRouteLabel";
            this.numberRouteLabel.Size = new System.Drawing.Size(129, 28);
            this.numberRouteLabel.TabIndex = 4;
            this.numberRouteLabel.Text = "Маршрут №";
            // 
            // BoardingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.passengerList);
            this.Controls.Add(this.numberRouteTextBox);
            this.Controls.Add(this.numberRouteLabel);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "BoardingList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Посадкова відомість";
            this.Load += new System.EventHandler(this.BoardingList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel back;
        private ListView passengerList;
        private ColumnHeader name;
        private ColumnHeader surname;
        private ColumnHeader reservedSeat;
        private ColumnHeader price;
        private TextBox numberRouteTextBox;
        private Label numberRouteLabel;
    }
}