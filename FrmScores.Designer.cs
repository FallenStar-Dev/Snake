namespace Snake
{
	partial class FrmScores
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnRestart = new System.Windows.Forms.Button();
			this.dgvScore = new System.Windows.Forms.DataGridView();
			this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ScoreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnClear = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvScore)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRestart
			// 
			this.btnRestart.Location = new System.Drawing.Point(12, 349);
			this.btnRestart.Name = "btnRestart";
			this.btnRestart.Size = new System.Drawing.Size(234, 45);
			this.btnRestart.TabIndex = 1;
			this.btnRestart.Text = "شروع دوباره";
			this.btnRestart.UseVisualStyleBackColor = true;
			this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
			// 
			// dgvScore
			// 
			this.dgvScore.AllowUserToAddRows = false;
			this.dgvScore.AllowUserToDeleteRows = false;
			this.dgvScore.AllowUserToResizeColumns = false;
			this.dgvScore.AllowUserToResizeRows = false;
			this.dgvScore.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvScore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCol,
            this.ScoreCol});
			this.dgvScore.Location = new System.Drawing.Point(12, 12);
			this.dgvScore.Name = "dgvScore";
			this.dgvScore.ReadOnly = true;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvScore.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvScore.RowHeadersVisible = false;
			this.dgvScore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dgvScore.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvScore.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvScore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvScore.Size = new System.Drawing.Size(235, 331);
			this.dgvScore.TabIndex = 2;
			// 
			// NameCol
			// 
			this.NameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NameCol.DataPropertyName = "Name";
			this.NameCol.HeaderText = "نام بازیکن";
			this.NameCol.Name = "NameCol";
			this.NameCol.ReadOnly = true;
			this.NameCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// ScoreCol
			// 
			this.ScoreCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ScoreCol.DataPropertyName = "Score";
			this.ScoreCol.HeaderText = "امتیاز";
			this.ScoreCol.Name = "ScoreCol";
			this.ScoreCol.ReadOnly = true;
			this.ScoreCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(12, 400);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(234, 45);
			this.btnClear.TabIndex = 3;
			this.btnClear.Text = "پاک کردن امتیازات";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// FrmScores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(260, 450);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.dgvScore);
			this.Controls.Add(this.btnRestart);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FrmScores";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "جدول امتیازات";
			this.Load += new System.EventHandler(this.FrmScores_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvScore)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnRestart;
		private System.Windows.Forms.DataGridView dgvScore;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn ScoreCol;
		private System.Windows.Forms.Button btnClear;
	}
}