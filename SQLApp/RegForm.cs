using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLApp
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();

            nameBox.Text = "Введите имя";
            nameBox.ForeColor = Color.Gray;
            surnameBox.Text = "Введите фамилию";
            surnameBox.ForeColor = Color.Gray;
        }

        private void closeText_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void backPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void backPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void nameBox_Enter(object sender, EventArgs e)
        {
            if (nameBox.Text == "Введите имя")
            {
                nameBox.Text = "";
                nameBox.ForeColor = Color.Black;
            }
        }

        private void nameBox_Leave(object sender, EventArgs e)
        {
            if (nameBox.Text == "")
            {
                nameBox.Text = "Введите имя";
                nameBox.ForeColor = Color.Gray;
            }
        }

        private void surnameBox_Enter(object sender, EventArgs e)
        {
            if (surnameBox.Text == "Введите фамилию")
            {
                surnameBox.Text = "";
                surnameBox.ForeColor = Color.Black;
            }
        }

        private void surnameBox_Leave(object sender, EventArgs e)
        {
            if (surnameBox.Text == "")
            {
                surnameBox.Text = "Введите фамилию";
                surnameBox.ForeColor = Color.Gray;
            }
        }

        private void authBtn_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "Введите имя") 
            {
                MessageBox.Show("Поле Имя пусто. Введите имя.");
                return;
            }
            if (surnameBox.Text == "Введите фамилию") 
            {
                MessageBox.Show("Поле фамилия пусто. Введите фамилию.");
                return;
            }

            if (isUserExist())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `surname`) VALUES (@login, @pass, @name, @surname)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = tboxUser.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = tboxKey.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameBox.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surnameBox.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаунт не был создан");

            db.closeConnection();
        }

        public Boolean isUserExist()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = tboxUser.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже есть, введите другой");
                return true;
            }
            else
            {
                return false;
            }
                
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }
    }
}
