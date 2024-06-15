using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace test
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        

        private void start_Click(object sender, EventArgs e)
        {
            string number = num.Text;
            string Name = name.Text;
;
            string message = "메세지";

            if (number.Length == 0 && Name.Length == 0)
            {
                MessageBox.Show("학번 또는 이름을 적어주세요.", message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("시작합니다", message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                quizPage quizpage = new quizPage();
                quizpage.ShowDialog();
                this.Close();
            }
        }


    }
}
