namespace VeteransCouncil
{
    partial class Request
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
            this.requestGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.dataGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.tableGroupBox = new System.Windows.Forms.GroupBox();
            this.tableComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.requestGroupBox.SuspendLayout();
            this.dataGroupBox.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.tableGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // requestGroupBox
            // 
            this.requestGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.requestGroupBox.Controls.Add(this.deleteButton);
            this.requestGroupBox.Controls.Add(this.insertButton);
            this.requestGroupBox.Controls.Add(this.updateButton);
            this.requestGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.requestGroupBox.Location = new System.Drawing.Point(12, 393);
            this.requestGroupBox.Name = "requestGroupBox";
            this.requestGroupBox.Size = new System.Drawing.Size(177, 115);
            this.requestGroupBox.TabIndex = 43;
            this.requestGroupBox.TabStop = false;
            this.requestGroupBox.Text = "Запросы";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Brown;
            this.deleteButton.Location = new System.Drawing.Point(9, 77);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(158, 23);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteRequest);
            // 
            // insertButton
            // 
            this.insertButton.BackColor = System.Drawing.Color.Brown;
            this.insertButton.Location = new System.Drawing.Point(9, 19);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(158, 23);
            this.insertButton.TabIndex = 16;
            this.insertButton.Text = "Добавить";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.InsertRequest);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Brown;
            this.updateButton.Location = new System.Drawing.Point(9, 48);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(158, 23);
            this.updateButton.TabIndex = 17;
            this.updateButton.Text = "Изменить";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.UpdateRequest);
            // 
            // dataGroupBox
            // 
            this.dataGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.dataGroupBox.Controls.Add(this.label1);
            this.dataGroupBox.Controls.Add(this.textBox1);
            this.dataGroupBox.Controls.Add(this.textBox2);
            this.dataGroupBox.Controls.Add(this.textBox3);
            this.dataGroupBox.Controls.Add(this.textBox4);
            this.dataGroupBox.Controls.Add(this.textBox5);
            this.dataGroupBox.Controls.Add(this.label2);
            this.dataGroupBox.Controls.Add(this.label3);
            this.dataGroupBox.Controls.Add(this.label5);
            this.dataGroupBox.Controls.Add(this.label4);
            this.dataGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGroupBox.Location = new System.Drawing.Point(12, 162);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Size = new System.Drawing.Size(177, 225);
            this.dataGroupBox.TabIndex = 42;
            this.dataGroupBox.TabStop = false;
            this.dataGroupBox.Text = "Данные";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Данные1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 21);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 21);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 112);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 21);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(9, 152);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(158, 21);
            this.textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(9, 191);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(158, 21);
            this.textBox5.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Данные2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Данные3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Данные5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Данные4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSearch.Controls.Add(this.searchComboBox);
            this.groupBoxSearch.Controls.Add(this.searchButton);
            this.groupBoxSearch.Controls.Add(this.searchLabel);
            this.groupBoxSearch.Controls.Add(this.searchTextBox);
            this.groupBoxSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 75);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(177, 81);
            this.groupBoxSearch.TabIndex = 41;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Поиск";
            // 
            // searchComboBox
            // 
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Location = new System.Drawing.Point(72, 22);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(95, 23);
            this.searchComboBox.TabIndex = 20;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Brown;
            this.searchButton.Location = new System.Drawing.Point(119, 49);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(48, 20);
            this.searchButton.TabIndex = 23;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchInCategory);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(6, 25);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(62, 15);
            this.searchLabel.TabIndex = 21;
            this.searchLabel.Text = "Категория";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(6, 49);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(107, 21);
            this.searchTextBox.TabIndex = 22;
            // 
            // tableGroupBox
            // 
            this.tableGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.tableGroupBox.Controls.Add(this.tableComboBox);
            this.tableGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableGroupBox.Location = new System.Drawing.Point(12, 12);
            this.tableGroupBox.Name = "tableGroupBox";
            this.tableGroupBox.Size = new System.Drawing.Size(177, 57);
            this.tableGroupBox.TabIndex = 40;
            this.tableGroupBox.TabStop = false;
            this.tableGroupBox.Text = "Таблица";
            // 
            // tableComboBox
            // 
            this.tableComboBox.FormattingEnabled = true;
            this.tableComboBox.Items.AddRange(new object[] {
            "FILIAL",
            "MEROPRIYATIE",
            "SOTRUDNIK",
            "VETERAN",
            "ZAYAVKA"});
            this.tableComboBox.Location = new System.Drawing.Point(9, 19);
            this.tableComboBox.Name = "tableComboBox";
            this.tableComboBox.Size = new System.Drawing.Size(158, 23);
            this.tableComboBox.TabIndex = 3;
            this.tableComboBox.SelectedIndexChanged += new System.EventHandler(this.TableChange);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView.Location = new System.Drawing.Point(195, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(789, 496);
            this.dataGridView.TabIndex = 44;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CurrentCell);
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(996, 520);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.requestGroupBox);
            this.Controls.Add(this.dataGroupBox);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.tableGroupBox);
            this.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Request";
            this.Text = "Request";
            this.requestGroupBox.ResumeLayout(false);
            this.dataGroupBox.ResumeLayout(false);
            this.dataGroupBox.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.tableGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox requestGroupBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.GroupBox dataGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.GroupBox tableGroupBox;
        private System.Windows.Forms.ComboBox tableComboBox;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}