namespace OnlineTicketDeskUI.Forms
{
    partial class AddTicket
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbxTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbxDescription = new System.Windows.Forms.RichTextBox();
            this.btnCreateTicket = new System.Windows.Forms.Button();
            this.btnToDashboard = new System.Windows.Forms.Button();
            this.lnkCount = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // txbxTitle
            // 
            this.txbxTitle.Location = new System.Drawing.Point(44, 57);
            this.txbxTitle.Name = "txbxTitle";
            this.txbxTitle.Size = new System.Drawing.Size(100, 20);
            this.txbxTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // txbxDescription
            // 
            this.txbxDescription.Location = new System.Drawing.Point(44, 128);
            this.txbxDescription.Name = "txbxDescription";
            this.txbxDescription.Size = new System.Drawing.Size(209, 96);
            this.txbxDescription.TabIndex = 3;
            this.txbxDescription.Text = "";
            // 
            // btnCreateTicket
            // 
            this.btnCreateTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTicket.Location = new System.Drawing.Point(44, 273);
            this.btnCreateTicket.Name = "btnCreateTicket";
            this.btnCreateTicket.Size = new System.Drawing.Size(110, 44);
            this.btnCreateTicket.TabIndex = 4;
            this.btnCreateTicket.Text = "Crate Ticket";
            this.btnCreateTicket.UseVisualStyleBackColor = true;
            this.btnCreateTicket.Click += new System.EventHandler(this.btnCreateTicket_Click);
            // 
            // btnToDashboard
            // 
            this.btnToDashboard.Location = new System.Drawing.Point(625, 13);
            this.btnToDashboard.Name = "btnToDashboard";
            this.btnToDashboard.Size = new System.Drawing.Size(149, 23);
            this.btnToDashboard.TabIndex = 5;
            this.btnToDashboard.Text = "Go to User Dashboard";
            this.btnToDashboard.UseVisualStyleBackColor = true;
            this.btnToDashboard.Click += new System.EventHandler(this.btnToDashboard_Click);
            // 
            // lnkCount
            // 
            this.lnkCount.AutoSize = true;
            this.lnkCount.Location = new System.Drawing.Point(205, 283);
            this.lnkCount.Name = "lnkCount";
            this.lnkCount.Size = new System.Drawing.Size(13, 13);
            this.lnkCount.TabIndex = 6;
            this.lnkCount.TabStop = true;
            this.lnkCount.Text = "0";
            // 
            // AddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lnkCount);
            this.Controls.Add(this.btnToDashboard);
            this.Controls.Add(this.btnCreateTicket);
            this.Controls.Add(this.txbxDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbxTitle);
            this.Controls.Add(this.label1);
            this.Name = "AddTicket";
            this.Text = "AddTicket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbxTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txbxDescription;
        private System.Windows.Forms.Button btnCreateTicket;
        private System.Windows.Forms.Button btnToDashboard;
        private System.Windows.Forms.LinkLabel lnkCount;
    }
}