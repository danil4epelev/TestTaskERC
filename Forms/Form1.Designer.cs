
namespace TestTaskERC
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_Start = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_CreateNewUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_Start
            // 
            this.b_Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Start.Location = new System.Drawing.Point(27, 168);
            this.b_Start.Name = "b_Start";
            this.b_Start.Size = new System.Drawing.Size(150, 48);
            this.b_Start.TabIndex = 0;
            this.b_Start.Text = "Поиск";
            this.b_Start.UseVisualStyleBackColor = true;
            this.b_Start.Click += new System.EventHandler(this.b_Start_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idTextBox.Location = new System.Drawing.Point(211, 70);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 38);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите ИН:";
            // 
            // b_CreateNewUser
            // 
            this.b_CreateNewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_CreateNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_CreateNewUser.Location = new System.Drawing.Point(261, 168);
            this.b_CreateNewUser.Name = "b_CreateNewUser";
            this.b_CreateNewUser.Size = new System.Drawing.Size(150, 48);
            this.b_CreateNewUser.TabIndex = 3;
            this.b_CreateNewUser.Text = "Создать новый";
            this.b_CreateNewUser.UseVisualStyleBackColor = true;
            this.b_CreateNewUser.Click += new System.EventHandler(this.b_CreateNewUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.b_CreateNewUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.b_Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Start;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_CreateNewUser;
    }
}

