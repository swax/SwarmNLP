namespace SwarmNLP
{
    partial class ProblemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProblemForm));
            this.SetButton = new System.Windows.Forms.Button();
            this.DimensionBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ConstraintsList = new System.Windows.Forms.ListBox();
            this.RemoveConstraintLink = new System.Windows.Forms.LinkLabel();
            this.AddConstraintLink = new System.Windows.Forms.LinkLabel();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.EditConstraintLink = new System.Windows.Forms.LinkLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.EditFunctionLink = new System.Windows.Forms.LinkLabel();
            this.AddFunctionLink = new System.Windows.Forms.LinkLabel();
            this.FunctionList = new System.Windows.Forms.ListBox();
            this.RemoveFunctionLink = new System.Windows.Forms.LinkLabel();
            this.TimeCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DimensionBox)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetButton
            // 
            this.SetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SetButton.Location = new System.Drawing.Point(310, 337);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(75, 23);
            this.SetButton.TabIndex = 1;
            this.SetButton.Text = "Set";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // DimensionBox
            // 
            this.DimensionBox.Location = new System.Drawing.Point(189, 12);
            this.DimensionBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.DimensionBox.Name = "DimensionBox";
            this.DimensionBox.Size = new System.Drawing.Size(57, 20);
            this.DimensionBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of Dimensions x1, x2 .. xN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Constraints:";
            // 
            // ConstraintsList
            // 
            this.ConstraintsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ConstraintsList.FormattingEnabled = true;
            this.ConstraintsList.IntegralHeight = false;
            this.ConstraintsList.Location = new System.Drawing.Point(6, 26);
            this.ConstraintsList.Name = "ConstraintsList";
            this.ConstraintsList.Size = new System.Drawing.Size(364, 87);
            this.ConstraintsList.TabIndex = 7;
            this.ConstraintsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ConstraintsList_MouseDoubleClick);
            // 
            // RemoveConstraintLink
            // 
            this.RemoveConstraintLink.AutoSize = true;
            this.RemoveConstraintLink.Location = new System.Drawing.Point(131, 10);
            this.RemoveConstraintLink.Name = "RemoveConstraintLink";
            this.RemoveConstraintLink.Size = new System.Drawing.Size(92, 13);
            this.RemoveConstraintLink.TabIndex = 11;
            this.RemoveConstraintLink.TabStop = true;
            this.RemoveConstraintLink.Text = "Remove Selected";
            this.RemoveConstraintLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RemoveLink_LinkClicked);
            // 
            // AddConstraintLink
            // 
            this.AddConstraintLink.AutoSize = true;
            this.AddConstraintLink.Location = new System.Drawing.Point(68, 10);
            this.AddConstraintLink.Name = "AddConstraintLink";
            this.AddConstraintLink.Size = new System.Drawing.Size(26, 13);
            this.AddConstraintLink.TabIndex = 12;
            this.AddConstraintLink.TabStop = true;
            this.AddConstraintLink.Text = "Add";
            this.AddConstraintLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddLink_LinkClicked);
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(37, 315);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(138, 13);
            this.TimeLabel.TabIndex = 14;
            this.TimeLabel.Text = "Increment t per run cycle by";
            // 
            // TimeBox
            // 
            this.TimeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TimeBox.Location = new System.Drawing.Point(181, 312);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(60, 20);
            this.TimeBox.TabIndex = 15;
            // 
            // EditConstraintLink
            // 
            this.EditConstraintLink.AutoSize = true;
            this.EditConstraintLink.Location = new System.Drawing.Point(100, 10);
            this.EditConstraintLink.Name = "EditConstraintLink";
            this.EditConstraintLink.Size = new System.Drawing.Size(25, 13);
            this.EditConstraintLink.TabIndex = 16;
            this.EditConstraintLink.TabStop = true;
            this.EditConstraintLink.Text = "Edit";
            this.EditConstraintLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EditLink_LinkClicked);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 38);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.EditFunctionLink);
            this.splitContainer1.Panel1.Controls.Add(this.AddFunctionLink);
            this.splitContainer1.Panel1.Controls.Add(this.FunctionList);
            this.splitContainer1.Panel1.Controls.Add(this.RemoveFunctionLink);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.EditConstraintLink);
            this.splitContainer1.Panel2.Controls.Add(this.ConstraintsList);
            this.splitContainer1.Panel2.Controls.Add(this.RemoveConstraintLink);
            this.splitContainer1.Panel2.Controls.Add(this.AddConstraintLink);
            this.splitContainer1.Size = new System.Drawing.Size(373, 236);
            this.splitContainer1.SplitterDistance = 115;
            this.splitContainer1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Objectives:";
            // 
            // EditFunctionLink
            // 
            this.EditFunctionLink.AutoSize = true;
            this.EditFunctionLink.Location = new System.Drawing.Point(102, 10);
            this.EditFunctionLink.Name = "EditFunctionLink";
            this.EditFunctionLink.Size = new System.Drawing.Size(25, 13);
            this.EditFunctionLink.TabIndex = 21;
            this.EditFunctionLink.TabStop = true;
            this.EditFunctionLink.Text = "Edit";
            this.EditFunctionLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EditFunctionLink_LinkClicked);
            // 
            // AddFunctionLink
            // 
            this.AddFunctionLink.AutoSize = true;
            this.AddFunctionLink.Location = new System.Drawing.Point(70, 10);
            this.AddFunctionLink.Name = "AddFunctionLink";
            this.AddFunctionLink.Size = new System.Drawing.Size(26, 13);
            this.AddFunctionLink.TabIndex = 20;
            this.AddFunctionLink.TabStop = true;
            this.AddFunctionLink.Text = "Add";
            this.AddFunctionLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddFunctionLink_LinkClicked);
            // 
            // FunctionList
            // 
            this.FunctionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.FunctionList.FormattingEnabled = true;
            this.FunctionList.IntegralHeight = false;
            this.FunctionList.Location = new System.Drawing.Point(6, 26);
            this.FunctionList.Name = "FunctionList";
            this.FunctionList.Size = new System.Drawing.Size(364, 86);
            this.FunctionList.TabIndex = 18;
            this.FunctionList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FunctionList_MouseDoubleClick);
            // 
            // RemoveFunctionLink
            // 
            this.RemoveFunctionLink.AutoSize = true;
            this.RemoveFunctionLink.Location = new System.Drawing.Point(133, 10);
            this.RemoveFunctionLink.Name = "RemoveFunctionLink";
            this.RemoveFunctionLink.Size = new System.Drawing.Size(92, 13);
            this.RemoveFunctionLink.TabIndex = 19;
            this.RemoveFunctionLink.TabStop = true;
            this.RemoveFunctionLink.Text = "Remove Selected";
            this.RemoveFunctionLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RemoveFunctionLink_LinkClicked);
            // 
            // TimeCheckBox
            // 
            this.TimeCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TimeCheckBox.AutoSize = true;
            this.TimeCheckBox.Location = new System.Drawing.Point(18, 289);
            this.TimeCheckBox.Name = "TimeCheckBox";
            this.TimeCheckBox.Size = new System.Drawing.Size(202, 17);
            this.TimeCheckBox.TabIndex = 18;
            this.TimeCheckBox.Text = "Time var t used in objective functions";
            this.TimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // ProblemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(397, 372);
            this.Controls.Add(this.TimeCheckBox);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DimensionBox);
            this.Controls.Add(this.SetButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProblemForm";
            this.Text = "Problem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProblemForm_FormClosing);
            this.Load += new System.EventHandler(this.ProblemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DimensionBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.NumericUpDown DimensionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ConstraintsList;
        private System.Windows.Forms.LinkLabel RemoveConstraintLink;
        private System.Windows.Forms.LinkLabel AddConstraintLink;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.LinkLabel EditConstraintLink;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel EditFunctionLink;
        private System.Windows.Forms.LinkLabel AddFunctionLink;
        private System.Windows.Forms.ListBox FunctionList;
        private System.Windows.Forms.LinkLabel RemoveFunctionLink;
        private System.Windows.Forms.CheckBox TimeCheckBox;
    }
}