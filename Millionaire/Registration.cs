using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Millionaire
{
    public partial class Registration : Form
    {
        public string PlayerName { get; set; }
        public int FireproofIndex { get; set; }

        public Registration()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "" || ListLevelFireproof.SelectedIndex == -1)
            {
                MessageBox.Show("Для начала введите имя и выберите несгораемую сумму");
                return;
            }
            if (!NameTextBox.Text.All(char.IsLetterOrDigit))
            {
                MessageBox.Show("В имени игрока может состоять только из букв и цифр");
                return;
            }
            PlayerName = NameTextBox.Text;
            FireproofIndex = 15 - ListLevelFireproof.SelectedIndex;
            Close();
        }
    }
}
