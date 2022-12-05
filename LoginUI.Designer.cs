using System;

namespace Lead.Tool.Login
{
    partial class LoginUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUI));
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.labelWarnning = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.button修改密码 = new System.Windows.Forms.Button();
            this.button取消修改 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPassWord = new System.Windows.Forms.TextBox();
            this.button登录 = new System.Windows.Forms.Button();
            this.button取消 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button登出取消 = new System.Windows.Forms.Button();
            this.button登出 = new System.Windows.Forms.Button();
            this.labelResetPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLevel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Location = new System.Drawing.Point(245, 71);
            this.comboBoxLevel.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(140, 30);
            this.comboBoxLevel.TabIndex = 0;
            this.comboBoxLevel.SelectedIndexChanged += new System.EventHandler(this.comboBoxLevel_SelectedIndexChanged);
            // 
            // labelWarnning
            // 
            this.labelWarnning.AutoSize = true;
            this.labelWarnning.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWarnning.Location = new System.Drawing.Point(184, 7);
            this.labelWarnning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWarnning.Name = "labelWarnning";
            this.labelWarnning.Size = new System.Drawing.Size(0, 19);
            this.labelWarnning.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxOldPassword);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxNewPassword);
            this.groupBox2.Controls.Add(this.button修改密码);
            this.groupBox2.Controls.Add(this.button取消修改);
            this.groupBox2.Location = new System.Drawing.Point(100, 125);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(305, 172);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "修改密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑 Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(25, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "旧密码：";
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxOldPassword.Location = new System.Drawing.Point(145, 18);
            this.textBoxOldPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.PasswordChar = '*';
            this.textBoxOldPassword.Size = new System.Drawing.Size(140, 29);
            this.textBoxOldPassword.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑 Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(25, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "新密码：";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxNewPassword.Location = new System.Drawing.Point(145, 59);
            this.textBoxNewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.Size = new System.Drawing.Size(140, 29);
            this.textBoxNewPassword.TabIndex = 9;
            // 
            // button修改密码
            // 
            this.button修改密码.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button修改密码.Image = ((System.Drawing.Image)(resources.GetObject("button修改密码.Image")));
            this.button修改密码.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button修改密码.Location = new System.Drawing.Point(24, 101);
            this.button修改密码.Margin = new System.Windows.Forms.Padding(2);
            this.button修改密码.Name = "button修改密码";
            this.button修改密码.Size = new System.Drawing.Size(95, 59);
            this.button修改密码.TabIndex = 8;
            this.button修改密码.Text = "修改";
            this.button修改密码.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button修改密码.UseVisualStyleBackColor = true;
            this.button修改密码.Click += new System.EventHandler(this.button修改密码_Click);
            // 
            // button取消修改
            // 
            this.button取消修改.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button取消修改.Image = ((System.Drawing.Image)(resources.GetObject("button取消修改.Image")));
            this.button取消修改.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button取消修改.Location = new System.Drawing.Point(191, 101);
            this.button取消修改.Margin = new System.Windows.Forms.Padding(2);
            this.button取消修改.Name = "button取消修改";
            this.button取消修改.Size = new System.Drawing.Size(92, 59);
            this.button取消修改.TabIndex = 7;
            this.button取消修改.Text = "取消";
            this.button取消修改.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button取消修改.UseVisualStyleBackColor = true;
            this.button取消修改.Click += new System.EventHandler(this.button取消修改_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxPassWord);
            this.groupBox1.Controls.Add(this.button登录);
            this.groupBox1.Controls.Add(this.button取消);
            this.groupBox1.Location = new System.Drawing.Point(100, 125);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(305, 172);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑 Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(25, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "密码：";
            // 
            // textBoxPassWord
            // 
            this.textBoxPassWord.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPassWord.Location = new System.Drawing.Point(145, 25);
            this.textBoxPassWord.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassWord.Name = "textBoxPassWord";
            this.textBoxPassWord.PasswordChar = '*';
            this.textBoxPassWord.Size = new System.Drawing.Size(140, 29);
            this.textBoxPassWord.TabIndex = 9;
            // 
            // button登录
            // 
            this.button登录.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button登录.Image = ((System.Drawing.Image)(resources.GetObject("button登录.Image")));
            this.button登录.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button登录.Location = new System.Drawing.Point(20, 86);
            this.button登录.Margin = new System.Windows.Forms.Padding(2);
            this.button登录.Name = "button登录";
            this.button登录.Size = new System.Drawing.Size(105, 52);
            this.button登录.TabIndex = 8;
            this.button登录.Text = "登录";
            this.button登录.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button登录.UseVisualStyleBackColor = true;
            this.button登录.Click += new System.EventHandler(this.button登录_Click);
            // 
            // button取消
            // 
            this.button取消.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button取消.Image = ((System.Drawing.Image)(resources.GetObject("button取消.Image")));
            this.button取消.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button取消.Location = new System.Drawing.Point(191, 86);
            this.button取消.Margin = new System.Windows.Forms.Padding(2);
            this.button取消.Name = "button取消";
            this.button取消.Size = new System.Drawing.Size(101, 52);
            this.button取消.TabIndex = 7;
            this.button取消.Text = "取消";
            this.button取消.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button取消.UseVisualStyleBackColor = true;
            this.button取消.Click += new System.EventHandler(this.button取消_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button登出取消);
            this.groupBox3.Controls.Add(this.button登出);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox3.Location = new System.Drawing.Point(100, 125);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(305, 172);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // button登出取消
            // 
            this.button登出取消.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button登出取消.Image = ((System.Drawing.Image)(resources.GetObject("button登出取消.Image")));
            this.button登出取消.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button登出取消.Location = new System.Drawing.Point(191, 56);
            this.button登出取消.Margin = new System.Windows.Forms.Padding(2);
            this.button登出取消.Name = "button登出取消";
            this.button登出取消.Size = new System.Drawing.Size(94, 53);
            this.button登出取消.TabIndex = 9;
            this.button登出取消.Text = "取消";
            this.button登出取消.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button登出取消.UseVisualStyleBackColor = true;
            this.button登出取消.Click += new System.EventHandler(this.button登出取消_Click);
            // 
            // button登出
            // 
            this.button登出.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button登出.Image = ((System.Drawing.Image)(resources.GetObject("button登出.Image")));
            this.button登出.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button登出.Location = new System.Drawing.Point(20, 55);
            this.button登出.Margin = new System.Windows.Forms.Padding(2);
            this.button登出.Name = "button登出";
            this.button登出.Size = new System.Drawing.Size(94, 53);
            this.button登出.TabIndex = 8;
            this.button登出.Text = "登出";
            this.button登出.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button登出.UseVisualStyleBackColor = true;
            this.button登出.Click += new System.EventHandler(this.button登出_Click);
            // 
            // labelResetPassword
            // 
            this.labelResetPassword.AutoSize = true;
            this.labelResetPassword.Font = new System.Drawing.Font("微软雅黑 Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelResetPassword.Image = ((System.Drawing.Image)(resources.GetObject("labelResetPassword.Image")));
            this.labelResetPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelResetPassword.Location = new System.Drawing.Point(407, 316);
            this.labelResetPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResetPassword.Name = "labelResetPassword";
            this.labelResetPassword.Size = new System.Drawing.Size(89, 20);
            this.labelResetPassword.TabIndex = 4;
            this.labelResetPassword.Text = "     重置密码";
            this.labelResetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelResetPassword.Click += new System.EventHandler(this.labelResetPassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(120, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "       权限：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LoginUI
            // 
            this.AcceptButton = this.button登录;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(505, 343);
            this.Controls.Add(this.labelWarnning);
            this.Controls.Add(this.labelResetPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxLevel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginUI";
            this.Text = "LoginUI";
            this.Shown += new System.EventHandler(this.LoginUI_Shown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelResetPassword;
        private System.Windows.Forms.Label labelWarnning;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Button button修改密码;
        private System.Windows.Forms.Button button取消修改;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPassWord;
        private System.Windows.Forms.Button button登录;
        private System.Windows.Forms.Button button取消;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button登出;
        private System.Windows.Forms.Button button登出取消;
    }
    [Serializable]
    public class password
    {
        public string passWord { get; set; }
    }
}