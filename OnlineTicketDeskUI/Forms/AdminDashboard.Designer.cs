namespace OnlineTicketDeskUI.Forms
{
    partial class AdminDashboard
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
            this.linkAddCard = new System.Windows.Forms.LinkLabel();
            this.linkShowCard = new System.Windows.Forms.LinkLabel();
            this.linkUsers = new System.Windows.Forms.LinkLabel();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkAddCard
            // 
            this.linkAddCard.AutoSize = true;
            this.linkAddCard.Location = new System.Drawing.Point(25, 76);
            this.linkAddCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkAddCard.Name = "linkAddCard";
            this.linkAddCard.Size = new System.Drawing.Size(56, 13);
            this.linkAddCard.TabIndex = 0;
            this.linkAddCard.TabStop = true;
            this.linkAddCard.Text = "Add Cards";
            this.linkAddCard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAddCard_LinkClicked);
            // 
            // linkShowCard
            // 
            this.linkShowCard.AutoSize = true;
            this.linkShowCard.Location = new System.Drawing.Point(25, 116);
            this.linkShowCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkShowCard.Name = "linkShowCard";
            this.linkShowCard.Size = new System.Drawing.Size(64, 13);
            this.linkShowCard.TabIndex = 2;
            this.linkShowCard.TabStop = true;
            this.linkShowCard.Text = "Show Cards";
            this.linkShowCard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkShowCard_LinkClicked);
            // 
            // linkUsers
            // 
            this.linkUsers.AutoSize = true;
            this.linkUsers.Location = new System.Drawing.Point(25, 157);
            this.linkUsers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkUsers.Name = "linkUsers";
            this.linkUsers.Size = new System.Drawing.Size(64, 13);
            this.linkUsers.TabIndex = 3;
            this.linkUsers.TabStop = true;
            this.linkUsers.Text = "Show Users";
            this.linkUsers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUsers_LinkClicked);
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Location = new System.Drawing.Point(458, 42);
            this.lblGreeting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(31, 13);
            this.lblGreeting.TabIndex = 4;
            this.lblGreeting.Text = "Hello";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(460, 11);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(119, 29);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.linkUsers);
            this.Controls.Add(this.linkShowCard);
            this.Controls.Add(this.linkAddCard);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminDashboard_FormClosed);
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkAddCard;
        private System.Windows.Forms.LinkLabel linkShowCard;
        private System.Windows.Forms.LinkLabel linkUsers;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Button btnLogout;
    }
}