using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento_de_tarefa
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user=root;password=root;database=tarefas");
        MySqlCommand cmd;
        MySqlDataReader reader;
        string id = string.Empty;
        private void Form3_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            lbViewTarefa.Items.Clear();
            btnDelete.Visible = false;
            btnConcluir.Visible = false;
        }

        private void lbViewTarefa_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            id = lbViewTarefa.SelectedItem.ToString().Substring(3, 4);
            id = id.Trim().Replace(",", " ");
            cmd = null;
            btnDelete.Visible = true;
            btnConcluir.Visible = true;
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("UPDATE `tarefastotais` SET `conclusao`='c' WHERE `id`=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                if(cmd.ExecuteNonQuery() == -1)
                {
                    MessageBox.Show("deu errado");
                }
                else
                {
                    MessageBox.Show("deu certo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                id = string.Empty;
                cmd = null;
                conn.Close();
                btnDelete.Visible = false;
                btnConcluir.Visible = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("DELETE FROM `tarefastotais` WHERE `id`=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                if(cmd.ExecuteNonQuery() == -1)
                {
                    MessageBox.Show("Deu erro");
                }
                else
                {
                    MessageBox.Show("Deu bao");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                id = string.Empty;
                cmd = null;
                conn.Close();
                btnConcluir.Visible=false;
                btnDelete.Visible = false;
            }
        }

        private void rdbNaoConcluido_CheckedChanged(object sender, EventArgs e)
        {
            lbViewTarefa.Items.Clear();
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT `id`,`nomeTarefa`, `Data`, `descricao`, `Prioridade` FROM `tarefastotais` WHERE `conclusao`= 'p';", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lbViewTarefa.Items.Add("id: " + reader[0] + ", Nome da tarefa: " + reader[1] + ", " + reader[2] + ", Descricao: " + reader[3] + ", Prioridade: " + reader[4]);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd = null;
                reader = null;
                label2.Visible = true;
                label2.Text = "Tarefas não concluidas:";
            }
        }

        private void rdbConcluidas_CheckedChanged(object sender, EventArgs e)
        {
            lbViewTarefa.Items.Clear();
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT `id`,`nomeTarefa`, `Data`, `descricao`, `Prioridade` FROM `tarefastotais` WHERE `conclusao`= 'c';", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lbViewTarefa.Items.Add("id: " + reader[0] + ", Nome da tarefa: " + reader[1] + ", " + reader[2] + ", Descricao: " + reader[3] + ", Prioridade: " + reader[4]);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd = null;
                reader = null;
                label2.Visible = true;
                label2.Text = "Tarefas não concluidas:";
            }
        }
    }
}
