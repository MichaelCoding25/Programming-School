namespace Ex_1
{
	partial class Convertor
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
			if( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.TitleOfForm = new System.Windows.Forms.Label();
            this.F = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.FTextBox = new System.Windows.Forms.TextBox();
            this.CTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TitleOfForm
            // 
            this.TitleOfForm.AutoSize = true;
            this.TitleOfForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleOfForm.Location = new System.Drawing.Point(75, 37);
            this.TitleOfForm.Name = "TitleOfForm";
            this.TitleOfForm.Size = new System.Drawing.Size(118, 29);
            this.TitleOfForm.TabIndex = 0;
            this.TitleOfForm.Text = "Convertor";
            this.TitleOfForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F.Location = new System.Drawing.Point(75, 100);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(23, 24);
            this.F.TabIndex = 1;
            this.F.Text = "F";
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(75, 150);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(24, 24);
            this.C.TabIndex = 2;
            this.C.Text = "C";
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(91, 200);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 25);
            this.ConvertButton.TabIndex = 3;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ConvertButton_MouseClick);
            // 
            // FTextBox
            // 
            this.FTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FTextBox.Location = new System.Drawing.Point(105, 100);
            this.FTextBox.Name = "FTextBox";
            this.FTextBox.Size = new System.Drawing.Size(100, 20);
            this.FTextBox.TabIndex = 4;
            this.FTextBox.TextChanged += new System.EventHandler(this.FTextBox_TextChanged);
            // 
            // CTextBox
            // 
            this.CTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CTextBox.Location = new System.Drawing.Point(105, 150);
            this.CTextBox.Name = "CTextBox";
            this.CTextBox.Size = new System.Drawing.Size(100, 20);
            this.CTextBox.TabIndex = 5;
            // 
            // Convertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.CTextBox);
            this.Controls.Add(this.FTextBox);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.C);
            this.Controls.Add(this.F);
            this.Controls.Add(this.TitleOfForm);
            this.Name = "Convertor";
            this.Text = "Convertor";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TitleOfForm;
		private System.Windows.Forms.Label F;
		private System.Windows.Forms.Label C;
		private System.Windows.Forms.Button ConvertButton;
		private System.Windows.Forms.TextBox FTextBox;
		private System.Windows.Forms.TextBox CTextBox;
	}
}

