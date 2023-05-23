namespace Activity2
{
    partial class Aggregate_Functions_Average
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
            txtSubject1 = new TextBox();
            txtSubject2 = new TextBox();
            txtAverage = new TextBox();
            btnSubmit = new Button();
            lblMark = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 39);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Subject 1 *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 70);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Subject 2 *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 103);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Average";
            // 
            // txtSubject1
            // 
            txtSubject1.Location = new Point(125, 36);
            txtSubject1.Name = "txtSubject1";
            txtSubject1.Size = new Size(175, 23);
            txtSubject1.TabIndex = 3;
            txtSubject1.Text = "0";
            txtSubject1.Validating += txtSubject1_Validating;
            // 
            // txtSubject2
            // 
            txtSubject2.Location = new Point(125, 67);
            txtSubject2.Name = "txtSubject2";
            txtSubject2.Size = new Size(175, 23);
            txtSubject2.TabIndex = 4;
            txtSubject2.Text = "0";
            txtSubject2.Validating += txtSubject2_Validating;
            // 
            // txtAverage
            // 
            txtAverage.Location = new Point(125, 100);
            txtAverage.Name = "txtAverage";
            txtAverage.Size = new Size(175, 23);
            txtAverage.TabIndex = 5;
            txtAverage.Text = "0";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(134, 143);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(147, 40);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblMark
            // 
            lblMark.AutoSize = true;
            lblMark.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMark.ForeColor = Color.Red;
            lblMark.Location = new Point(287, 156);
            lblMark.Name = "lblMark";
            lblMark.Size = new Size(0, 15);
            lblMark.TabIndex = 7;
            // 
            // Aggregate_Functions_Average
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 210);
            Controls.Add(lblMark);
            Controls.Add(btnSubmit);
            Controls.Add(txtAverage);
            Controls.Add(txtSubject2);
            Controls.Add(txtSubject1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Aggregate_Functions_Average";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aggregate Functions -Average";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSubject1;
        private TextBox txtSubject2;
        private TextBox txtAverage;
        private Button btnSubmit;
        private Label lblMark;
    }
}