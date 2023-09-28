namespace โปรแกรมคำนวณ_GPA
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
            Label label2;
            หน่วยกิต1 = new ComboBox();
            วืชา1 = new ComboBox();
            เกรด1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            เกรด14 = new ComboBox();
            หน่วยกิต14 = new ComboBox();
            วืชา14 = new ComboBox();
            เกรด13 = new ComboBox();
            เกรด12 = new ComboBox();
            เกรด11 = new ComboBox();
            เกรด10 = new ComboBox();
            เกรด9 = new ComboBox();
            เกรด8 = new ComboBox();
            เกรด7 = new ComboBox();
            เกรด6 = new ComboBox();
            เกรด5 = new ComboBox();
            เกรด4 = new ComboBox();
            เกรด3 = new ComboBox();
            เกรด2 = new ComboBox();
            หน่วยกิต13 = new ComboBox();
            หน่วยกิต12 = new ComboBox();
            หน่วยกิต11 = new ComboBox();
            หน่วยกิต10 = new ComboBox();
            หน่วยกิต9 = new ComboBox();
            หน่วยกิต8 = new ComboBox();
            หน่วยกิต7 = new ComboBox();
            หน่วยกิต6 = new ComboBox();
            หน่วยกิต5 = new ComboBox();
            หน่วยกิต4 = new ComboBox();
            หน่วยกิต3 = new ComboBox();
            หน่วยกิต2 = new ComboBox();
            วืชา13 = new ComboBox();
            วืชา12 = new ComboBox();
            วืชา11 = new ComboBox();
            วืชา10 = new ComboBox();
            วืชา9 = new ComboBox();
            วืชา8 = new ComboBox();
            วืชา7 = new ComboBox();
            วืชา6 = new ComboBox();
            วืชา5 = new ComboBox();
            วืชา4 = new ComboBox();
            วืชา3 = new ComboBox();
            วืชา2 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(171, 40);
            label2.TabIndex = 7;
            label2.Text = "วิชา";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // หน่วยกิต1
            // 
            หน่วยกิต1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            หน่วยกิต1.FormattingEnabled = true;
            หน่วยกิต1.Items.AddRange(new object[] { "0.5", "1", "1.5", "2", "2.5", "3", "3.5", "4" });
            หน่วยกิต1.Location = new Point(180, 43);
            หน่วยกิต1.Name = "หน่วยกิต1";
            หน่วยกิต1.Size = new Size(127, 38);
            หน่วยกิต1.TabIndex = 1;
            หน่วยกิต1.Text = "-เลือกหน่วยกิต";
            // 
            // วืชา1
            // 
            วืชา1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            วืชา1.FormattingEnabled = true;
            วืชา1.IntegralHeight = false;
            วืชา1.Items.AddRange(new object[] { "ภาษาไทย", "คณิตศาสตร์", "วิทยาศาสตร์", "สังคมศึกษา", "ประวัติศาสตร์", "สุขศึกษา", "ศิลปะ", "การงานอาชีพ", "ภาษาต่างประเทศ", "คอมพิวเตอร์(เพิ่มเติม)", "ภาษาไทย(เพิ่มเติม)", "คณิตศาสตร์(เพิ่มเติม)", "ฟิกสิก", "เคมี", "ชีวะ", "ภาษาจีน", "" });
            วืชา1.Location = new Point(3, 43);
            วืชา1.Name = "วืชา1";
            วืชา1.Size = new Size(171, 38);
            วืชา1.TabIndex = 2;
            วืชา1.Text = "-เลือกวิชา";
            วืชา1.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // เกรด1
            // 
            เกรด1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            เกรด1.FormattingEnabled = true;
            เกรด1.Items.AddRange(new object[] { "4", "3.5", "3", "2.5", "2", "1.5", "1", "0" });
            เกรด1.Location = new Point(313, 43);
            เกรด1.Name = "เกรด1";
            เกรด1.Size = new Size(115, 38);
            เกรด1.TabIndex = 3;
            เกรด1.Text = "-เลือกเกรด";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(95, 662);
            label1.Name = "label1";
            label1.Size = new Size(70, 39);
            label1.TabIndex = 4;
            label1.Text = "GPA";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(246, 652);
            button1.Name = "button1";
            button1.Size = new Size(211, 49);
            button1.TabIndex = 5;
            button1.Text = "คำนวณเกรดเฉลี่ย GPA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.10059F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.8994064F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.Controls.Add(เกรด14, 2, 14);
            tableLayoutPanel1.Controls.Add(หน่วยกิต14, 1, 14);
            tableLayoutPanel1.Controls.Add(วืชา14, 0, 14);
            tableLayoutPanel1.Controls.Add(เกรด13, 2, 13);
            tableLayoutPanel1.Controls.Add(เกรด12, 2, 12);
            tableLayoutPanel1.Controls.Add(เกรด11, 2, 11);
            tableLayoutPanel1.Controls.Add(เกรด10, 2, 10);
            tableLayoutPanel1.Controls.Add(เกรด9, 2, 9);
            tableLayoutPanel1.Controls.Add(เกรด8, 2, 8);
            tableLayoutPanel1.Controls.Add(เกรด7, 2, 7);
            tableLayoutPanel1.Controls.Add(เกรด6, 2, 6);
            tableLayoutPanel1.Controls.Add(เกรด5, 2, 5);
            tableLayoutPanel1.Controls.Add(เกรด4, 2, 4);
            tableLayoutPanel1.Controls.Add(เกรด3, 2, 3);
            tableLayoutPanel1.Controls.Add(เกรด2, 2, 2);
            tableLayoutPanel1.Controls.Add(หน่วยกิต13, 1, 13);
            tableLayoutPanel1.Controls.Add(หน่วยกิต12, 1, 12);
            tableLayoutPanel1.Controls.Add(หน่วยกิต11, 1, 11);
            tableLayoutPanel1.Controls.Add(หน่วยกิต10, 1, 10);
            tableLayoutPanel1.Controls.Add(หน่วยกิต9, 1, 9);
            tableLayoutPanel1.Controls.Add(หน่วยกิต8, 1, 8);
            tableLayoutPanel1.Controls.Add(หน่วยกิต7, 1, 7);
            tableLayoutPanel1.Controls.Add(หน่วยกิต6, 1, 6);
            tableLayoutPanel1.Controls.Add(หน่วยกิต5, 1, 5);
            tableLayoutPanel1.Controls.Add(หน่วยกิต4, 1, 4);
            tableLayoutPanel1.Controls.Add(หน่วยกิต3, 1, 3);
            tableLayoutPanel1.Controls.Add(หน่วยกิต2, 1, 2);
            tableLayoutPanel1.Controls.Add(วืชา13, 0, 13);
            tableLayoutPanel1.Controls.Add(วืชา12, 0, 12);
            tableLayoutPanel1.Controls.Add(วืชา11, 0, 11);
            tableLayoutPanel1.Controls.Add(วืชา10, 0, 10);
            tableLayoutPanel1.Controls.Add(วืชา9, 0, 9);
            tableLayoutPanel1.Controls.Add(วืชา8, 0, 8);
            tableLayoutPanel1.Controls.Add(วืชา7, 0, 7);
            tableLayoutPanel1.Controls.Add(วืชา6, 0, 6);
            tableLayoutPanel1.Controls.Add(วืชา5, 0, 5);
            tableLayoutPanel1.Controls.Add(วืชา4, 0, 4);
            tableLayoutPanel1.Controls.Add(วืชา3, 0, 3);
            tableLayoutPanel1.Controls.Add(วืชา2, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
            tableLayoutPanel1.Controls.Add(วืชา1, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(เกรด1, 2, 1);
            tableLayoutPanel1.Controls.Add(หน่วยกิต1, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Location = new Point(51, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 15;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(431, 605);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // เกรด14
            // 
            เกรด14.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            เกรด14.FormattingEnabled = true;
            เกรด14.Items.AddRange(new object[] { "4", "3.5", "3", "2.5", "2", "1.5", "1", "0" });
            เกรด14.Location = new Point(313, 563);
            เกรด14.Name = "เกรด14";
            เกรด14.Size = new Size(115, 38);
            เกรด14.TabIndex = 85;
            เกรด14.Text = "-เลือกเกรด";
            // 
            // หน่วยกิต14
            // 
            หน่วยกิต14.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            หน่วยกิต14.FormattingEnabled = true;
            หน่วยกิต14.Items.AddRange(new object[] { "0.5", "1", "1.5", "2", "2.5", "3", "3.5", "4" });
            หน่วยกิต14.Location = new Point(180, 563);
            หน่วยกิต14.Name = "หน่วยกิต14";
            หน่วยกิต14.Size = new Size(127, 38);
            หน่วยกิต14.TabIndex = 84;
            หน่วยกิต14.Text = "-เลือกหน่วยกิต";
            // 
            // วืชา14
            // 
            วืชา14.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            วืชา14.FormattingEnabled = true;
            วืชา14.IntegralHeight = false;
            วืชา14.Items.AddRange(new object[] { "ภาษาไทย", "คณิตศาสตร์", "วิทยาศาสตร์", "สังคมศึกษา", "ประวัติศาสตร์", "สุขศึกษา", "ศิลปะ", "การงานอาชีพ", "ภาษาต่างประเทศ", "คอมพิวเตอร์(เพิ่มเติม)", "ภาษาไทย(เพิ่มเติม)", "คณิตศาสตร์(เพิ่มเติม)", "ฟิกสิก", "เคมี", "ชีวะ", "ภาษาจีน" });
            วืชา14.Location = new Point(3, 563);
            วืชา14.Name = "วืชา14";
            วืชา14.Size = new Size(171, 38);
            วืชา14.TabIndex = 83;
            วืชา14.Text = "-เลือกวิชา";
            // 
            // เกรด13
            // 
            เกรด13.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            เกรด13.FormattingEnabled = true;
            เกรด13.Items.AddRange(new object[] { "4", "3.5", "3", "2.5", "2", "1.5", "1", "0" });
            เกรด13.Location = new Point(313, 523);
            เกรด13.Name = "เกรด13";
            เกรด13.Size = new Size(115, 38);
            เกรด13.TabIndex = 82;
            เกรด13.Text = "-เลือกเกรด";
            // 
            // เกรด12
            // 
            เกรด12.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            เกรด12.FormattingEnabled = true;
            เกรด12.Items.AddRange(new object[] { "4", "3.5", "3", "2.5", "2", "1.5", "1", "0" });
            เกรด12.Location = new Point(313, 483);
            เกรด12.Name = "เกรด12";
            เกรด12.Size = new Size(115, 38);
            เกรด12.TabIndex = 81;
            เกรด12.Text = "-เลือกเกรด";
            // 
            // เกรด11
            // 
            เกรด11.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            เกรด11.FormattingEnabled = true;
            เกรด11.Items.AddRange(new object[] { "4", "3.5", "3", "2.5", "2", "1.5", "1", "0" });
            เกรด11.Location = new Point(313, 443);
            เกรด11.Name = "เกรด11";
            เกรด11.Size = new Size(115, 38);
            เกรด11.TabIndex = 80;
            เกรด11.Text = "-เลือกเกรด";
            // 
            // เกรด10
            // 
            เกรด10.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            เกรด10.FormattingEnabled = true;
            เกรด10.Items.AddRange(new object[] { "4", "3.5", "3", "2.5", "2", "1.5", "1", "0" });
            เกรด10.Location = new Point(313, 403);
            เกรด10.Name = "เกรด10";
            เกรด10.Size = new Size(115, 38);
            เกรด10.TabIndex = 79;
            เกรด10.Text = "-เลือกเกรด";
            // 
            // เกรด9
            // 
            เกรด9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            เกรด9.FormattingEnabled = true;
            เกรด9.Items.AddRange(new object[] { "4", "3.5", "3", "2.5", "2", "1.5", "1", "0" });
            เกรด9.Location = new Point(313, 363);
            เกรด9.Name = "เกรด9";
            เกรด9.Size = new Size(115, 38);
            เกรด9.TabIndex = 78;
            เกรด9.Text = "-เลือกเกรด";
            // 
            // เกรด8
            // 
            เกรด8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            เกรด8.FormattingEnabled = true;
            เกรด8.Items.AddRange(new object[] { "4", "3.5", "3", "2.5", "2", "1.5", "1", "0" });
            เกรด8.Location = new Point(313, 323);
            เกรด8.Name = "เกรด8";
            เกรด8.Size = new Size(115, 38);
            เกรด8.TabIndex = 77;
            เกรด8.Text = "-เลือกเกรด";
            // 
            // เกรด7
            // 
            เกรด7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            เกรด7.FormattingEnabled = true;
            เกรด7.Items.AddRange(new object[] { "4", "3.5", "3", "2.5", "2", "1.5", "1", "0" });
            เกรด7.Location = new Point(313, 283);
            เกรด7.Name = "เกรด7";
            เกรด7.Size = new Size(115, 38);
            เกรด7.TabIndex = 76;
            เกรด7.Text = "-เลือกเกรด";
            // 
            // เกรด6
            // 
            เกรด6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            เกรด6.FormattingEnabled = true;
            เกรด6.Items.AddRange(new object[] { "4", "3.5", "3", "2.5", "2", "1.5", "1", "0" });
            เกรด6.Location = new Point(313, 243);
            เกรด6.Name = "เกรด6";
            เกรด6.Size = new Size(115, 38);
            เกรด6.TabIndex = 75;
            เกรด6.Text = "-เลือกเกรด";
            // 
            // เกรด5
            // 
            เกรด5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            เกรด5.FormattingEnabled = true;
            เกรด5.Items.AddRange(new object[] { "4", "3.5", "3", "2.5", "2", "1.5", "1", "0" });
            เกรด5.Location = new Point(313, 203);
            เกรด5.Name = "เกรด5";
            เกรด5.Size = new Size(115, 38);
            เกรด5.TabIndex = 74;
            เกรด5.Text = "-เลือกเกรด";
            // 
            // เกรด4
            // 
            เกรด4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            เกรด4.FormattingEnabled = true;
            เกรด4.Items.AddRange(new object[] { "4", "3.5", "3", "2.5", "2", "1.5", "1", "0" });
            เกรด4.Location = new Point(313, 163);
            เกรด4.Name = "เกรด4";
            เกรด4.Size = new Size(115, 38);
            เกรด4.TabIndex = 73;
            เกรด4.Text = "-เลือกเกรด";
            // 
            // เกรด3
            // 
            เกรด3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            เกรด3.FormattingEnabled = true;
            เกรด3.Items.AddRange(new object[] { "4", "3.5", "3", "2.5", "2", "1.5", "1", "0" });
            เกรด3.Location = new Point(313, 123);
            เกรด3.Name = "เกรด3";
            เกรด3.Size = new Size(115, 38);
            เกรด3.TabIndex = 72;
            เกรด3.Text = "-เลือกเกรด";
            // 
            // เกรด2
            // 
            เกรด2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            เกรด2.FormattingEnabled = true;
            เกรด2.Items.AddRange(new object[] { "4", "3.5", "3", "2.5", "2", "1.5", "1", "0" });
            เกรด2.Location = new Point(313, 83);
            เกรด2.Name = "เกรด2";
            เกรด2.Size = new Size(115, 38);
            เกรด2.TabIndex = 71;
            เกรด2.Text = "-เลือกเกรด";
            // 
            // หน่วยกิต13
            // 
            หน่วยกิต13.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            หน่วยกิต13.FormattingEnabled = true;
            หน่วยกิต13.Items.AddRange(new object[] { "0.5", "1", "1.5", "2", "2.5", "3", "3.5", "4" });
            หน่วยกิต13.Location = new Point(180, 523);
            หน่วยกิต13.Name = "หน่วยกิต13";
            หน่วยกิต13.Size = new Size(127, 38);
            หน่วยกิต13.TabIndex = 70;
            หน่วยกิต13.Text = "-เลือกหน่วยกิต";
            // 
            // หน่วยกิต12
            // 
            หน่วยกิต12.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            หน่วยกิต12.FormattingEnabled = true;
            หน่วยกิต12.Items.AddRange(new object[] { "0.5", "1", "1.5", "2", "2.5", "3", "3.5", "4" });
            หน่วยกิต12.Location = new Point(180, 483);
            หน่วยกิต12.Name = "หน่วยกิต12";
            หน่วยกิต12.Size = new Size(127, 38);
            หน่วยกิต12.TabIndex = 69;
            หน่วยกิต12.Text = "-เลือกหน่วยกิต";
            // 
            // หน่วยกิต11
            // 
            หน่วยกิต11.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            หน่วยกิต11.FormattingEnabled = true;
            หน่วยกิต11.Items.AddRange(new object[] { "0.5", "1", "1.5", "2", "2.5", "3", "3.5", "4" });
            หน่วยกิต11.Location = new Point(180, 443);
            หน่วยกิต11.Name = "หน่วยกิต11";
            หน่วยกิต11.Size = new Size(127, 38);
            หน่วยกิต11.TabIndex = 68;
            หน่วยกิต11.Text = "-เลือกหน่วยกิต";
            // 
            // หน่วยกิต10
            // 
            หน่วยกิต10.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            หน่วยกิต10.FormattingEnabled = true;
            หน่วยกิต10.Items.AddRange(new object[] { "0.5", "1", "1.5", "2", "2.5", "3", "3.5", "4" });
            หน่วยกิต10.Location = new Point(180, 403);
            หน่วยกิต10.Name = "หน่วยกิต10";
            หน่วยกิต10.Size = new Size(127, 38);
            หน่วยกิต10.TabIndex = 67;
            หน่วยกิต10.Text = "-เลือกหน่วยกิต";
            // 
            // หน่วยกิต9
            // 
            หน่วยกิต9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            หน่วยกิต9.FormattingEnabled = true;
            หน่วยกิต9.Items.AddRange(new object[] { "0.5", "1", "1.5", "2", "2.5", "3", "3.5", "4" });
            หน่วยกิต9.Location = new Point(180, 363);
            หน่วยกิต9.Name = "หน่วยกิต9";
            หน่วยกิต9.Size = new Size(127, 38);
            หน่วยกิต9.TabIndex = 66;
            หน่วยกิต9.Text = "-เลือกหน่วยกิต";
            // 
            // หน่วยกิต8
            // 
            หน่วยกิต8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            หน่วยกิต8.FormattingEnabled = true;
            หน่วยกิต8.Items.AddRange(new object[] { "0.5", "1", "1.5", "2", "2.5", "3", "3.5", "4" });
            หน่วยกิต8.Location = new Point(180, 323);
            หน่วยกิต8.Name = "หน่วยกิต8";
            หน่วยกิต8.Size = new Size(127, 38);
            หน่วยกิต8.TabIndex = 65;
            หน่วยกิต8.Text = "-เลือกหน่วยกิต";
            // 
            // หน่วยกิต7
            // 
            หน่วยกิต7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            หน่วยกิต7.FormattingEnabled = true;
            หน่วยกิต7.Items.AddRange(new object[] { "0.5", "1", "1.5", "2", "2.5", "3", "3.5", "4" });
            หน่วยกิต7.Location = new Point(180, 283);
            หน่วยกิต7.Name = "หน่วยกิต7";
            หน่วยกิต7.Size = new Size(127, 38);
            หน่วยกิต7.TabIndex = 64;
            หน่วยกิต7.Text = "-เลือกหน่วยกิต";
            // 
            // หน่วยกิต6
            // 
            หน่วยกิต6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            หน่วยกิต6.FormattingEnabled = true;
            หน่วยกิต6.Items.AddRange(new object[] { "0.5", "1", "1.5", "2", "2.5", "3", "3.5", "4" });
            หน่วยกิต6.Location = new Point(180, 243);
            หน่วยกิต6.Name = "หน่วยกิต6";
            หน่วยกิต6.Size = new Size(127, 38);
            หน่วยกิต6.TabIndex = 63;
            หน่วยกิต6.Text = "-เลือกหน่วยกิต";
            // 
            // หน่วยกิต5
            // 
            หน่วยกิต5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            หน่วยกิต5.FormattingEnabled = true;
            หน่วยกิต5.Items.AddRange(new object[] { "0.5", "1", "1.5", "2", "2.5", "3", "3.5", "4" });
            หน่วยกิต5.Location = new Point(180, 203);
            หน่วยกิต5.Name = "หน่วยกิต5";
            หน่วยกิต5.Size = new Size(127, 38);
            หน่วยกิต5.TabIndex = 62;
            หน่วยกิต5.Text = "-เลือกหน่วยกิต";
            // 
            // หน่วยกิต4
            // 
            หน่วยกิต4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            หน่วยกิต4.FormattingEnabled = true;
            หน่วยกิต4.Items.AddRange(new object[] { "0.5", "1", "1.5", "2", "2.5", "3", "3.5", "4" });
            หน่วยกิต4.Location = new Point(180, 163);
            หน่วยกิต4.Name = "หน่วยกิต4";
            หน่วยกิต4.Size = new Size(127, 38);
            หน่วยกิต4.TabIndex = 61;
            หน่วยกิต4.Text = "-เลือกหน่วยกิต";
            // 
            // หน่วยกิต3
            // 
            หน่วยกิต3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            หน่วยกิต3.FormattingEnabled = true;
            หน่วยกิต3.Items.AddRange(new object[] { "0.5", "1", "1.5", "2", "2.5", "3", "3.5", "4" });
            หน่วยกิต3.Location = new Point(180, 123);
            หน่วยกิต3.Name = "หน่วยกิต3";
            หน่วยกิต3.Size = new Size(127, 38);
            หน่วยกิต3.TabIndex = 60;
            หน่วยกิต3.Text = "-เลือกหน่วยกิต";
            // 
            // หน่วยกิต2
            // 
            หน่วยกิต2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            หน่วยกิต2.FormattingEnabled = true;
            หน่วยกิต2.Items.AddRange(new object[] { "0.5", "1", "1.5", "2", "2.5", "3", "3.5", "4" });
            หน่วยกิต2.Location = new Point(180, 83);
            หน่วยกิต2.Name = "หน่วยกิต2";
            หน่วยกิต2.Size = new Size(127, 38);
            หน่วยกิต2.TabIndex = 59;
            หน่วยกิต2.Text = "-เลือกหน่วยกิต";
            // 
            // วืชา13
            // 
            วืชา13.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            วืชา13.FormattingEnabled = true;
            วืชา13.IntegralHeight = false;
            วืชา13.Items.AddRange(new object[] { "ภาษาไทย", "คณิตศาสตร์", "วิทยาศาสตร์", "สังคมศึกษา", "ประวัติศาสตร์", "สุขศึกษา", "ศิลปะ", "การงานอาชีพ", "ภาษาต่างประเทศ", "คอมพิวเตอร์(เพิ่มเติม)", "ภาษาไทย(เพิ่มเติม)", "คณิตศาสตร์(เพิ่มเติม)", "ฟิกสิก", "เคมี", "ชีวะ", "ภาษาจีน" });
            วืชา13.Location = new Point(3, 523);
            วืชา13.Name = "วืชา13";
            วืชา13.Size = new Size(171, 38);
            วืชา13.TabIndex = 58;
            วืชา13.Text = "-เลือกวิชา";
            // 
            // วืชา12
            // 
            วืชา12.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            วืชา12.FormattingEnabled = true;
            วืชา12.IntegralHeight = false;
            วืชา12.Items.AddRange(new object[] { "ภาษาไทย", "คณิตศาสตร์", "วิทยาศาสตร์", "สังคมศึกษา", "ประวัติศาสตร์", "สุขศึกษา", "ศิลปะ", "การงานอาชีพ", "ภาษาต่างประเทศ", "คอมพิวเตอร์(เพิ่มเติม)", "ภาษาไทย(เพิ่มเติม)", "คณิตศาสตร์(เพิ่มเติม)", "ฟิกสิก", "เคมี", "ชีวะ", "ภาษาจีน" });
            วืชา12.Location = new Point(3, 483);
            วืชา12.Name = "วืชา12";
            วืชา12.Size = new Size(171, 38);
            วืชา12.TabIndex = 57;
            วืชา12.Text = "-เลือกวิชา";
            // 
            // วืชา11
            // 
            วืชา11.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            วืชา11.FormattingEnabled = true;
            วืชา11.IntegralHeight = false;
            วืชา11.Items.AddRange(new object[] { "ภาษาไทย", "คณิตศาสตร์", "วิทยาศาสตร์", "สังคมศึกษา", "ประวัติศาสตร์", "สุขศึกษา", "ศิลปะ", "การงานอาชีพ", "ภาษาต่างประเทศ", "คอมพิวเตอร์(เพิ่มเติม)", "ภาษาไทย(เพิ่มเติม)", "คณิตศาสตร์(เพิ่มเติม)", "ฟิกสิก", "เคมี", "ชีวะ", "ภาษาจีน" });
            วืชา11.Location = new Point(3, 443);
            วืชา11.Name = "วืชา11";
            วืชา11.Size = new Size(171, 38);
            วืชา11.TabIndex = 56;
            วืชา11.Text = "-เลือกวิชา";
            // 
            // วืชา10
            // 
            วืชา10.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            วืชา10.FormattingEnabled = true;
            วืชา10.IntegralHeight = false;
            วืชา10.Items.AddRange(new object[] { "ภาษาไทย", "คณิตศาสตร์", "วิทยาศาสตร์", "สังคมศึกษา", "ประวัติศาสตร์", "สุขศึกษา", "ศิลปะ", "การงานอาชีพ", "ภาษาต่างประเทศ", "คอมพิวเตอร์(เพิ่มเติม)", "ภาษาไทย(เพิ่มเติม)", "คณิตศาสตร์(เพิ่มเติม)", "ฟิกสิก", "เคมี", "ชีวะ", "ภาษาจีน" });
            วืชา10.Location = new Point(3, 403);
            วืชา10.Name = "วืชา10";
            วืชา10.Size = new Size(171, 38);
            วืชา10.TabIndex = 55;
            วืชา10.Text = "-เลือกวิชา";
            // 
            // วืชา9
            // 
            วืชา9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            วืชา9.FormattingEnabled = true;
            วืชา9.IntegralHeight = false;
            วืชา9.Items.AddRange(new object[] { "ภาษาไทย", "คณิตศาสตร์", "วิทยาศาสตร์", "สังคมศึกษา", "ประวัติศาสตร์", "สุขศึกษา", "ศิลปะ", "การงานอาชีพ", "ภาษาต่างประเทศ", "คอมพิวเตอร์(เพิ่มเติม)", "ภาษาไทย(เพิ่มเติม)", "คณิตศาสตร์(เพิ่มเติม)", "ฟิกสิก", "เคมี", "ชีวะ", "ภาษาจีน" });
            วืชา9.Location = new Point(3, 363);
            วืชา9.Name = "วืชา9";
            วืชา9.Size = new Size(171, 38);
            วืชา9.TabIndex = 54;
            วืชา9.Text = "-เลือกวิชา";
            // 
            // วืชา8
            // 
            วืชา8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            วืชา8.FormattingEnabled = true;
            วืชา8.IntegralHeight = false;
            วืชา8.Items.AddRange(new object[] { "ภาษาไทย", "คณิตศาสตร์", "วิทยาศาสตร์", "สังคมศึกษา", "ประวัติศาสตร์", "สุขศึกษา", "ศิลปะ", "การงานอาชีพ", "ภาษาต่างประเทศ", "คอมพิวเตอร์(เพิ่มเติม)", "ภาษาไทย(เพิ่มเติม)", "คณิตศาสตร์(เพิ่มเติม)", "ฟิกสิก", "เคมี", "ชีวะ", "ภาษาจีน" });
            วืชา8.Location = new Point(3, 323);
            วืชา8.Name = "วืชา8";
            วืชา8.Size = new Size(171, 38);
            วืชา8.TabIndex = 53;
            วืชา8.Text = "-เลือกวิชา";
            // 
            // วืชา7
            // 
            วืชา7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            วืชา7.FormattingEnabled = true;
            วืชา7.IntegralHeight = false;
            วืชา7.Items.AddRange(new object[] { "ภาษาไทย", "คณิตศาสตร์", "วิทยาศาสตร์", "สังคมศึกษา", "ประวัติศาสตร์", "สุขศึกษา", "ศิลปะ", "การงานอาชีพ", "ภาษาต่างประเทศ", "คอมพิวเตอร์(เพิ่มเติม)", "ภาษาไทย(เพิ่มเติม)", "คณิตศาสตร์(เพิ่มเติม)", "ฟิกสิก", "เคมี", "ชีวะ", "ภาษาจีน" });
            วืชา7.Location = new Point(3, 283);
            วืชา7.Name = "วืชา7";
            วืชา7.Size = new Size(171, 38);
            วืชา7.TabIndex = 52;
            วืชา7.Text = "-เลือกวิชา";
            // 
            // วืชา6
            // 
            วืชา6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            วืชา6.FormattingEnabled = true;
            วืชา6.IntegralHeight = false;
            วืชา6.Items.AddRange(new object[] { "ภาษาไทย", "คณิตศาสตร์", "วิทยาศาสตร์", "สังคมศึกษา", "ประวัติศาสตร์", "สุขศึกษา", "ศิลปะ", "การงานอาชีพ", "ภาษาต่างประเทศ", "คอมพิวเตอร์(เพิ่มเติม)", "ภาษาไทย(เพิ่มเติม)", "คณิตศาสตร์(เพิ่มเติม)", "ฟิกสิก", "เคมี", "ชีวะ", "ภาษาจีน" });
            วืชา6.Location = new Point(3, 243);
            วืชา6.Name = "วืชา6";
            วืชา6.Size = new Size(171, 38);
            วืชา6.TabIndex = 51;
            วืชา6.Text = "-เลือกวิชา";
            // 
            // วืชา5
            // 
            วืชา5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            วืชา5.FormattingEnabled = true;
            วืชา5.IntegralHeight = false;
            วืชา5.Items.AddRange(new object[] { "ภาษาไทย", "คณิตศาสตร์", "วิทยาศาสตร์", "สังคมศึกษา", "ประวัติศาสตร์", "สุขศึกษา", "ศิลปะ", "การงานอาชีพ", "ภาษาต่างประเทศ", "คอมพิวเตอร์(เพิ่มเติม)", "ภาษาไทย(เพิ่มเติม)", "คณิตศาสตร์(เพิ่มเติม)", "ฟิกสิก", "เคมี", "ชีวะ", "ภาษาจีน" });
            วืชา5.Location = new Point(3, 203);
            วืชา5.Name = "วืชา5";
            วืชา5.Size = new Size(171, 38);
            วืชา5.TabIndex = 50;
            วืชา5.Text = "-เลือกวิชา";
            // 
            // วืชา4
            // 
            วืชา4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            วืชา4.FormattingEnabled = true;
            วืชา4.IntegralHeight = false;
            วืชา4.Items.AddRange(new object[] { "ภาษาไทย", "คณิตศาสตร์", "วิทยาศาสตร์", "สังคมศึกษา", "ประวัติศาสตร์", "สุขศึกษา", "ศิลปะ", "การงานอาชีพ", "ภาษาต่างประเทศ", "คอมพิวเตอร์(เพิ่มเติม)", "ภาษาไทย(เพิ่มเติม)", "คณิตศาสตร์(เพิ่มเติม)", "ฟิกสิก", "เคมี", "ชีวะ", "ภาษาจีน" });
            วืชา4.Location = new Point(3, 163);
            วืชา4.Name = "วืชา4";
            วืชา4.Size = new Size(171, 38);
            วืชา4.TabIndex = 49;
            วืชา4.Text = "-เลือกวิชา";
            // 
            // วืชา3
            // 
            วืชา3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            วืชา3.FormattingEnabled = true;
            วืชา3.IntegralHeight = false;
            วืชา3.Items.AddRange(new object[] { "ภาษาไทย", "คณิตศาสตร์", "วิทยาศาสตร์", "สังคมศึกษา", "ประวัติศาสตร์", "สุขศึกษา", "ศิลปะ", "การงานอาชีพ", "ภาษาต่างประเทศ", "คอมพิวเตอร์(เพิ่มเติม)", "ภาษาไทย(เพิ่มเติม)", "คณิตศาสตร์(เพิ่มเติม)", "ฟิกสิก", "เคมี", "ชีวะ", "ภาษาจีน" });
            วืชา3.Location = new Point(3, 123);
            วืชา3.Name = "วืชา3";
            วืชา3.Size = new Size(171, 38);
            วืชา3.TabIndex = 48;
            วืชา3.Text = "-เลือกวิชา";
            // 
            // วืชา2
            // 
            วืชา2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            วืชา2.FormattingEnabled = true;
            วืชา2.IntegralHeight = false;
            วืชา2.Items.AddRange(new object[] { "ภาษาไทย", "คณิตศาสตร์", "วิทยาศาสตร์", "สังคมศึกษา", "ประวัติศาสตร์", "สุขศึกษา", "ศิลปะ", "การงานอาชีพ", "ภาษาต่างประเทศ", "คอมพิวเตอร์(เพิ่มเติม)", "ภาษาไทย(เพิ่มเติม)", "คณิตศาสตร์(เพิ่มเติม)", "ฟิกสิก", "เคมี", "ชีวะ", "ภาษาจีน" });
            วืชา2.Location = new Point(3, 83);
            วืชา2.Name = "วืชา2";
            วืชา2.Size = new Size(171, 38);
            วืชา2.TabIndex = 9;
            วืชา2.Text = "-เลือกวิชา";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(313, 0);
            label4.Name = "label4";
            label4.Size = new Size(115, 40);
            label4.TabIndex = 8;
            label4.Text = "เกรด";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(180, 0);
            label3.Name = "label3";
            label3.Size = new Size(127, 40);
            label3.TabIndex = 7;
            label3.Text = "หน่วยกิต";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(529, 732);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "โปรแกรมคำนวณ GPA";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox หน่วยกิต1;
        private ComboBox วืชา1;
        private ComboBox เกรด1;
        private Label label1;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox วืชา2;
        private ComboBox เกรด13;
        private ComboBox เกรด12;
        private ComboBox เกรด11;
        private ComboBox เกรด10;
        private ComboBox เกรด9;
        private ComboBox เกรด8;
        private ComboBox เกรด7;
        private ComboBox เกรด6;
        private ComboBox เกรด5;
        private ComboBox เกรด4;
        private ComboBox เกรด3;
        private ComboBox เกรด2;
        private ComboBox หน่วยกิต13;
        private ComboBox หน่วยกิต12;
        private ComboBox หน่วยกิต11;
        private ComboBox หน่วยกิต10;
        private ComboBox หน่วยกิต9;
        private ComboBox หน่วยกิต8;
        private ComboBox หน่วยกิต7;
        private ComboBox หน่วยกิต6;
        private ComboBox หน่วยกิต5;
        private ComboBox หน่วยกิต4;
        private ComboBox หน่วยกิต3;
        private ComboBox หน่วยกิต2;
        private ComboBox วืชา13;
        private ComboBox วืชา12;
        private ComboBox วืชา11;
        private ComboBox วืชา10;
        private ComboBox วืชา9;
        private ComboBox วืชา8;
        private ComboBox วืชา7;
        private ComboBox วืชา6;
        private ComboBox วืชา5;
        private ComboBox วืชา4;
        private ComboBox วืชา3;
        private ComboBox เกรด14;
        private ComboBox หน่วยกิต14;
        private ComboBox วืชา14;
    }
}