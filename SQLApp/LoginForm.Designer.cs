
namespace SQLApp
{
    partial class LoginForm
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.closeText = new System.Windows.Forms.Label();
            this.authName = new System.Windows.Forms.Label();
            this.backPanel = new System.Windows.Forms.Panel();
            this.registerLabel = new System.Windows.Forms.Label();
            this.authBtn = new System.Windows.Forms.Button();
            this.tboxKey = new System.Windows.Forms.TextBox();
            this.tboxUser = new System.Windows.Forms.TextBox();
            this.keyIcon = new System.Windows.Forms.PictureBox();
            this.userIcon = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            this.backPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.topPanel.Controls.Add(this.closeText);
            this.topPanel.Controls.Add(this.authName);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(325, 90);
            this.topPanel.TabIndex = 0;
            // 
            // closeText
            // 
            this.closeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.closeText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.closeText.Location = new System.Drawing.Point(267, 0);
            this.closeText.Name = "closeText";
            this.closeText.Size = new System.Drawing.Size(58, 15);
            this.closeText.TabIndex = 1;
            this.closeText.Text = "Закрыть";
            this.closeText.Click += new System.EventHandler(this.closeText_Click);
            // 
            // authName
            // 
            this.authName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authName.Font = new System.Drawing.Font("Proxima Nova Rg", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.authName.Location = new System.Drawing.Point(0, 0);
            this.authName.Name = "authName";
            this.authName.Size = new System.Drawing.Size(325, 90);
            this.authName.TabIndex = 0;
            this.authName.Text = "Авторизация";
            this.authName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backPanel
            // 
            this.backPanel.Controls.Add(this.registerLabel);
            this.backPanel.Controls.Add(this.authBtn);
            this.backPanel.Controls.Add(this.tboxKey);
            this.backPanel.Controls.Add(this.tboxUser);
            this.backPanel.Controls.Add(this.keyIcon);
            this.backPanel.Controls.Add(this.userIcon);
            this.backPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(325, 461);
            this.backPanel.TabIndex = 1;
            this.backPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.backPanel_MouseDown);
            this.backPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.backPanel_MouseMove);
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerLabel.Font = new System.Drawing.Font("Proxima Nova Rg", 8.999999F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.registerLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.registerLabel.Location = new System.Drawing.Point(102, 421);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(110, 15);
            this.registerLabel.TabIndex = 5;
            this.registerLabel.Text = "Еще нет аккаунта?";
            this.registerLabel.Click += new System.EventHandler(this.registerLabel_Click);
            // 
            // authBtn
            // 
            this.authBtn.BackColor = System.Drawing.Color.Lime;
            this.authBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authBtn.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.authBtn.FlatAppearance.BorderSize = 0;
            this.authBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.authBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.authBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authBtn.Font = new System.Drawing.Font("Proxima Nova Rg", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.authBtn.Location = new System.Drawing.Point(97, 357);
            this.authBtn.Name = "authBtn";
            this.authBtn.Size = new System.Drawing.Size(120, 50);
            this.authBtn.TabIndex = 4;
            this.authBtn.Text = "Вход";
            this.authBtn.UseVisualStyleBackColor = false;
            this.authBtn.Click += new System.EventHandler(this.authBtn_Click);
            // 
            // tboxKey
            // 
            this.tboxKey.Font = new System.Drawing.Font("Proxima Nova Rg", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxKey.Location = new System.Drawing.Point(93, 244);
            this.tboxKey.MaxLength = 15;
            this.tboxKey.Name = "tboxKey";
            this.tboxKey.Size = new System.Drawing.Size(209, 22);
            this.tboxKey.TabIndex = 3;
            this.tboxKey.UseSystemPasswordChar = true;
            // 
            // tboxUser
            // 
            this.tboxUser.Font = new System.Drawing.Font("Proxima Nova Rg", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxUser.Location = new System.Drawing.Point(93, 148);
            this.tboxUser.Multiline = true;
            this.tboxUser.Name = "tboxUser";
            this.tboxUser.Size = new System.Drawing.Size(209, 33);
            this.tboxUser.TabIndex = 2;
            // 
            // keyIcon
            // 
            this.keyIcon.Image = global::SQLApp.Properties.Resources.password;
            this.keyIcon.InitialImage = global::SQLApp.Properties.Resources.password;
            this.keyIcon.Location = new System.Drawing.Point(15, 231);
            this.keyIcon.Name = "keyIcon";
            this.keyIcon.Size = new System.Drawing.Size(57, 57);
            this.keyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.keyIcon.TabIndex = 1;
            this.keyIcon.TabStop = false;
            // 
            // userIcon
            // 
            this.userIcon.Image = global::SQLApp.Properties.Resources.user;
            this.userIcon.InitialImage = global::SQLApp.Properties.Resources.user;
            this.userIcon.Location = new System.Drawing.Point(12, 130);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(64, 64);
            this.userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userIcon.TabIndex = 0;
            this.userIcon.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 461);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.backPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.topPanel.ResumeLayout(false);
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Label authName;
        private System.Windows.Forms.Label closeText;
        private System.Windows.Forms.PictureBox userIcon;
        private System.Windows.Forms.PictureBox keyIcon;
        private System.Windows.Forms.Button authBtn;
        private System.Windows.Forms.TextBox tboxKey;
        private System.Windows.Forms.TextBox tboxUser;
        private System.Windows.Forms.Label registerLabel;
    }
}