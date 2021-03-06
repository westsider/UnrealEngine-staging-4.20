namespace UnrealGameSync
{
	partial class ProgramsRunningWindow
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
			this.IgnoreBtn = new System.Windows.Forms.Button();
			this.CancelBtn = new System.Windows.Forms.Button();
			this.ProgramListBox = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// IgnoreBtn
			// 
			this.IgnoreBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.IgnoreBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.IgnoreBtn.Location = new System.Drawing.Point(12, 188);
			this.IgnoreBtn.Name = "IgnoreBtn";
			this.IgnoreBtn.Size = new System.Drawing.Size(94, 27);
			this.IgnoreBtn.TabIndex = 0;
			this.IgnoreBtn.Text = "Ignore";
			this.IgnoreBtn.UseVisualStyleBackColor = true;
			// 
			// CancelBtn
			// 
			this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelBtn.Location = new System.Drawing.Point(523, 188);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(95, 27);
			this.CancelBtn.TabIndex = 1;
			this.CancelBtn.Text = "Cancel";
			this.CancelBtn.UseVisualStyleBackColor = true;
			// 
			// ProgramListBox
			// 
			this.ProgramListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ProgramListBox.FormattingEnabled = true;
			this.ProgramListBox.IntegralHeight = false;
			this.ProgramListBox.ItemHeight = 15;
			this.ProgramListBox.Location = new System.Drawing.Point(23, 44);
			this.ProgramListBox.Name = "ProgramListBox";
			this.ProgramListBox.Size = new System.Drawing.Size(586, 136);
			this.ProgramListBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(264, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Please close the following programs to continue:";
			// 
			// ProgramsRunningWindow
			// 
			this.AcceptButton = this.CancelBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(630, 227);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ProgramListBox);
			this.Controls.Add(this.CancelBtn);
			this.Controls.Add(this.IgnoreBtn);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "ProgramsRunningWindow";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Programs Running";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProgramsRunningWindow_FormClosed);
			this.Load += new System.EventHandler(this.ProgramsRunningWindow_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button IgnoreBtn;
		private System.Windows.Forms.Button CancelBtn;
		private System.Windows.Forms.ListBox ProgramListBox;
		private System.Windows.Forms.Label label1;
	}
}