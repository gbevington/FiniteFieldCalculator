namespace FiniteFieldCalculator
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
            btnEnterPrime = new Button();
            btnDiv = new Button();
            btnMulti = new Button();
            btnSubtract = new Button();
            btnAdd = new Button();
            btnNIST = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtResult = new TextBox();
            label1 = new Label();
            txtOp1 = new TextBox();
            txtOp2 = new TextBox();
            txtExpo = new TextBox();
            txtPrime = new TextBox();
            btnExponent = new Button();
            SuspendLayout();
            // 
            // btnEnterPrime
            // 
            btnEnterPrime.Location = new Point(151, 66);
            btnEnterPrime.Name = "btnEnterPrime";
            btnEnterPrime.Size = new Size(101, 23);
            btnEnterPrime.TabIndex = 31;
            btnEnterPrime.Text = "Enter Prime #";
            btnEnterPrime.UseVisualStyleBackColor = true;
            btnEnterPrime.Click += btnEnterPrime_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(318, 259);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(75, 23);
            btnDiv.TabIndex = 30;
            btnDiv.Text = "A / B";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(237, 259);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(75, 23);
            btnMulti.TabIndex = 29;
            btnMulti.Text = "A * B";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(156, 259);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(75, 23);
            btnSubtract.TabIndex = 28;
            btnSubtract.Text = "A - B";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(75, 259);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "A + B";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnNIST
            // 
            btnNIST.Location = new Point(54, 52);
            btnNIST.Name = "btnNIST";
            btnNIST.Size = new Size(75, 51);
            btnNIST.TabIndex = 26;
            btnNIST.Text = "NIST Primes";
            btnNIST.UseVisualStyleBackColor = true;
            btnNIST.Click += btnNIST_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 302);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 25;
            label5.Text = "Output:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 122);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 24;
            label4.Text = "A: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 167);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 23;
            label3.Text = "B:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 212);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 22;
            label2.Text = "R: ";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(113, 302);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(441, 23);
            txtResult.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 27);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 20;
            label1.Text = "Prime # :";
            // 
            // txtOp1
            // 
            txtOp1.Location = new Point(152, 122);
            txtOp1.Name = "txtOp1";
            txtOp1.Size = new Size(100, 23);
            txtOp1.TabIndex = 19;
            // 
            // txtOp2
            // 
            txtOp2.Location = new Point(152, 167);
            txtOp2.Name = "txtOp2";
            txtOp2.Size = new Size(100, 23);
            txtOp2.TabIndex = 18;
            // 
            // txtExpo
            // 
            txtExpo.Location = new Point(152, 212);
            txtExpo.Name = "txtExpo";
            txtExpo.Size = new Size(100, 23);
            txtExpo.TabIndex = 17;
            // 
            // txtPrime
            // 
            txtPrime.Location = new Point(152, 27);
            txtPrime.Name = "txtPrime";
            txtPrime.Size = new Size(402, 23);
            txtPrime.TabIndex = 16;
            // 
            // btnExponent
            // 
            btnExponent.Location = new Point(399, 259);
            btnExponent.Name = "btnExponent";
            btnExponent.Size = new Size(75, 23);
            btnExponent.TabIndex = 32;
            btnExponent.Text = "A ^ R";
            btnExponent.UseVisualStyleBackColor = true;
            btnExponent.Click += btnExponent_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 362);
            Controls.Add(btnExponent);
            Controls.Add(btnEnterPrime);
            Controls.Add(btnDiv);
            Controls.Add(btnMulti);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(btnNIST);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtResult);
            Controls.Add(label1);
            Controls.Add(txtOp1);
            Controls.Add(txtOp2);
            Controls.Add(txtExpo);
            Controls.Add(txtPrime);
            Name = "Form1";
            Text = "Finite Field Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnterPrime;
        private Button btnDiv;
        private Button btnMulti;
        private Button btnSubtract;
        private Button btnAdd;
        private Button btnNIST;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtResult;
        private Label label1;
        private TextBox txtOp1;
        private TextBox txtOp2;
        private TextBox txtExpo;
        private TextBox txtPrime;
        private Button btnExponent;
    }
}