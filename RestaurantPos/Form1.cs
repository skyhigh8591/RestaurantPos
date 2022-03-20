namespace RestaurantPos
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {

            if (checkBoxBeefBurger.Checked)
            {
                Program.beefBurger = Program.beefBurgerPrice * Convert.ToInt32(comboBoxBeefBurger.Text);
            }
            if (checkBoxChickenBurger.Checked)
            {
                Program.chickenBurger = Program.chickenBurgerPrice * Convert.ToInt32(comboBoxChickenBurger.Text);
            }
            if (checkBoxJapanesePizza.Checked)
            {
                Program.japanesePizza = Program.japanesePizzaPrice * Convert.ToInt32(comboBoxJapanesePizza.Text);
            }
            if (checkBoxHawaiianPizza.Checked)
            {
                Program.hawaiianPizza = Program.hawaiianPizzaPrice * Convert.ToInt32(comboBoxHawaiianPizza.Text);
            }

            if (
               (checkBoxBeefBurger.Checked && !(comboBoxBeefBurger.Items.IndexOf(comboBoxBeefBurger.Text) < 0)) ||
               (checkBoxChickenBurger.Checked && !(comboBoxChickenBurger.Items.IndexOf(comboBoxChickenBurger.Text) < 0)) ||
               (checkBoxHawaiianPizza.Checked && !(comboBoxJapanesePizza.Items.IndexOf(comboBoxJapanesePizza.Text) < 0)) ||
               (checkBoxHawaiianPizza.Checked && !(comboBoxHawaiianPizza.Items.IndexOf(comboBoxHawaiianPizza.Text) < 0))
                )
            {
                Form2 form2 = new Form2();
                form2.Show();
            }

        }

        private void checkBoxBeefBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBeefBurger.Checked)
            {
                comboBoxBeefBurger.SelectedIndex = 0;
            }
            else
            {
                comboBoxBeefBurger.Text = null;
            }
        }

        private void checkBoxChickenBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxChickenBurger.Checked)
            {
                comboBoxChickenBurger.SelectedIndex = 0;
            }
            else
            {
                comboBoxChickenBurger.Text = null;
            }
        }

        private void checkBoxJapanesePizza_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxJapanesePizza.Checked)
            {
                comboBoxJapanesePizza.SelectedIndex = 0;
            }
            else
            {
                comboBoxJapanesePizza.Text = null;
            }
        }

        private void checkBoxHawaiianPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHawaiianPizza.Checked)
            {
                comboBoxHawaiianPizza.SelectedIndex = 0;
            }
            else
            {
                comboBoxHawaiianPizza.Text = null;
            }
        }
    }
}