namespace MiniSimCity
{
    partial class MiniSimCity
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
            this.comBoxBuildings = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.tmrCurrentDate = new System.Windows.Forms.Timer(this.components);
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblPopulation = new System.Windows.Forms.Label();
            this.lblEconomy = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblDateText = new System.Windows.Forms.Label();
            this.lblMoneyText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEconomyText = new System.Windows.Forms.Label();
            this.lblPopulationText = new System.Windows.Forms.Label();
            this.lblScoreText = new System.Windows.Forms.Label();
            this.lblPromptUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comBoxBuildings
            // 
            this.comBoxBuildings.BackColor = System.Drawing.Color.White;
            this.comBoxBuildings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxBuildings.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxBuildings.ForeColor = System.Drawing.Color.LawnGreen;
            this.comBoxBuildings.FormattingEnabled = true;
            this.comBoxBuildings.Location = new System.Drawing.Point(804, 107);
            this.comBoxBuildings.Name = "comBoxBuildings";
            this.comBoxBuildings.Size = new System.Drawing.Size(184, 27);
            this.comBoxBuildings.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblDate.Location = new System.Drawing.Point(800, 41);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(217, 32);
            this.lblDate.TabIndex = 5;
            // 
            // tmrCurrentDate
            // 
            this.tmrCurrentDate.Enabled = true;
            this.tmrCurrentDate.Interval = 666;
            this.tmrCurrentDate.Tick += new System.EventHandler(this.tmrCurrentDate_Tick);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblMoney.Location = new System.Drawing.Point(801, 170);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(0, 19);
            this.lblMoney.TabIndex = 6;
            // 
            // lblPopulation
            // 
            this.lblPopulation.AutoSize = true;
            this.lblPopulation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopulation.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblPopulation.Location = new System.Drawing.Point(801, 289);
            this.lblPopulation.Name = "lblPopulation";
            this.lblPopulation.Size = new System.Drawing.Size(0, 19);
            this.lblPopulation.TabIndex = 7;
            // 
            // lblEconomy
            // 
            this.lblEconomy.AutoSize = true;
            this.lblEconomy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEconomy.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblEconomy.Location = new System.Drawing.Point(801, 230);
            this.lblEconomy.Name = "lblEconomy";
            this.lblEconomy.Size = new System.Drawing.Size(0, 19);
            this.lblEconomy.TabIndex = 8;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblScore.Location = new System.Drawing.Point(801, 639);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 29);
            this.lblScore.TabIndex = 9;
            // 
            // lblDateText
            // 
            this.lblDateText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateText.Location = new System.Drawing.Point(800, 15);
            this.lblDateText.Name = "lblDateText";
            this.lblDateText.Size = new System.Drawing.Size(140, 26);
            this.lblDateText.TabIndex = 10;
            this.lblDateText.Text = "Date:";
            // 
            // lblMoneyText
            // 
            this.lblMoneyText.AutoSize = true;
            this.lblMoneyText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyText.Location = new System.Drawing.Point(800, 151);
            this.lblMoneyText.Name = "lblMoneyText";
            this.lblMoneyText.Size = new System.Drawing.Size(68, 19);
            this.lblMoneyText.TabIndex = 11;
            this.lblMoneyText.Text = "Money:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(800, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Build:";
            // 
            // lblEconomyText
            // 
            this.lblEconomyText.AutoSize = true;
            this.lblEconomyText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEconomyText.Location = new System.Drawing.Point(800, 211);
            this.lblEconomyText.Name = "lblEconomyText";
            this.lblEconomyText.Size = new System.Drawing.Size(87, 19);
            this.lblEconomyText.TabIndex = 13;
            this.lblEconomyText.Text = "Economy:";
            // 
            // lblPopulationText
            // 
            this.lblPopulationText.AutoSize = true;
            this.lblPopulationText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopulationText.Location = new System.Drawing.Point(800, 270);
            this.lblPopulationText.Name = "lblPopulationText";
            this.lblPopulationText.Size = new System.Drawing.Size(103, 19);
            this.lblPopulationText.TabIndex = 14;
            this.lblPopulationText.Text = "Population:";
            // 
            // lblScoreText
            // 
            this.lblScoreText.AutoSize = true;
            this.lblScoreText.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreText.Location = new System.Drawing.Point(801, 607);
            this.lblScoreText.Name = "lblScoreText";
            this.lblScoreText.Size = new System.Drawing.Size(70, 23);
            this.lblScoreText.TabIndex = 15;
            this.lblScoreText.Text = "Score:";
            // 
            // lblPromptUser
            // 
            this.lblPromptUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromptUser.ForeColor = System.Drawing.Color.Red;
            this.lblPromptUser.Location = new System.Drawing.Point(805, 329);
            this.lblPromptUser.Name = "lblPromptUser";
            this.lblPromptUser.Size = new System.Drawing.Size(183, 263);
            this.lblPromptUser.TabIndex = 16;
            // 
            // MiniSimCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 713);
            this.Controls.Add(this.lblPromptUser);
            this.Controls.Add(this.lblScoreText);
            this.Controls.Add(this.lblPopulationText);
            this.Controls.Add(this.lblEconomyText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMoneyText);
            this.Controls.Add(this.lblDateText);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblEconomy);
            this.Controls.Add(this.lblPopulation);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.comBoxBuildings);
            this.Name = "MiniSimCity";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comBoxBuildings;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer tmrCurrentDate;
        public System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblPopulation;
        private System.Windows.Forms.Label lblEconomy;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblDateText;
        private System.Windows.Forms.Label lblMoneyText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEconomyText;
        private System.Windows.Forms.Label lblPopulationText;
        private System.Windows.Forms.Label lblScoreText;
        private System.Windows.Forms.Label lblPromptUser;

    }
}

