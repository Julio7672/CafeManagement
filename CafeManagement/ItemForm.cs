using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CafeManagement
{
    public partial class ItemForm : Form  // toda a classe criada em winforms é herdeira da classe Forms que fornece os metodos e ferramnetas necessesarias para a criaçao
    {
        public ItemForm()
        {
            InitializeComponent(); // iniciando aplicaçao
            date.Text = DateTime.Today.ToShortDateString(); //exibindo data atual

        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=Teste99;Integrated Security=True"); // criando string de conexao
        void populate()
        {
            // metodo criado para que os outros forms possam acessar os dados inseridos na 
            //tabela ItemTbl, assim como o proprio forms ItemForms
            con.Open();
            string query = "select * from ItemTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UsersGV.DataSource = ds.Tables[0];
            con.Close();
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrder order = new UserOrder(); // botao Orders para redirecionar para o forms "UsersOrders"
            order.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();   // botao logout para redirecionar para o forms "Forms1"
            login.Show();

        }
        //botao de edit
       
        private void button1_Click(object sender, EventArgs e)
        {
            //mostrando mensagem de aviso caso o usuario deixe algum campo vazio
            if (itemNumTb.Text == "" || itemNameTb.Text == "" || itemPriceTb.Text == "")
            {
                MessageBox.Show(" Complete todos os campos");

            }
            else
            {
                // atualizando o banco de dados atraves do comando Update. Nesse caso nao é possivel atualizar o ItemName pois ele esta sendo usado como Id
                con.Open();
                string query = "update ItemTbl set ItemNum= '" + itemNumTb.Text + "',ItemPrice= '" + itemPriceTb.Text + "',ItemCat= '" + ItemCat.SelectedItem.ToString() + "' Where ItemName = '" + itemNameTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario atualizado com sucesso");
                con.Close();
                populate();
            }

        }
        // botao de add
        private void button3_Click(object sender, EventArgs e)
        {    
            // caso o usuario deixe de preencher algum campo
            if (itemNameTb.Text == "" || itemNumTb.Text == "" || itemPriceTb.Text == "")
            {
                MessageBox.Show("Preencha todos os dados");
            }
            else
            {
                //implementando o metodo add atraves do comando sql insert into 
                con.Open();
                string query = "insert into ItemTbl values('" + (itemNumTb.Text + "','" + itemNameTb.Text + "','" + ItemCat.SelectedItem.ToString() + "','" + itemPriceTb.Text + "')");
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario Criado com Sucesso");
                con.Close();
                populate(); // metodo implementado acima para acessar os dados inseridos na tabela Itemstbl

            }


        }

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Os dados inseridos pelo usuarios nos textbox a seguir serao incorporados e exibidos em 4 colunas no datagrid
            itemNumTb.Text = UsersGV.SelectedRows[0].Cells[0].Value.ToString();
            itemNameTb.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString(); //Textbox(itemName) = terceira coluna do datagrid (UsersGV)
            ItemCat.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
            itemPriceTb.Text = UsersGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        //botao de delete
        private void button2_Click(object sender, EventArgs e)
        {
            // caso o usuario nao passe o numero de item ele nao sera deletado
            if (itemNumTb.Text == "")
            {
                MessageBox.Show("Escolha o Usuario a ser deletado");

            }
            else
            {   
                //Implementando o metodo deletar atravers do comando sql delete From
                con.Open();
                string query = "delete from ItemTbl where ItemNum = '" + itemNumTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Item deletado com sucesso");
                con.Close();
                populate();

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit(); // botao "X" para sair da aplicaçao
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserFormcs user = new UserFormcs(); // botao users para redirecionar para o forms "UserForms"
            user.Show();
        }

        private void date_Click(object sender, EventArgs e)
        {

        }


    }
}





