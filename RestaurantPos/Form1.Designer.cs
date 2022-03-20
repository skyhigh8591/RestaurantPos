namespace RestaurantPos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxBeefBurger = new System.Windows.Forms.CheckBox();
            this.checkBoxChickenBurger = new System.Windows.Forms.CheckBox();
            this.checkBoxJapanesePizza = new System.Windows.Forms.CheckBox();
            this.checkBoxHawaiianPizza = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxBeefBurger = new System.Windows.Forms.ComboBox();
            this.comboBoxChickenBurger = new System.Windows.Forms.ComboBox();
            this.comboBoxJapanesePizza = new System.Windows.Forms.ComboBox();
            this.comboBoxHawaiianPizza = new System.Windows.Forms.ComboBox();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxBeefBurger
            // 
            this.checkBoxBeefBurger.AutoSize = true;
            this.checkBoxBeefBurger.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxBeefBurger.Location = new System.Drawing.Point(54, 51);
            this.checkBoxBeefBurger.Name = "checkBoxBeefBurger";
            this.checkBoxBeefBurger.Size = new System.Drawing.Size(161, 25);
            this.checkBoxBeefBurger.TabIndex = 0;
            this.checkBoxBeefBurger.Text = "牛肉漢堡 $75";
            this.checkBoxBeefBurger.UseVisualStyleBackColor = true;
            this.checkBoxBeefBurger.CheckedChanged += new System.EventHandler(this.checkBoxBeefBurger_CheckedChanged);
            // 
            // checkBoxChickenBurger
            // 
            this.checkBoxChickenBurger.AutoSize = true;
            this.checkBoxChickenBurger.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxChickenBurger.Location = new System.Drawing.Point(54, 124);
            this.checkBoxChickenBurger.Name = "checkBoxChickenBurger";
            this.checkBoxChickenBurger.Size = new System.Drawing.Size(139, 25);
            this.checkBoxChickenBurger.TabIndex = 1;
            this.checkBoxChickenBurger.Text = "雞腿堡 $70";
            this.checkBoxChickenBurger.UseVisualStyleBackColor = true;
            this.checkBoxChickenBurger.CheckedChanged += new System.EventHandler(this.checkBoxChickenBurger_CheckedChanged);
            // 
            // checkBoxJapanesePizza
            // 
            this.checkBoxJapanesePizza.AutoSize = true;
            this.checkBoxJapanesePizza.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxJapanesePizza.Location = new System.Drawing.Point(54, 197);
            this.checkBoxJapanesePizza.Name = "checkBoxJapanesePizza";
            this.checkBoxJapanesePizza.Size = new System.Drawing.Size(172, 25);
            this.checkBoxJapanesePizza.TabIndex = 2;
            this.checkBoxJapanesePizza.Text = "和風披薩 $300";
            this.checkBoxJapanesePizza.UseVisualStyleBackColor = true;
            this.checkBoxJapanesePizza.CheckedChanged += new System.EventHandler(this.checkBoxJapanesePizza_CheckedChanged);
            // 
            // checkBoxHawaiianPizza
            // 
            this.checkBoxHawaiianPizza.AutoSize = true;
            this.checkBoxHawaiianPizza.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxHawaiianPizza.Location = new System.Drawing.Point(54, 270);
            this.checkBoxHawaiianPizza.Name = "checkBoxHawaiianPizza";
            this.checkBoxHawaiianPizza.Size = new System.Drawing.Size(194, 25);
            this.checkBoxHawaiianPizza.TabIndex = 3;
            this.checkBoxHawaiianPizza.Text = "夏威夷披薩 $250";
            this.checkBoxHawaiianPizza.UseVisualStyleBackColor = true;
            this.checkBoxHawaiianPizza.CheckedChanged += new System.EventHandler(this.checkBoxHawaiianPizza_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(325, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "數量:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(325, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "數量:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(325, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "數量:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(325, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "數量:";
            // 
            // comboBoxBeefBurger
            // 
            this.comboBoxBeefBurger.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxBeefBurger.FormattingEnabled = true;
            this.comboBoxBeefBurger.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxBeefBurger.Location = new System.Drawing.Point(441, 52);
            this.comboBoxBeefBurger.Name = "comboBoxBeefBurger";
            this.comboBoxBeefBurger.Size = new System.Drawing.Size(121, 29);
            this.comboBoxBeefBurger.TabIndex = 8;
            // 
            // comboBoxChickenBurger
            // 
            this.comboBoxChickenBurger.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxChickenBurger.FormattingEnabled = true;
            this.comboBoxChickenBurger.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxChickenBurger.Location = new System.Drawing.Point(441, 123);
            this.comboBoxChickenBurger.Name = "comboBoxChickenBurger";
            this.comboBoxChickenBurger.Size = new System.Drawing.Size(121, 29);
            this.comboBoxChickenBurger.TabIndex = 9;
            // 
            // comboBoxJapanesePizza
            // 
            this.comboBoxJapanesePizza.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxJapanesePizza.FormattingEnabled = true;
            this.comboBoxJapanesePizza.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxJapanesePizza.Location = new System.Drawing.Point(441, 194);
            this.comboBoxJapanesePizza.Name = "comboBoxJapanesePizza";
            this.comboBoxJapanesePizza.Size = new System.Drawing.Size(121, 29);
            this.comboBoxJapanesePizza.TabIndex = 10;
            // 
            // comboBoxHawaiianPizza
            // 
            this.comboBoxHawaiianPizza.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxHawaiianPizza.FormattingEnabled = true;
            this.comboBoxHawaiianPizza.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxHawaiianPizza.Location = new System.Drawing.Point(441, 265);
            this.comboBoxHawaiianPizza.Name = "comboBoxHawaiianPizza";
            this.comboBoxHawaiianPizza.Size = new System.Drawing.Size(121, 29);
            this.comboBoxHawaiianPizza.TabIndex = 11;
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCheckout.Location = new System.Drawing.Point(184, 337);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(235, 69);
            this.buttonCheckout.TabIndex = 12;
            this.buttonCheckout.Text = "結帳";
            this.buttonCheckout.UseVisualStyleBackColor = true;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 433);
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.comboBoxHawaiianPizza);
            this.Controls.Add(this.comboBoxJapanesePizza);
            this.Controls.Add(this.comboBoxChickenBurger);
            this.Controls.Add(this.comboBoxBeefBurger);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxHawaiianPizza);
            this.Controls.Add(this.checkBoxJapanesePizza);
            this.Controls.Add(this.checkBoxChickenBurger);
            this.Controls.Add(this.checkBoxBeefBurger);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox checkBoxBeefBurger;
        private CheckBox checkBoxChickenBurger;
        private CheckBox checkBoxJapanesePizza;
        private CheckBox checkBoxHawaiianPizza;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxBeefBurger;
        private ComboBox comboBoxChickenBurger;
        private ComboBox comboBoxJapanesePizza;
        private ComboBox comboBoxHawaiianPizza;
        private Button buttonCheckout;
    }
}