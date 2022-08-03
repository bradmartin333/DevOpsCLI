namespace DevOpsCLI
{
    partial class UserEntry
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
            this.ComboNames = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblAssignedUser = new System.Windows.Forms.Label();
            this.LblUserStoryTitle = new System.Windows.Forms.Label();
            this.LblSprintNumber = new System.Windows.Forms.Label();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.TextTitle = new System.Windows.Forms.TextBox();
            this.TextSprintNum = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboNames
            // 
            this.ComboNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboNames.FormattingEnabled = true;
            this.ComboNames.Location = new System.Drawing.Point(125, 7);
            this.ComboNames.Name = "ComboNames";
            this.ComboNames.Size = new System.Drawing.Size(286, 24);
            this.ComboNames.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.LblAssignedUser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ComboNames, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblUserStoryTitle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblSprintNumber, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnConfirm, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TextTitle, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TextSprintNum, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(414, 152);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LblAssignedUser
            // 
            this.LblAssignedUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAssignedUser.AutoSize = true;
            this.LblAssignedUser.Location = new System.Drawing.Point(3, 0);
            this.LblAssignedUser.Name = "LblAssignedUser";
            this.LblAssignedUser.Size = new System.Drawing.Size(116, 38);
            this.LblAssignedUser.TabIndex = 0;
            this.LblAssignedUser.Text = "Assigned User";
            this.LblAssignedUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblUserStoryTitle
            // 
            this.LblUserStoryTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUserStoryTitle.AutoSize = true;
            this.LblUserStoryTitle.Location = new System.Drawing.Point(3, 38);
            this.LblUserStoryTitle.Name = "LblUserStoryTitle";
            this.LblUserStoryTitle.Size = new System.Drawing.Size(116, 38);
            this.LblUserStoryTitle.TabIndex = 1;
            this.LblUserStoryTitle.Text = "User Story Title";
            this.LblUserStoryTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSprintNumber
            // 
            this.LblSprintNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSprintNumber.AutoSize = true;
            this.LblSprintNumber.Location = new System.Drawing.Point(3, 76);
            this.LblSprintNumber.Name = "LblSprintNumber";
            this.LblSprintNumber.Size = new System.Drawing.Size(116, 38);
            this.LblSprintNumber.TabIndex = 2;
            this.LblSprintNumber.Text = "Sprint Number ###";
            this.LblSprintNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.Color.LightGreen;
            this.tableLayoutPanel1.SetColumnSpan(this.BtnConfirm, 2);
            this.BtnConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirm.Location = new System.Drawing.Point(3, 117);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(408, 32);
            this.BtnConfirm.TabIndex = 3;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // TextTitle
            // 
            this.TextTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextTitle.Location = new System.Drawing.Point(125, 46);
            this.TextTitle.Name = "TextTitle";
            this.TextTitle.Size = new System.Drawing.Size(286, 22);
            this.TextTitle.TabIndex = 4;
            // 
            // TextSprintNum
            // 
            this.TextSprintNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextSprintNum.Location = new System.Drawing.Point(125, 84);
            this.TextSprintNum.Name = "TextSprintNum";
            this.TextSprintNum.Size = new System.Drawing.Size(286, 22);
            this.TextSprintNum.TabIndex = 5;
            // 
            // UserEntry
            // 
            this.AcceptButton = this.BtnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 152);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "UserEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Entry";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboNames;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblAssignedUser;
        private System.Windows.Forms.Label LblUserStoryTitle;
        private System.Windows.Forms.Label LblSprintNumber;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.TextBox TextTitle;
        private System.Windows.Forms.TextBox TextSprintNum;
    }
}