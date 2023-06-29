namespace BusStationCashDesk.Windows_Forms
{
    partial class LogIn
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
            this.linkLabelToRegistration = new System.Windows.Forms.LinkLabel();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLogIn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabelToRegistration
            // 
            this.linkLabelToRegistration.AutoSize = true;
            this.linkLabelToRegistration.Location = new System.Drawing.Point(136, 226);
            this.linkLabelToRegistration.Name = "linkLabelToRegistration";
            this.linkLabelToRegistration.Size = new System.Drawing.Size(99, 15);
            this.linkLabelToRegistration.TabIndex = 13;
            this.linkLabelToRegistration.TabStop = true;
            this.linkLabelToRegistration.Text = "Зареєструватися";
            this.linkLabelToRegistration.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabelToRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogIn.Location = new System.Drawing.Point(91, 182);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(190, 41);
            this.buttonLogIn.TabIndex = 12;
            this.buttonLogIn.Text = "Увійти";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(107, 144);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(203, 23);
            this.textBoxPassword.TabIndex = 11;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(107, 114);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(203, 23);
            this.textBoxName.TabIndex = 10;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(27, 139);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(74, 25);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "Пароль";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(58, 114);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 25);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Ім\'я";
            // 
            // labelLogIn
            // 
            this.labelLogIn.AutoSize = true;
            this.labelLogIn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLogIn.Location = new System.Drawing.Point(136, 47);
            this.labelLogIn.Name = "labelLogIn";
            this.labelLogIn.Size = new System.Drawing.Size(66, 37);
            this.labelLogIn.TabIndex = 7;
            this.labelLogIn.Text = "Вхід";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 281);
            this.Controls.Add(this.linkLabelToRegistration);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelLogIn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 320);
            this.MinimumSize = new System.Drawing.Size(360, 320);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вхід";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel linkLabelToRegistration;
        private Button buttonLogIn;
        private TextBox textBoxPassword;
        private TextBox textBoxName;
        private Label labelPassword;
        private Label labelName;
        private Label labelLogIn;
    }
}