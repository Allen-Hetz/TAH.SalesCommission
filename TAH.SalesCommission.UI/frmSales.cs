namespace TAH.SalesCommission.UI
{
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exits the application
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clears the inputs and outputs
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtSales.Text = "";
            lblCommission.Text = "";
            lblResult.Text = "";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Declares variables for last name, first name, and commission
            string strLastName;
            string strFirstName;
            decimal dmlCommission;
            // Validates the sales input
            if (txtSales.Text == "" || !decimal.TryParse(txtSales.Text, out decimal dmlSales))
            {
                // Displays an error message
                MessageBox.Show("Please enter a valid sales amount.");
                return;
            }
            else
            {
                // Converts the sales input text box to two decimal places
                txtSales.Text = dmlSales.ToString("f2");
            }

            // Checks if the sales amount is negative
            if (dmlSales < 0)
            {
                // Displays an error message
                MessageBox.Show("Sales amount cannot be negative.");
                return;
            }

            // Checks if last name and first name are provided
            if (string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtFirstName.Text))
            {

                // makes name variables empty if no name is provided
                if (string.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    strLastName = "";
                }
                else
                {
                    // Gets the last name from the text box
                    strLastName = txtLastName.Text;
                    // Capitalizes the first letter of the last name
                    strLastName = char.ToUpper(strLastName[0]) + strLastName.Substring(1).ToLower();
                }
                if (string.IsNullOrWhiteSpace(txtFirstName.Text))
                {
                    strFirstName = "";
                }
                else
                {
                    // Gets the first name from the text box
                    strFirstName = txtFirstName.Text;
                    // Capitalizes the first letter of the first name
                    strFirstName = char.ToUpper(strFirstName[0]) + strFirstName.Substring(1).ToLower();
                }
            }
            else
            {
                // Gets the last name and first name from the text boxes
                strLastName = txtLastName.Text;
                strFirstName = txtFirstName.Text;

                // Capitalizes the first letter of the last name and first name
                strLastName = char.ToUpper(strLastName[0]) + strLastName.Substring(1).ToLower();
                strFirstName = char.ToUpper(strFirstName[0]) + strFirstName.Substring(1).ToLower();
            }

            // Corrects capitalization in the name text boxes
            txtLastName.Text = strLastName;
            txtFirstName.Text = strFirstName;

            // Displays the names above the commission result
            lblCommission.Text = $"Commission for {strFirstName} {strLastName}";

            // Calculate the commission as 10% of sales
            dmlCommission = (dmlSales * 0.1m);

            // Display the commission in the result label
            lblResult.Text = $"{dmlCommission:C2}";
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            // Clears outputs when the last name text box is changed
            lblCommission.Text = "";
            lblResult.Text = "";
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            // Clears outputs when the first name text box is changed
            lblCommission.Text = "";
            lblResult.Text = "";
        }

        private void txtSales_TextChanged(object sender, EventArgs e)
        {
            // Clears outputs when the sales text box is changed
            lblCommission.Text = "";
            lblResult.Text = "";
        }
    }
}