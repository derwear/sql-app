
namespace SQLApp
{
    partial class RegForm
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
            this.backPanel = new System.Windows.Forms.Panel();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createLoginLabel = new System.Windows.Forms.Label();
            this.authBtn = new System.Windows.Forms.Button();
            this.tboxKey = new System.Windows.Forms.TextBox();
            this.tboxUser = new System.Windows.Forms.TextBox();
            this.keyIcon = new System.Windows.Forms.PictureBox();
            this.userIcon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeText = new System.Windows.Forms.Label();
            this.authName = new System.Windows.Forms.Label();
            this.registerLabel = new System.Windows.Forms.Label();
            this.backPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backPanel
            // 
            this.backPanel.Controls.Add(this.registerLabel);
            this.backPanel.Controls.Add(this.nameBox);
            this.backPanel.Controls.Add(this.surnameBox);
            this.backPanel.Controls.Add(this.label1);
            this.backPanel.Controls.Add(this.createLoginLabel);
            this.backPanel.Controls.Add(this.authBtn);
            this.backPanel.Controls.Add(this.tboxKey);
            this.backPanel.Controls.Add(this.tboxUser);
            this.backPanel.Controls.Add(this.keyIcon);
            this.backPanel.Controls.Add(this.userIcon);
            this.backPanel.Controls.Add(this.panel1);
            this.backPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(340, 614);
            this.backPanel.TabIndex = 3;
            this.backPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.backPanel_MouseDown);
            this.backPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.backPanel_MouseMove);
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Proxima Nova Rg", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameBox.Location = new System.Drawing.Point(102, 159);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(209, 33);
            this.nameBox.TabIndex = 9;
            this.nameBox.Enter += new System.EventHandler(this.nameBox_Enter);
            this.nameBox.Leave += new System.EventHandler(this.nameBox_Leave);
            // 
            // surnameBox
            // 
            this.surnameBox.Font = new System.Drawing.Font("Proxima Nova Rg", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surnameBox.Location = new System.Drawing.Point(102, 237);
            this.surnameBox.Multiline = true;
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(209, 33);
            this.surnameBox.TabIndex = 8;
            this.surnameBox.Enter += new System.EventHandler(this.surnameBox_Enter);
            this.surnameBox.Leave += new System.EventHandler(this.surnameBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Proxima Nova Rg", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(100, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Придумайте пароль (до 20 символов)";
            // 
            // createLoginLabel
            // 
            this.createLoginLabel.AutoSize = true;
            this.createLoginLabel.Font = new System.Drawing.Font("Proxima Nova Rg", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createLoginLabel.Location = new System.Drawing.Point(100, 299);
            this.createLoginLabel.Name = "createLoginLabel";
            this.createLoginLabel.Size = new System.Drawing.Size(211, 15);
            this.createLoginLabel.TabIndex = 6;
            this.createLoginLabel.Text = "Придумайте логин (до 20 символов)";
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
            this.authBtn.Location = new System.Drawing.Point(30, 497);
            this.authBtn.Name = "authBtn";
            this.authBtn.Size = new System.Drawing.Size(272, 50);
            this.authBtn.TabIndex = 4;
            this.authBtn.Text = "Зарегистрироваться";
            this.authBtn.UseVisualStyleBackColor = false;
            this.authBtn.Click += new System.EventHandler(this.authBtn_Click);
            // 
            // tboxKey
            // 
            this.tboxKey.Font = new System.Drawing.Font("Proxima Nova Rg", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxKey.Location = new System.Drawing.Point(102, 413);
            this.tboxKey.MaxLength = 15;
            this.tboxKey.Name = "tboxKey";
            this.tboxKey.Size = new System.Drawing.Size(209, 22);
            this.tboxKey.TabIndex = 3;
            this.tboxKey.UseSystemPasswordChar = true;
            // 
            // tboxUser
            // 
            this.tboxUser.Font = new System.Drawing.Font("Proxima Nova Rg", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxUser.Location = new System.Drawing.Point(102, 317);
            this.tboxUser.Multiline = true;
            this.tboxUser.Name = "tboxUser";
            this.tboxUser.Size = new System.Drawing.Size(209, 33);
            this.tboxUser.TabIndex = 2;
            // 
            // keyIcon
            // 
            this.keyIcon.Image = global::SQLApp.Properties.Resources.password;
            this.keyIcon.InitialImage = global::SQLApp.Properties.Resources.password;
            this.keyIcon.Location = new System.Drawing.Point(24, 400);
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
            this.userIcon.Location = new System.Drawing.Point(21, 299);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(64, 64);
            this.userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userIcon.TabIndex = 0;
            this.userIcon.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.closeText);
            this.panel1.Controls.Add(this.authName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 100);
            this.panel1.TabIndex = 5;
            // 
            // closeText
            // 
            this.closeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeText.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.closeText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.closeText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.closeText.Location = new System.Drawing.Point(282, 9);
            this.closeText.Name = "closeText";
            this.closeText.Size = new System.Drawing.Size(58, 15);
            this.closeText.TabIndex = 4;
            this.closeText.Text = "Закрыть";
            this.closeText.Click += new System.EventHandler(this.closeText_Click);
            // 
            // authName
            // 
            this.authName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.authName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authName.Font = new System.Drawing.Font("Proxima Nova Rg", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.authName.Location = new System.Drawing.Point(0, 0);
            this.authName.Name = "authName";
            this.authName.Size = new System.Drawing.Size(340, 100);
            this.authName.TabIndex = 5;
            this.authName.Text = "Регистрация";
            this.authName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerLabel.Font = new System.Drawing.Font("Proxima Nova Rg", 8.999999F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.registerLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.registerLabel.Location = new System.Drawing.Point(102, 563);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(109, 15);
            this.registerLabel.TabIndex = 10;
            this.registerLabel.Text = "Уже есть аккаунт?";
            this.registerLabel.Click += new System.EventHandler(this.registerLabel_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 614);
            this.Controls.Add(this.backPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegForm";
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Button authBtn;
        private System.Windows.Forms.TextBox tboxKey;
        private System.Windows.Forms.TextBox tboxUser;
        private System.Windows.Forms.PictureBox keyIcon;
        private System.Windows.Forms.PictureBox userIcon;
        private System.Windows.Forms.Label closeText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label authName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label createLoginLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label registerLabel;
    }
}