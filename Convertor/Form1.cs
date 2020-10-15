using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {
                if (!((e.KeyChar.ToString() == ",") && (textBox1.Text.IndexOf(",") == -1)))
                    e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {
                if (!((e.KeyChar.ToString() == ",") && (textBox2.Text.IndexOf(",") == -1)))
                    e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double k;// курс(отнощение рубля к доллару)
            double usd; //цена в долларах
            double rub;//цена в рублях
            label4.Text = "";

            try
            {
                usd = Convert.ToDouble(textBox1.Text);
                k= Convert.ToDouble(textBox2.Text);
                rub = usd * k;

                label4.Text = usd.ToString("N") + "USD=" + rub.ToString("C");
            }
            catch (Exception)
            {

                if((textBox1.Text=="")||(textBox2.Text==""))
                {
                    MessageBox.Show("Ошибка исходных данныхю.\n" +
                        "Необходимо ввести данные в оба поля.",
                        "Конвертор", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else MessageBox.Show("Ошибка исходных данныхю.\n" +
                        "Необходимо ввести данных в одном из полей.",
                        "Конвертор", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
