namespace CrossoutStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textScrap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textAccumulators = new System.Windows.Forms.TextBox();
            this.textElectronics = new System.Windows.Forms.TextBox();
            this.textWires = new System.Windows.Forms.TextBox();
            this.textPlastic = new System.Windows.Forms.TextBox();
            this.textCopper = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonParsePrice = new System.Windows.Forms.Button();
            this.checkBoxUnfinished = new System.Windows.Forms.CheckBox();
            this.checkBoxfreePlayFinish = new System.Windows.Forms.CheckBox();
            this.checkBoxVictory = new System.Windows.Forms.CheckBox();
            this.checkBoxDefeat = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Battle Stats";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(791, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(649, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Металлолом";
            // 
            // textScrap
            // 
            this.textScrap.Location = new System.Drawing.Point(758, 433);
            this.textScrap.Name = "textScrap";
            this.textScrap.Size = new System.Drawing.Size(105, 22);
            this.textScrap.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 549);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пластик";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(650, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Аккумуляторы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(649, 577);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Медь";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(650, 489);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Электроника";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(650, 517);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Провода";
            // 
            // textAccumulators
            // 
            this.textAccumulators.Location = new System.Drawing.Point(758, 461);
            this.textAccumulators.Name = "textAccumulators";
            this.textAccumulators.Size = new System.Drawing.Size(105, 22);
            this.textAccumulators.TabIndex = 10;
            // 
            // textElectronics
            // 
            this.textElectronics.Location = new System.Drawing.Point(758, 489);
            this.textElectronics.Name = "textElectronics";
            this.textElectronics.Size = new System.Drawing.Size(105, 22);
            this.textElectronics.TabIndex = 11;
            // 
            // textWires
            // 
            this.textWires.Location = new System.Drawing.Point(758, 517);
            this.textWires.Name = "textWires";
            this.textWires.Size = new System.Drawing.Size(105, 22);
            this.textWires.TabIndex = 12;
            // 
            // textPlastic
            // 
            this.textPlastic.Location = new System.Drawing.Point(758, 549);
            this.textPlastic.Name = "textPlastic";
            this.textPlastic.Size = new System.Drawing.Size(105, 22);
            this.textPlastic.TabIndex = 13;
            // 
            // textCopper
            // 
            this.textCopper.Location = new System.Drawing.Point(758, 577);
            this.textCopper.Name = "textCopper";
            this.textCopper.Size = new System.Drawing.Size(105, 22);
            this.textCopper.TabIndex = 15;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 276);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(489, 324);
            this.listBox1.TabIndex = 18;
            // 
            // buttonParsePrice
            // 
            this.buttonParsePrice.Location = new System.Drawing.Point(652, 404);
            this.buttonParsePrice.Name = "buttonParsePrice";
            this.buttonParsePrice.Size = new System.Drawing.Size(100, 23);
            this.buttonParsePrice.TabIndex = 19;
            this.buttonParsePrice.Text = "Parse";
            this.buttonParsePrice.UseVisualStyleBackColor = true;
            this.buttonParsePrice.Click += new System.EventHandler(this.buttonParsePrice_Click);
            // 
            // checkBoxUnfinished
            // 
            this.checkBoxUnfinished.AutoSize = true;
            this.checkBoxUnfinished.Checked = true;
            this.checkBoxUnfinished.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUnfinished.Location = new System.Drawing.Point(508, 550);
            this.checkBoxUnfinished.Name = "checkBoxUnfinished";
            this.checkBoxUnfinished.Size = new System.Drawing.Size(92, 20);
            this.checkBoxUnfinished.TabIndex = 20;
            this.checkBoxUnfinished.Text = "Unfinished";
            this.checkBoxUnfinished.UseVisualStyleBackColor = true;
            // 
            // checkBoxfreePlayFinish
            // 
            this.checkBoxfreePlayFinish.AutoSize = true;
            this.checkBoxfreePlayFinish.Checked = true;
            this.checkBoxfreePlayFinish.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxfreePlayFinish.Location = new System.Drawing.Point(508, 522);
            this.checkBoxfreePlayFinish.Name = "checkBoxfreePlayFinish";
            this.checkBoxfreePlayFinish.Size = new System.Drawing.Size(114, 20);
            this.checkBoxfreePlayFinish.TabIndex = 21;
            this.checkBoxfreePlayFinish.Text = "freePlayFinish";
            this.checkBoxfreePlayFinish.UseVisualStyleBackColor = true;
            // 
            // checkBoxVictory
            // 
            this.checkBoxVictory.AutoSize = true;
            this.checkBoxVictory.Checked = true;
            this.checkBoxVictory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxVictory.Location = new System.Drawing.Point(508, 468);
            this.checkBoxVictory.Name = "checkBoxVictory";
            this.checkBoxVictory.Size = new System.Drawing.Size(68, 20);
            this.checkBoxVictory.TabIndex = 22;
            this.checkBoxVictory.Text = "victory";
            this.checkBoxVictory.UseVisualStyleBackColor = true;
            // 
            // checkBoxDefeat
            // 
            this.checkBoxDefeat.AutoSize = true;
            this.checkBoxDefeat.Checked = true;
            this.checkBoxDefeat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDefeat.Location = new System.Drawing.Point(508, 494);
            this.checkBoxDefeat.Name = "checkBoxDefeat";
            this.checkBoxDefeat.Size = new System.Drawing.Size(67, 20);
            this.checkBoxDefeat.TabIndex = 23;
            this.checkBoxDefeat.Text = "defeat";
            this.checkBoxDefeat.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(739, 230);
            this.dataGridView1.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(523, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(758, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "Profit: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 624);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBoxDefeat);
            this.Controls.Add(this.checkBoxVictory);
            this.Controls.Add(this.checkBoxfreePlayFinish);
            this.Controls.Add(this.checkBoxUnfinished);
            this.Controls.Add(this.buttonParsePrice);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textCopper);
            this.Controls.Add(this.textPlastic);
            this.Controls.Add(this.textWires);
            this.Controls.Add(this.textElectronics);
            this.Controls.Add(this.textAccumulators);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textScrap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Statistics And Сalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textScrap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textAccumulators;
        private System.Windows.Forms.TextBox textElectronics;
        private System.Windows.Forms.TextBox textWires;
        private System.Windows.Forms.TextBox textPlastic;
        private System.Windows.Forms.TextBox textCopper;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonParsePrice;
        private System.Windows.Forms.CheckBox checkBoxUnfinished;
        private System.Windows.Forms.CheckBox checkBoxfreePlayFinish;
        private System.Windows.Forms.CheckBox checkBoxVictory;
        private System.Windows.Forms.CheckBox checkBoxDefeat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
    }
}

