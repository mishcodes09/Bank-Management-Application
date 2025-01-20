using BankAccountApplication;

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
            if (grid.SelectedRows.Count == 0)
                return;

            //i need to get the selected account from the data grid
            int selected = grid.SelectedRows[0].Index;
            BankAccount selectedAccount = BankAccounts[selected];

            //now i need to get the deposit amount from the numUpDown
            decimal depositAmount = numUpDown.Value;

            //perform the deposit
            try
            {
                selectedAccount.Deposit(depositAmount);
                RefreshGrid();
                MessageBox.Show($"Successfully deposited {depositAmount:C} into account.");
            }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Deposit Error");
            }

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count == 0)
                return;

            int selected = grid.SelectedRows[0].Index;
            BankAccount selectedAccount = BankAccounts[selected];

            decimal withdrawAmount = numUpDown.Value;

            try
            {  selectedAccount.Withdraw(withdrawAmount);
               RefreshGrid();
               MessageBox.Show($"Successfully withdrew {withdrawAmount:C} into account.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Withdrawal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Withdrawal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
