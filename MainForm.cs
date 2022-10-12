using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace step1
{
    public partial class MainForm : System.Windows.Forms.Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        Coin coin;

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.dgvResult.Font = new Font("Tahoma", 9, FontStyle.Regular);

            dgvResult.Columns.Add("colname", "음료 이름");
            dgvResult.Columns.Add("colprice", "가격");
            dgvResult.Columns.Add("colcolor", "색상");
            
        }

        private void btnCharge_Click(object sender, EventArgs e)
        {
            this.coin = new Coin();

            coin.FormClosed += new FormClosedEventHandler(coin_FormClosed);
            coin.SetPrice(Convert.ToInt32(txRemainder.Text));
            coin.Show();

            btnSelect1.Enabled = true;
            btnSelect2.Enabled = true;
            btnSelect3.Enabled = true;
        }

        private void coin_FormClosed(object sender, FormClosedEventArgs e)
        {
            txRemainder.Text = (Convert.ToInt32(txRemainder.Text) + coin.GetPrice()).ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txRemainder.Clear();
            txRemainder.Text = "0";
        }

        private void btnSelect(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Name == "btnSelect1")
            {
                if (Convert.ToInt32(txtPrice1.Text) > Convert.ToInt32(txRemainder.Text))
                {
                    btnSelect1.Enabled = false;
                    MessageBox.Show("금액이 부족합니다.");
                }
                else
                {
                    dgvResult.Rows.Add(tbName1.Text, txtPrice1.Text, tbColor1.Text);
                    txRemainder.Text = (Convert.ToInt32(txRemainder.Text) - Convert.ToInt32(txtPrice1.Text)).ToString();
                }
            }
            else if (btn.Name == "btnSelect2")
            {
                if (Convert.ToInt32(txtPrice2.Text) > Convert.ToInt32(txRemainder.Text))
                {
                    btnSelect2.Enabled = false;
                    MessageBox.Show("금액이 부족합니다.");

                }
                else
                {
                    dgvResult.Rows.Add(tbName2.Text, txtPrice2.Text, tbColor2.Text);
                    txRemainder.Text = (Convert.ToInt32(txRemainder.Text) - Convert.ToInt32(txtPrice2.Text)).ToString();
                }
            }
            else if (btn.Name == "btnSelect3")
            {
                if (Convert.ToInt32(txtPrice3.Text) > Convert.ToInt32(txRemainder.Text))
                {
                    btnSelect3.Enabled = false;
                    MessageBox.Show("금액이 부족합니다.");

                }
                else
                {
                    dgvResult.Rows.Add(tbName3.Text, txtPrice3.Text, tbColor3.Text);
                    txRemainder.Text = (Convert.ToInt32(txRemainder.Text) - Convert.ToInt32(txtPrice3.Text)).ToString();

                }
            }


        }

       
    }
}
