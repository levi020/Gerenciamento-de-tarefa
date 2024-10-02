namespace Gerenciamento_de_tarefa
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewAdd = new System.Windows.Forms.Button();
            this.btnViewTarefas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 135);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(307, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerenciador \r\n         de \r\n    Tarefas";
            // 
            // btnViewAdd
            // 
            this.btnViewAdd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnViewAdd.Location = new System.Drawing.Point(80, 261);
            this.btnViewAdd.Name = "btnViewAdd";
            this.btnViewAdd.Size = new System.Drawing.Size(109, 36);
            this.btnViewAdd.TabIndex = 1;
            this.btnViewAdd.Text = "Adicionar uma nova tarefa";
            this.btnViewAdd.UseVisualStyleBackColor = false;
            this.btnViewAdd.Click += new System.EventHandler(this.btnViewAdd_Click);
            // 
            // btnViewTarefas
            // 
            this.btnViewTarefas.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnViewTarefas.Location = new System.Drawing.Point(591, 261);
            this.btnViewTarefas.Name = "btnViewTarefas";
            this.btnViewTarefas.Size = new System.Drawing.Size(113, 36);
            this.btnViewTarefas.TabIndex = 2;
            this.btnViewTarefas.Text = "Visualizar tarefas";
            this.btnViewTarefas.UseVisualStyleBackColor = false;
            this.btnViewTarefas.Click += new System.EventHandler(this.btnViewTarefas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewTarefas);
            this.Controls.Add(this.btnViewAdd);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewAdd;
        private System.Windows.Forms.Button btnViewTarefas;
    }
}

