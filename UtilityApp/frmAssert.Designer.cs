namespace UtilityApp
{
    partial class frmAssert
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
            txtHealth = new TextBox();
            txtName = new TextBox();
            lblName = new Label();
            lblHealth = new Label();
            btnAssert = new Button();
            SuspendLayout();
            // 
            // txtHealth
            // 
            txtHealth.Location = new Point(302, 153);
            txtHealth.Name = "txtHealth";
            txtHealth.Size = new Size(125, 27);
            txtHealth.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(302, 88);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(183, 91);
            lblName.Name = "lblName";
            lblName.Size = new Size(113, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Character name";
            // 
            // lblHealth
            // 
            lblHealth.AutoSize = true;
            lblHealth.Location = new Point(226, 156);
            lblHealth.Name = "lblHealth";
            lblHealth.Size = new Size(53, 20);
            lblHealth.TabIndex = 3;
            lblHealth.Text = "Health";
            lblHealth.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btnAssert
            // 
            btnAssert.Location = new Point(302, 225);
            btnAssert.Name = "btnAssert";
            btnAssert.Size = new Size(94, 29);
            btnAssert.TabIndex = 4;
            btnAssert.Text = "Assert";
            btnAssert.UseVisualStyleBackColor = true;
            btnAssert.Click += btnAssert_Click;
            // 
            // frmAssert
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 416);
            Controls.Add(btnAssert);
            Controls.Add(lblHealth);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(txtHealth);
            Name = "frmAssert";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHealth;
        private TextBox txtName;
        private Label lblName;
        private Label lblHealth;
        private Button btnAssert;
    }
}
