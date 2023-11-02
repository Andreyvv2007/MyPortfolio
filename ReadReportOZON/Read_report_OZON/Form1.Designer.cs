namespace ReadReportOZON
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItem1 = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            labelHeadMonthOut = new Label();
            labelHeadMonthIn = new Label();
            labelHeadYearOut = new Label();
            labelHeadYearIn = new Label();
            labelSoldQuantityOut = new Label();
            labelNalOut1 = new Label();
            label_Nal_Out_2 = new Label();
            groupBox1 = new GroupBox();
            labelPaymentOut = new Label();
            labelLogisticsOut = new Label();
            labelSoldAmountOut = new Label();
            labelPaymentIn = new Label();
            labelLogisticsIn = new Label();
            labelSoldAmountIn = new Label();
            labelCommissionIn = new Label();
            labelCommissionOut = new Label();
            labelSoldQuantityIn = new Label();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            labelNalIn2 = new Label();
            labelNalIn1 = new Label();
            labelNalOut2 = new Label();
            groupBox3 = new GroupBox();
            labelSumNalAllIn = new Label();
            labelSumAllIn = new Label();
            label_sum_all_out = new Label();
            labelSumNalAllOut = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, toolStripSeparator1, toolStripMenuItem1 });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Image = (Image)resources.GetObject("открытьToolStripMenuItem.Image");
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.ShortcutKeys = Keys.F3;
            открытьToolStripMenuItem.Size = new Size(146, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(143, 6);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Image = (Image)resources.GetObject("toolStripMenuItem1.Image");
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.ShortcutKeys = Keys.Alt | Keys.X;
            toolStripMenuItem1.Size = new Size(146, 22);
            toolStripMenuItem1.Text = "Выход";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 303);
            dataGridView1.TabIndex = 1;
            // 
            // labelHeadMonthOut
            // 
            labelHeadMonthOut.AutoSize = true;
            labelHeadMonthOut.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelHeadMonthOut.Location = new Point(12, 35);
            labelHeadMonthOut.Name = "labelHeadMonthOut";
            labelHeadMonthOut.Size = new Size(104, 30);
            labelHeadMonthOut.TabIndex = 2;
            labelHeadMonthOut.Text = "Отчет за:";
            labelHeadMonthOut.UseWaitCursor = true;
            // 
            // labelHeadMonthIn
            // 
            labelHeadMonthIn.AutoSize = true;
            labelHeadMonthIn.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelHeadMonthIn.Location = new Point(112, 35);
            labelHeadMonthIn.Name = "labelHeadMonthIn";
            labelHeadMonthIn.Size = new Size(22, 30);
            labelHeadMonthIn.TabIndex = 2;
            labelHeadMonthIn.Text = "_";
            labelHeadMonthIn.UseWaitCursor = true;
            // 
            // labelHeadYearOut
            // 
            labelHeadYearOut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelHeadYearOut.AutoSize = true;
            labelHeadYearOut.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelHeadYearOut.Location = new Point(677, 35);
            labelHeadYearOut.Name = "labelHeadYearOut";
            labelHeadYearOut.Size = new Size(53, 30);
            labelHeadYearOut.TabIndex = 2;
            labelHeadYearOut.Text = "Год:";
            labelHeadYearOut.UseWaitCursor = true;
            // 
            // labelHeadYearIn
            // 
            labelHeadYearIn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelHeadYearIn.AutoSize = true;
            labelHeadYearIn.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelHeadYearIn.Location = new Point(723, 35);
            labelHeadYearIn.Name = "labelHeadYearIn";
            labelHeadYearIn.Size = new Size(22, 30);
            labelHeadYearIn.TabIndex = 2;
            labelHeadYearIn.Text = "_";
            labelHeadYearIn.UseWaitCursor = true;
            // 
            // labelSoldQuantityOut
            // 
            labelSoldQuantityOut.AutoSize = true;
            labelSoldQuantityOut.Location = new Point(25, 25);
            labelSoldQuantityOut.Name = "labelSoldQuantityOut";
            labelSoldQuantityOut.Size = new Size(130, 15);
            labelSoldQuantityOut.TabIndex = 3;
            labelSoldQuantityOut.Text = "Реализовано (кол-во):";
            // 
            // labelNalOut1
            // 
            labelNalOut1.AutoSize = true;
            labelNalOut1.Location = new Point(27, 25);
            labelNalOut1.Name = "labelNalOut1";
            labelNalOut1.Size = new Size(87, 15);
            labelNalOut1.TabIndex = 3;
            labelNalOut1.Text = "На доход (6%):";
            // 
            // label_Nal_Out_2
            // 
            label_Nal_Out_2.AutoSize = true;
            label_Nal_Out_2.Location = new Point(27, 50);
            label_Nal_Out_2.Name = "label_Nal_Out_2";
            label_Nal_Out_2.Size = new Size(141, 15);
            label_Nal_Out_2.TabIndex = 3;
            label_Nal_Out_2.Text = "Страховые налоги (год):";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(labelPaymentOut);
            groupBox1.Controls.Add(labelLogisticsOut);
            groupBox1.Controls.Add(labelSoldAmountOut);
            groupBox1.Controls.Add(labelPaymentIn);
            groupBox1.Controls.Add(labelLogisticsIn);
            groupBox1.Controls.Add(labelSoldAmountIn);
            groupBox1.Controls.Add(labelCommissionIn);
            groupBox1.Controls.Add(labelCommissionOut);
            groupBox1.Controls.Add(labelSoldQuantityIn);
            groupBox1.Controls.Add(labelSoldQuantityOut);
            groupBox1.Location = new Point(12, 392);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 157);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Маркетплейс";
            // 
            // labelPaymentOut
            // 
            labelPaymentOut.AutoSize = true;
            labelPaymentOut.Location = new Point(24, 128);
            labelPaymentOut.Name = "labelPaymentOut";
            labelPaymentOut.Size = new Size(129, 15);
            labelPaymentOut.TabIndex = 3;
            labelPaymentOut.Text = "Выплата на расч.счет:";
            // 
            // labelLogisticsOut
            // 
            labelLogisticsOut.AutoSize = true;
            labelLogisticsOut.Location = new Point(25, 102);
            labelLogisticsOut.Name = "labelLogisticsOut";
            labelLogisticsOut.Size = new Size(67, 15);
            labelLogisticsOut.TabIndex = 3;
            labelLogisticsOut.Text = "Логистика:";
            // 
            // labelSoldAmountOut
            // 
            labelSoldAmountOut.AutoSize = true;
            labelSoldAmountOut.Location = new Point(25, 50);
            labelSoldAmountOut.Name = "labelSoldAmountOut";
            labelSoldAmountOut.Size = new Size(128, 15);
            labelSoldAmountOut.TabIndex = 3;
            labelSoldAmountOut.Text = "Реализовано (сумма):";
            // 
            // labelPaymentIn
            // 
            labelPaymentIn.AutoSize = true;
            labelPaymentIn.Location = new Point(161, 128);
            labelPaymentIn.Name = "labelPaymentIn";
            labelPaymentIn.Size = new Size(12, 15);
            labelPaymentIn.TabIndex = 3;
            labelPaymentIn.Text = "_";
            // 
            // labelLogisticsIn
            // 
            labelLogisticsIn.AutoSize = true;
            labelLogisticsIn.Location = new Point(161, 102);
            labelLogisticsIn.Name = "labelLogisticsIn";
            labelLogisticsIn.Size = new Size(12, 15);
            labelLogisticsIn.TabIndex = 3;
            labelLogisticsIn.Text = "_";
            // 
            // labelSoldAmountIn
            // 
            labelSoldAmountIn.AutoSize = true;
            labelSoldAmountIn.Location = new Point(161, 50);
            labelSoldAmountIn.Name = "labelSoldAmountIn";
            labelSoldAmountIn.Size = new Size(12, 15);
            labelSoldAmountIn.TabIndex = 3;
            labelSoldAmountIn.Text = "_";
            // 
            // labelCommissionIn
            // 
            labelCommissionIn.AutoSize = true;
            labelCommissionIn.Location = new Point(161, 77);
            labelCommissionIn.Name = "labelCommissionIn";
            labelCommissionIn.Size = new Size(12, 15);
            labelCommissionIn.TabIndex = 3;
            labelCommissionIn.Text = "_";
            // 
            // labelCommissionOut
            // 
            labelCommissionOut.AutoSize = true;
            labelCommissionOut.Location = new Point(25, 77);
            labelCommissionOut.Name = "labelCommissionOut";
            labelCommissionOut.Size = new Size(96, 15);
            labelCommissionOut.TabIndex = 3;
            labelCommissionOut.Text = "Комиссия Озон:";
            // 
            // labelSoldQuantityIn
            // 
            labelSoldQuantityIn.AutoSize = true;
            labelSoldQuantityIn.Location = new Point(161, 25);
            labelSoldQuantityIn.Name = "labelSoldQuantityIn";
            labelSoldQuantityIn.Size = new Size(12, 15);
            labelSoldQuantityIn.TabIndex = 3;
            labelSoldQuantityIn.Text = "_";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(labelNalIn2);
            groupBox2.Controls.Add(labelNalIn1);
            groupBox2.Controls.Add(labelNalOut1);
            groupBox2.Controls.Add(labelNalOut2);
            groupBox2.Controls.Add(label_Nal_Out_2);
            groupBox2.Location = new Point(276, 392);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(262, 107);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Налоги";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(67, 23);
            textBox1.TabIndex = 4;
            textBox1.Text = "45842";
            // 
            // labelNalIn2
            // 
            labelNalIn2.AutoSize = true;
            labelNalIn2.Location = new Point(174, 76);
            labelNalIn2.Name = "labelNalIn2";
            labelNalIn2.Size = new Size(12, 15);
            labelNalIn2.TabIndex = 3;
            labelNalIn2.Text = "_";
            // 
            // labelNalIn1
            // 
            labelNalIn1.AutoSize = true;
            labelNalIn1.Location = new Point(174, 25);
            labelNalIn1.Name = "labelNalIn1";
            labelNalIn1.Size = new Size(12, 15);
            labelNalIn1.TabIndex = 3;
            labelNalIn1.Text = "_";
            // 
            // labelNalOut2
            // 
            labelNalOut2.AutoSize = true;
            labelNalOut2.Location = new Point(27, 76);
            labelNalOut2.Name = "labelNalOut2";
            labelNalOut2.Size = new Size(147, 15);
            labelNalOut2.TabIndex = 3;
            labelNalOut2.Text = "Страховые налоги (мес.):";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox3.Controls.Add(labelSumNalAllIn);
            groupBox3.Controls.Add(labelSumAllIn);
            groupBox3.Controls.Add(label_sum_all_out);
            groupBox3.Controls.Add(labelSumNalAllOut);
            groupBox3.Location = new Point(555, 392);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(233, 107);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Итого за месяц";
            // 
            // labelSumNalAllIn
            // 
            labelSumNalAllIn.AutoSize = true;
            labelSumNalAllIn.Location = new Point(132, 25);
            labelSumNalAllIn.Name = "labelSumNalAllIn";
            labelSumNalAllIn.Size = new Size(12, 15);
            labelSumNalAllIn.TabIndex = 3;
            labelSumNalAllIn.Text = "_";
            // 
            // labelSumAllIn
            // 
            labelSumAllIn.AutoSize = true;
            labelSumAllIn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelSumAllIn.Location = new Point(27, 65);
            labelSumAllIn.Name = "labelSumAllIn";
            labelSumAllIn.Size = new Size(28, 32);
            labelSumAllIn.TabIndex = 3;
            labelSumAllIn.Text = "0";
            labelSumAllIn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_sum_all_out
            // 
            label_sum_all_out.AutoSize = true;
            label_sum_all_out.Location = new Point(27, 50);
            label_sum_all_out.Name = "label_sum_all_out";
            label_sum_all_out.Size = new Size(92, 15);
            label_sum_all_out.TabIndex = 3;
            label_sum_all_out.Text = "Вы заработали:";
            // 
            // labelSumNalAllOut
            // 
            labelSumNalAllOut.AutoSize = true;
            labelSumNalAllOut.Location = new Point(27, 25);
            labelSumNalAllOut.Name = "labelSumNalAllOut";
            labelSumNalAllOut.Size = new Size(101, 15);
            labelSumNalAllOut.TabIndex = 3;
            labelSumNalAllOut.Text = "Нужно оплатить:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 556);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(labelHeadYearIn);
            Controls.Add(labelHeadYearOut);
            Controls.Add(labelHeadMonthIn);
            Controls.Add(labelHeadMonthOut);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            ShowIcon = false;
            Text = "Отчет за месяц";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem1;
        private DataGridView dataGridView1;
        private Label labelHeadMonthOut;
        private Label labelHeadMonthIn;
        private Label labelHeadYearOut;
        private Label labelHeadYearIn;
        private Label labelSoldQuantityOut;
        private Label labelNalOut1;
        private Label label_Nal_Out_2;
        private GroupBox groupBox1;
        private Label labelPaymentOut;
        private Label labelSoldAmountOut;
        private Label labelPaymentIn;
        private Label labelSoldAmountIn;
        private Label labelSoldQuantityIn;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Label labelNalOut2;
        private Label labelNalIn2;
        private Label labelNalIn1;
        private GroupBox groupBox3;
        private Label labelSumNalAllIn;
        private Label labelSumAllIn;
        private Label label_sum_all_out;
        private Label labelSumNalAllOut;
        private Label labelLogisticsOut;
        private Label labelLogisticsIn;
        private Label labelCommissionIn;
        private Label labelCommissionOut;
    }
}