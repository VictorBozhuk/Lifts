
namespace Lifts
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TimerPriority = new System.Windows.Forms.Timer(this.components);
            this.OutFocus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxCountPeople = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.richTextBox1.Location = new System.Drawing.Point(1223, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(207, 691);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // TimerPriority
            // 
            this.TimerPriority.Tick += new System.EventHandler(this.TimerPriority_Tick);
            // 
            // OutFocus
            // 
            this.OutFocus.AutoSize = true;
            this.OutFocus.Location = new System.Drawing.Point(4, 4);
            this.OutFocus.Name = "OutFocus";
            this.OutFocus.Size = new System.Drawing.Size(0, 13);
            this.OutFocus.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(809, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Ліфт в підвал";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RepairClick);
            // 
            // textBoxCountPeople
            // 
            this.textBoxCountPeople.Location = new System.Drawing.Point(809, 277);
            this.textBoxCountPeople.Name = "textBoxCountPeople";
            this.textBoxCountPeople.Size = new System.Drawing.Size(128, 20);
            this.textBoxCountPeople.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(809, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Зламати";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(809, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Полагодити";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.richTextBox2.Location = new System.Drawing.Point(1016, 0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(207, 691);
            this.richTextBox2.TabIndex = 20;
            this.richTextBox2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1430, 691);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxCountPeople);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OutFocus);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Ліфти";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer TimerPriority;
        private System.Windows.Forms.Label OutFocus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxCountPeople;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

