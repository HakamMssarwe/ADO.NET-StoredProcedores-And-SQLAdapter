using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Backend_Practice
{
    public partial class ManageUsers : Form
    {
        string connectionString = @"Data Source=HAKAM\SQLEXPRESS;Initial Catalog=DBProjectManagerTest;Integrated Security=True";
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataSet DSUsers = new DataSet();
        DataTable DTUsers;



        string emailValidation = @"[a-zA-Z0-9]{1,12}@[a-zA-Z0-9]{1,12}.[a-zA-Z]";
        int passwordMinimumLength = 6;



        public ManageUsers()
        {
            InitializeComponent();

        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter($"select * from TBUsers order by username",connection);
            new SqlCommandBuilder(adapter);
            //change the "insert" statement after it was built by the command builder
            adapter.InsertCommand = new SqlCommand("InsertUsers", connection);
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
            adapter.InsertCommand.Parameters.AddWithValue("usersTable", DTUsers);

            //change the "update" statement after it was built by the command builder (could not update the SQL table using a table parameter in the procedore)
            //adapter.UpdateCommand = new SqlCommand("UpdateUsers", connection);
            //adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;
            //adapter.UpdateCommand.Parameters.AddWithValue("usersTable", DTUsers);



     

            adapter.Fill(DSUsers, "TBUsers");
            DTUsers = DSUsers.Tables["TBUsers"];
        }

       
        private void signupBtn_Click(object sender, EventArgs e)
        {

            Regex regex = new Regex(emailValidation);


            bool checkForEmptyInputs =
                usernameInput.Text == "" && emailInput.Text == "" && firstnameInput.Text == "" &&
                lastnameInput.Text == "" && stateInput.Text == "" && addressInput.Text == "" &&
                avatarURLInput.Text == "" && passwordInput.Text == "" && confirmPasswordInput.Text == "";

            if (checkForEmptyInputs)
            {
                MessageBox.Show("Please do not leave any empty fields!");
                return;
            }
            else if (passwordInput.Text != confirmPasswordInput.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            else if (!regex.IsMatch(emailInput.Text))
            {
                MessageBox.Show("Incorrect email format!");
                return;
            }

            else if (passwordInput.Text.Length < passwordMinimumLength)
            {
                MessageBox.Show("Password too short!");
                return;
            }



            string optionSelected = "";

            foreach(Control option in roleGB.Controls)
            {

                RadioButton radio = (RadioButton)option;

                if (radio.Checked)
                    optionSelected = radio.Text;
            }

            string statusSelected = "";

            foreach (Control option in statusGB.Controls)
            {

                RadioButton radio = (RadioButton)option;

                if (radio.Checked)
                    statusSelected = radio.Text;
            }


     


            DataRow row = DTUsers.NewRow();
            row["username"] = usernameInput.Text;
            row["firstName"] = firstnameInput.Text;
            row["lastName"] = lastnameInput.Text;
            row["email"] = emailInput.Text;
            row["password"] = passwordInput.Text;
            row["avatar"] = avatarURLInput.Text;
            row["role"] = optionSelected;
            row["isAdmin"] = statusSelected == "Admin";
            row["state"] = stateInput.Text;
            row["address"] = addressInput.Text;
            DTUsers.Rows.Add(row);



            MessageBox.Show("Successfully signed up!");
            ClearForm();

        }


        #region keypress functions
        private void usernameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void firstnameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void lastnameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void stateInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void addressInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion

        private void ClearForm()
        {
            usernameInput.Text = "";
            emailInput.Text = "";
            firstnameInput.Text = "";
            lastnameInput.Text = "";
            stateInput.Text = "";
            addressInput.Text = "";
            passwordInput.Text = "";
            confirmPasswordInput.Text = "";
            avatarURLInput.Text = "";
            usernameInput.Text = "";
            FullstackOption.Checked = true;
            MemberStatusOption.Checked = true;


        }



        private void btnSelect_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = DTUsers;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string optionSelected = "";

            foreach (Control option in roleGB.Controls)
            {

                RadioButton radio = (RadioButton)option;

                if (radio.Checked)
                    optionSelected = radio.Text;
            }

            string statusSelected = "";

            foreach (Control option in statusGB.Controls)
            {

                RadioButton radio = (RadioButton)option;

                if (radio.Checked)
                    statusSelected = radio.Text;
            }



            foreach (DataRow row in DTUsers.Rows)
            {
                if (row.RowState != DataRowState.Deleted && row["username"].ToString() == usernameInput.Text)
                {
                    row["firstName"] = firstnameInput.Text;
                    row["lastName"] = lastnameInput.Text;
                    row["email"] = emailInput.Text;
                    row["password"] = passwordInput.Text;
                    row["avatar"] = avatarURLInput.Text;
                    row["role"] = optionSelected;
                    row["isAdmin"] = statusSelected == "Admin";
                    row["state"] = stateInput.Text;
                    row["address"] = addressInput.Text;

                }

            }
             
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach(DataRow row in DTUsers.Rows)
                if (row.RowState != DataRowState.Deleted && row["username"].ToString() == usernameInput.Text)
                    row.Delete();
                
        }

        private void btnUpdateDB_Click(object sender, EventArgs e)
        {
            adapter.Update(DTUsers);
            MessageBox.Show("Sucessfully updated the database!");

        }
    }
}
