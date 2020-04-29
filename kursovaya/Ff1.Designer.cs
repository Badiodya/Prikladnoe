namespace FOODRols
{
    partial class Ff1
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
            this.labelPath = new System.Windows.Forms.Label();
            this.textBPath = new System.Windows.Forms.TextBox();
            this.buttonSearchPath = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelSearchDrug = new System.Windows.Forms.Label();
            this.textBFiltr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPath
            // 
            this.labelPath.Location = new System.Drawing.Point(1, 29);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(100, 23);
            this.labelPath.TabIndex = 0;
            this.labelPath.Text = "Путь";
            // 
            // textBPath
            // 
            this.textBPath.Location = new System.Drawing.Point(90, 27);
            this.textBPath.Name = "textBPath";
            this.textBPath.Size = new System.Drawing.Size(157, 20);
            this.textBPath.TabIndex = 1;
            this.textBPath.Text = "Выберите путь";
            // 
            // buttonSearchPath
            // 
            this.buttonSearchPath.BackColor = System.Drawing.Color.LightCyan;
            this.buttonSearchPath.Location = new System.Drawing.Point(49, 24);
            this.buttonSearchPath.Name = "buttonSearchPath";
            this.buttonSearchPath.Size = new System.Drawing.Size(35, 23);
            this.buttonSearchPath.TabIndex = 2;
            this.buttonSearchPath.Text = "...";
            this.buttonSearchPath.UseVisualStyleBackColor = false;
            this.buttonSearchPath.Click += new System.EventHandler(this.buttonSearchPath_Click);
            // 
            // data
            // 
            this.data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.BackgroundColor = System.Drawing.Color.White;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.data.Location = new System.Drawing.Point(15, 121);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Size = new System.Drawing.Size(361, 203);
            this.data.TabIndex = 3;
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            this.data.DoubleClick += new System.EventHandler(this.dataGVRollBlud_DoubleClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightCyan;
            this.buttonAdd.Location = new System.Drawing.Point(382, 121);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.LightCyan;
            this.buttonDelete.Location = new System.Drawing.Point(382, 164);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelSearchDrug
            // 
            this.labelSearchDrug.AutoSize = true;
            this.labelSearchDrug.Location = new System.Drawing.Point(-2, 98);
            this.labelSearchDrug.Name = "labelSearchDrug";
            this.labelSearchDrug.Size = new System.Drawing.Size(39, 13);
            this.labelSearchDrug.TabIndex = 6;
            this.labelSearchDrug.Text = "Поиск";
            // 
            // textBFiltr
            // 
            this.textBFiltr.Location = new System.Drawing.Point(43, 95);
            this.textBFiltr.Name = "textBFiltr";
            this.textBFiltr.Size = new System.Drawing.Size(333, 20);
            this.textBFiltr.TabIndex = 7;
            this.textBFiltr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Ff1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(463, 350);
            this.Controls.Add(this.textBFiltr);
            this.Controls.Add(this.labelSearchDrug);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.data);
            this.Controls.Add(this.buttonSearchPath);
            this.Controls.Add(this.textBPath);
            this.Controls.Add(this.labelPath);
            this.Name = "Ff1";
            this.Text = "Меню ";
            this.Activated += new System.EventHandler(this.BludForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.TextBox textBPath;
        private System.Windows.Forms.Button buttonSearchPath;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelSearchDrug;
        private System.Windows.Forms.TextBox textBFiltr;
    }
}

