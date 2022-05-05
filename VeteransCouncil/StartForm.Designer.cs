namespace VeteransCouncil
{
    partial class StartForm
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
            this.RequestButton = new System.Windows.Forms.Button();
            this.TablesButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RequestButton
            // 
            this.RequestButton.BackColor = System.Drawing.Color.Brown;
            this.RequestButton.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RequestButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RequestButton.Location = new System.Drawing.Point(12, 79);
            this.RequestButton.Name = "RequestButton";
            this.RequestButton.Size = new System.Drawing.Size(255, 61);
            this.RequestButton.TabIndex = 1;
            this.RequestButton.Text = "Запросы";
            this.RequestButton.UseVisualStyleBackColor = false;
            this.RequestButton.Click += new System.EventHandler(this.RequestButton_Click);
            // 
            // TablesButton
            // 
            this.TablesButton.BackColor = System.Drawing.Color.Brown;
            this.TablesButton.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TablesButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TablesButton.Location = new System.Drawing.Point(12, 12);
            this.TablesButton.Name = "TablesButton";
            this.TablesButton.Size = new System.Drawing.Size(255, 61);
            this.TablesButton.TabIndex = 0;
            this.TablesButton.Text = "Таблицы";
            this.TablesButton.UseVisualStyleBackColor = false;
            this.TablesButton.Click += new System.EventHandler(this.TablesButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Brown;
            this.CloseButton.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButton.Location = new System.Drawing.Point(12, 146);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(255, 61);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Выход";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(279, 222);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TablesButton);
            this.Controls.Add(this.RequestButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RequestButton;
        private System.Windows.Forms.Button TablesButton;
        private System.Windows.Forms.Button CloseButton;
    }
}

