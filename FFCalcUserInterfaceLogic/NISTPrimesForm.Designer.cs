namespace FiniteFieldCalculator
{
    partial class NISTPrimesForm
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
            btnP224 = new Button();
            btnP192 = new Button();
            btnP256 = new Button();
            btnP384 = new Button();
            btnP521 = new Button();
            SuspendLayout();
            // 
            // btnP224
            // 
            btnP224.Location = new Point(71, 96);
            btnP224.Name = "btnP224";
            btnP224.Size = new Size(75, 23);
            btnP224.TabIndex = 0;
            btnP224.Text = "p224";
            btnP224.UseVisualStyleBackColor = true;
            btnP224.Click += btnP224_Click;
            // 
            // btnP192
            // 
            btnP192.Location = new Point(71, 48);
            btnP192.Name = "btnP192";
            btnP192.Size = new Size(75, 23);
            btnP192.TabIndex = 1;
            btnP192.Text = "p192";
            btnP192.UseVisualStyleBackColor = true;
            btnP192.Click += btnP192_Click;
            // 
            // btnP256
            // 
            btnP256.Location = new Point(71, 141);
            btnP256.Name = "btnP256";
            btnP256.Size = new Size(75, 23);
            btnP256.TabIndex = 2;
            btnP256.Text = "p256";
            btnP256.UseVisualStyleBackColor = true;
            btnP256.Click += btnP256_Click;
            // 
            // btnP384
            // 
            btnP384.Location = new Point(71, 183);
            btnP384.Name = "btnP384";
            btnP384.Size = new Size(75, 23);
            btnP384.TabIndex = 3;
            btnP384.Text = "p384";
            btnP384.UseVisualStyleBackColor = true;
            btnP384.Click += btnP384_Click;
            // 
            // btnP521
            // 
            btnP521.Location = new Point(71, 222);
            btnP521.Name = "btnP521";
            btnP521.Size = new Size(75, 23);
            btnP521.TabIndex = 4;
            btnP521.Text = "p521";
            btnP521.UseVisualStyleBackColor = true;
            btnP521.Click += btnP521_Click;
            // 
            // NISTPrimesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 450);
            Controls.Add(btnP521);
            Controls.Add(btnP384);
            Controls.Add(btnP256);
            Controls.Add(btnP192);
            Controls.Add(btnP224);
            Name = "NISTPrimesForm";
            Text = "NIST";
            ResumeLayout(false);
        }

        #endregion

        private Button btnP224;
        private Button btnP192;
        private Button btnP256;
        private Button btnP384;
        private Button btnP521;
    }
}