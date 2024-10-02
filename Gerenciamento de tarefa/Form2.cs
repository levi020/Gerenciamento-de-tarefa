using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;

namespace Gerenciamento_de_tarefa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user=root;password=root;database=tarefas");
        MySqlCommand cmd;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if(cbbPriority.SelectedIndex == -1)
                {
                    MessageBox.Show("Coloque a prioridade", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    
                }
                if(txbDesc.Text == string.Empty)
                {
                    MessageBox.Show("Coloque a descricao", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                if(txbNameTarefa.Text == string.Empty)
                {
                    MessageBox.Show("Coloque o nome", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    cmd = new MySqlCommand("INSERT INTO `tarefasTotais`(`nomeTarefa`, `Data`, `descricao`, `Prioridade`, `conclusao`) VALUES (@name, @data ,@desc,@prioridade, @conclusao)", conn);
                    cmd.Parameters.AddWithValue("@name", txbNameTarefa.Text);
                    cmd.Parameters.AddWithValue("@data", txbData.Text);
                    cmd.Parameters.AddWithValue("@desc", txbDesc.Text);
                    cmd.Parameters.AddWithValue("@prioridade", cbbPriority.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@conclusao", 'p');
                    if(cmd.ExecuteNonQuery() == -1)
                    {
                        MessageBox.Show("Erro ao adicionar");
                    }
                    else
                    {
                        MessageBox.Show("Deu certo");
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txbDesc.Text = string.Empty;
                txbNameTarefa.Text = string.Empty;
                cbbPriority.SelectedIndex = -1;
                cmd = null;
            }
        }
    }
}
