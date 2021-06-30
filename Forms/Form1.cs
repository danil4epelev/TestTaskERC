using System;
using System.Windows.Forms;

namespace TestTaskERC
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }


        private void idTextBox_KeyPress(object sender, KeyPressEventArgs e) //Не позволяет вводить всё, кроме цифр.
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void b_Start_Click(object sender, EventArgs e)
        {
            if(idTextBox.Text == "")
            {
                MessageBox.Show("Вы не ввели ИН!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User newUser = DatabaseQuies.FindUser(Int32.Parse(idTextBox.Text));

            if(newUser == null)
            {
                MessageBox.Show("Такого ИН не существует", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CreateForm(newUser);
        }

        private void b_CreateNewUser_Click(object sender, EventArgs e)
        {
            // хардкод нужен для создания новой записи в БД, это нужно сделать до вывода формы ввода показаний, потому что пользователь должен знать свой ИН(индивидуальный номер)
            int id = DatabaseQuies.AddUserToDB(0.0f, 0.0f, 0.0f, 0.0f);

            User newUser = new User(id, 0.0f, 0.0f, 0.0f, 0.0f);

            CreateForm(newUser);
        }

        private void CreateForm(User user)
        {
            Hide();
            Form2 form = new Form2(user);
            form.Show();
        }

       
    }
}
