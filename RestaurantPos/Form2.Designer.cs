namespace RestaurantPos
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelOrderAll = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.radioButtonCash = new System.Windows.Forms.RadioButton();
            this.radioButtonCreditCard = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.timerTimeOut = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelOrderAll
            // 
            this.labelOrderAll.AutoSize = true;
            this.labelOrderAll.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOrderAll.Location = new System.Drawing.Point(60, 30);
            this.labelOrderAll.Name = "labelOrderAll";
            this.labelOrderAll.Size = new System.Drawing.Size(98, 21);
            this.labelOrderAll.TabIndex = 0;
            this.labelOrderAll.Text = "點餐清單";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotalPrice.Location = new System.Drawing.Point(252, 308);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(54, 21);
            this.labelTotalPrice.TabIndex = 1;
            this.labelTotalPrice.Text = "總價";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirm.Location = new System.Drawing.Point(60, 308);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(117, 37);
            this.buttonConfirm.TabIndex = 2;
            this.buttonConfirm.Text = "確認";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // radioButtonCash
            // 
            this.radioButtonCash.AutoSize = true;
            this.radioButtonCash.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonCash.Location = new System.Drawing.Point(60, 249);
            this.radioButtonCash.Name = "radioButtonCash";
            this.radioButtonCash.Size = new System.Drawing.Size(72, 25);
            this.radioButtonCash.TabIndex = 3;
            this.radioButtonCash.TabStop = true;
            this.radioButtonCash.Text = "現金";
            this.radioButtonCash.UseVisualStyleBackColor = true;
            // 
            // radioButtonCreditCard
            // 
            this.radioButtonCreditCard.AutoSize = true;
            this.radioButtonCreditCard.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonCreditCard.Location = new System.Drawing.Point(252, 249);
            this.radioButtonCreditCard.Name = "radioButtonCreditCard";
            this.radioButtonCreditCard.Size = new System.Drawing.Size(94, 25);
            this.radioButtonCreditCard.TabIndex = 4;
            this.radioButtonCreditCard.TabStop = true;
            this.radioButtonCreditCard.Text = "信用卡";
            this.radioButtonCreditCard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "刷卡享8折優惠";
            // 
            // timerTimeOut
            // 
            this.timerTimeOut.Interval = 1000;
            this.timerTimeOut.Tick += new System.EventHandler(this.timerTimeOut_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonCreditCard);
            this.Controls.Add(this.radioButtonCash);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.labelOrderAll);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelOrderAll;
        private Label labelTotalPrice;
        private Button buttonConfirm;
        private RadioButton radioButtonCash;
        private RadioButton radioButtonCreditCard;
        private Label label1;
        private System.Windows.Forms.Timer timerTimeOut;
    }
}