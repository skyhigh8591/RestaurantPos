using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantPos
{
    public partial class Form2 : Form
    {
        private int totalPrice = 0;
        private int discount = 0;
        private int time = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labelOrderAll.Text =
                "牛肉漢堡 " + Program.beefBurger / Program.beefBurgerPrice + " 份 " + " $ " + Program.beefBurger + "\n" +
                "雞腿堡 " + Program.chickenBurger / Program.chickenBurgerPrice + " 份" + " $ " + Program.chickenBurger + "\n" +
                "和風披薩 " + Program.japanesePizza / Program.japanesePizzaPrice + " 份" + " $ " + Program.japanesePizza + "\n" +
                "夏威夷披薩 " + Program.hawaiianPizza / Program.hawaiianPizzaPrice + " 份" + " $ " + Program.hawaiianPizza + "\n";
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            totalPrice = Program.beefBurger + Program.chickenBurger + Program.japanesePizza + Program.hawaiianPizza;
            discount = Convert.ToInt32(totalPrice * 0.8);

            if (radioButtonCash.Checked)
            {
                labelTotalPrice.Text = "總價 " + totalPrice + " $";
            }

            if (radioButtonCreditCard.Checked)
            {
                labelTotalPrice.Text = "總價 " + totalPrice + " $" + "\n" +
                    "折扣後價格 " + discount + " $";
            }

            timerTimeOut.Start();

        }

        private void timerTimeOut_Tick(object sender, EventArgs e)
        {
            time += 1;
            if (time == 20)
            {
                labelTotalPrice.Text = "超過時間為點餐" + "\n" + "請重新點餐";
            }

            if (time > 25)
            {
                this.Close();
            }
        }
    }
}
