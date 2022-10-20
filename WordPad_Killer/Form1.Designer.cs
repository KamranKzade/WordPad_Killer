namespace WordPad_Killer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_font = new System.Windows.Forms.Label();
            this.label_size = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbox_size = new System.Windows.Forms.ComboBox();
            this.btn_bold = new System.Windows.Forms.Button();
            this.btn_underLine = new System.Windows.Forms.Button();
            this.btn_italic = new System.Windows.Forms.Button();
            this.label_alignment = new System.Windows.Forms.Label();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_center = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.label_Color = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.check_Font = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // label_font
            // 
            this.label_font.AutoSize = true;
            this.label_font.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_font.Location = new System.Drawing.Point(24, 9);
            this.label_font.Name = "label_font";
            this.label_font.Size = new System.Drawing.Size(48, 23);
            this.label_font.TabIndex = 0;
            this.label_font.Text = "Font";
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_size.Location = new System.Drawing.Point(170, 9);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(46, 23);
            this.label_size.TabIndex = 0;
            this.label_size.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(250, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "FontStyle";
            // 
            // cbox_size
            // 
            this.cbox_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_size.FormattingEnabled = true;
            this.cbox_size.Items.AddRange(new object[] {
            "      9",
            "      10",
            "      11",
            "      12",
            "      14",
            "      16",
            "      18",
            "      20",
            "      22",
            "      24"});
            this.cbox_size.Location = new System.Drawing.Point(158, 34);
            this.cbox_size.Name = "cbox_size";
            this.cbox_size.Size = new System.Drawing.Size(76, 28);
            this.cbox_size.TabIndex = 1;
            this.cbox_size.SelectedIndexChanged += new System.EventHandler(this.cbox_size_SelectedIndexChanged);
            // 
            // btn_bold
            // 
            this.btn_bold.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_bold.Location = new System.Drawing.Point(247, 35);
            this.btn_bold.Name = "btn_bold";
            this.btn_bold.Size = new System.Drawing.Size(27, 29);
            this.btn_bold.TabIndex = 2;
            this.btn_bold.Text = "B";
            this.btn_bold.UseVisualStyleBackColor = true;
            this.btn_bold.Click += new System.EventHandler(this.btn_Font_Style_Click);
            // 
            // btn_underLine
            // 
            this.btn_underLine.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_underLine.Location = new System.Drawing.Point(280, 35);
            this.btn_underLine.Name = "btn_underLine";
            this.btn_underLine.Size = new System.Drawing.Size(27, 29);
            this.btn_underLine.TabIndex = 2;
            this.btn_underLine.Text = "U";
            this.btn_underLine.UseVisualStyleBackColor = true;
            this.btn_underLine.Click += new System.EventHandler(this.btn_Font_Style_Click);
            // 
            // btn_italic
            // 
            this.btn_italic.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_italic.Location = new System.Drawing.Point(313, 35);
            this.btn_italic.Name = "btn_italic";
            this.btn_italic.Size = new System.Drawing.Size(27, 29);
            this.btn_italic.TabIndex = 2;
            this.btn_italic.Text = "I";
            this.btn_italic.UseVisualStyleBackColor = true;
            this.btn_italic.Click += new System.EventHandler(this.btn_Font_Style_Click);
            // 
            // label_alignment
            // 
            this.label_alignment.AutoSize = true;
            this.label_alignment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_alignment.Location = new System.Drawing.Point(361, 9);
            this.label_alignment.Name = "label_alignment";
            this.label_alignment.Size = new System.Drawing.Size(96, 23);
            this.label_alignment.TabIndex = 0;
            this.label_alignment.Text = "Alignment";
            // 
            // btn_left
            // 
            this.btn_left.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_left.Location = new System.Drawing.Point(361, 35);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(27, 29);
            this.btn_left.TabIndex = 2;
            this.btn_left.Text = "L";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_Aligment_Click);
            // 
            // btn_center
            // 
            this.btn_center.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_center.Location = new System.Drawing.Point(394, 35);
            this.btn_center.Name = "btn_center";
            this.btn_center.Size = new System.Drawing.Size(27, 29);
            this.btn_center.TabIndex = 2;
            this.btn_center.Text = "C";
            this.btn_center.UseVisualStyleBackColor = true;
            this.btn_center.Click += new System.EventHandler(this.btn_Aligment_Click);
            // 
            // btn_right
            // 
            this.btn_right.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_right.Location = new System.Drawing.Point(427, 35);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(27, 29);
            this.btn_right.TabIndex = 2;
            this.btn_right.Text = "R";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_Aligment_Click);
            // 
            // label_Color
            // 
            this.label_Color.AutoSize = true;
            this.label_Color.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Color.Location = new System.Drawing.Point(500, 11);
            this.label_Color.Name = "label_Color";
            this.label_Color.Size = new System.Drawing.Size(57, 23);
            this.label_Color.TabIndex = 0;
            this.label_Color.Text = "Color";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_save.Location = new System.Drawing.Point(604, 35);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(63, 29);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_open
            // 
            this.btn_open.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_open.Location = new System.Drawing.Point(683, 35);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(86, 29);
            this.btn_open.TabIndex = 2;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 79);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(756, 359);
            this.textBox1.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // check_Font
            // 
            this.check_Font.AutoSize = true;
            this.check_Font.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.check_Font.Location = new System.Drawing.Point(13, 35);
            this.check_Font.Name = "check_Font";
            this.check_Font.Size = new System.Drawing.Size(139, 27);
            this.check_Font.TabIndex = 4;
            this.check_Font.Text = "Change Font";
            this.check_Font.UseVisualStyleBackColor = true;
            this.check_Font.CheckedChanged += new System.EventHandler(this.check_Font_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox2.Location = new System.Drawing.Point(460, 37);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(148, 27);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Change Color";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.check_Font);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_center);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_italic);
            this.Controls.Add(this.btn_underLine);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_bold);
            this.Controls.Add(this.cbox_size);
            this.Controls.Add(this.label_Color);
            this.Controls.Add(this.label_alignment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_size);
            this.Controls.Add(this.label_font);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_font;
        private Label label_size;
        private Label label2;
        private ComboBox cbox_size;
        private Button btn_bold;
        private Button btn_underLine;
        private Button btn_italic;
        private Label label_alignment;
        private Button btn_left;
        private Button btn_center;
        private Button btn_right;
        private Label label_Color;
        private Button btn_save;
        private Button btn_open;
        private TextBox textBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private CheckBox check_Font;
        private CheckBox checkBox2;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
    }
}