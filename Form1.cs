using BankAccountApplication;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace BankAccountApplication
{
    public partial class Form1 : Form
    {
        List<BankAccount> BankAccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOwner.Text)) //sees if user has entered name
                return;

            decimal initialDeposit = numUpDown.Value;

            if (numInterest.Value > 0) //checks which type of bank account we want to make
            {
                //savings bank account
                decimal interestRate = numInterest.Value;
                SavingsAccount S1 = new SavingsAccount(txtOwner.Text, initialDeposit, interestRate);
                BankAccounts.Add(S1); //adds to list
            }

            else
            {
                //regular bank account
                BankAccount B1 = new BankAccount(txtOwner.Text, initialDeposit);
                BankAccounts.Add(B1);
            }

            /* shorter way to write the above 
             * 
             * 
             if (numInterest.Value > 0) 

                decimal initialDeposit = numUpDown.Value;
                BankAccounts.Add(new SavingsAccount(txtOwner.Text, numInterest.Value, initialDeposit)); 

            else

                decimal initialDeposit = numUpDown.Value; 
                BankAccounts.Add(new BankAccount(txtOwner.Text, initialDeposit));
            
             */


            RefreshGrid();
            txtOwner.Clear();
            numUpDown.Value = 0;
            numInterest.Value = 0;
        }

        private void RefreshGrid()
        {
            grid.DataSource = null;
            grid.DataSource = BankAccounts;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count != 1)
                return;

            int selected = grid.SelectedRows[0].Index; // Gets the selected account from the data grid
            BankAccount selectedAccount = BankAccounts[selected];

            decimal depositAmount = numUpDown.Value; // Get the deposit amount from the numUpDown

            string message = selectedAccount.Deposit(depositAmount); // Perform the deposit and get the result message

            MessageBox.Show(message);
            RefreshGrid();
            numUpDown.Value = 0;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count != 1)
                return; 

            // Get the selected account from the data grid
            int selected = grid.SelectedRows[0].Index;
            BankAccount selectedAccount = BankAccounts[selected];

            // Get the withdrawal amount from the numUpDown
            decimal withdrawAmount = numUpDown.Value;

            // Perform the withdrawal and get the result message
            string message = selectedAccount.Withdraw(withdrawAmount);

            // Show feedback to the user based on the result
            MessageBox.Show(message);
            RefreshGrid(); // Refresh the data grid to reflect the updated balance
            numUpDown.Value = 0; // Reset the numeric up-down control
        }
    }
}
