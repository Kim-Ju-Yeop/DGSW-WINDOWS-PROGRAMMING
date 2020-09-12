using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace diary
{
    public partial class Form1 : Form
    {
        String connStr = "Server=10.80.163.37;Database=test;Uid=root;Pwd=tiger";
        String id = "Heesong2";

        public Form1()
        {
            InitializeComponent();
            initListView();
            getAllData();
        }

        public void initListView()
        {
            listView.View = View.Details;
            listView.GridLines = true;

            listView.Columns.Add("날짜");
            listView.Columns.Add("일기");
            listView.Columns.Add("아이디");
        }

        public void getAllData()
        {
            listView.Items.Clear();

            using(MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                String sql = "SELECT * FROM diary WHERE id = '" + id + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    String[] dataArr = { rdr["date"].ToString(), rdr["contents"].ToString(), rdr["id"].ToString() };
                    ListViewItem listViewItem = new ListViewItem(dataArr);

                    listView.Items.Add(listViewItem);
                }
            }
        }

        private void insertData(object sender, EventArgs e)
        {
            if (textBox.Text.Equals(""))
            {
                MessageBox.Show("내용을 정확히 입력하시기 바랍니다.");
            } 
            else
            {
                DateTime now = DateTime.Now;
                String date = now.ToString("yyyy-MM-dd tt HH:mm:ss");
                String content = textBox.Text.ToString();

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    String sql = "INSERT INTO diary VALUES(" + "'" + date + "'" + "," + "'" + content + "'" + "," + "'" + id + "'" + ");";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("정상적으로 글 작성을 수행하였습니다.");
                    textBox.Text = "";

                    getAllData();
                }
            }
        }

        private void refreshData(object sender, EventArgs e)
        {
            MessageBox.Show("정상적으로 새로고침을 수행하였습니다.");
            getAllData();
        }
    }
}
