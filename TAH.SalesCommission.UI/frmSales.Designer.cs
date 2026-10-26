namespace TAH.SalesCommission.UI
{
    partial class frmSales
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
            lblLastName = new Label();
            lblFirstName = new Label();
            lblSales = new Label();
            lblResult = new Label();
            lblCommission = new Label();
            btnCalc = new Button();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtSales = new TextBox();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F);
            lblLastName.Location = new Point(27, 9);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(84, 21);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 12F);
            lblFirstName.Location = new Point(27, 50);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(86, 21);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name";
            // 
            // lblSales
            // 
            lblSales.AutoSize = true;
            lblSales.Font = new Font("Segoe UI", 12F);
            lblSales.Location = new Point(27, 91);
            lblSales.Name = "lblSales";
            lblSales.Size = new Size(46, 21);
            lblSales.TabIndex = 2;
            lblSales.Text = "Sales";
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.FlatStyle = FlatStyle.Popup;
            lblResult.Font = new Font("Segoe UI", 12F);
            lblResult.Location = new Point(55, 224);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(253, 23);
            lblResult.TabIndex = 3;
            lblResult.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCommission
            // 
            lblCommission.Font = new Font("Segoe UI", 12F);
            lblCommission.Location = new Point(55, 189);
            lblCommission.Name = "lblCommission";
            lblCommission.Size = new Size(253, 21);
            lblCommission.TabIndex = 4;
            lblCommission.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCalc
            // 
            btnCalc.Font = new Font("Segoe UI", 12F);
            btnCalc.Location = new Point(84, 139);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(190, 35);
            btnCalc.TabIndex = 8;
            btnCalc.Text = "&Calculate Commission";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 12F);
            txtLastName.Location = new Point(122, 6);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(205, 29);
            txtLastName.TabIndex = 5;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 12F);
            txtFirstName.Location = new Point(122, 47);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(205, 29);
            txtFirstName.TabIndex = 6;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // txtSales
            // 
            txtSales.Font = new Font("Segoe UI", 12F);
            txtSales.Location = new Point(122, 88);
            txtSales.Name = "txtSales";
            txtSales.Size = new Size(205, 29);
            txtSales.TabIndex = 7;
            txtSales.TextAlign = HorizontalAlignment.Right;
            txtSales.TextChanged += txtSales_TextChanged;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F);
            btnClear.Location = new Point(55, 265);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(102, 35);
            btnClear.TabIndex = 9;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F);
            btnExit.Location = new Point(206, 265);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(102, 35);
            btnExit.TabIndex = 10;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 330);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(txtSales);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(btnCalc);
            Controls.Add(lblCommission);
            Controls.Add(lblResult);
            Controls.Add(lblSales);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Name = "frmSales";
            Text = "Sales Commission";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLastName;
        private Label lblFirstName;
        private Label lblSales;
        private Label lblResult;
        private Label lblCommission;
        private Button btnCalc;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtSales;
        private Button btnClear;
        private Button btnExit;
    }
}
