namespace CombAlg_lab2
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
            this.lblDesertSize = new System.Windows.Forms.Label();
            this.tbDesertSize = new System.Windows.Forms.TextBox();
            this.btnTask = new System.Windows.Forms.Button();
            this.lblTankSize = new System.Windows.Forms.Label();
            this.tbTankSize = new System.Windows.Forms.TextBox();
            this.lblCanisterSize = new System.Windows.Forms.Label();
            this.tbCanisterSize = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDesertSize
            // 
            this.lblDesertSize.AutoSize = true;
            this.lblDesertSize.Location = new System.Drawing.Point(12, 105);
            this.lblDesertSize.Name = "lblDesertSize";
            this.lblDesertSize.Size = new System.Drawing.Size(116, 17);
            this.lblDesertSize.TabIndex = 0;
            this.lblDesertSize.Text = "Размер пустыни";
            // 
            // tbDesertSize
            // 
            this.tbDesertSize.Location = new System.Drawing.Point(15, 125);
            this.tbDesertSize.Name = "tbDesertSize";
            this.tbDesertSize.Size = new System.Drawing.Size(79, 22);
            this.tbDesertSize.TabIndex = 1;
            // 
            // btnTask
            // 
            this.btnTask.Location = new System.Drawing.Point(15, 45);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(79, 30);
            this.btnTask.TabIndex = 2;
            this.btnTask.Text = "Задание";
            this.btnTask.UseVisualStyleBackColor = true;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // lblTankSize
            // 
            this.lblTankSize.AutoSize = true;
            this.lblTankSize.Location = new System.Drawing.Point(12, 182);
            this.lblTankSize.Name = "lblTankSize";
            this.lblTankSize.Size = new System.Drawing.Size(92, 17);
            this.lblTankSize.TabIndex = 3;
            this.lblTankSize.Text = "Размер бака";
            // 
            // tbTankSize
            // 
            this.tbTankSize.Location = new System.Drawing.Point(12, 202);
            this.tbTankSize.Name = "tbTankSize";
            this.tbTankSize.Size = new System.Drawing.Size(82, 22);
            this.tbTankSize.TabIndex = 4;
            // 
            // lblCanisterSize
            // 
            this.lblCanisterSize.AutoSize = true;
            this.lblCanisterSize.Location = new System.Drawing.Point(12, 263);
            this.lblCanisterSize.Name = "lblCanisterSize";
            this.lblCanisterSize.Size = new System.Drawing.Size(124, 17);
            this.lblCanisterSize.TabIndex = 5;
            this.lblCanisterSize.Text = "Размер канистры";
            // 
            // tbCanisterSize
            // 
            this.tbCanisterSize.Location = new System.Drawing.Point(15, 283);
            this.tbCanisterSize.Name = "tbCanisterSize";
            this.tbCanisterSize.Size = new System.Drawing.Size(79, 22);
            this.tbCanisterSize.TabIndex = 6;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(175, 45);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResult.Size = new System.Drawing.Size(517, 260);
            this.tbResult.TabIndex = 7;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(5, 330);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(131, 30);
            this.btnRun.TabIndex = 8;
            this.btnRun.Text = "Найти решение";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(598, 330);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 30);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 383);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbCanisterSize);
            this.Controls.Add(this.lblCanisterSize);
            this.Controls.Add(this.tbTankSize);
            this.Controls.Add(this.lblTankSize);
            this.Controls.Add(this.btnTask);
            this.Controls.Add(this.tbDesertSize);
            this.Controls.Add(this.lblDesertSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesertSize;
        private System.Windows.Forms.TextBox tbDesertSize;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Label lblTankSize;
        private System.Windows.Forms.TextBox tbTankSize;
        private System.Windows.Forms.Label lblCanisterSize;
        private System.Windows.Forms.TextBox tbCanisterSize;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClear;
    }
}

