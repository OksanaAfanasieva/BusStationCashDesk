namespace BusStationCashDesk.Windows_Forms.Warnings
{
    partial class WarningCancel
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
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.labelWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNo
            // 
            this.buttonNo.Location = new System.Drawing.Point(170, 110);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(88, 37);
            this.buttonNo.TabIndex = 5;
            this.buttonNo.Text = "Ні";
            this.buttonNo.UseVisualStyleBackColor = true;
            // 
            // buttonYes
            // 
            this.buttonYes.Location = new System.Drawing.Point(51, 110);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(88, 37);
            this.buttonYes.TabIndex = 4;
            this.buttonYes.Text = "Так";
            this.buttonYes.UseVisualStyleBackColor = true;
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWarning.Location = new System.Drawing.Point(28, 9);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(252, 75);
            this.labelWarning.TabIndex = 3;
            this.labelWarning.Text = "Дані не будуть збережені! Ви\r\nвпевнені, що хочете закрити \r\nсторінку?";
            // 
            // WarningCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 161);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.labelWarning);
            this.MaximumSize = new System.Drawing.Size(325, 200);
            this.MinimumSize = new System.Drawing.Size(325, 200);
            this.Name = "WarningCancel";
            this.Text = "Попередження";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonNo;
        private Button buttonYes;
        private Label labelWarning;
    }
}