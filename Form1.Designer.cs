namespace BankAccountApplication
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
            lblOwner = new Label();
            lblAmount = new Label();
            txtOwner = new TextBox();
            numUpDown = new NumericUpDown();
            grid = new DataGridView();
            btnDeposit = new Button();
            btnCreate = new Button();
            btnWithdraw = new Button();
            numInterest = new NumericUpDown();
            label1 = new Label();
            lblInterest = new Label();
            ((System.ComponentModel.ISupportInitialize)numUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numInterest).BeginInit();
            SuspendLayout();
            // 
            // lblOwner
            // 
            lblOwner.AutoSize = true;
            lblOwner.Location = new Point(82, 115);
            lblOwner.Name = "lblOwner";
            lblOwner.Size = new Size(73, 25);
            lblOwner.TabIndex = 0;
            lblOwner.Text = "Owner: ";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(82, 354);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(81, 25);
            lblAmount.TabIndex = 1;
            lblAmount.Text = "Amount:";
            // 
            // txtOwner
            // 
            txtOwner.Location = new Point(187, 112);
            txtOwner.Name = "txtOwner";
            txtOwner.Size = new Size(180, 31);
            txtOwner.TabIndex = 2;
            // 
            // numUpDown
            // 
            numUpDown.Location = new Point(187, 352);
            numUpDown.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numUpDown.Minimum = new decimal(new int[] { 999999, 0, 0, int.MinValue });
            numUpDown.Name = "numUpDown";
            numUpDown.Size = new Size(180, 31);
            numUpDown.TabIndex = 3;
            // 
            // grid
            // 
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Location = new Point(412, 112);
            grid.Name = "grid";
            grid.RowHeadersWidth = 62;
            grid.Size = new Size(477, 225);
            grid.TabIndex = 4;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(412, 352);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(223, 34);
            btnDeposit.TabIndex = 5;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(187, 217);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(180, 34);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create Account";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(666, 352);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(223, 34);
            btnWithdraw.TabIndex = 7;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // numInterest
            // 
            numInterest.Location = new Point(256, 164);
            numInterest.Name = "numInterest";
            numInterest.Size = new Size(111, 31);
            numInterest.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 9;
            label1.Text = "label1";
            // 
            // lblInterest
            // 
            lblInterest.AutoSize = true;
            lblInterest.Location = new Point(82, 164);
            lblInterest.Name = "lblInterest";
            lblInterest.Size = new Size(145, 25);
            lblInterest.TabIndex = 10;
            lblInterest.Text = "Interest Rate (%):";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 435);
            Controls.Add(lblInterest);
            Controls.Add(label1);
            Controls.Add(numInterest);
            Controls.Add(btnWithdraw);
            Controls.Add(btnCreate);
            Controls.Add(btnDeposit);
            Controls.Add(grid);
            Controls.Add(numUpDown);
            Controls.Add(txtOwner);
            Controls.Add(lblAmount);
            Controls.Add(lblOwner);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)numInterest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOwner;
        private Label lblAmount;
        private TextBox txtOwner;
        private NumericUpDown numUpDown;
        private DataGridView grid;
        private Button btnDeposit;
        private Button btnCreate;
        private Button btnWithdraw;
        private NumericUpDown numInterest;
        private Label label1;
        private Label lblInterest;
    }
}
