using System;

namespace ControleFrota
{
    partial class ControleFrota
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
            this.btnCarros = new System.Windows.Forms.Button();
            this.btnCaminhoes = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblKm = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.pboxCarro = new System.Windows.Forms.PictureBox();
            this.pboxCaminhao = new System.Windows.Forms.PictureBox();
            this.txtCarros = new System.Windows.Forms.TextBox();
            this.txtCaminhoes = new System.Windows.Forms.TextBox();
            this.lblEixos = new System.Windows.Forms.Label();
            this.txtEixos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCarro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCaminhao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCarros
            // 
            this.btnCarros.Location = new System.Drawing.Point(326, 23);
            this.btnCarros.Name = "btnCarros";
            this.btnCarros.Size = new System.Drawing.Size(93, 41);
            this.btnCarros.TabIndex = 0;
            this.btnCarros.Text = "Carros";
            this.btnCarros.UseVisualStyleBackColor = true;
            this.btnCarros.Click += new System.EventHandler(this.btnCarros_Click);
            // 
            // btnCaminhoes
            // 
            this.btnCaminhoes.Location = new System.Drawing.Point(425, 23);
            this.btnCaminhoes.Name = "btnCaminhoes";
            this.btnCaminhoes.Size = new System.Drawing.Size(93, 41);
            this.btnCaminhoes.TabIndex = 0;
            this.btnCaminhoes.Text = "Caminhões";
            this.btnCaminhoes.UseVisualStyleBackColor = true;
            this.btnCaminhoes.Click += new System.EventHandler(this.btnCaminhoes_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(524, 23);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(93, 41);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(104, 101);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(59, 15);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(169, 96);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(645, 20);
            this.txtModelo.TabIndex = 2;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(112, 127);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(47, 15);
            this.lblPlaca.TabIndex = 1;
            this.lblPlaca.Text = "Placa:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(169, 122);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(645, 20);
            this.txtPlaca.TabIndex = 2;
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKm.Location = new System.Drawing.Point(127, 153);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(32, 15);
            this.lblKm.TabIndex = 1;
            this.lblKm.Text = "Km:";
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(169, 148);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(107, 20);
            this.txtKm.TabIndex = 2;
            // 
            // pboxCarro
            // 
            this.pboxCarro.Location = new System.Drawing.Point(34, 192);
            this.pboxCarro.Name = "pboxCarro";
            this.pboxCarro.Size = new System.Drawing.Size(100, 50);
            this.pboxCarro.TabIndex = 3;
            this.pboxCarro.TabStop = false;
            // 
            // pboxCaminhao
            // 
            this.pboxCaminhao.Location = new System.Drawing.Point(516, 192);
            this.pboxCaminhao.Name = "pboxCaminhao";
            this.pboxCaminhao.Size = new System.Drawing.Size(100, 50);
            this.pboxCaminhao.TabIndex = 3;
            this.pboxCaminhao.TabStop = false;
            // 
            // txtCarros
            // 
            this.txtCarros.BackColor = System.Drawing.SystemColors.Control;
            this.txtCarros.Location = new System.Drawing.Point(34, 244);
            this.txtCarros.Multiline = true;
            this.txtCarros.Name = "txtCarros";
            this.txtCarros.Size = new System.Drawing.Size(400, 217);
            this.txtCarros.TabIndex = 0;
            // 
            // txtCaminhoes
            // 
            this.txtCaminhoes.BackColor = System.Drawing.SystemColors.Control;
            this.txtCaminhoes.Location = new System.Drawing.Point(516, 244);
            this.txtCaminhoes.Multiline = true;
            this.txtCaminhoes.Name = "txtCaminhoes";
            this.txtCaminhoes.Size = new System.Drawing.Size(400, 217);
            this.txtCaminhoes.TabIndex = 0;
            // 
            // lblEixos
            // 
            this.lblEixos.AutoSize = true;
            this.lblEixos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEixos.Location = new System.Drawing.Point(359, 153);
            this.lblEixos.Name = "lblEixos";
            this.lblEixos.Size = new System.Drawing.Size(46, 15);
            this.lblEixos.TabIndex = 1;
            this.lblEixos.Text = "Eixos:";
            // 
            // txtEixos
            // 
            this.txtEixos.Location = new System.Drawing.Point(411, 148);
            this.txtEixos.Name = "txtEixos";
            this.txtEixos.Size = new System.Drawing.Size(107, 20);
            this.txtEixos.TabIndex = 2;
            // 
            // ControleFrota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(954, 473);
            this.Controls.Add(this.txtCaminhoes);
            this.Controls.Add(this.txtCarros);
            this.Controls.Add(this.pboxCaminhao);
            this.Controls.Add(this.pboxCarro);
            this.Controls.Add(this.txtEixos);
            this.Controls.Add(this.lblEixos);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCaminhoes);
            this.Controls.Add(this.btnCarros);
            this.Name = "ControleFrota";
            this.Text = "Controle da Frota";
            ((System.ComponentModel.ISupportInitialize)(this.pboxCarro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCaminhao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarros;
        private System.Windows.Forms.Button btnCaminhoes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.PictureBox pboxCarro;
        private System.Windows.Forms.PictureBox pboxCaminhao;
        private System.Windows.Forms.TextBox txtCarros;
        private System.Windows.Forms.TextBox txtCaminhoes;
        private System.Windows.Forms.Label lblEixos;
        private System.Windows.Forms.TextBox txtEixos;
    }
}

