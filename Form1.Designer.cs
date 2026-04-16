namespace FileCompare
{
    partial class FileCompare
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            panel3 = new Panel();
            lvwLeftDir = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            panel2 = new Panel();
            btnLeftDir = new Button();
            txtLeftDir = new TextBox();
            panel1 = new Panel();
            btnCopyFromLeft = new Button();
            lblAppName = new Label();
            panel6 = new Panel();
            lvwRightDir = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            panel5 = new Panel();
            txtRightDir = new TextBox();
            btnRightDir = new Button();
            panel4 = new Panel();
            btnCopyFromRight = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(20, 10);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel6);
            splitContainer1.Panel2.Controls.Add(panel5);
            splitContainer1.Panel2.Controls.Add(panel4);
            splitContainer1.Size = new Size(864, 430);
            splitContainer1.SplitterDistance = 432;
            splitContainer1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(lvwLeftDir);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 127);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(432, 303);
            panel3.TabIndex = 2;
            // 
            // lvwLeftDir
            // 
            lvwLeftDir.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvwLeftDir.Dock = DockStyle.Fill;
            lvwLeftDir.FullRowSelect = true;
            lvwLeftDir.GridLines = true;
            lvwLeftDir.Location = new Point(10, 10);
            lvwLeftDir.Name = "lvwLeftDir";
            lvwLeftDir.Size = new Size(412, 283);
            lvwLeftDir.TabIndex = 0;
            lvwLeftDir.UseCompatibleStateImageBehavior = false;
            lvwLeftDir.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "이름";
            columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "크기";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "수정일";
            columnHeader3.Width = 160;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnLeftDir);
            panel2.Controls.Add(txtLeftDir);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(432, 58);
            panel2.TabIndex = 1;
            // 
            // btnLeftDir
            // 
            btnLeftDir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLeftDir.Font = new Font("문체부 돋음체", 11F);
            btnLeftDir.Location = new Point(342, 14);
            btnLeftDir.Name = "btnLeftDir";
            btnLeftDir.Size = new Size(80, 30);
            btnLeftDir.TabIndex = 1;
            btnLeftDir.Text = "폴더 선택";
            btnLeftDir.UseVisualStyleBackColor = true;
            btnLeftDir.Click += btnLeftDir_Click;
            // 
            // txtLeftDir
            // 
            txtLeftDir.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtLeftDir.Font = new Font("문체부 돋음체", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtLeftDir.Location = new Point(10, 19);
            txtLeftDir.Name = "txtLeftDir";
            txtLeftDir.Size = new Size(322, 22);
            txtLeftDir.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCopyFromLeft);
            panel1.Controls.Add(lblAppName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 69);
            panel1.TabIndex = 0;
            // 
            // btnCopyFromLeft
            // 
            btnCopyFromLeft.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCopyFromLeft.Font = new Font("문체부 돋음체", 18F, FontStyle.Bold);
            btnCopyFromLeft.Location = new Point(342, 15);
            btnCopyFromLeft.Name = "btnCopyFromLeft";
            btnCopyFromLeft.Size = new Size(80, 40);
            btnCopyFromLeft.TabIndex = 1;
            btnCopyFromLeft.Text = ">>>";
            btnCopyFromLeft.UseVisualStyleBackColor = true;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("MS UI Gothic", 38F, FontStyle.Bold);
            lblAppName.ForeColor = Color.FromArgb(255, 128, 128);
            lblAppName.Location = new Point(3, 4);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(316, 51);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "File Compare";
            // 
            // panel6
            // 
            panel6.Controls.Add(lvwRightDir);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 127);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(10);
            panel6.Size = new Size(428, 303);
            panel6.TabIndex = 2;
            // 
            // lvwRightDir
            // 
            lvwRightDir.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            lvwRightDir.Dock = DockStyle.Fill;
            lvwRightDir.FullRowSelect = true;
            lvwRightDir.GridLines = true;
            lvwRightDir.Location = new Point(10, 10);
            lvwRightDir.Name = "lvwRightDir";
            lvwRightDir.Size = new Size(408, 283);
            lvwRightDir.TabIndex = 0;
            lvwRightDir.UseCompatibleStateImageBehavior = false;
            lvwRightDir.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "이름";
            columnHeader4.Width = 300;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "크기";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "수정일";
            columnHeader6.Width = 160;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtRightDir);
            panel5.Controls.Add(btnRightDir);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 69);
            panel5.Name = "panel5";
            panel5.Size = new Size(428, 58);
            panel5.TabIndex = 1;
            // 
            // txtRightDir
            // 
            txtRightDir.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRightDir.Font = new Font("문체부 돋음체", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtRightDir.Location = new Point(10, 19);
            txtRightDir.Name = "txtRightDir";
            txtRightDir.Size = new Size(322, 22);
            txtRightDir.TabIndex = 2;
            // 
            // btnRightDir
            // 
            btnRightDir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRightDir.Font = new Font("문체부 돋음체", 11F);
            btnRightDir.Location = new Point(338, 14);
            btnRightDir.Name = "btnRightDir";
            btnRightDir.Size = new Size(80, 30);
            btnRightDir.TabIndex = 0;
            btnRightDir.Text = "폴더 선택";
            btnRightDir.UseVisualStyleBackColor = true;
            btnRightDir.Click += btnRightDir_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnCopyFromRight);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(428, 69);
            panel4.TabIndex = 0;
            // 
            // btnCopyFromRight
            // 
            btnCopyFromRight.Font = new Font("문체부 돋음체", 18F, FontStyle.Bold);
            btnCopyFromRight.Location = new Point(10, 15);
            btnCopyFromRight.Name = "btnCopyFromRight";
            btnCopyFromRight.Size = new Size(80, 40);
            btnCopyFromRight.TabIndex = 0;
            btnCopyFromRight.Text = "<<<";
            btnCopyFromRight.UseVisualStyleBackColor = true;
            // 
            // FileCompare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 450);
            Controls.Add(splitContainer1);
            Name = "FileCompare";
            Padding = new Padding(20, 10, 20, 10);
            Text = "File Compare v1.0";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Button btnLeftDir;
        private TextBox txtLeftDir;
        private Button btnCopyFromLeft;
        private Label lblAppName;
        private Button btnRightDir;
        private Button btnCopyFromRight;
        private ListView lvwLeftDir;
        private ListView lvwRightDir;
        private TextBox txtRightDir;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}
