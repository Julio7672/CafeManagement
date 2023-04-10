namespace CafeManagement
{
    partial class ItemForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            date = new Label();
            UsersGV = new DataGridView();
            label7 = new Label();
            label6 = new Label();
            ItemCat = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            itemPriceTb = new TextBox();
            itemNameTb = new TextBox();
            itemNumTb = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            label4 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UsersGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(date);
            panel1.Controls.Add(UsersGV);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(ItemCat);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(itemPriceTb);
            panel1.Controls.Add(itemNameTb);
            panel1.Controls.Add(itemNumTb);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(221, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(1097, 793);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // date
            // 
            date.AutoSize = true;
            date.Font = new Font("Elephant", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            date.ForeColor = Color.SaddleBrown;
            date.Location = new Point(912, 20);
            date.Name = "date";
            date.Size = new Size(63, 27);
            date.TabIndex = 28;
            date.Text = "Date";
            date.Click += date_Click;
            // 
            // UsersGV
            // 
            UsersGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UsersGV.BackgroundColor = Color.LightGray;
            UsersGV.BorderStyle = BorderStyle.None;
            UsersGV.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            UsersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            UsersGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            UsersGV.DefaultCellStyle = dataGridViewCellStyle2;
            UsersGV.EnableHeadersVisualStyles = false;
            UsersGV.GridColor = Color.SaddleBrown;
            UsersGV.ImeMode = ImeMode.NoControl;
            UsersGV.Location = new Point(504, 231);
            UsersGV.Name = "UsersGV";
            dataGridViewCellStyle3.BackColor = Color.LightGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.DeepPink;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            UsersGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            UsersGV.RowTemplate.Height = 25;
            UsersGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UsersGV.ShowEditingIcon = false;
            UsersGV.Size = new Size(567, 550);
            UsersGV.TabIndex = 24;
            UsersGV.CellContentClick += UsersGV_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Elephant", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.SaddleBrown;
            label7.Location = new Point(34, 343);
            label7.Name = "label7";
            label7.Size = new Size(96, 21);
            label7.TabIndex = 23;
            label7.Text = "ItemPrice:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Elephant", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.SaddleBrown;
            label6.Location = new Point(34, 233);
            label6.Name = "label6";
            label6.Size = new Size(99, 21);
            label6.TabIndex = 22;
            label6.Text = "ItemName:";
            // 
            // ItemCat
            // 
            ItemCat.Font = new Font("Elephant", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            ItemCat.ForeColor = Color.SaddleBrown;
            ItemCat.FormattingEnabled = true;
            ItemCat.Items.AddRange(new object[] { "Comida", "Bebida" });
            ItemCat.Location = new Point(139, 275);
            ItemCat.Name = "ItemCat";
            ItemCat.Size = new Size(183, 29);
            ItemCat.TabIndex = 21;
            ItemCat.Text = "Category";
            ItemCat.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightGray;
            label2.Font = new Font("Elephant", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(34, 184);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 17;
            label2.Text = "ItemNum:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Elephant", 20.2499962F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(709, 170);
            label3.Name = "label3";
            label3.Size = new Size(142, 35);
            label3.TabIndex = 16;
            label3.Text = "Item List";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(434, 10);
            label1.Name = "label1";
            label1.Size = new Size(244, 41);
            label1.TabIndex = 15;
            label1.Text = "Manage Items";
            // 
            // itemPriceTb
            // 
            itemPriceTb.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            itemPriceTb.Location = new Point(139, 341);
            itemPriceTb.Name = "itemPriceTb";
            itemPriceTb.Size = new Size(183, 23);
            itemPriceTb.TabIndex = 14;
            // 
            // itemNameTb
            // 
            itemNameTb.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            itemNameTb.Location = new Point(139, 231);
            itemNameTb.Name = "itemNameTb";
            itemNameTb.Size = new Size(183, 23);
            itemNameTb.TabIndex = 13;
            // 
            // itemNumTb
            // 
            itemNumTb.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            itemNumTb.Location = new Point(139, 182);
            itemNumTb.Name = "itemNumTb";
            itemNumTb.Size = new Size(183, 23);
            itemNumTb.TabIndex = 12;
            itemNumTb.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.SaddleBrown;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(18, 462);
            button3.Name = "button3";
            button3.Size = new Size(128, 35);
            button3.TabIndex = 11;
            button3.Text = "Add ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SaddleBrown;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(315, 462);
            button2.Name = "button2";
            button2.Size = new Size(139, 35);
            button2.TabIndex = 10;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SaddleBrown;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(161, 462);
            button1.Name = "button1";
            button1.Size = new Size(139, 35);
            button1.TabIndex = 9;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Elephant", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.SaddleBrown;
            button4.Location = new Point(30, 239);
            button4.Name = "button4";
            button4.Size = new Size(139, 35);
            button4.TabIndex = 13;
            button4.Text = "Order";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Elephant", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.SaddleBrown;
            button5.Location = new Point(30, 326);
            button5.Name = "button5";
            button5.Size = new Size(139, 35);
            button5.TabIndex = 14;
            button5.Text = "Users";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Elephant", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(62, 787);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 15;
            label4.Text = "Logout";
            label4.Click += label4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.SaddleBrown;
            label8.Font = new Font("Algerian", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(1317, 4);
            label8.Name = "label8";
            label8.Size = new Size(25, 24);
            label8.TabIndex = 16;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // ItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(1342, 848);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ItemForm";
            Load += ItemForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UsersGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button5;
        private TextBox itemPriceTb;
        private TextBox itemNameTb;
        private TextBox itemNumTb;
        private Label label1;
        private Label label3;
        private Label label2;
#pragma warning disable CS0169 // O campo "ItemForm.UsesGV" nunca é usado
        private DataGridView UsesGV;
#pragma warning restore CS0169 // O campo "ItemForm.UsesGV" nunca é usado
        private ComboBox ItemCat;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label8;
        private DataGridView UsersGV;
        private Label date;
    }
}