namespace BusStationCashDesk
{
    partial class Registration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelRegistration = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.linkLabelToLogIn = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelRegistration
            // 
            this.labelRegistration.AutoSize = true;
            this.labelRegistration.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRegistration.Location = new System.Drawing.Point(98, 52);
            this.labelRegistration.Name = "labelRegistration";
            this.labelRegistration.Size = new System.Drawing.Size(148, 37);
            this.labelRegistration.TabIndex = 0;
            this.labelRegistration.Text = "Реєстрація";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(58, 115);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 25);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Ім\'я";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(27, 140);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(74, 25);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Пароль";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(107, 115);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(203, 23);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(107, 145);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(203, 23);
            this.textBoxPassword.TabIndex = 4;
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRegistration.Location = new System.Drawing.Point(91, 183);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(190, 41);
            this.buttonRegistration.TabIndex = 5;
            this.buttonRegistration.Text = "Зареєструватися";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // linkLabelToLogIn
            // 
            this.linkLabelToLogIn.AutoSize = true;
            this.linkLabelToLogIn.Location = new System.Drawing.Point(117, 227);
            this.linkLabelToLogIn.Name = "linkLabelToLogIn";
            this.linkLabelToLogIn.Size = new System.Drawing.Size(129, 15);
            this.linkLabelToLogIn.TabIndex = 6;
            this.linkLabelToLogIn.TabStop = true;
            this.linkLabelToLogIn.Text = "Я вже зареєстрований";
            this.linkLabelToLogIn.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabelToLogIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 281);
            this.Controls.Add(this.linkLabelToLogIn);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelRegistration);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 320);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реєстрація";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelRegistration;
        private Label labelName;
        private Label labelPassword;
        private TextBox textBoxName;
        private TextBox textBoxPassword;
        private Button buttonRegistration;
        private LinkLabel linkLabelToLogIn;
    }
}