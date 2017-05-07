namespace RegExp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.cB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRegExp = new System.Windows.Forms.TextBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.chB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer
            // 
            this.SplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplitContainer.BackColor = System.Drawing.Color.White;
            this.SplitContainer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.SplitContainer.Name = "SplitContainer";
            this.SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.AllowDrop = true;
            this.SplitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(205)))), ((int)(((byte)(230)))));
            this.SplitContainer.Panel1.Controls.Add(this.chB);
            this.SplitContainer.Panel1.Controls.Add(this.cB);
            this.SplitContainer.Panel1.Controls.Add(this.label3);
            this.SplitContainer.Panel1.Controls.Add(this.label1);
            this.SplitContainer.Panel1.Controls.Add(this.tbRegExp);
            this.SplitContainer.Panel1.Controls.Add(this.tbInput);
            this.SplitContainer.Panel1MinSize = 180;
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.BackColor = System.Drawing.Color.LightGreen;
            this.SplitContainer.Panel2.Controls.Add(this.label2);
            this.SplitContainer.Panel2.Controls.Add(this.tbOutput);
            this.SplitContainer.Panel2MinSize = 80;
            this.SplitContainer.Size = new System.Drawing.Size(584, 465);
            this.SplitContainer.SplitterDistance = 301;
            this.SplitContainer.SplitterWidth = 5;
            this.SplitContainer.TabIndex = 0;
            // 
            // cB
            // 
            this.cB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cB.BackColor = System.Drawing.Color.White;
            this.cB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB.Font = new System.Drawing.Font("Calibri", 12.75F);
            this.cB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cB.FormattingEnabled = true;
            this.cB.Location = new System.Drawing.Point(11, 206);
            this.cB.Name = "cB";
            this.cB.Size = new System.Drawing.Size(561, 29);
            this.cB.TabIndex = 5;
            this.cB.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Регулярное выражение:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Исходный текст";
            // 
            // tbRegExp
            // 
            this.tbRegExp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRegExp.BackColor = System.Drawing.Color.Moccasin;
            this.tbRegExp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRegExp.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRegExp.Location = new System.Drawing.Point(11, 244);
            this.tbRegExp.Multiline = true;
            this.tbRegExp.Name = "tbRegExp";
            this.tbRegExp.Size = new System.Drawing.Size(561, 43);
            this.tbRegExp.TabIndex = 2;
            this.tbRegExp.TextChanged += new System.EventHandler(this.tbRegExp_TextChanged);
            // 
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInput.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInput.Location = new System.Drawing.Point(11, 27);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInput.Size = new System.Drawing.Size(562, 148);
            this.tbInput.TabIndex = 0;
            this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Результат";
            // 
            // tbOutput
            // 
            this.tbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOutput.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutput.Location = new System.Drawing.Point(11, 40);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput.Size = new System.Drawing.Size(562, 107);
            this.tbOutput.TabIndex = 1;
            // 
            // chB
            // 
            this.chB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chB.AutoSize = true;
            this.chB.ForeColor = System.Drawing.Color.Black;
            this.chB.Location = new System.Drawing.Point(496, 185);
            this.chB.Name = "chB";
            this.chB.Size = new System.Drawing.Size(80, 17);
            this.chB.TabIndex = 6;
            this.chB.Text = "IgnoreCase";
            this.chB.UseVisualStyleBackColor = true;
            this.chB.Click += new System.EventHandler(this.chB_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.SplitContainer);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegExp";
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel1.PerformLayout();
            this.SplitContainer.Panel2.ResumeLayout(false);
            this.SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.TextBox tbRegExp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cB;
        private System.Windows.Forms.CheckBox chB;
    }
}

