namespace CafeManagement
{
    partial class UserOrder
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            date = new Label();
            OrdersGV = new DataGridView();
            UsersGV = new DataGridView();
            Quant = new TextBox();
            button2 = new Button();
            label3 = new Label();
            button1 = new Button();
            Amount = new Label();
            SellerName = new TextBox();
            OrderNum = new TextBox();
            OrderCat = new ComboBox();
            label1 = new Label();
            label8 = new Label();
            button4 = new Button();
            button3 = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UsersGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(date);
            panel1.Controls.Add(OrdersGV);
            panel1.Controls.Add(UsersGV);
            panel1.Controls.Add(Quant);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Amount);
            panel1.Controls.Add(SellerName);
            panel1.Controls.Add(OrderNum);
            panel1.Controls.Add(OrderCat);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Unispace", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(189, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(1141, 797);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // date
            // 
            date.AutoSize = true;
            date.Font = new Font("Elephant", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            date.ForeColor = Color.SaddleBrown;
            date.Location = new Point(980, 16);
            date.Name = "date";
            date.Size = new Size(63, 27);
            date.TabIndex = 27;
            date.Text = "Date";
            date.Click += date_Click;
            // 
            // OrdersGV
            // 
            OrdersGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OrdersGV.BackgroundColor = Color.LightGray;
            OrdersGV.BorderStyle = BorderStyle.None;
            OrdersGV.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            OrdersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            OrdersGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            OrdersGV.DefaultCellStyle = dataGridViewCellStyle2;
            OrdersGV.EnableHeadersVisualStyles = false;
            OrdersGV.GridColor = Color.SaddleBrown;
            OrdersGV.ImeMode = ImeMode.NoControl;
            OrdersGV.Location = new Point(275, 432);
            OrdersGV.Name = "OrdersGV";
            dataGridViewCellStyle3.BackColor = Color.LightGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.DeepPink;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            OrdersGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            OrdersGV.RowTemplate.Height = 25;
            OrdersGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrdersGV.ShowEditingIcon = false;
            OrdersGV.Size = new Size(768, 277);
            OrdersGV.TabIndex = 26;
            OrdersGV.CellContentClick += OrdersGV_CellContentClick;
            // 
            // UsersGV
            // 
            UsersGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UsersGV.BackgroundColor = Color.LightGray;
            UsersGV.BorderStyle = BorderStyle.None;
            UsersGV.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            UsersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            UsersGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.LightGray;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            UsersGV.DefaultCellStyle = dataGridViewCellStyle5;
            UsersGV.EnableHeadersVisualStyles = false;
            UsersGV.GridColor = Color.SaddleBrown;
            UsersGV.ImeMode = ImeMode.NoControl;
            UsersGV.Location = new Point(275, 90);
            UsersGV.Name = "UsersGV";
            dataGridViewCellStyle6.BackColor = Color.LightGray;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.DeepPink;
            dataGridViewCellStyle6.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            UsersGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            UsersGV.RowTemplate.Height = 25;
            UsersGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UsersGV.ShowEditingIcon = false;
            UsersGV.Size = new Size(768, 216);
            UsersGV.TabIndex = 25;
            UsersGV.CellContentClick += UsersGV_CellContentClick;
            // 
            // Quant
            // 
            Quant.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Quant.ForeColor = Color.SaddleBrown;
            Quant.Location = new Point(535, 353);
            Quant.Name = "Quant";
            Quant.RightToLeft = RightToLeft.Yes;
            Quant.Size = new Size(183, 23);
            Quant.TabIndex = 12;
            Quant.Text = "Quantity";
            // 
            // button2
            // 
            button2.BackColor = Color.SaddleBrown;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(566, 733);
            button2.Name = "button2";
            button2.Size = new Size(139, 35);
            button2.TabIndex = 11;
            button2.Text = "Place The Order";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Elephant", 20.2499962F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(566, 389);
            label3.Name = "label3";
            label3.Size = new Size(172, 35);
            label3.TabIndex = 9;
            label3.Text = "Your Order";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SaddleBrown;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(735, 341);
            button1.Name = "button1";
            button1.Size = new Size(139, 35);
            button1.TabIndex = 8;
            button1.Text = "Add To Cart";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Amount
            // 
            Amount.AutoSize = true;
            Amount.Font = new Font("Elephant", 20.2499962F, FontStyle.Regular, GraphicsUnit.Point);
            Amount.ForeColor = Color.SaddleBrown;
            Amount.Location = new Point(830, 729);
            Amount.Name = "Amount";
            Amount.Size = new Size(103, 35);
            Amount.TabIndex = 7;
            Amount.Text = "Total :";
            Amount.Click += label2_Click;
            // 
            // SellerName
            // 
            SellerName.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            SellerName.ForeColor = Color.SaddleBrown;
            SellerName.Location = new Point(24, 188);
            SellerName.Name = "SellerName";
            SellerName.Size = new Size(183, 23);
            SellerName.TabIndex = 6;
            SellerName.Text = "SellerName";
            SellerName.TextChanged += textBox2_TextChanged;
            // 
            // OrderNum
            // 
            OrderNum.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            OrderNum.ForeColor = Color.SaddleBrown;
            OrderNum.Location = new Point(24, 159);
            OrderNum.Name = "OrderNum";
            OrderNum.Size = new Size(183, 23);
            OrderNum.TabIndex = 5;
            OrderNum.Text = "OrderNum";
            // 
            // OrderCat
            // 
            OrderCat.Font = new Font("Elephant", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            OrderCat.ForeColor = Color.SaddleBrown;
            OrderCat.FormattingEnabled = true;
            OrderCat.Items.AddRange(new object[] { "Comida", "Bebida" });
            OrderCat.Location = new Point(24, 120);
            OrderCat.Name = "OrderCat";
            OrderCat.Size = new Size(183, 33);
            OrderCat.TabIndex = 3;
            OrderCat.Text = "Category";
            OrderCat.SelectedIndexChanged += OrderCat_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(546, 33);
            label1.Name = "label1";
            label1.Size = new Size(213, 41);
            label1.TabIndex = 2;
            label1.Text = "Place Order";
            label1.Click += label1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.SaddleBrown;
            label8.Font = new Font("Algerian", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(1314, 1);
            label8.Name = "label8";
            label8.Size = new Size(25, 24);
            label8.TabIndex = 7;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Elephant", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.SaddleBrown;
            button4.Location = new Point(23, 216);
            button4.Name = "button4";
            button4.Size = new Size(139, 35);
            button4.TabIndex = 14;
            button4.Text = "Users";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Elephant", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.SaddleBrown;
            button3.Location = new Point(23, 148);
            button3.Name = "button3";
            button3.Size = new Size(139, 35);
            button3.TabIndex = 15;
            button3.Text = "Items";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Elephant", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(42, 781);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 16;
            label4.Text = "Logout";
            label4.Click += label4_Click;
            // 
            // UserOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(1342, 848);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(label8);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserOrder";
            Load += UserOrder_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)UsersGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox Quant;
        private Button button2;
        private Label label3;
        private Button button1;
        private Label Amount;
        private TextBox SellerName;
        private TextBox OrderNum;
        private ComboBox OrderCat;
        private Label label1;
        private Label label8;
        private Button button4;
        private Button button3;
        private Label label4;
        private DataGridView OrdersGV;
        private DataGridView UsersGV;
        private Label date;
    }
}