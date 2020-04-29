namespace FOODRols
{
    partial class fr2
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelReleasForm = new System.Windows.Forms.Label();
            this.labelIndications = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textSostav = new System.Windows.Forms.TextBox();
            this.textweight = new System.Windows.Forms.TextBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(16, 19);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название";
            // 
            // labelReleasForm
            // 
            this.labelReleasForm.AutoSize = true;
            this.labelReleasForm.Location = new System.Drawing.Point(30, 43);
            this.labelReleasForm.Name = "labelReleasForm";
            this.labelReleasForm.Size = new System.Drawing.Size(43, 13);
            this.labelReleasForm.TabIndex = 1;
            this.labelReleasForm.Text = "Состав";
            // 
            // labelIndications
            // 
            this.labelIndications.AutoSize = true;
            this.labelIndications.Location = new System.Drawing.Point(47, 66);
            this.labelIndications.Name = "labelIndications";
            this.labelIndications.Size = new System.Drawing.Size(26, 13);
            this.labelIndications.TabIndex = 2;
            this.labelIndications.Text = "Вес";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(130, 16);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(222, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // textSostav
            // 
            this.textSostav.Location = new System.Drawing.Point(130, 40);
            this.textSostav.Name = "textSostav";
            this.textSostav.Size = new System.Drawing.Size(222, 20);
            this.textSostav.TabIndex = 6;
            // 
            // textweight
            // 
            this.textweight.Location = new System.Drawing.Point(130, 63);
            this.textweight.Name = "textweight";
            this.textweight.Size = new System.Drawing.Size(45, 20);
            this.textweight.TabIndex = 9;
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(371, 16);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(163, 116);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 10;
            this.picture.TabStop = false;
            this.picture.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBBlud_Paint);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.LightCyan;
            this.buttonSave.Location = new System.Drawing.Point(459, 173);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(413, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Картинка";
            // 
            // fr2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(546, 205);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.textweight);
            this.Controls.Add(this.textSostav);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelIndications);
            this.Controls.Add(this.labelReleasForm);
            this.Controls.Add(this.labelName);
            this.Name = "fr2";
            this.Text = "Добавление и редактирование";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelReleasForm;
        private System.Windows.Forms.Label labelIndications;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textSostav;
        private System.Windows.Forms.TextBox textweight;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}