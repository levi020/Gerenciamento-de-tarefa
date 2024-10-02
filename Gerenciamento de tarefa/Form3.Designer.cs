namespace Gerenciamento_de_tarefa
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbViewTarefa = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.rdbConcluidas = new System.Windows.Forms.RadioButton();
            this.rdbNaoConcluido = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 109);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visualizar";
            // 
            // lbViewTarefa
            // 
            this.lbViewTarefa.FormattingEnabled = true;
            this.lbViewTarefa.Location = new System.Drawing.Point(12, 161);
            this.lbViewTarefa.Name = "lbViewTarefa";
            this.lbViewTarefa.Size = new System.Drawing.Size(484, 277);
            this.lbViewTarefa.TabIndex = 1;
            this.lbViewTarefa.SelectedIndexChanged += new System.EventHandler(this.lbViewTarefa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(92, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tarefas não concluidas:";
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(635, 243);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnConcluir
            // 
            this.btnConcluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConcluir.Location = new System.Drawing.Point(635, 200);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(75, 37);
            this.btnConcluir.TabIndex = 4;
            this.btnConcluir.Text = "Marcar como feito";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.rdbNaoConcluido);
            this.gbOptions.Controls.Add(this.rdbConcluidas);
            this.gbOptions.Location = new System.Drawing.Point(502, 177);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(127, 100);
            this.gbOptions.TabIndex = 5;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Opções";
            // 
            // rdbConcluidas
            // 
            this.rdbConcluidas.AutoSize = true;
            this.rdbConcluidas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbConcluidas.Location = new System.Drawing.Point(6, 66);
            this.rdbConcluidas.Name = "rdbConcluidas";
            this.rdbConcluidas.Size = new System.Drawing.Size(77, 17);
            this.rdbConcluidas.TabIndex = 0;
            this.rdbConcluidas.TabStop = true;
            this.rdbConcluidas.Text = "Concluidas";
            this.rdbConcluidas.UseVisualStyleBackColor = true;
            this.rdbConcluidas.CheckedChanged += new System.EventHandler(this.rdbConcluidas_CheckedChanged);
            // 
            // rdbNaoConcluido
            // 
            this.rdbNaoConcluido.AutoSize = true;
            this.rdbNaoConcluido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbNaoConcluido.Location = new System.Drawing.Point(7, 23);
            this.rdbNaoConcluido.Name = "rdbNaoConcluido";
            this.rdbNaoConcluido.Size = new System.Drawing.Size(100, 17);
            this.rdbNaoConcluido.TabIndex = 1;
            this.rdbNaoConcluido.TabStop = true;
            this.rdbNaoConcluido.Text = "Não Concluidas";
            this.rdbNaoConcluido.UseVisualStyleBackColor = true;
            this.rdbNaoConcluido.CheckedChanged += new System.EventHandler(this.rdbNaoConcluido_CheckedChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbViewTarefa);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbViewTarefa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.RadioButton rdbNaoConcluido;
        private System.Windows.Forms.RadioButton rdbConcluidas;
    }
}