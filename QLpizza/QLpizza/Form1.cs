using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLpizza
{
    public partial class Form1 : Form
    {
        private SqlDependency dep;
        private SqlCommand comm;

        public Form1()
        {
            InitializeComponent();
            SqlDependency.Start(SqlUtils.Conn.ConnectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegisterChangeEvent();
            //dep.AddCommandDependency(comm);
            
            dataGridView1.DataSource = SqlUtils.Query("SELECT * FROM THONGBAO");
        }

        private void RegisterChangeEvent()
        {
            comm = new SqlCommand("SELECT MaThongBao FROM dbo.THONGBAO", SqlUtils.Open());
            dep = new SqlDependency();
            dep.OnChange += A_OnChange;
            dep.AddCommandDependency(comm);
            var dta = new SqlDataAdapter(comm);
            var dt = new DataTable();
            dta.Fill(dt);
        }

        private void A_OnChange(object sender, SqlNotificationEventArgs e)
        {
            RegisterChangeEvent();
            Console.WriteLine("THONGBAO");
            /*dep.OnChange -= A_OnChange;
            dep.OnChange += A_OnChange;*/
            /*dep = new SqlDependency();*/
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SqlDependency.Stop(SqlUtils.Conn.ConnectionString);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string[] cacMaThongBao =
                SqlUtils.Query("SELECT MaThongBao FROM THONGBAO").Select()
                    .Select(v => v.Field<string>("MaThongBao"))
                    .ToArray();
            SqlUtils.ExecuteNonQuery(
                "INSERT INTO THONGBAO VALUES (@MaThongBao, @MaND, @TieuDe, @NoiDung, DEFAULT, DEFAULT, @MaMucThongBao)",
                new Dictionary<string, object>
                {
                    ["MaThongBao"] = await MaGenerator.MaCheBien(),
                    ["MaND"] = "406TK",
                    ["TieuDe"] = "Chế biến",
                    ["NoiDung"] = textBox1.Text,
                    ["MaMucThongBao"] = 0
                });
        }
    }
}
