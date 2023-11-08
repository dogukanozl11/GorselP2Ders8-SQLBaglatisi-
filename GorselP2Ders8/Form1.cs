using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselP2Ders8
{//from 1 de textbox a girilmiş olan değeri butona basınca form2 de lable da yazdıran kodu yazınız.
    //ÖDEV :  maaş zam oranı ve prim girilen personelin zam miktarını ve yeni maaşını butona basınca hesaplayan kodu yazın
    //ÖDEV2 : VKİ hesaplama uygulaması.  IK=(boy-100+yas/10)*ck ERkekler için = 0,9 kadınlar için 0,8.
    
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string deger;
        public void button1_Click(object sender, EventArgs e)
        {
            string deger = textBox1.Text;
            Form2 frm = new Form2();
            frm.ShowDialog();

        }
    }
}
