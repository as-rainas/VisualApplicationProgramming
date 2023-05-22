namespace Activity1
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            txtResult = new TextBox();
            btnSum = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 60);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Number 1 *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 110);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Number 2 *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 157);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Result";
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(154, 57);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(184, 23);
            txtNumber1.TabIndex = 3;
            txtNumber1.Text = "0";
            txtNumber1.Validating += txtNumber1_Validating;
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(154, 107);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(184, 23);
            txtNumber2.TabIndex = 4;
            txtNumber2.Text = "0";
            txtNumber2.Validating += txtNumber2_Validating;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(154, 154);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(184, 23);
            txtResult.TabIndex = 5;
            txtResult.Text = "0";
            // 
            // btnSum
            // 
            btnSum.Location = new Point(154, 197);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(184, 43);
            btnSum.TabIndex = 6;
            btnSum.Text = "SUM";
            btnSum.UseVisualStyleBackColor = false;
            btnSum.Click += btnSum_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 291);
            Controls.Add(btnSum);
            Controls.Add(txtResult);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Aggregate Function - Sum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private TextBox txtResult;
        private Button btnSum;
    }
}