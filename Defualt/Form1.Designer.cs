
namespace Defualt
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.but_7 = new System.Windows.Forms.Button();
            this.sub_del = new System.Windows.Forms.Button();
            this.but_9 = new System.Windows.Forms.Button();
            this.but_8 = new System.Windows.Forms.Button();
            this.but_5 = new System.Windows.Forms.Button();
            this.but_6 = new System.Windows.Forms.Button();
            this.sum_m = new System.Windows.Forms.Button();
            this.but_4 = new System.Windows.Forms.Button();
            this.but_2 = new System.Windows.Forms.Button();
            this.but_3 = new System.Windows.Forms.Button();
            this.sub_p = new System.Windows.Forms.Button();
            this.but_1 = new System.Windows.Forms.Button();
            this.sub_z = new System.Windows.Forms.Button();
            this.sub_r = new System.Windows.Forms.Button();
            this.sub_x = new System.Windows.Forms.Button();
            this.but_0 = new System.Windows.Forms.Button();
            this.sub_1 = new System.Windows.Forms.Button();
            this.sub_c = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // but_7
            // 
            this.but_7.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_7.Location = new System.Drawing.Point(5, 116);
            this.but_7.Name = "but_7";
            this.but_7.Size = new System.Drawing.Size(34, 31);
            this.but_7.TabIndex = 0;
            this.but_7.Text = "7";
            this.but_7.UseVisualStyleBackColor = true;
            this.but_7.Click += new System.EventHandler(this.but_0_click);
            // 
            // sub_del
            // 
            this.sub_del.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_del.Location = new System.Drawing.Point(134, 107);
            this.sub_del.Name = "sub_del";
            this.sub_del.Size = new System.Drawing.Size(34, 31);
            this.sub_del.TabIndex = 1;
            this.sub_del.Text = "/";
            this.sub_del.UseVisualStyleBackColor = true;
            this.sub_del.Click += new System.EventHandler(this.MathOperationSelect);
            // 
            // but_9
            // 
            this.but_9.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_9.Location = new System.Drawing.Point(88, 101);
            this.but_9.Name = "but_9";
            this.but_9.Size = new System.Drawing.Size(34, 31);
            this.but_9.TabIndex = 2;
            this.but_9.Text = "9";
            this.but_9.UseVisualStyleBackColor = true;
            this.but_9.Click += new System.EventHandler(this.but_0_click);
            // 
            // but_8
            // 
            this.but_8.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_8.Location = new System.Drawing.Point(48, 107);
            this.but_8.Name = "but_8";
            this.but_8.Size = new System.Drawing.Size(34, 31);
            this.but_8.TabIndex = 3;
            this.but_8.Text = "8";
            this.but_8.UseVisualStyleBackColor = true;
            this.but_8.Click += new System.EventHandler(this.but_0_click);
            // 
            // but_5
            // 
            this.but_5.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_5.Location = new System.Drawing.Point(45, 152);
            this.but_5.Name = "but_5";
            this.but_5.Size = new System.Drawing.Size(34, 31);
            this.but_5.TabIndex = 8;
            this.but_5.Text = "5";
            this.but_5.UseVisualStyleBackColor = true;
            this.but_5.Click += new System.EventHandler(this.but_0_click);
            // 
            // but_6
            // 
            this.but_6.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_6.Location = new System.Drawing.Point(91, 153);
            this.but_6.Name = "but_6";
            this.but_6.Size = new System.Drawing.Size(34, 31);
            this.but_6.TabIndex = 7;
            this.but_6.Text = "6";
            this.but_6.UseVisualStyleBackColor = true;
            this.but_6.Click += new System.EventHandler(this.but_0_click);
            // 
            // sum_m
            // 
            this.sum_m.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum_m.Location = new System.Drawing.Point(134, 153);
            this.sum_m.Name = "sum_m";
            this.sum_m.Size = new System.Drawing.Size(34, 31);
            this.sum_m.TabIndex = 6;
            this.sum_m.Text = "-";
            this.sum_m.UseVisualStyleBackColor = true;
            this.sum_m.Click += new System.EventHandler(this.MathOperationSelect);
            // 
            // but_4
            // 
            this.but_4.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_4.Location = new System.Drawing.Point(5, 153);
            this.but_4.Name = "but_4";
            this.but_4.Size = new System.Drawing.Size(34, 31);
            this.but_4.TabIndex = 5;
            this.but_4.Text = "4";
            this.but_4.UseVisualStyleBackColor = true;
            this.but_4.Click += new System.EventHandler(this.but_0_click);
            // 
            // but_2
            // 
            this.but_2.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_2.Location = new System.Drawing.Point(51, 204);
            this.but_2.Name = "but_2";
            this.but_2.Size = new System.Drawing.Size(34, 31);
            this.but_2.TabIndex = 13;
            this.but_2.Text = "2";
            this.but_2.UseVisualStyleBackColor = true;
            this.but_2.Click += new System.EventHandler(this.but_0_click);
            // 
            // but_3
            // 
            this.but_3.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_3.Location = new System.Drawing.Point(91, 199);
            this.but_3.Name = "but_3";
            this.but_3.Size = new System.Drawing.Size(34, 31);
            this.but_3.TabIndex = 12;
            this.but_3.Text = "3";
            this.but_3.UseVisualStyleBackColor = true;
            this.but_3.Click += new System.EventHandler(this.but_0_click);
            // 
            // sub_p
            // 
            this.sub_p.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_p.Location = new System.Drawing.Point(134, 199);
            this.sub_p.Name = "sub_p";
            this.sub_p.Size = new System.Drawing.Size(34, 31);
            this.sub_p.TabIndex = 11;
            this.sub_p.Text = "+";
            this.sub_p.UseVisualStyleBackColor = true;
            this.sub_p.Click += new System.EventHandler(this.MathOperationSelect);
            // 
            // but_1
            // 
            this.but_1.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_1.Location = new System.Drawing.Point(5, 199);
            this.but_1.Name = "but_1";
            this.but_1.Size = new System.Drawing.Size(34, 31);
            this.but_1.TabIndex = 10;
            this.but_1.Text = "1";
            this.but_1.UseVisualStyleBackColor = true;
            this.but_1.Click += new System.EventHandler(this.but_0_click);
            // 
            // sub_z
            // 
            this.sub_z.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_z.Location = new System.Drawing.Point(48, 245);
            this.sub_z.Name = "sub_z";
            this.sub_z.Size = new System.Drawing.Size(34, 40);
            this.sub_z.TabIndex = 18;
            this.sub_z.Text = ",";
            this.sub_z.UseVisualStyleBackColor = true;
            // 
            // sub_r
            // 
            this.sub_r.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_r.Location = new System.Drawing.Point(91, 245);
            this.sub_r.Name = "sub_r";
            this.sub_r.Size = new System.Drawing.Size(77, 40);
            this.sub_r.TabIndex = 17;
            this.sub_r.Text = "=";
            this.sub_r.UseVisualStyleBackColor = true;
            // 
            // sub_x
            // 
            this.sub_x.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_x.Location = new System.Drawing.Point(134, 61);
            this.sub_x.Name = "sub_x";
            this.sub_x.Size = new System.Drawing.Size(34, 31);
            this.sub_x.TabIndex = 16;
            this.sub_x.Text = "X";
            this.sub_x.UseVisualStyleBackColor = true;
            this.sub_x.Click += new System.EventHandler(this.MathOperationSelect);
            // 
            // but_0
            // 
            this.but_0.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_0.Location = new System.Drawing.Point(5, 245);
            this.but_0.Name = "but_0";
            this.but_0.Size = new System.Drawing.Size(34, 40);
            this.but_0.TabIndex = 15;
            this.but_0.Text = "0";
            this.but_0.UseVisualStyleBackColor = true;
            this.but_0.Click += new System.EventHandler(this.but_0_click);
            // 
            // sub_1
            // 
            this.sub_1.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_1.Location = new System.Drawing.Point(48, 61);
            this.sub_1.Name = "sub_1";
            this.sub_1.Size = new System.Drawing.Size(77, 40);
            this.sub_1.TabIndex = 19;
            this.sub_1.Text = "<=";
            this.sub_1.UseVisualStyleBackColor = true;
            // 
            // sub_c
            // 
            this.sub_c.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_c.Location = new System.Drawing.Point(5, 61);
            this.sub_c.Name = "sub_c";
            this.sub_c.Size = new System.Drawing.Size(34, 40);
            this.sub_c.TabIndex = 20;
            this.sub_c.Text = "C";
            this.sub_c.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Место под рекламую ";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(5, 12);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(166, 34);
            this.textBox.TabIndex = 22;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 333);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sub_c);
            this.Controls.Add(this.sub_1);
            this.Controls.Add(this.sub_z);
            this.Controls.Add(this.sub_r);
            this.Controls.Add(this.sub_x);
            this.Controls.Add(this.but_0);
            this.Controls.Add(this.but_2);
            this.Controls.Add(this.but_3);
            this.Controls.Add(this.sub_p);
            this.Controls.Add(this.but_1);
            this.Controls.Add(this.but_5);
            this.Controls.Add(this.but_6);
            this.Controls.Add(this.sum_m);
            this.Controls.Add(this.but_4);
            this.Controls.Add(this.but_8);
            this.Controls.Add(this.but_9);
            this.Controls.Add(this.sub_del);
            this.Controls.Add(this.but_7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button but_7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sub_c;
        private System.Windows.Forms.Button sub_1;
        private System.Windows.Forms.Button sub_z;
        private System.Windows.Forms.Button sub_r;
        private System.Windows.Forms.Button sub_x;
        private System.Windows.Forms.Button but_0;
        private System.Windows.Forms.Button but_2;
        private System.Windows.Forms.Button but_3;
        private System.Windows.Forms.Button sub_p;
        private System.Windows.Forms.Button but_1;
        private System.Windows.Forms.Button but_5;
        private System.Windows.Forms.Button but_6;
        private System.Windows.Forms.Button sum_m;
        private System.Windows.Forms.Button but_4;
        private System.Windows.Forms.Button but_8;
        private System.Windows.Forms.Button but_9;
        private System.Windows.Forms.Button sub_del;
        private System.Windows.Forms.TextBox textBox;
    }
}

