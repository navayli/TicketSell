namespace OnlineTicketDeskUI.Forms
{
    partial class UserDashboard
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
            this.btnLogOutUD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogOutUD
            // 
            this.btnLogOutUD.Location = new System.Drawing.Point(618, 25);
            this.btnLogOutUD.Name = "btnLogOutUD";
            this.btnLogOutUD.Size = new System.Drawing.Size(134, 37);
            this.btnLogOutUD.TabIndex = 0;
            this.btnLogOutUD.Text = "Logout";
            this.btnLogOutUD.UseVisualStyleBackColor = true;
            this.btnLogOutUD.Click += new System.EventHandler(this.btnLogOutUD_Click);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogOutUD);
            this.Name = "UserDashboard";
            this.Text = "UserDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserDashboard_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogOutUD;
    }
}