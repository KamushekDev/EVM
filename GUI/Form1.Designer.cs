namespace GUI {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.TextBData = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.ComboBType = new System.Windows.Forms.ComboBox();
            this.ComboBNotation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupBOutput = new System.Windows.Forms.GroupBox();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblQuadro = new System.Windows.Forms.Label();
            this.lblHex = new System.Windows.Forms.Label();
            this.lblBinary = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBounds = new System.Windows.Forms.Label();
            this.CheckBPress = new System.Windows.Forms.CheckBox();
            this.GroupBOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBData
            // 
            this.TextBData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBData.Location = new System.Drawing.Point(69, 39);
            this.TextBData.MinimumSize = new System.Drawing.Size(130, 20);
            this.TextBData.Name = "TextBData";
            this.TextBData.Size = new System.Drawing.Size(302, 20);
            this.TextBData.TabIndex = 0;
            this.TextBData.TextChanged += new System.EventHandler(this.TextBData_TextChanged);
            this.TextBData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBData_KeyDown);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(377, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(105, 47);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Поехали!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // ComboBType
            // 
            this.ComboBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBType.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ComboBType.Location = new System.Drawing.Point(47, 10);
            this.ComboBType.Name = "ComboBType";
            this.ComboBType.Size = new System.Drawing.Size(64, 21);
            this.ComboBType.TabIndex = 1;
            this.ComboBType.SelectedValueChanged += new System.EventHandler(this.ComboBType_SelectedValueChanged);
            // 
            // ComboBNotation
            // 
            this.ComboBNotation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBNotation.FormattingEnabled = true;
            this.ComboBNotation.Location = new System.Drawing.Point(233, 10);
            this.ComboBNotation.Name = "ComboBNotation";
            this.ComboBNotation.Size = new System.Drawing.Size(55, 21);
            this.ComboBNotation.TabIndex = 3;
            this.ComboBNotation.SelectedIndexChanged += new System.EventHandler(this.ComboBNotation_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Тип:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Система счисления:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Данные:";
            // 
            // GroupBOutput
            // 
            this.GroupBOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBOutput.Controls.Add(this.lblSymbol);
            this.GroupBOutput.Controls.Add(this.label8);
            this.GroupBOutput.Controls.Add(this.lblTen);
            this.GroupBOutput.Controls.Add(this.lblQuadro);
            this.GroupBOutput.Controls.Add(this.lblHex);
            this.GroupBOutput.Controls.Add(this.lblBinary);
            this.GroupBOutput.Controls.Add(this.label7);
            this.GroupBOutput.Controls.Add(this.label6);
            this.GroupBOutput.Controls.Add(this.label5);
            this.GroupBOutput.Controls.Add(this.label4);
            this.GroupBOutput.Location = new System.Drawing.Point(12, 110);
            this.GroupBOutput.Name = "GroupBOutput";
            this.GroupBOutput.Size = new System.Drawing.Size(470, 94);
            this.GroupBOutput.TabIndex = 7;
            this.GroupBOutput.TabStop = false;
            this.GroupBOutput.Text = "Представление";
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Location = new System.Drawing.Point(61, 76);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(10, 13);
            this.lblSymbol.TabIndex = 9;
            this.lblSymbol.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Символ:";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(96, 46);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(13, 13);
            this.lblTen.TabIndex = 7;
            this.lblTen.Text = "0";
            // 
            // lblQuadro
            // 
            this.lblQuadro.AutoSize = true;
            this.lblQuadro.Location = new System.Drawing.Point(96, 31);
            this.lblQuadro.Name = "lblQuadro";
            this.lblQuadro.Size = new System.Drawing.Size(13, 13);
            this.lblQuadro.TabIndex = 6;
            this.lblQuadro.Text = "0";
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Location = new System.Drawing.Point(124, 61);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(13, 13);
            this.lblHex.TabIndex = 5;
            this.lblHex.Text = "0";
            // 
            // lblBinary
            // 
            this.lblBinary.AutoSize = true;
            this.lblBinary.Location = new System.Drawing.Point(72, 16);
            this.lblBinary.Name = "lblBinary";
            this.lblBinary.Size = new System.Drawing.Size(13, 13);
            this.lblBinary.TabIndex = 4;
            this.lblBinary.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Шестнадцатеричное:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Десятеричное:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Восьмеричное:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Двоичное:";
            // 
            // lblBounds
            // 
            this.lblBounds.AutoSize = true;
            this.lblBounds.Location = new System.Drawing.Point(12, 66);
            this.lblBounds.Name = "lblBounds";
            this.lblBounds.Size = new System.Drawing.Size(114, 39);
            this.lblBounds.TabIndex = 10;
            this.lblBounds.Text = "Диапазон значений: \r\nот {0}\r\nдо {1}.";
            // 
            // CheckBPress
            // 
            this.CheckBPress.AutoSize = true;
            this.CheckBPress.Enabled = false;
            this.CheckBPress.Location = new System.Drawing.Point(300, 13);
            this.CheckBPress.Name = "CheckBPress";
            this.CheckBPress.Size = new System.Drawing.Size(71, 17);
            this.CheckBPress.TabIndex = 8;
            this.CheckBPress.Text = "Нажатия";
            this.CheckBPress.UseVisualStyleBackColor = true;
            this.CheckBPress.CheckedChanged += new System.EventHandler(this.ChangePress);
            this.CheckBPress.EnabledChanged += new System.EventHandler(this.ChangePress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 215);
            this.Controls.Add(this.lblBounds);
            this.Controls.Add(this.CheckBPress);
            this.Controls.Add(this.GroupBOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBNotation);
            this.Controls.Add(this.ComboBType);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.TextBData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(510, 205);
            this.Name = "Form1";
            this.Text = "ЭВМ лабораторная 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBOutput.ResumeLayout(false);
            this.GroupBOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBData;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox ComboBType;
        private System.Windows.Forms.ComboBox ComboBNotation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GroupBOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblQuadro;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.Label lblBinary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CheckBPress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.Label lblBounds;
    }
}

