namespace Ex_2
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
			this.Number1 = new System.Windows.Forms.TextBox();
			this.Operator = new System.Windows.Forms.ComboBox();
			this.Number2 = new System.Windows.Forms.TextBox();
			this.CalcButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TitleOfForm
			// 
			this.TitleOfForm.AutoSize = true;
			this.TitleOfForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TitleOfForm.Location = new System.Drawing.Point(75, 37);
			this.TitleOfForm.Name = "TitleOfForm";
			this.TitleOfForm.Size = new System.Drawing.Size(121, 29);
			this.TitleOfForm.TabIndex = 0;
			this.TitleOfForm.Text = "Calculator";
			// 
			// Number1
			// 
			this.Number1.Location = new System.Drawing.Point(50, 100);
			this.Number1.MaxLength = 9;
			this.Number1.Name = "Number1";
			this.Number1.Size = new System.Drawing.Size(50, 20);
			this.Number1.TabIndex = 1;
			this.Number1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// Operator
			// 
			this.Operator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Operator.FormattingEnabled = true;
			this.Operator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "%",
            "^"});
			this.Operator.Location = new System.Drawing.Point(112, 100);
			this.Operator.Name = "Operator";
			this.Operator.Size = new System.Drawing.Size(50, 21);
			this.Operator.TabIndex = 2;
			this.Operator.Text = "+";
			// 
			// Number2
			// 
			this.Number2.Location = new System.Drawing.Point(175, 100);
			this.Number2.MaxLength = 9;
			this.Number2.Name = "Number2";
			this.Number2.Size = new System.Drawing.Size(50, 20);
			this.Number2.TabIndex = 3;
			// 
			// CalcButton
			// 
			this.CalcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CalcButton.Location = new System.Drawing.Point(100, 206);
			this.CalcButton.Name = "CalcButton";
			this.CalcButton.Size = new System.Drawing.Size(75, 23);
			this.CalcButton.TabIndex = 4;
			this.CalcButton.Text = "=";
			this.CalcButton.UseVisualStyleBackColor = true;
			this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.CalcButton);
			this.Controls.Add(this.Number2);
			this.Controls.Add(this.Operator);
			this.Controls.Add(this.Number1);
			this.Controls.Add(this.TitleOfForm);
			this.Name = "Form1";
			this.Text = "Calculator";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TitleOfForm;
		private System.Windows.Forms.TextBox Number1;
		private System.Windows.Forms.ComboBox Operator;
		private System.Windows.Forms.TextBox Number2;
		private System.Windows.Forms.Button CalcButton;
	}
}

