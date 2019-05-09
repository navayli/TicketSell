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
            this.lnkCreateTicket = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnLogOutUD
            // 
            this.btnLogOutUD.Location = new System.Drawing.Point(464, 20);
            this.btnLogOutUD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogOutUD.Name = "btnLogOutUD";
            this.btnLogOutUD.Size = new System.Drawing.Size(100, 30);
            this.btnLogOutUD.TabIndex = 0;
            this.btnLogOutUD.Text = "Logout";
            this.btnLogOutUD.UseVisualStyleBackColor = true;
            this.btnLogOutUD.Click += new System.EventHandler(this.btnLogOutUD_Click);
            // 
            // lnkCreateTicket
            // 
            this.lnkCreateTicket.AutoSize = true;
            this.lnkCreateTicket.Location = new System.Drawing.Point(12, 61);
            this.lnkCreateTicket.Name = "lnkCreateTicket";
            this.lnkCreateTicket.Size = new System.Drawing.Size(71, 13);
            this.lnkCreateTicket.TabIndex = 1;
            this.lnkCreateTicket.TabStop = true;
            this.lnkCreateTicket.Text = "Create Ticket";
            this.lnkCreateTicket.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCreateTicket_LinkClicked);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lnkCreateTicket);
            this.Controls.Add(this.btnLogOutUD);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserDashboard";
            this.Text = "UserDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserDashboard_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOutUD;
        private System.Windows.Forms.LinkLabel lnkCreateTicket;
    }
}