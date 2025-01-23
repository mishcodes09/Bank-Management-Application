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
            if (string.IsNullOrEmpty(txtOwner.Text))
                return;

            decimal initialDeposit = numUpDown.Value; //gets the amount
            BankAccount B1 = new BankAccount(txtOwner.Text, initialDeposit);
            BankAccounts.Add(B1);

            RefreshGrid();
            txtOwner.Clear();
            numUpDown.Value = 0;
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
