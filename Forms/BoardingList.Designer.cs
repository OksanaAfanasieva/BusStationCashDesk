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
            this.linkLabelBack = new System.Windows.Forms.LinkLabel();
            this.listViewPassenger = new System.Windows.Forms.ListView();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.surname = new System.Windows.Forms.ColumnHeader();
            this.reservedSeat = new System.Windows.Forms.ColumnHeader();
            this.price = new System.Windows.Forms.ColumnHeader();
            this.textBoxNumberRoute = new System.Windows.Forms.TextBox();
            this.labelNumberRoute = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabelBack
            // 
            this.linkLabelBack.AutoSize = true;
            this.linkLabelBack.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelBack.LinkColor = System.Drawing.Color.Black;
            this.linkLabelBack.Location = new System.Drawing.Point(7, 413);
            this.linkLabelBack.Name = "linkLabelBack";
            this.linkLabelBack.Size = new System.Drawing.Size(66, 28);
            this.linkLabelBack.TabIndex = 7;
            this.linkLabelBack.TabStop = true;
            this.linkLabelBack.Text = "Назад";
            this.linkLabelBack.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // listViewPassenger
            // 
            this.listViewPassenger.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.surname,
            this.reservedSeat,
            this.price});
            this.listViewPassenger.Location = new System.Drawing.Point(7, 52);
            this.listViewPassenger.Name = "listViewPassenger";
            this.listViewPassenger.Size = new System.Drawing.Size(786, 358);
            this.listViewPassenger.TabIndex = 6;
            this.listViewPassenger.UseCompatibleStateImageBehavior = false;
            this.listViewPassenger.View = System.Windows.Forms.View.Details;
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
            // textBoxNumberRoute
            // 
            this.textBoxNumberRoute.Location = new System.Drawing.Point(138, 14);
            this.textBoxNumberRoute.Name = "textBoxNumberRoute";
            this.textBoxNumberRoute.ReadOnly = true;
            this.textBoxNumberRoute.Size = new System.Drawing.Size(100, 23);
            this.textBoxNumberRoute.TabIndex = 5;
            // 
            // labelNumberRoute
            // 
            this.labelNumberRoute.AutoSize = true;
            this.labelNumberRoute.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNumberRoute.Location = new System.Drawing.Point(7, 9);
            this.labelNumberRoute.Name = "labelNumberRoute";
            this.labelNumberRoute.Size = new System.Drawing.Size(125, 28);
            this.labelNumberRoute.TabIndex = 4;
            this.labelNumberRoute.Text = "Маршрут №";
            // 
            // BoardingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabelBack);
            this.Controls.Add(this.listViewPassenger);
            this.Controls.Add(this.textBoxNumberRoute);
            this.Controls.Add(this.labelNumberRoute);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "BoardingList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Посадкова відомість";
            this.Load += new System.EventHandler(this.BoardingList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel linkLabelBack;
        private ListView listViewPassenger;
        private ColumnHeader name;
        private ColumnHeader surname;
        private ColumnHeader reservedSeat;
        private ColumnHeader price;
        private TextBox textBoxNumberRoute;
        private Label labelNumberRoute;
    }
}