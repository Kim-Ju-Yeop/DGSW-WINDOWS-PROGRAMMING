using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace register
{
    public partial class Form1 : Form
    {
        String connStr = "Server=10.80.163.37;Database=test;Uid=root;Pwd=tiger";

        public Form1()
        {
            InitializeComponent();
            setGeneralCheckBox();
        }

        private void setGeneralCheckBox()
        {
            generalCheckBox.Items.Add("man");
            generalCheckBox.Items.Add("woman");
        }


        private void checkIdOverlapping(object sender, EventArgs e)
        {   
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                String sql = "SELECT * FROM csharp";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                int overlappingCheck = 0;

                while (rdr.Read())
                {
                    if (idTextbox.Text.Equals("")) overlappingCheck = 1;
                    if (idTextbox.Text.Equals(rdr["id"])) overlappingCheck = 2;
                }

                if (overlappingCheck == 0) idOverlapping.Text = "사용 가능한 아이디입니다.";
                else if (overlappingCheck == 1) idOverlapping.Text = "아이디를 입력해주세요.";
                else idOverlapping.Text = "중복된 아이디가 존재합니다.";
            }
        }

        private void checkMatchPw(object sender, EventArgs e)
        {
            if (pwTextbox.Text.Equals(pwTexbox2.Text)) pwMatching.Text = "비밀번호가 일치합니다.";
            else pwMatching.Text = "비밀번호가 불일치합니다.";
        }

        private void clickRegister(object sender, EventArgs e)
        {
            if (idTextbox.Text.Equals("") || idOverlapping.Text.Equals("") || idOverlapping.Text.Equals("중복된 아이디가 존재합니다."))
            {
                MessageBox.Show("아이디를 다시 한 번 확인부탁드립니다.");
            }
            else if (pwTextbox.Text.Equals("") || pwMatching.Text.Equals("") || pwMatching.Text.Equals("비밀번호가 불일치합니다."))
            {
                MessageBox.Show("비밀번호를 다시 한 번 확인부탁드립니다.");
            }
            else if (generalCheckBox.SelectedItem == null)
            {
                MessageBox.Show("성별을 선택해주시기 바랍니다.");
            }
            else
            {
                String id = idTextbox.Text;
                String pw = pwTextbox.Text;
                String general = generalCheckBox.SelectedItem.ToString();
                String sns = "false";

                if (snsCheckBox.Checked) sns = "true";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    String sql = "INSERT INTO csharp VALUES(" + "'" + id + "'" + ", " + "'" + pw + "'" + ", " + "'" + general + "'" + ", " + "'" + sns + "'" + ");";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("회원가입을 정상적으로 수행하였습니다.");
                }
            }
        }
    }
}
