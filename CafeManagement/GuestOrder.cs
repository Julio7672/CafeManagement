using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class GuestOrder : Form
    {
        public GuestOrder()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=Teste99;Integrated Security=True");
        void populate()
        {
            con.Open();
            string query = "select * from ItemTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UsersGV.DataSource = ds.Tables[0];
            con.Close();
        }
        void FilterCat()
        {
            con.Open();
            string query = "select * from ItemTbl where ItemCat = '" + OrderCat.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UsersGV.DataSource = ds.Tables[0];
            con.Close();
        }
        string num = "0";
#pragma warning disable CS0169 // O campo "UserOrder.qyt" nunca é usado
        int price, total;
#pragma warning restore CS0169 // O campo "UserOrder.qyt" nunca é usado
#pragma warning disable CS0169 // O campo "UserOrder.item" nunca é usado
        string item, cat;
#pragma warning restore CS0169 // O campo "UserOrder.item" nunca é usado



        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        DataTable table = new DataTable();
        int sum = 0;
        int flag = 0;

        private void GuestOrder_Load(object sender, EventArgs e)
        {
            populate();
            table.Columns.Add("Number", typeof(int));
            table.Columns.Add("ItemName", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("Total", typeof(int));
            OrdersGV.DataSource = table;
            date.Text = DateTime.Today.ToShortDateString();
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sum > 0)
            {
                MessageBox.Show("Compra realizada com sucesso");
            }
            else
            {
                MessageBox.Show("Escolha um item");
            }
        }

        private void OrdersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            num = UsersGV.SelectedRows[0].Cells[0].Value.ToString();
            Name = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
#pragma warning disable CS8601 // Possível atribuição de referência nula.
            cat = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
#pragma warning restore CS8601 // Possível atribuição de referência nula.
            price = Convert.ToInt32(UsersGV.SelectedRows[0].Cells[3].Value.ToString());
            flag = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Quant.Text == "")
            {
                MessageBox.Show("Digite a quantidade que deseja");
            }
            else if (flag == 0)
            {
                MessageBox.Show("selecione o produto a ser adicionado");
            }
            else
            {

                total = price * Convert.ToInt32(Quant.Text);
                table.Rows.Add(num, Name, cat, price, total);
                OrdersGV.DataSource = table;
                flag = 0;

            }
            sum = sum + total;
            Amount.Text = "Total: R$ " + sum + ",00";
        }

        private void OrderCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterCat();
        }
    }
}
