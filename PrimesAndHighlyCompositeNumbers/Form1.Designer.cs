namespace PrimesAndHighlyCompositeNumbers
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainWorkerProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.PercentageLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MaximumValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.PrimesGrid = new System.Windows.Forms.DataGridView();
            this.formBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CompositesGrid = new System.Windows.Forms.DataGridView();
            this.CurrentNumberLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ElapsedTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.RemainingLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.primesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compositesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Divisors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumValue)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrimesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompositesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.MainWorkerProgressBar,
            this.PercentageLabel,
            this.CurrentNumberLabel,
            this.ElapsedTimeLabel,
            this.RemainingLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 24);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = false;
            this.StatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.StatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(82, 19);
            this.StatusLabel.Text = "Idle";
            // 
            // MainWorkerProgressBar
            // 
            this.MainWorkerProgressBar.Name = "MainWorkerProgressBar";
            this.MainWorkerProgressBar.Size = new System.Drawing.Size(100, 18);
            // 
            // PercentageLabel
            // 
            this.PercentageLabel.AutoSize = false;
            this.PercentageLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.PercentageLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.PercentageLabel.Name = "PercentageLabel";
            this.PercentageLabel.Size = new System.Drawing.Size(48, 19);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(784, 537);
            this.splitContainer1.SplitterDistance = 392;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.MaximumValue);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CancelButton);
            this.groupBox2.Controls.Add(this.StartButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 537);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // MaximumValue
            // 
            this.MaximumValue.Location = new System.Drawing.Point(122, 155);
            this.MaximumValue.Maximum = new decimal(new int[] {
            27000000,
            0,
            0,
            0});
            this.MaximumValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.MaximumValue.Name = "MaximumValue";
            this.MaximumValue.Size = new System.Drawing.Size(120, 20);
            this.MaximumValue.TabIndex = 4;
            this.MaximumValue.ThousandsSeparator = true;
            this.MaximumValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "End of search range";
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(199, 466);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(187, 65);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(6, 466);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(187, 65);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 537);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 16);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.PrimesGrid);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.CompositesGrid);
            this.splitContainer2.Size = new System.Drawing.Size(382, 518);
            this.splitContainer2.SplitterDistance = 192;
            this.splitContainer2.TabIndex = 0;
            // 
            // PrimesGrid
            // 
            this.PrimesGrid.AllowUserToAddRows = false;
            this.PrimesGrid.AllowUserToDeleteRows = false;
            this.PrimesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrimesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.primesColumn});
            this.PrimesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrimesGrid.Location = new System.Drawing.Point(0, 0);
            this.PrimesGrid.Name = "PrimesGrid";
            this.PrimesGrid.ReadOnly = true;
            this.PrimesGrid.RowHeadersVisible = false;
            this.PrimesGrid.Size = new System.Drawing.Size(192, 518);
            this.PrimesGrid.TabIndex = 0;
            // 
            // formBindingSource
            // 
            this.formBindingSource.DataSource = typeof(PrimesAndHighlyCompositeNumbers.Form);
            // 
            // CompositesGrid
            // 
            this.CompositesGrid.AllowUserToAddRows = false;
            this.CompositesGrid.AllowUserToDeleteRows = false;
            this.CompositesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompositesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.compositesColumn,
            this.Divisors});
            this.CompositesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompositesGrid.Location = new System.Drawing.Point(0, 0);
            this.CompositesGrid.Name = "CompositesGrid";
            this.CompositesGrid.ReadOnly = true;
            this.CompositesGrid.RowHeadersVisible = false;
            this.CompositesGrid.Size = new System.Drawing.Size(186, 518);
            this.CompositesGrid.TabIndex = 0;
            // 
            // CurrentNumberLabel
            // 
            this.CurrentNumberLabel.AutoSize = false;
            this.CurrentNumberLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.CurrentNumberLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.CurrentNumberLabel.Name = "CurrentNumberLabel";
            this.CurrentNumberLabel.Size = new System.Drawing.Size(174, 19);
            // 
            // ElapsedTimeLabel
            // 
            this.ElapsedTimeLabel.AutoSize = false;
            this.ElapsedTimeLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.ElapsedTimeLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.ElapsedTimeLabel.Name = "ElapsedTimeLabel";
            this.ElapsedTimeLabel.Size = new System.Drawing.Size(64, 19);
            // 
            // RemainingLabel
            // 
            this.RemainingLabel.AutoSize = false;
            this.RemainingLabel.Name = "RemainingLabel";
            this.RemainingLabel.Size = new System.Drawing.Size(127, 19);
            // 
            // primesColumn
            // 
            this.primesColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.primesColumn.HeaderText = "Prime numbers";
            this.primesColumn.Name = "primesColumn";
            this.primesColumn.ReadOnly = true;
            this.primesColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // compositesColumn
            // 
            this.compositesColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.compositesColumn.HeaderText = "Composite numbers";
            this.compositesColumn.Name = "compositesColumn";
            this.compositesColumn.ReadOnly = true;
            this.compositesColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Divisors
            // 
            this.Divisors.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Divisors.HeaderText = "Divisors";
            this.Divisors.Name = "Divisors";
            this.Divisors.ReadOnly = true;
            this.Divisors.Width = 69;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(374, 130);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabel1.Location = new System.Drawing.Point(229, 120);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(41, 20);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form
            // 
            this.AcceptButton = this.StartButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "Prime and Highly Composite Numbers Generator";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumValue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PrimesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompositesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripProgressBar MainWorkerProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel PercentageLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView PrimesGrid;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.DataGridView CompositesGrid;
        private System.Windows.Forms.NumericUpDown MaximumValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource formBindingSource;
        private System.Windows.Forms.ToolStripStatusLabel CurrentNumberLabel;
        private System.Windows.Forms.ToolStripStatusLabel ElapsedTimeLabel;
        private System.Windows.Forms.ToolStripStatusLabel RemainingLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn primesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compositesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Divisors;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

