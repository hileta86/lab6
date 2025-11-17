namespace WindowsFormsApp1
{
    partial class Form1
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
            this.A_matrix_dgv = new System.Windows.Forms.DataGridView();
            this.C_matrix_dgv = new System.Windows.Forms.DataGridView();
            this.B_vector_dgv = new System.Windows.Forms.DataGridView();
            this.X_vector_dgv = new System.Windows.Forms.DataGridView();
            this.BСreateGrid = new System.Windows.Forms.Button();
            this.BClear = new System.Windows.Forms.Button();
            this.BClose = new System.Windows.Forms.Button();
            this.NUD_rozmir = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMethod = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.A_matrix_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_matrix_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_vector_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_vector_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_rozmir)).BeginInit();
            this.SuspendLayout();
            // 
            // A_matrix_dgv
            // 
            this.A_matrix_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.A_matrix_dgv.ColumnHeadersVisible = false;
            this.A_matrix_dgv.Location = new System.Drawing.Point(32, 66);
            this.A_matrix_dgv.Name = "A_matrix_dgv";
            this.A_matrix_dgv.RowHeadersVisible = false;
            this.A_matrix_dgv.Size = new System.Drawing.Size(348, 150);
            this.A_matrix_dgv.TabIndex = 0;
            this.A_matrix_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.A_matrix_dgv_CellClick);
            // 
            // C_matrix_dgv
            // 
            this.C_matrix_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.C_matrix_dgv.ColumnHeadersVisible = false;
            this.C_matrix_dgv.Location = new System.Drawing.Point(32, 249);
            this.C_matrix_dgv.Name = "C_matrix_dgv";
            this.C_matrix_dgv.RowHeadersVisible = false;
            this.C_matrix_dgv.Size = new System.Drawing.Size(348, 150);
            this.C_matrix_dgv.TabIndex = 1;
            // 
            // B_vector_dgv
            // 
            this.B_vector_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.B_vector_dgv.ColumnHeadersVisible = false;
            this.B_vector_dgv.Location = new System.Drawing.Point(464, 66);
            this.B_vector_dgv.Name = "B_vector_dgv";
            this.B_vector_dgv.RowHeadersVisible = false;
            this.B_vector_dgv.Size = new System.Drawing.Size(125, 150);
            this.B_vector_dgv.TabIndex = 2;
            this.B_vector_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.B_vector_dgv_CellClick);
            // 
            // X_vector_dgv
            // 
            this.X_vector_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.X_vector_dgv.ColumnHeadersVisible = false;
            this.X_vector_dgv.Location = new System.Drawing.Point(626, 66);
            this.X_vector_dgv.Name = "X_vector_dgv";
            this.X_vector_dgv.ReadOnly = true;
            this.X_vector_dgv.RowHeadersVisible = false;
            this.X_vector_dgv.Size = new System.Drawing.Size(125, 150);
            this.X_vector_dgv.TabIndex = 3;
            // 
            // BСreateGrid
            // 
            this.BСreateGrid.Location = new System.Drawing.Point(464, 249);
            this.BСreateGrid.Name = "BСreateGrid";
            this.BСreateGrid.Size = new System.Drawing.Size(125, 47);
            this.BСreateGrid.TabIndex = 4;
            this.BСreateGrid.Text = "Розв\'язати";
            this.BСreateGrid.UseVisualStyleBackColor = true;
            this.BСreateGrid.Click += new System.EventHandler(this.BСreateGrid_Click);
            // 
            // BClear
            // 
            this.BClear.Location = new System.Drawing.Point(626, 249);
            this.BClear.Name = "BClear";
            this.BClear.Size = new System.Drawing.Size(125, 47);
            this.BClear.TabIndex = 5;
            this.BClear.Text = "Очистити";
            this.BClear.UseVisualStyleBackColor = true;
            this.BClear.Click += new System.EventHandler(this.BClear_Click);
            // 
            // BClose
            // 
            this.BClose.Location = new System.Drawing.Point(464, 302);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(287, 48);
            this.BClose.TabIndex = 6;
            this.BClose.Text = "Вихід";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // NUD_rozmir
            // 
            this.NUD_rozmir.Location = new System.Drawing.Point(260, 20);
            this.NUD_rozmir.Name = "NUD_rozmir";
            this.NUD_rozmir.Size = new System.Drawing.Size(120, 20);
            this.NUD_rozmir.TabIndex = 7;
            this.NUD_rozmir.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_rozmir.ValueChanged += new System.EventHandler(this.NUD_rozmir_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Оберіть розмір матриці А";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Матриця А коефіцієнтів СЛАР";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Матриця С коефіцієнтів L / U розкладу";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Вектор В";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(623, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Вектор Х";
            // 
            // cbMethod
            // 
            this.cbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMethod.FormattingEnabled = true;
            this.cbMethod.Items.AddRange(new object[] {
            "L/U-розклад",
            "Метод Гауса"});
            this.cbMethod.Location = new System.Drawing.Point(630, 19);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(121, 21);
            this.cbMethod.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Оберіть метод";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbMethod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NUD_rozmir);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.BClear);
            this.Controls.Add(this.BСreateGrid);
            this.Controls.Add(this.X_vector_dgv);
            this.Controls.Add(this.B_vector_dgv);
            this.Controls.Add(this.C_matrix_dgv);
            this.Controls.Add(this.A_matrix_dgv);
            this.Name = "Form1";
            this.Text = "Г.І. Метод L/U перетворення для розв\'язання СЛАР.";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.A_matrix_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_matrix_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_vector_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_vector_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_rozmir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView A_matrix_dgv;
        private System.Windows.Forms.DataGridView C_matrix_dgv;
        private System.Windows.Forms.DataGridView B_vector_dgv;
        private System.Windows.Forms.DataGridView X_vector_dgv;
        private System.Windows.Forms.Button BСreateGrid;
        private System.Windows.Forms.Button BClear;
        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.NumericUpDown NUD_rozmir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMethod;
        private System.Windows.Forms.Label label6;
    }
}

