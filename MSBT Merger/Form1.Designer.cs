namespace MSBT_Merger
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectMSBT1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectMSBT2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.msbt1RTB = new System.Windows.Forms.RichTextBox();
            this.msbt1CLB = new System.Windows.Forms.CheckedListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.msbt2RTB = new System.Windows.Forms.RichTextBox();
            this.msbt2CLB = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.twoOnOneBtn = new System.Windows.Forms.Button();
            this.oneOnTwoBtn = new System.Windows.Forms.Button();
            this.msbtResultCLB = new System.Windows.Forms.CheckedListBox();
            this.msbtResultRTB = new System.Windows.Forms.RichTextBox();
            this.createEntriesCB = new System.Windows.Forms.CheckBox();
            this.mergeSelectedCB = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectMSBT1ToolStripMenuItem,
            this.selectMSBT2ToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // selectMSBT1ToolStripMenuItem
            // 
            this.selectMSBT1ToolStripMenuItem.Name = "selectMSBT1ToolStripMenuItem";
            this.selectMSBT1ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.selectMSBT1ToolStripMenuItem.Text = "Select MSBT 1";
            this.selectMSBT1ToolStripMenuItem.Click += new System.EventHandler(this.selectMSBT1ToolStripMenuItem_Click);
            // 
            // selectMSBT2ToolStripMenuItem
            // 
            this.selectMSBT2ToolStripMenuItem.Name = "selectMSBT2ToolStripMenuItem";
            this.selectMSBT2ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.selectMSBT2ToolStripMenuItem.Text = "Select MSBT 2";
            this.selectMSBT2ToolStripMenuItem.Click += new System.EventHandler(this.selectMSBT2ToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(946, 525);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.msbt1RTB);
            this.groupBox1.Controls.Add(this.msbt1CLB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 525);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MSBT 1";
            // 
            // msbt1RTB
            // 
            this.msbt1RTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msbt1RTB.BackColor = System.Drawing.SystemColors.Control;
            this.msbt1RTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msbt1RTB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msbt1RTB.Location = new System.Drawing.Point(3, 422);
            this.msbt1RTB.Name = "msbt1RTB";
            this.msbt1RTB.ReadOnly = true;
            this.msbt1RTB.Size = new System.Drawing.Size(244, 100);
            this.msbt1RTB.TabIndex = 0;
            this.msbt1RTB.TabStop = false;
            this.msbt1RTB.Text = "";
            // 
            // msbt1CLB
            // 
            this.msbt1CLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msbt1CLB.FormattingEnabled = true;
            this.msbt1CLB.Location = new System.Drawing.Point(3, 18);
            this.msbt1CLB.Name = "msbt1CLB";
            this.msbt1CLB.Size = new System.Drawing.Size(244, 395);
            this.msbt1CLB.Sorted = true;
            this.msbt1CLB.TabIndex = 0;
            this.msbt1CLB.TabStop = false;
            this.msbt1CLB.SelectedIndexChanged += new System.EventHandler(this.msbt1CLB_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Size = new System.Drawing.Size(692, 525);
            this.splitContainer2.SplitterDistance = 266;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.msbt2RTB);
            this.groupBox2.Controls.Add(this.msbt2CLB);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 525);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MSBT 2";
            // 
            // msbt2RTB
            // 
            this.msbt2RTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msbt2RTB.BackColor = System.Drawing.SystemColors.Control;
            this.msbt2RTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msbt2RTB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msbt2RTB.Location = new System.Drawing.Point(3, 422);
            this.msbt2RTB.Name = "msbt2RTB";
            this.msbt2RTB.ReadOnly = true;
            this.msbt2RTB.Size = new System.Drawing.Size(260, 100);
            this.msbt2RTB.TabIndex = 0;
            this.msbt2RTB.TabStop = false;
            this.msbt2RTB.Text = "";
            // 
            // msbt2CLB
            // 
            this.msbt2CLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msbt2CLB.FormattingEnabled = true;
            this.msbt2CLB.Location = new System.Drawing.Point(3, 18);
            this.msbt2CLB.Name = "msbt2CLB";
            this.msbt2CLB.Size = new System.Drawing.Size(260, 395);
            this.msbt2CLB.Sorted = true;
            this.msbt2CLB.TabIndex = 0;
            this.msbt2CLB.TabStop = false;
            this.msbt2CLB.SelectedIndexChanged += new System.EventHandler(this.msbt2CLB_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mergeSelectedCB);
            this.groupBox3.Controls.Add(this.createEntriesCB);
            this.groupBox3.Controls.Add(this.twoOnOneBtn);
            this.groupBox3.Controls.Add(this.oneOnTwoBtn);
            this.groupBox3.Controls.Add(this.msbtResultCLB);
            this.groupBox3.Controls.Add(this.msbtResultRTB);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 525);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result MSBT";
            // 
            // twoOnOneBtn
            // 
            this.twoOnOneBtn.Location = new System.Drawing.Point(6, 236);
            this.twoOnOneBtn.Name = "twoOnOneBtn";
            this.twoOnOneBtn.Size = new System.Drawing.Size(172, 30);
            this.twoOnOneBtn.TabIndex = 2;
            this.twoOnOneBtn.Text = "Copy 2 onto 1";
            this.twoOnOneBtn.UseVisualStyleBackColor = true;
            this.twoOnOneBtn.Click += new System.EventHandler(this.twoOnOneBtn_Click);
            // 
            // oneOnTwoBtn
            // 
            this.oneOnTwoBtn.Location = new System.Drawing.Point(6, 200);
            this.oneOnTwoBtn.Name = "oneOnTwoBtn";
            this.oneOnTwoBtn.Size = new System.Drawing.Size(172, 30);
            this.oneOnTwoBtn.TabIndex = 1;
            this.oneOnTwoBtn.Text = "Copy 1 onto 2";
            this.oneOnTwoBtn.UseVisualStyleBackColor = true;
            this.oneOnTwoBtn.Click += new System.EventHandler(this.oneOnTwoBtn_Click);
            // 
            // msbtResultCLB
            // 
            this.msbtResultCLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msbtResultCLB.FormattingEnabled = true;
            this.msbtResultCLB.Location = new System.Drawing.Point(184, 21);
            this.msbtResultCLB.Name = "msbtResultCLB";
            this.msbtResultCLB.Size = new System.Drawing.Size(226, 395);
            this.msbtResultCLB.Sorted = true;
            this.msbtResultCLB.TabIndex = 0;
            this.msbtResultCLB.TabStop = false;
            this.msbtResultCLB.SelectedIndexChanged += new System.EventHandler(this.msbtResultCLB_SelectedIndexChanged);
            // 
            // msbtResultRTB
            // 
            this.msbtResultRTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msbtResultRTB.BackColor = System.Drawing.SystemColors.Control;
            this.msbtResultRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msbtResultRTB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msbtResultRTB.Location = new System.Drawing.Point(6, 422);
            this.msbtResultRTB.Name = "msbtResultRTB";
            this.msbtResultRTB.ReadOnly = true;
            this.msbtResultRTB.Size = new System.Drawing.Size(413, 97);
            this.msbtResultRTB.TabIndex = 0;
            this.msbtResultRTB.TabStop = false;
            this.msbtResultRTB.Text = "";
            // 
            // createEntriesCB
            // 
            this.createEntriesCB.AutoSize = true;
            this.createEntriesCB.Location = new System.Drawing.Point(7, 173);
            this.createEntriesCB.Name = "createEntriesCB";
            this.createEntriesCB.Size = new System.Drawing.Size(171, 21);
            this.createEntriesCB.TabIndex = 0;
            this.createEntriesCB.Text = "Create Missing Entries";
            this.createEntriesCB.UseVisualStyleBackColor = true;
            // 
            // mergeSelectedCB
            // 
            this.mergeSelectedCB.AutoSize = true;
            this.mergeSelectedCB.Location = new System.Drawing.Point(7, 146);
            this.mergeSelectedCB.Name = "mergeSelectedCB";
            this.mergeSelectedCB.Size = new System.Drawing.Size(162, 21);
            this.mergeSelectedCB.TabIndex = 0;
            this.mergeSelectedCB.Text = "Merge Only Selected";
            this.mergeSelectedCB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 553);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MSBT Merger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectMSBT1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectMSBT2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox msbt1CLB;
        private System.Windows.Forms.RichTextBox msbt1RTB;
        private System.Windows.Forms.RichTextBox msbt2RTB;
        private System.Windows.Forms.CheckedListBox msbt2CLB;
        private System.Windows.Forms.RichTextBox msbtResultRTB;
        private System.Windows.Forms.Button twoOnOneBtn;
        private System.Windows.Forms.Button oneOnTwoBtn;
        private System.Windows.Forms.CheckedListBox msbtResultCLB;
        private System.Windows.Forms.CheckBox createEntriesCB;
        private System.Windows.Forms.CheckBox mergeSelectedCB;
    }
}

