using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.CodeDom;
using System.Diagnostics.Contracts;
using System.Diagnostics.Eventing.Reader;

namespace CafeManagement
{
    public partial class UserFormcs : Form
    {
        public UserFormcs()
        {
            InitializeComponent();
            date.Text = DateTime.Today.ToShortDateString();
        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=Teste99;Integrated Security=True");
        void populate()
        {
            con.Open();
            string query = "select * from UsersTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UsersGV.DataSource = ds.Tables[0];
            con.Close();
        }




        private void button4_Click(object sender, EventArgs e)
        {
            UserOrder userOrder = new UserOrder();
            userOrder.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm();
            itemForm.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into UsersTbl values('" + UnameTb.Text + "','" + UphoneTb.Text + "','" + UpassTb.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Usuario Criado com Sucesso");
            con.Close();
            populate();
        }

        private void UpassTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserFormcs_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UnameTb.Text = UsersGV.SelectedRows[0].Cells[0].Value.ToString();
            UphoneTb.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
            UpassTb.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (UphoneTb.Text == "")
            {
                MessageBox.Show("Escolha o Usuario a ser deletado");

            }
            else
            {
                con.Open();
                string query = "delete from UsersTbl where Uphone = '" + UphoneTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Usuario deletado com sucesso");
                con.Close();
                populate();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UphoneTb.Text == "" || UpassTb.Text == "" || UnameTb.Text == "")
            {
                MessageBox.Show(" Complete todos os campos");

            }
            else
            {
                con.Open();
                string query = "update UsersTbl set Uphone= '" + UphoneTb.Text + "',Upassword= '" + UpassTb.Text + "' Where Uname= '" + UnameTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario atualizado com sucesso");
                con.Close();
                populate();

            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void date_Click(object sender, EventArgs e)
        {

        }
    }
}
