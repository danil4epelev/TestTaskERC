
namespace TestTaskERC
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
            this.check_HotWater = new System.Windows.Forms.CheckBox();
            this.check_ColdWater = new System.Windows.Forms.CheckBox();
            this.check_Ecect = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_Calculate = new System.Windows.Forms.Button();
            this.tb_HotWater = new System.Windows.Forms.TextBox();
            this.tb_ColdWater = new System.Windows.Forms.TextBox();
            this.tb_Elect = new System.Windows.Forms.TextBox();
            this.tb_CountPeople = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_IdUSer = new System.Windows.Forms.Label();
            this.label_Day = new System.Windows.Forms.Label();
            this.label_Night = new System.Windows.Forms.Label();
            this.tb_ElectNight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // check_HotWater
            // 
            this.check_HotWater.AutoSize = true;
            this.check_HotWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check_HotWater.Location = new System.Drawing.Point(41, 151);
            this.check_HotWater.Name = "check_HotWater";
            this.check_HotWater.Size = new System.Drawing.Size(151, 28);
            this.check_HotWater.TabIndex = 0;
            this.check_HotWater.Text = "Горячая вода";
            this.check_HotWater.UseVisualStyleBackColor = true;
            this.check_HotWater.CheckedChanged += new System.EventHandler(this.check_HotWater_CheckedChanged);
            // 
            // check_ColdWater
            // 
            this.check_ColdWater.AutoSize = true;
            this.check_ColdWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check_ColdWater.Location = new System.Drawing.Point(41, 220);
            this.check_ColdWater.Name = "check_ColdWater";
            this.check_ColdWater.Size = new System.Drawing.Size(165, 28);
            this.check_ColdWater.TabIndex = 1;
            this.check_ColdWater.Text = "Холодная вода";
            this.check_ColdWater.UseVisualStyleBackColor = true;
            this.check_ColdWater.CheckedChanged += new System.EventHandler(this.check_ColdWater_CheckedChanged);
            // 
            // check_Ecect
            // 
            this.check_Ecect.AutoSize = true;
            this.check_Ecect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check_Ecect.Location = new System.Drawing.Point(41, 287);
            this.check_Ecect.Name = "check_Ecect";
            this.check_Ecect.Size = new System.Drawing.Size(177, 28);
            this.check_Ecect.TabIndex = 2;
            this.check_Ecect.Text = "Электроэнергия";
            this.check_Ecect.UseVisualStyleBackColor = true;
            this.check_Ecect.CheckedChanged += new System.EventHandler(this.check_Ecect_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Укажите какие приборы учёта имеются";
            // 
            // b_Calculate
            // 
            this.b_Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Calculate.Location = new System.Drawing.Point(350, 474);
            this.b_Calculate.Name = "b_Calculate";
            this.b_Calculate.Size = new System.Drawing.Size(163, 48);
            this.b_Calculate.TabIndex = 4;
            this.b_Calculate.Text = "Рассчёт";
            this.b_Calculate.UseVisualStyleBackColor = true;
            this.b_Calculate.Click += new System.EventHandler(this.b_Calculate_Click);
            // 
            // tb_HotWater
            // 
            this.tb_HotWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_HotWater.Location = new System.Drawing.Point(566, 149);
            this.tb_HotWater.Name = "tb_HotWater";
            this.tb_HotWater.Size = new System.Drawing.Size(240, 29);
            this.tb_HotWater.TabIndex = 5;
            this.tb_HotWater.Tag = "Hide";
            this.tb_HotWater.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            this.tb_HotWater.Leave += new System.EventHandler(this.tb_HotWater_Leave);
            // 
            // tb_ColdWater
            // 
            this.tb_ColdWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_ColdWater.Location = new System.Drawing.Point(566, 218);
            this.tb_ColdWater.Name = "tb_ColdWater";
            this.tb_ColdWater.Size = new System.Drawing.Size(240, 29);
            this.tb_ColdWater.TabIndex = 6;
            this.tb_ColdWater.Tag = "Hide";
            this.tb_ColdWater.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            this.tb_ColdWater.Leave += new System.EventHandler(this.tb_ColdWater_Leave);
            // 
            // tb_Elect
            // 
            this.tb_Elect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Elect.Location = new System.Drawing.Point(566, 285);
            this.tb_Elect.Name = "tb_Elect";
            this.tb_Elect.Size = new System.Drawing.Size(240, 29);
            this.tb_Elect.TabIndex = 7;
            this.tb_Elect.Tag = "Hide";
            this.tb_Elect.TextChanged += new System.EventHandler(this.tb_Elect_TextChanged);
            this.tb_Elect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // tb_CountPeople
            // 
            this.tb_CountPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_CountPeople.Location = new System.Drawing.Point(566, 391);
            this.tb_CountPeople.Name = "tb_CountPeople";
            this.tb_CountPeople.Size = new System.Drawing.Size(240, 29);
            this.tb_CountPeople.TabIndex = 8;
            this.tb_CountPeople.Tag = "";
            this.tb_CountPeople.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_CountPeople_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(37, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Сколько человек проживает на площади:";
            // 
            // label_IdUSer
            // 
            this.label_IdUSer.AutoSize = true;
            this.label_IdUSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_IdUSer.Location = new System.Drawing.Point(35, 9);
            this.label_IdUSer.Name = "label_IdUSer";
            this.label_IdUSer.Size = new System.Drawing.Size(131, 31);
            this.label_IdUSer.TabIndex = 10;
            this.label_IdUSer.Text = "Ваш ИН: ";
            // 
            // label_Day
            // 
            this.label_Day.AutoSize = true;
            this.label_Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Day.Location = new System.Drawing.Point(472, 288);
            this.label_Day.Name = "label_Day";
            this.label_Day.Size = new System.Drawing.Size(62, 24);
            this.label_Day.TabIndex = 11;
            this.label_Day.Tag = "Hide";
            this.label_Day.Text = "День:";
            // 
            // label_Night
            // 
            this.label_Night.AutoSize = true;
            this.label_Night.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Night.Location = new System.Drawing.Point(472, 339);
            this.label_Night.Name = "label_Night";
            this.label_Night.Size = new System.Drawing.Size(60, 24);
            this.label_Night.TabIndex = 13;
            this.label_Night.Tag = "Hide";
            this.label_Night.Text = "Ночь:";
            // 
            // tb_ElectNight
            // 
            this.tb_ElectNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_ElectNight.Location = new System.Drawing.Point(566, 336);
            this.tb_ElectNight.Name = "tb_ElectNight";
            this.tb_ElectNight.Size = new System.Drawing.Size(240, 29);
            this.tb_ElectNight.TabIndex = 12;
            this.tb_ElectNight.Tag = "Hide";
            this.tb_ElectNight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            this.tb_ElectNight.Leave += new System.EventHandler(this.tb_ElectNight_Leave);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(851, 534);
            this.Controls.Add(this.label_Night);
            this.Controls.Add(this.tb_ElectNight);
            this.Controls.Add(this.label_Day);
            this.Controls.Add(this.label_IdUSer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_CountPeople);
            this.Controls.Add(this.tb_Elect);
            this.Controls.Add(this.tb_ColdWater);
            this.Controls.Add(this.tb_HotWater);
            this.Controls.Add(this.b_Calculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check_Ecect);
            this.Controls.Add(this.check_ColdWater);
            this.Controls.Add(this.check_HotWater);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox check_HotWater;
        private System.Windows.Forms.CheckBox check_ColdWater;
        private System.Windows.Forms.CheckBox check_Ecect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_Calculate;
        private System.Windows.Forms.TextBox tb_HotWater;
        private System.Windows.Forms.TextBox tb_ColdWater;
        private System.Windows.Forms.TextBox tb_Elect;
        private System.Windows.Forms.TextBox tb_CountPeople;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_IdUSer;
        private System.Windows.Forms.Label label_Day;
        private System.Windows.Forms.Label label_Night;
        private System.Windows.Forms.TextBox tb_ElectNight;
    }
}