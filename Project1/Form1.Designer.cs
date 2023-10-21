namespace Project1
{
    partial class form1
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
            groupBox1 = new GroupBox();
            lbl_keyCount = new Label();
            btn_delete_key = new Button();
            label3 = new Label();
            cb_keys = new ComboBox();
            label2 = new Label();
            btn_create_key = new Button();
            txtbox_key_name = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btn_delete_value = new Button();
            btn_value_create = new Button();
            label6 = new Label();
            txt_key_value = new TextBox();
            cb_values = new ComboBox();
            label7 = new Label();
            label5 = new Label();
            txt_key_valueName = new TextBox();
            label4 = new Label();
            lbl_value = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_keyCount);
            groupBox1.Controls.Add(btn_delete_key);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cb_keys);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btn_create_key);
            groupBox1.Controls.Add(txtbox_key_name);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(546, 183);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ایجاد و حذف زیر کلید";
            // 
            // lbl_keyCount
            // 
            lbl_keyCount.AutoSize = true;
            lbl_keyCount.Location = new Point(427, 149);
            lbl_keyCount.Name = "lbl_keyCount";
            lbl_keyCount.Size = new Size(13, 20);
            lbl_keyCount.TabIndex = 7;
            lbl_keyCount.Text = "|";
            lbl_keyCount.Click += label8_Click;
            // 
            // btn_delete_key
            // 
            btn_delete_key.Location = new Point(6, 145);
            btn_delete_key.Name = "btn_delete_key";
            btn_delete_key.Size = new Size(94, 29);
            btn_delete_key.TabIndex = 6;
            btn_delete_key.Text = "حذف";
            btn_delete_key.UseVisualStyleBackColor = true;
            btn_delete_key.Click += btn_delete_key_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(490, 149);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 5;
            label3.Text = "تعداد: ";
            label3.Click += label3_Click;
            // 
            // cb_keys
            // 
            cb_keys.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_keys.FormattingEnabled = true;
            cb_keys.Location = new Point(6, 106);
            cb_keys.Name = "cb_keys";
            cb_keys.Size = new Size(456, 28);
            cb_keys.TabIndex = 4;
            cb_keys.SelectedIndexChanged += cb_keys_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(491, 109);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "لیست:";
            label2.Click += label2_Click;
            // 
            // btn_create_key
            // 
            btn_create_key.Location = new Point(269, 68);
            btn_create_key.Name = "btn_create_key";
            btn_create_key.Size = new Size(193, 29);
            btn_create_key.TabIndex = 2;
            btn_create_key.Text = "ایجاد";
            btn_create_key.UseVisualStyleBackColor = true;
            btn_create_key.Click += button1_Click;
            // 
            // txtbox_key_name
            // 
            txtbox_key_name.Location = new Point(6, 35);
            txtbox_key_name.Name = "txtbox_key_name";
            txtbox_key_name.Size = new Size(456, 27);
            txtbox_key_name.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(480, 38);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "نام کلید:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_delete_value);
            groupBox2.Controls.Add(btn_value_create);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txt_key_value);
            groupBox2.Controls.Add(cb_values);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txt_key_valueName);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(lbl_value);
            groupBox2.Location = new Point(12, 201);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(546, 216);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "ایجاد، حذف و گرفتن داده یک مقدار";
            // 
            // btn_delete_value
            // 
            btn_delete_value.Location = new Point(6, 176);
            btn_delete_value.Name = "btn_delete_value";
            btn_delete_value.Size = new Size(94, 29);
            btn_delete_value.TabIndex = 10;
            btn_delete_value.Text = "حذف";
            btn_delete_value.UseVisualStyleBackColor = true;
            btn_delete_value.Click += btn_delete_value_Click;
            // 
            // btn_value_create
            // 
            btn_value_create.Location = new Point(269, 102);
            btn_value_create.Name = "btn_value_create";
            btn_value_create.Size = new Size(192, 29);
            btn_value_create.TabIndex = 4;
            btn_value_create.Text = "ایجاد";
            btn_value_create.UseVisualStyleBackColor = true;
            btn_value_create.Click += btn_value_create_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(489, 180);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 9;
            label6.Text = "مقدار: ";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_key_value
            // 
            txt_key_value.Location = new Point(6, 69);
            txt_key_value.Name = "txt_key_value";
            txt_key_value.Size = new Size(456, 27);
            txt_key_value.TabIndex = 3;
            // 
            // cb_values
            // 
            cb_values.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_values.FormattingEnabled = true;
            cb_values.Location = new Point(6, 137);
            cb_values.Name = "cb_values";
            cb_values.Size = new Size(456, 28);
            cb_values.TabIndex = 8;
            cb_values.SelectedIndexChanged += cb_values_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(491, 140);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 7;
            label7.Text = "لیست:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(496, 72);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 2;
            label5.Text = "داده: ";
            // 
            // txt_key_valueName
            // 
            txt_key_valueName.Location = new Point(6, 35);
            txt_key_valueName.Name = "txt_key_valueName";
            txt_key_valueName.Size = new Size(455, 27);
            txt_key_valueName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(467, 38);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 0;
            label4.Text = "نام مقدار: ";
            label4.Click += label4_Click;
            // 
            // lbl_value
            // 
            lbl_value.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_value.AutoSize = true;
            lbl_value.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_value.Location = new Point(448, 180);
            lbl_value.Name = "lbl_value";
            lbl_value.Size = new Size(13, 20);
            lbl_value.TabIndex = 11;
            lbl_value.Text = "|";
            lbl_value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 429);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "form1";
            RightToLeft = RightToLeft.Yes;
            Text = "رجیستری";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btn_create_key;
        private TextBox txtbox_key_name;
        private Label label1;
        private Label label2;
        private ComboBox cb_keys;
        private Label label3;
        private Button btn_delete_key;
        private Label label4;
        private Button btn_delete_value;
        private Button btn_value_create;
        private Label label6;
        private TextBox txt_key_value;
        private ComboBox cb_values;
        private Label label7;
        private Label label5;
        private TextBox txt_key_valueName;
        private Label lbl_keyCount;
        private Label lbl_value;
    }
}