namespace VeteransCouncil
{
    partial class Tables
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
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.filterCheckBox = new System.Windows.Forms.CheckBox();
            this.TablesGroupBox = new System.Windows.Forms.GroupBox();
            this.tablesComboBox = new System.Windows.Forms.ComboBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.SearchGroupBox.SuspendLayout();
            this.TablesGroupBox.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.SearchGroupBox.Controls.Add(this.searchButton);
            this.SearchGroupBox.Controls.Add(this.searchTextBox);
            this.SearchGroupBox.Controls.Add(this.filterCheckBox);
            this.SearchGroupBox.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchGroupBox.Location = new System.Drawing.Point(4, 71);
            this.SearchGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.SearchGroupBox.Size = new System.Drawing.Size(154, 67);
            this.SearchGroupBox.TabIndex = 10;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Поиск";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Brown;
            this.searchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchButton.Location = new System.Drawing.Point(88, 20);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(56, 20);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.TableSearch);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(5, 20);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(81, 21);
            this.searchTextBox.TabIndex = 1;
            // 
            // filterCheckBox
            // 
            this.filterCheckBox.AutoSize = true;
            this.filterCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filterCheckBox.Location = new System.Drawing.Point(88, 43);
            this.filterCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.filterCheckBox.Name = "filterCheckBox";
            this.filterCheckBox.Size = new System.Drawing.Size(65, 19);
            this.filterCheckBox.TabIndex = 5;
            this.filterCheckBox.Text = "Фильтр";
            this.filterCheckBox.UseVisualStyleBackColor = true;
            this.filterCheckBox.CheckedChanged += new System.EventHandler(this.FilterUse);
            // 
            // TablesGroupBox
            // 
            this.TablesGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.TablesGroupBox.Controls.Add(this.tablesComboBox);
            this.TablesGroupBox.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TablesGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TablesGroupBox.Location = new System.Drawing.Point(5, 18);
            this.TablesGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.TablesGroupBox.Name = "TablesGroupBox";
            this.TablesGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.TablesGroupBox.Size = new System.Drawing.Size(153, 49);
            this.TablesGroupBox.TabIndex = 9;
            this.TablesGroupBox.TabStop = false;
            this.TablesGroupBox.Text = "Таблица";
            // 
            // tablesComboBox
            // 
            this.tablesComboBox.FormattingEnabled = true;
            this.tablesComboBox.Items.AddRange(new object[] {
            "FILIAL",
            "MEROPRIYATIE",
            "SOTRUDNIK",
            "VETERAN",
            "ZAYAVKA"});
            this.tablesComboBox.Location = new System.Drawing.Point(4, 16);
            this.tablesComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.tablesComboBox.Name = "tablesComboBox";
            this.tablesComboBox.Size = new System.Drawing.Size(142, 23);
            this.tablesComboBox.TabIndex = 0;
            this.tablesComboBox.SelectedIndexChanged += new System.EventHandler(this.TableChange);
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.Color.Brown;
            this.PrintButton.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PrintButton.Location = new System.Drawing.Point(9, 398);
            this.PrintButton.Margin = new System.Windows.Forms.Padding(2);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(149, 23);
            this.PrintButton.TabIndex = 8;
            this.PrintButton.Text = "Печать";
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.TablesGroupBox);
            this.groupBox.Controls.Add(this.PrintButton);
            this.groupBox.Controls.Add(this.SearchGroupBox);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(165, 426);
            this.groupBox.TabIndex = 11;
            this.groupBox.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView.Location = new System.Drawing.Point(183, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(752, 426);
            this.dataGridView.TabIndex = 12;
            // 
            // Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(947, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Tables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tables";
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.TablesGroupBox.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.CheckBox filterCheckBox;
        private System.Windows.Forms.GroupBox TablesGroupBox;
        private System.Windows.Forms.ComboBox tablesComboBox;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}