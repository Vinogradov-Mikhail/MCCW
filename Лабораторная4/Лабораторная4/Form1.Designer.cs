namespace Лабораторная4
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xBox = new System.Windows.Forms.TextBox();
            this.nBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.rn1222 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.res222222 = new System.Windows.Forms.Label();
            this.rn222 = new System.Windows.Forms.Label();
            this.res1 = new System.Windows.Forms.Label();
            this.rn1 = new System.Windows.Forms.Label();
            this.res2 = new System.Windows.Forms.Label();
            this.rn2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(15, 90);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(182, 334);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "x";
            this.columnHeader1.Width = 66;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "f(x)";
            this.columnHeader2.Width = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите значение f(x):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите n <=  ";
            // 
            // xBox
            // 
            this.xBox.Location = new System.Drawing.Point(15, 25);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(100, 20);
            this.xBox.TabIndex = 3;
            // 
            // nBox
            // 
            this.nBox.Location = new System.Drawing.Point(15, 64);
            this.nBox.Name = "nBox";
            this.nBox.Size = new System.Drawing.Size(100, 20);
            this.nBox.TabIndex = 4;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(121, 25);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(76, 59);
            this.calcButton.TabIndex = 5;
            this.calcButton.Text = "Вычислить";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(231, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "1 способ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(231, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Задача обратного интерполирования:";
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab1.Location = new System.Drawing.Point(256, 48);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(61, 17);
            this.lab1.TabIndex = 8;
            this.lab1.Text = "Qn(F) = ";
            // 
            // rn1222
            // 
            this.rn1222.AutoSize = true;
            this.rn1222.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rn1222.Location = new System.Drawing.Point(256, 67);
            this.rn1222.Name = "rn1222";
            this.rn1222.Size = new System.Drawing.Size(66, 17);
            this.rn1222.TabIndex = 9;
            this.rn1222.Text = "|f(X)-F| = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(231, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "2 способ:";
            // 
            // res222222
            // 
            this.res222222.AutoSize = true;
            this.res222222.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res222222.Location = new System.Drawing.Point(256, 107);
            this.res222222.Name = "res222222";
            this.res222222.Size = new System.Drawing.Size(57, 17);
            this.res222222.TabIndex = 11;
            this.res222222.Text = "Pn(x) = ";
            // 
            // rn222
            // 
            this.rn222.AutoSize = true;
            this.rn222.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rn222.Location = new System.Drawing.Point(256, 124);
            this.rn222.Name = "rn222";
            this.rn222.Size = new System.Drawing.Size(66, 17);
            this.rn222.TabIndex = 12;
            this.rn222.Text = "|f(X)-F| = ";
            // 
            // res1
            // 
            this.res1.AutoSize = true;
            this.res1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res1.Location = new System.Drawing.Point(314, 48);
            this.res1.Name = "res1";
            this.res1.Size = new System.Drawing.Size(0, 17);
            this.res1.TabIndex = 13;
            // 
            // rn1
            // 
            this.rn1.AutoSize = true;
            this.rn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rn1.Location = new System.Drawing.Point(314, 67);
            this.rn1.Name = "rn1";
            this.rn1.Size = new System.Drawing.Size(0, 17);
            this.rn1.TabIndex = 14;
            // 
            // res2
            // 
            this.res2.AutoSize = true;
            this.res2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res2.Location = new System.Drawing.Point(307, 107);
            this.res2.Name = "res2";
            this.res2.Size = new System.Drawing.Size(0, 17);
            this.res2.TabIndex = 15;
            // 
            // rn2
            // 
            this.rn2.AutoSize = true;
            this.rn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rn2.Location = new System.Drawing.Point(314, 124);
            this.rn2.Name = "rn2";
            this.rn2.Size = new System.Drawing.Size(0, 17);
            this.rn2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(231, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(337, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Формулы численного дифференцирования:";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(234, 183);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(622, 241);
            this.listView2.TabIndex = 18;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "x";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "f(x)";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "f\'(x)чд";
            this.columnHeader5.Width = 110;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "|f\'(x)т-f\'(x)чд|";
            this.columnHeader6.Width = 110;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "f\'\'(x)чд";
            this.columnHeader7.Width = 110;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "|f\'\'(x)т-f\'\'(x)чд|";
            this.columnHeader8.Width = 117;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 445);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rn2);
            this.Controls.Add(this.res2);
            this.Controls.Add(this.rn1);
            this.Controls.Add(this.res1);
            this.Controls.Add(this.rn222);
            this.Controls.Add(this.res222222);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rn1222);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.nBox);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Лабораторная 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xBox;
        private System.Windows.Forms.TextBox nBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label rn1222;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label res222222;
        private System.Windows.Forms.Label rn222;
        private System.Windows.Forms.Label res1;
        private System.Windows.Forms.Label rn1;
        private System.Windows.Forms.Label res2;
        private System.Windows.Forms.Label rn2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}

