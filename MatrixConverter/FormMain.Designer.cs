namespace MatrixConverter
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewInMatrix = new System.Windows.Forms.DataGridView();
            this.dataGridViewOutMatrix = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuAboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuInstruction = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewInMatrix
            // 
            this.dataGridViewInMatrix.AllowUserToAddRows = false;
            this.dataGridViewInMatrix.AllowUserToDeleteRows = false;
            this.dataGridViewInMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewInMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInMatrix.ColumnHeadersVisible = false;
            this.dataGridViewInMatrix.Location = new System.Drawing.Point(6, 20);
            this.dataGridViewInMatrix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewInMatrix.Name = "dataGridViewInMatrix";
            this.dataGridViewInMatrix.RowHeadersVisible = false;
            this.dataGridViewInMatrix.Size = new System.Drawing.Size(230, 201);
            this.dataGridViewInMatrix.TabIndex = 1;
            this.dataGridViewInMatrix.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewInMatrix_CellBeginEdit);
            this.dataGridViewInMatrix.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInMatrix_CellValueChanged);
            // 
            // dataGridViewOutMatrix
            // 
            this.dataGridViewOutMatrix.AllowUserToAddRows = false;
            this.dataGridViewOutMatrix.AllowUserToDeleteRows = false;
            this.dataGridViewOutMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewOutMatrix.ColumnHeadersVisible = false;
            this.dataGridViewOutMatrix.Location = new System.Drawing.Point(370, 20);
            this.dataGridViewOutMatrix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewOutMatrix.Name = "dataGridViewOutMatrix";
            this.dataGridViewOutMatrix.ReadOnly = true;
            this.dataGridViewOutMatrix.RowHeadersVisible = false;
            this.dataGridViewOutMatrix.Size = new System.Drawing.Size(230, 201);
            this.dataGridViewOutMatrix.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.btnConvert);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridViewOutMatrix);
            this.groupBox1.Controls.Add(this.dataGridViewInMatrix);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(606, 232);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.White;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConvert.Location = new System.Drawing.Point(242, 69);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(122, 104);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Перетворити матрицю зв\'язків\r\n у матрицю з\'єднань";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(398, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Матриця з\'єднань";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Матриця зв\'язків";
            // 
            // btnFill
            // 
            this.btnFill.BackColor = System.Drawing.Color.White;
            this.btnFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFill.Location = new System.Drawing.Point(404, 284);
            this.btnFill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(176, 54);
            this.btnFill.TabIndex = 4;
            this.btnFill.Text = "Заповнити випадково \r\nматрицю зв\'язків";
            this.btnFill.UseVisualStyleBackColor = false;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(543, 365);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 32);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Вихід";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 318);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(150, 284);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.White;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreate.Location = new System.Drawing.Point(256, 284);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(142, 54);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Створити пусту \r\nматрицю зв\'язків";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Кількість стовбців";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(33, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Кількість рядків";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuAboutProgram,
            this.ToolStripMenuInstruction});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 12;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuAboutProgram
            // 
            this.ToolStripMenuAboutProgram.Name = "ToolStripMenuAboutProgram";
            this.ToolStripMenuAboutProgram.Size = new System.Drawing.Size(99, 20);
            this.ToolStripMenuAboutProgram.Text = "Про програму";
            this.ToolStripMenuAboutProgram.Click += new System.EventHandler(this.ToolStripMenuAboutProgram_Click);
            // 
            // ToolStripMenuInstruction
            // 
            this.ToolStripMenuInstruction.Name = "ToolStripMenuInstruction";
            this.ToolStripMenuInstruction.Size = new System.Drawing.Size(75, 20);
            this.ToolStripMenuInstruction.Text = "Інструкція";
            this.ToolStripMenuInstruction.Click += new System.EventHandler(this.ToolStripMenuInstruction_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(632, 410);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "Конвертор матриць";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInMatrix;
        private System.Windows.Forms.DataGridView dataGridViewOutMatrix;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuAboutProgram;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuInstruction;
    }
}

