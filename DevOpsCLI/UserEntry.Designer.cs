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
            this.TLP = new System.Windows.Forms.TableLayoutPanel();
            this.LblAssignedUser = new System.Windows.Forms.Label();
            this.LblUserStoryTitle = new System.Windows.Forms.Label();
            this.LblSprintNumber = new System.Windows.Forms.Label();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.TextTitle = new System.Windows.Forms.TextBox();
            this.LblTaskNames = new System.Windows.Forms.Label();
            this.TextTask1 = new System.Windows.Forms.TextBox();
            this.TextTask2 = new System.Windows.Forms.TextBox();
            this.TextTask3 = new System.Windows.Forms.TextBox();
            this.TextTask4 = new System.Windows.Forms.TextBox();
            this.TextTask5 = new System.Windows.Forms.TextBox();
            this.NumSprintNumA = new System.Windows.Forms.NumericUpDown();
            this.NumSprintNumB = new System.Windows.Forms.NumericUpDown();
            this.NumSprintNumC = new System.Windows.Forms.NumericUpDown();
            this.TLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumSprintNumA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSprintNumB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSprintNumC)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboNames
            // 
            this.ComboNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboNames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboNames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TLP.SetColumnSpan(this.ComboNames, 3);
            this.ComboNames.FormattingEnabled = true;
            this.ComboNames.Location = new System.Drawing.Point(91, 2);
            this.ComboNames.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboNames.Name = "ComboNames";
            this.ComboNames.Size = new System.Drawing.Size(228, 23);
            this.ComboNames.TabIndex = 0;
            // 
            // TLP
            // 
            this.TLP.ColumnCount = 4;
            this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLP.Controls.Add(this.LblAssignedUser, 0, 0);
            this.TLP.Controls.Add(this.ComboNames, 1, 0);
            this.TLP.Controls.Add(this.LblUserStoryTitle, 0, 1);
            this.TLP.Controls.Add(this.LblSprintNumber, 0, 2);
            this.TLP.Controls.Add(this.BtnConfirm, 0, 11);
            this.TLP.Controls.Add(this.TextTitle, 1, 1);
            this.TLP.Controls.Add(this.LblTaskNames, 0, 4);
            this.TLP.Controls.Add(this.TextTask1, 0, 5);
            this.TLP.Controls.Add(this.TextTask2, 0, 6);
            this.TLP.Controls.Add(this.TextTask3, 0, 7);
            this.TLP.Controls.Add(this.TextTask4, 0, 8);
            this.TLP.Controls.Add(this.TextTask5, 0, 9);
            this.TLP.Controls.Add(this.NumSprintNumA, 1, 2);
            this.TLP.Controls.Add(this.NumSprintNumB, 2, 2);
            this.TLP.Controls.Add(this.NumSprintNumC, 3, 2);
            this.TLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP.Location = new System.Drawing.Point(0, 0);
            this.TLP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TLP.Name = "TLP";
            this.TLP.RowCount = 12;
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP.Size = new System.Drawing.Size(321, 336);
            this.TLP.TabIndex = 1;
            // 
            // LblAssignedUser
            // 
            this.LblAssignedUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAssignedUser.AutoSize = true;
            this.LblAssignedUser.Location = new System.Drawing.Point(2, 0);
            this.LblAssignedUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAssignedUser.Name = "LblAssignedUser";
            this.LblAssignedUser.Size = new System.Drawing.Size(85, 28);
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
            this.LblUserStoryTitle.Location = new System.Drawing.Point(2, 28);
            this.LblUserStoryTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblUserStoryTitle.Name = "LblUserStoryTitle";
            this.LblUserStoryTitle.Size = new System.Drawing.Size(85, 27);
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
            this.LblSprintNumber.Location = new System.Drawing.Point(2, 55);
            this.LblSprintNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSprintNumber.Name = "LblSprintNumber";
            this.LblSprintNumber.Size = new System.Drawing.Size(85, 29);
            this.LblSprintNumber.TabIndex = 2;
            this.LblSprintNumber.Text = "Sprint Number";
            this.LblSprintNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.Color.LightGreen;
            this.TLP.SetColumnSpan(this.BtnConfirm, 4);
            this.BtnConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirm.Location = new System.Drawing.Point(2, 298);
            this.BtnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(317, 36);
            this.BtnConfirm.TabIndex = 3;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // TextTitle
            // 
            this.TextTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TLP.SetColumnSpan(this.TextTitle, 3);
            this.TextTitle.Location = new System.Drawing.Point(91, 30);
            this.TextTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextTitle.Name = "TextTitle";
            this.TextTitle.Size = new System.Drawing.Size(228, 23);
            this.TextTitle.TabIndex = 4;
            this.TextTitle.Tag = "story";
            // 
            // LblTaskNames
            // 
            this.LblTaskNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTaskNames.AutoSize = true;
            this.TLP.SetColumnSpan(this.LblTaskNames, 4);
            this.LblTaskNames.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTaskNames.Location = new System.Drawing.Point(4, 107);
            this.LblTaskNames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTaskNames.Name = "LblTaskNames";
            this.LblTaskNames.Size = new System.Drawing.Size(313, 21);
            this.LblTaskNames.TabIndex = 6;
            this.LblTaskNames.Text = "Task Names";
            this.LblTaskNames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextTask1
            // 
            this.TextTask1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TLP.SetColumnSpan(this.TextTask1, 4);
            this.TextTask1.Location = new System.Drawing.Point(4, 131);
            this.TextTask1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextTask1.Name = "TextTask1";
            this.TextTask1.Size = new System.Drawing.Size(313, 23);
            this.TextTask1.TabIndex = 7;
            this.TextTask1.Tag = "task";
            this.TextTask1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextTask2
            // 
            this.TextTask2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TLP.SetColumnSpan(this.TextTask2, 4);
            this.TextTask2.Location = new System.Drawing.Point(4, 160);
            this.TextTask2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextTask2.Name = "TextTask2";
            this.TextTask2.Size = new System.Drawing.Size(313, 23);
            this.TextTask2.TabIndex = 8;
            this.TextTask2.Tag = "task";
            this.TextTask2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextTask3
            // 
            this.TextTask3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TLP.SetColumnSpan(this.TextTask3, 4);
            this.TextTask3.Location = new System.Drawing.Point(4, 189);
            this.TextTask3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextTask3.Name = "TextTask3";
            this.TextTask3.Size = new System.Drawing.Size(313, 23);
            this.TextTask3.TabIndex = 9;
            this.TextTask3.Tag = "task";
            this.TextTask3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextTask4
            // 
            this.TextTask4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TLP.SetColumnSpan(this.TextTask4, 4);
            this.TextTask4.Location = new System.Drawing.Point(4, 218);
            this.TextTask4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextTask4.Name = "TextTask4";
            this.TextTask4.Size = new System.Drawing.Size(313, 23);
            this.TextTask4.TabIndex = 10;
            this.TextTask4.Tag = "task";
            this.TextTask4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextTask5
            // 
            this.TextTask5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TLP.SetColumnSpan(this.TextTask5, 4);
            this.TextTask5.Location = new System.Drawing.Point(4, 247);
            this.TextTask5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextTask5.Name = "TextTask5";
            this.TextTask5.Size = new System.Drawing.Size(313, 23);
            this.TextTask5.TabIndex = 11;
            this.TextTask5.Tag = "task";
            this.TextTask5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumSprintNumA
            // 
            this.NumSprintNumA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NumSprintNumA.Location = new System.Drawing.Point(93, 58);
            this.NumSprintNumA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NumSprintNumA.Name = "NumSprintNumA";
            this.NumSprintNumA.Size = new System.Drawing.Size(69, 23);
            this.NumSprintNumA.TabIndex = 12;
            this.NumSprintNumA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumSprintNumB
            // 
            this.NumSprintNumB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NumSprintNumB.Location = new System.Drawing.Point(170, 58);
            this.NumSprintNumB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NumSprintNumB.Name = "NumSprintNumB";
            this.NumSprintNumB.Size = new System.Drawing.Size(69, 23);
            this.NumSprintNumB.TabIndex = 13;
            this.NumSprintNumB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumSprintNumC
            // 
            this.NumSprintNumC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NumSprintNumC.Location = new System.Drawing.Point(247, 58);
            this.NumSprintNumC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NumSprintNumC.Name = "NumSprintNumC";
            this.NumSprintNumC.Size = new System.Drawing.Size(70, 23);
            this.NumSprintNumC.TabIndex = 14;
            this.NumSprintNumC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserEntry
            // 
            this.AcceptButton = this.BtnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 336);
            this.Controls.Add(this.TLP);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Entry";
            this.TLP.ResumeLayout(false);
            this.TLP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumSprintNumA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSprintNumB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSprintNumC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboNames;
        private System.Windows.Forms.TableLayoutPanel TLP;
        private System.Windows.Forms.Label LblAssignedUser;
        private System.Windows.Forms.Label LblUserStoryTitle;
        private System.Windows.Forms.Label LblSprintNumber;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.TextBox TextTitle;
        private System.Windows.Forms.Label LblTaskNames;
        private System.Windows.Forms.TextBox TextTask1;
        private System.Windows.Forms.TextBox TextTask2;
        private System.Windows.Forms.TextBox TextTask3;
        private System.Windows.Forms.TextBox TextTask4;
        private System.Windows.Forms.TextBox TextTask5;
        private System.Windows.Forms.NumericUpDown NumSprintNumA;
        private System.Windows.Forms.NumericUpDown NumSprintNumB;
        private System.Windows.Forms.NumericUpDown NumSprintNumC;
    }
}