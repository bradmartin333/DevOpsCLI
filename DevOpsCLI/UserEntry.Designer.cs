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
            this.LabelAssignedUser = new System.Windows.Forms.Label();
            this.LabelUserStoryTitle = new System.Windows.Forms.Label();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.TextTitle = new System.Windows.Forms.TextBox();
            this.LabelTaskNames = new System.Windows.Forms.Label();
            this.TextTask1 = new System.Windows.Forms.TextBox();
            this.TextTask2 = new System.Windows.Forms.TextBox();
            this.TextTask3 = new System.Windows.Forms.TextBox();
            this.TextTask4 = new System.Windows.Forms.TextBox();
            this.TextTask5 = new System.Windows.Forms.TextBox();
            this.LabelArea = new System.Windows.Forms.Label();
            this.LabelStoryPoints = new System.Windows.Forms.Label();
            this.ComboAreas = new System.Windows.Forms.ComboBox();
            this.NumStoryPoints = new System.Windows.Forms.NumericUpDown();
            this.TLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumStoryPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboNames
            // 
            this.ComboNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboNames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboNames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboNames.FormattingEnabled = true;
            this.ComboNames.Location = new System.Drawing.Point(104, 2);
            this.ComboNames.Margin = new System.Windows.Forms.Padding(2);
            this.ComboNames.Name = "ComboNames";
            this.ComboNames.Size = new System.Drawing.Size(215, 23);
            this.ComboNames.TabIndex = 0;
            // 
            // TLP
            // 
            this.TLP.ColumnCount = 2;
            this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLP.Controls.Add(this.LabelAssignedUser, 0, 0);
            this.TLP.Controls.Add(this.ComboNames, 1, 0);
            this.TLP.Controls.Add(this.LabelUserStoryTitle, 0, 2);
            this.TLP.Controls.Add(this.BtnConfirm, 0, 12);
            this.TLP.Controls.Add(this.TextTitle, 1, 2);
            this.TLP.Controls.Add(this.LabelTaskNames, 0, 5);
            this.TLP.Controls.Add(this.TextTask1, 0, 6);
            this.TLP.Controls.Add(this.TextTask2, 0, 7);
            this.TLP.Controls.Add(this.TextTask3, 0, 8);
            this.TLP.Controls.Add(this.TextTask4, 0, 9);
            this.TLP.Controls.Add(this.TextTask5, 0, 10);
            this.TLP.Controls.Add(this.LabelArea, 0, 1);
            this.TLP.Controls.Add(this.LabelStoryPoints, 0, 3);
            this.TLP.Controls.Add(this.ComboAreas, 1, 1);
            this.TLP.Controls.Add(this.NumStoryPoints, 1, 3);
            this.TLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP.Location = new System.Drawing.Point(0, 0);
            this.TLP.Margin = new System.Windows.Forms.Padding(2);
            this.TLP.Name = "TLP";
            this.TLP.RowCount = 13;
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP.Size = new System.Drawing.Size(321, 348);
            this.TLP.TabIndex = 1;
            // 
            // LabelAssignedUser
            // 
            this.LabelAssignedUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelAssignedUser.AutoSize = true;
            this.LabelAssignedUser.Location = new System.Drawing.Point(2, 0);
            this.LabelAssignedUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelAssignedUser.Name = "LabelAssignedUser";
            this.LabelAssignedUser.Size = new System.Drawing.Size(98, 27);
            this.LabelAssignedUser.TabIndex = 0;
            this.LabelAssignedUser.Text = "Assigned User";
            this.LabelAssignedUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelUserStoryTitle
            // 
            this.LabelUserStoryTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelUserStoryTitle.AutoSize = true;
            this.LabelUserStoryTitle.Location = new System.Drawing.Point(2, 56);
            this.LabelUserStoryTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelUserStoryTitle.Name = "LabelUserStoryTitle";
            this.LabelUserStoryTitle.Size = new System.Drawing.Size(98, 27);
            this.LabelUserStoryTitle.TabIndex = 1;
            this.LabelUserStoryTitle.Text = "User Story Title";
            this.LabelUserStoryTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.Color.LightGreen;
            this.TLP.SetColumnSpan(this.BtnConfirm, 2);
            this.BtnConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirm.Location = new System.Drawing.Point(2, 318);
            this.BtnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(317, 28);
            this.BtnConfirm.TabIndex = 3;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // TextTitle
            // 
            this.TextTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextTitle.Location = new System.Drawing.Point(104, 58);
            this.TextTitle.Margin = new System.Windows.Forms.Padding(2);
            this.TextTitle.Name = "TextTitle";
            this.TextTitle.Size = new System.Drawing.Size(215, 23);
            this.TextTitle.TabIndex = 4;
            this.TextTitle.Tag = "story";
            this.TextTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelTaskNames
            // 
            this.LabelTaskNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTaskNames.AutoSize = true;
            this.TLP.SetColumnSpan(this.LabelTaskNames, 2);
            this.LabelTaskNames.Location = new System.Drawing.Point(4, 134);
            this.LabelTaskNames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTaskNames.Name = "LabelTaskNames";
            this.LabelTaskNames.Size = new System.Drawing.Size(313, 15);
            this.LabelTaskNames.TabIndex = 6;
            this.LabelTaskNames.Text = "Task Names";
            this.LabelTaskNames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextTask1
            // 
            this.TextTask1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TLP.SetColumnSpan(this.TextTask1, 2);
            this.TextTask1.Location = new System.Drawing.Point(4, 152);
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
            this.TLP.SetColumnSpan(this.TextTask2, 2);
            this.TextTask2.Location = new System.Drawing.Point(4, 181);
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
            this.TLP.SetColumnSpan(this.TextTask3, 2);
            this.TextTask3.Location = new System.Drawing.Point(4, 210);
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
            this.TLP.SetColumnSpan(this.TextTask4, 2);
            this.TextTask4.Location = new System.Drawing.Point(4, 239);
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
            this.TLP.SetColumnSpan(this.TextTask5, 2);
            this.TextTask5.Location = new System.Drawing.Point(4, 268);
            this.TextTask5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextTask5.Name = "TextTask5";
            this.TextTask5.Size = new System.Drawing.Size(313, 23);
            this.TextTask5.TabIndex = 11;
            this.TextTask5.Tag = "task";
            this.TextTask5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelArea
            // 
            this.LabelArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelArea.AutoSize = true;
            this.LabelArea.Location = new System.Drawing.Point(3, 27);
            this.LabelArea.Name = "LabelArea";
            this.LabelArea.Size = new System.Drawing.Size(96, 29);
            this.LabelArea.TabIndex = 12;
            this.LabelArea.Text = "DevOps Area";
            this.LabelArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelStoryPoints
            // 
            this.LabelStoryPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelStoryPoints.AutoSize = true;
            this.LabelStoryPoints.Location = new System.Drawing.Point(3, 83);
            this.LabelStoryPoints.Name = "LabelStoryPoints";
            this.LabelStoryPoints.Size = new System.Drawing.Size(96, 29);
            this.LabelStoryPoints.TabIndex = 13;
            this.LabelStoryPoints.Text = "User Story Points";
            this.LabelStoryPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboAreas
            // 
            this.ComboAreas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboAreas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboAreas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboAreas.FormattingEnabled = true;
            this.ComboAreas.Location = new System.Drawing.Point(105, 30);
            this.ComboAreas.Name = "ComboAreas";
            this.ComboAreas.Size = new System.Drawing.Size(213, 23);
            this.ComboAreas.TabIndex = 14;
            // 
            // NumStoryPoints
            // 
            this.NumStoryPoints.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumStoryPoints.Location = new System.Drawing.Point(105, 86);
            this.NumStoryPoints.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.NumStoryPoints.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumStoryPoints.Name = "NumStoryPoints";
            this.NumStoryPoints.Size = new System.Drawing.Size(213, 23);
            this.NumStoryPoints.TabIndex = 15;
            this.NumStoryPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumStoryPoints.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // UserEntry
            // 
            this.AcceptButton = this.BtnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 348);
            this.Controls.Add(this.TLP);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Entry";
            this.TLP.ResumeLayout(false);
            this.TLP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumStoryPoints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboNames;
        private System.Windows.Forms.TableLayoutPanel TLP;
        private System.Windows.Forms.Label LabelAssignedUser;
        private System.Windows.Forms.Label LabelUserStoryTitle;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.TextBox TextTitle;
        private System.Windows.Forms.Label LabelTaskNames;
        private System.Windows.Forms.TextBox TextTask1;
        private System.Windows.Forms.TextBox TextTask2;
        private System.Windows.Forms.TextBox TextTask3;
        private System.Windows.Forms.TextBox TextTask4;
        private System.Windows.Forms.TextBox TextTask5;
        private System.Windows.Forms.Label LabelArea;
        private System.Windows.Forms.Label LabelStoryPoints;
        private System.Windows.Forms.ComboBox ComboAreas;
        private System.Windows.Forms.NumericUpDown NumStoryPoints;
    }
}