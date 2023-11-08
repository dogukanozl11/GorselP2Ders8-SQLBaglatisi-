using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselP2Ders8
{
    public partial class Form2 : Form
    {
        public static string sehir;
        sqlbaglantisi bgl = new sqlbaglantisi();
        public Form2()
        {
            InitializeComponent();
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.deger;

            //SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=il_ilceler;Integrated Security=True");
            string sql = "select* from sehirler";
            SqlDataAdapter da = new SqlDataAdapter(sql, bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "sehir";  //sehir görünsün
            comboBox1.ValueMember = "s_id";  //değer olarak idsine bak.
            bgl.baglanti().Close();



        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                DataRowView row = (DataRowView)comboBox1.SelectedItem;
                int sehirID = Convert.ToInt32(row["s_id"]);

                //int sehirID = Convert.ToInt32(comboBox1.SelectedValue);
                //SqlConnection bag = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=il_ilceler;Integrated Security=True");

                string sqlilce = "SELECT * FROM ilceler WHERE s_id = @sehirID";
                SqlDataAdapter da = new SqlDataAdapter(sqlilce, bgl.baglanti());
                da.SelectCommand.Parameters.AddWithValue("@sehirID", sehirID);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "ilce";
                comboBox2.ValueMember = "i_id";
                bgl.baglanti().Close();
            }
        }
    }
}
