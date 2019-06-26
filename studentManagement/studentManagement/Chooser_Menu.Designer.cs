namespace studentManagement
{
    partial class Chooser_Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chooser_Menu));
            this.adminbutton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.Label();
            this.Admin = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adminbutton
            // 
            this.adminbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adminbutton.BackgroundImage")));
            this.adminbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminbutton.Location = new System.Drawing.Point(33, 87);
            this.adminbutton.Name = "adminbutton";
            this.adminbutton.Size = new System.Drawing.Size(113, 120);
            this.adminbutton.TabIndex = 0;
            this.adminbutton.UseVisualStyleBackColor = true;
            this.adminbutton.Click += new System.EventHandler(this.adminbutton_Click);
            // 
            // userButton
            // 
            this.userButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userButton.BackgroundImage")));
            this.userButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userButton.Location = new System.Drawing.Point(216, 87);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(110, 120);
            this.userButton.TabIndex = 1;
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.White;
            this.User.Location = new System.Drawing.Point(249, 66);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(47, 20);
            this.User.TabIndex = 2;
            this.User.Text = "User";
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.Color.White;
            this.Admin.Location = new System.Drawing.Point(56, 66);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(59, 20);
            this.Admin.TabIndex = 3;
            this.Admin.Text = "Admin";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.button3.Location = new System.Drawing.Point(286, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 37);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "DR Education";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Chooser_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(362, 293);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.User);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.adminbutton);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Chooser_Menu";
            this.Text = "Chooser_Menu";
            this.Load += new System.EventHandler(this.Chooser_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adminbutton;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
    }
}