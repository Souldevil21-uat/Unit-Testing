namespace Unit_Testing
{
    partial class Form1
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
            lblValue1 = new Label();
            lblValue2 = new Label();
            txtValue1 = new TextBox();
            txtValue2 = new TextBox();
            btnCheckGreater = new Button();
            btnCheckRange = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblValue1
            // 
            lblValue1.AutoSize = true;
            lblValue1.Location = new Point(172, 120);
            lblValue1.Name = "lblValue1";
            lblValue1.Size = new Size(106, 15);
            lblValue1.TabIndex = 0;
            lblValue1.Text = "Enter First Number";
            // 
            // lblValue2
            // 
            lblValue2.AutoSize = true;
            lblValue2.Location = new Point(393, 120);
            lblValue2.Name = "lblValue2";
            lblValue2.Size = new Size(123, 15);
            lblValue2.TabIndex = 1;
            lblValue2.Text = "Enter Second Number";
            // 
            // txtValue1
            // 
            txtValue1.Location = new Point(172, 177);
            txtValue1.Name = "txtValue1";
            txtValue1.Size = new Size(100, 23);
            txtValue1.TabIndex = 2;
            // 
            // txtValue2
            // 
            txtValue2.Location = new Point(404, 177);
            txtValue2.Name = "txtValue2";
            txtValue2.Size = new Size(100, 23);
            txtValue2.TabIndex = 3;
            // 
            // btnCheckGreater
            // 
            btnCheckGreater.Location = new Point(173, 252);
            btnCheckGreater.Name = "btnCheckGreater";
            btnCheckGreater.Size = new Size(99, 23);
            btnCheckGreater.TabIndex = 4;
            btnCheckGreater.Text = "Check Greater";
            btnCheckGreater.UseVisualStyleBackColor = true;
            // 
            // btnCheckRange
            // 
            btnCheckRange.Location = new Point(404, 252);
            btnCheckRange.Name = "btnCheckRange";
            btnCheckRange.Size = new Size(99, 23);
            btnCheckRange.TabIndex = 5;
            btnCheckRange.Text = "Check Range";
            btnCheckRange.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(294, 326);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnCheckRange);
            Controls.Add(btnCheckGreater);
            Controls.Add(txtValue2);
            Controls.Add(txtValue1);
            Controls.Add(lblValue2);
            Controls.Add(lblValue1);
            Name = "Form1";
            Text = "Number Off";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblValue1;
        private Label lblValue2;
        private TextBox txtValue1;
        private TextBox txtValue2;
        private Button btnCheckGreater;
        private Button btnCheckRange;
        private Label lblResult;
    }
}
