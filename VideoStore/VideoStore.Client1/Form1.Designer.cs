namespace VideoStore.Client1
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
			this.btnSynch = new System.Windows.Forms.Button();
			this.btnAsynch = new System.Windows.Forms.Button();
			this.btnAsynch2 = new System.Windows.Forms.Button();
			this.btnRating = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnSynch
			// 
			this.btnSynch.Location = new System.Drawing.Point(55, 43);
			this.btnSynch.Name = "btnSynch";
			this.btnSynch.Size = new System.Drawing.Size(166, 35);
			this.btnSynch.TabIndex = 0;
			this.btnSynch.Text = "Synchronous";
			this.btnSynch.UseVisualStyleBackColor = true;
			this.btnSynch.Click += new System.EventHandler(this.btnSynch_Click);
			// 
			// btnAsynch
			// 
			this.btnAsynch.Location = new System.Drawing.Point(59, 114);
			this.btnAsynch.Name = "btnAsynch";
			this.btnAsynch.Size = new System.Drawing.Size(166, 35);
			this.btnAsynch.TabIndex = 1;
			this.btnAsynch.Text = "Asynchronous";
			this.btnAsynch.UseVisualStyleBackColor = true;
			this.btnAsynch.Click += new System.EventHandler(this.btnAsynch_Click);
			// 
			// btnAsynch2
			// 
			this.btnAsynch2.Location = new System.Drawing.Point(59, 178);
			this.btnAsynch2.Name = "btnAsynch2";
			this.btnAsynch2.Size = new System.Drawing.Size(166, 35);
			this.btnAsynch2.TabIndex = 2;
			this.btnAsynch2.Text = "Asynchronous With Wait";
			this.btnAsynch2.UseVisualStyleBackColor = true;
			this.btnAsynch2.Click += new System.EventHandler(this.btnAsynch2_Click);
			// 
			// btnRating
			// 
			this.btnRating.Location = new System.Drawing.Point(272, 43);
			this.btnRating.Name = "btnRating";
			this.btnRating.Size = new System.Drawing.Size(166, 35);
			this.btnRating.TabIndex = 3;
			this.btnRating.Text = "Send Rating";
			this.btnRating.UseVisualStyleBackColor = true;
			this.btnRating.Click += new System.EventHandler(this.btnRating_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(513, 262);
			this.Controls.Add(this.btnRating);
			this.Controls.Add(this.btnAsynch2);
			this.Controls.Add(this.btnAsynch);
			this.Controls.Add(this.btnSynch);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSynch;
		private System.Windows.Forms.Button btnAsynch;
		private System.Windows.Forms.Button btnAsynch2;
		private System.Windows.Forms.Button btnRating;
	}
}

