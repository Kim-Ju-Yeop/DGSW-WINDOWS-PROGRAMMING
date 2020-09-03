using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace login
{
    public partial class Form1 : Form
    {

        const String ID_HINT = "아이디를 입력해주세요";
        const String PW_HINT = "비밀번호를 입력해주세요";

        public Form1()
        {
            InitializeComponent();

            idTextBox.TabStop = false;
            pwTextBox.TabStop = false;

            idTextBox.Text = ID_HINT;
            pwTextBox.Text = PW_HINT;
        }   

        private void compareDataBase(String id, String pw)
        {
            String strConn = "Server=10.80.163.37;Database=test;Uid=root;Pwd=tiger";
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                String sql = "SELECT * FROM login";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                int idCheck = 0;
                int pwCheck = 0;

                while (rdr.Read())
                {
                    if (id.Equals(rdr["id"])) idCheck = 1;
                    if (pw.Equals(rdr["pwd"])) pwCheck = 1;

                    if (id.Equals(rdr["id"]) && pw.Equals(rdr["pwd"]))
                    {
                        MessageBox.Show("로그인을 성공했습니다.");
                        return;
                    }
                }

                if (idCheck == 0) MessageBox.Show("아이디가 틀렸습니다.");
                if (pwCheck == 0) MessageBox.Show("비밀번호가 틀렸습니다.");

                rdr.Close();
            }
        }

        private void loginClick(object sender, EventArgs e)
        {
            String id = idTextBox.Text.ToString();
            String pw = pwTextBox.Text.ToString();

            compareDataBase(id, pw);
        }

        private void idTextBox_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text.Contains(ID_HINT))
            {
                idTextBox.Focus();
                idTextBox.Text = "";
            }

            if (pwTextBox.Text.Equals(""))
            {
                pwTextBox.Text = PW_HINT;
                pwTextBox.PasswordChar = '\0';
            }
        }

        private void pwTextBox_Click(object sender, EventArgs e)
        {
            if (pwTextBox.Text.Contains(PW_HINT))
            {
                pwTextBox.Focus();
                pwTextBox.Text = "";
                pwTextBox.PasswordChar = '*';
            }

            if (idTextBox.Text.Equals(""))
            {
                idTextBox.Text = ID_HINT;
            }
        }
    }
}
