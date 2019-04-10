namespace ProductorConsumidor
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPEstatus = new System.Windows.Forms.Label();
            this.lblPTiempo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPEstatusAnt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPPos = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCPos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCEstatusAnt = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCTiempo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCEstatus = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Location = new System.Drawing.Point(16, 359);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1051, 100);
            this.pnlContainer.TabIndex = 0;
            this.pnlContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContainer_Paint);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Red;
            this.lblTitulo.Location = new System.Drawing.Point(288, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(502, 55);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Productor-Consumidor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(174, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Productor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(698, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Consumidor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(43, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estatus Actual:";
            // 
            // lblPEstatus
            // 
            this.lblPEstatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPEstatus.ForeColor = System.Drawing.Color.Black;
            this.lblPEstatus.Location = new System.Drawing.Point(236, 148);
            this.lblPEstatus.Name = "lblPEstatus";
            this.lblPEstatus.Size = new System.Drawing.Size(262, 27);
            this.lblPEstatus.TabIndex = 5;
            // 
            // lblPTiempo
            // 
            this.lblPTiempo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPTiempo.ForeColor = System.Drawing.Color.Black;
            this.lblPTiempo.Location = new System.Drawing.Point(236, 199);
            this.lblPTiempo.Name = "lblPTiempo";
            this.lblPTiempo.Size = new System.Drawing.Size(262, 27);
            this.lblPTiempo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(43, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tiempo Restante:";
            // 
            // lblPEstatusAnt
            // 
            this.lblPEstatusAnt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPEstatusAnt.ForeColor = System.Drawing.Color.Black;
            this.lblPEstatusAnt.Location = new System.Drawing.Point(236, 250);
            this.lblPEstatusAnt.Name = "lblPEstatusAnt";
            this.lblPEstatusAnt.Size = new System.Drawing.Size(262, 27);
            this.lblPEstatusAnt.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(43, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 27);
            this.label7.TabIndex = 8;
            this.label7.Text = "Estatus Anterior:";
            // 
            // lblPPos
            // 
            this.lblPPos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPos.ForeColor = System.Drawing.Color.Black;
            this.lblPPos.Location = new System.Drawing.Point(236, 301);
            this.lblPPos.Name = "lblPPos";
            this.lblPPos.Size = new System.Drawing.Size(262, 27);
            this.lblPPos.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(43, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 27);
            this.label9.TabIndex = 10;
            this.label9.Text = "Posicion Actual:";
            // 
            // lblCPos
            // 
            this.lblCPos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPos.ForeColor = System.Drawing.Color.Black;
            this.lblCPos.Location = new System.Drawing.Point(784, 301);
            this.lblCPos.Name = "lblCPos";
            this.lblCPos.Size = new System.Drawing.Size(262, 27);
            this.lblCPos.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(591, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 27);
            this.label6.TabIndex = 18;
            this.label6.Text = "Posicion Actual:";
            // 
            // lblCEstatusAnt
            // 
            this.lblCEstatusAnt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEstatusAnt.ForeColor = System.Drawing.Color.Black;
            this.lblCEstatusAnt.Location = new System.Drawing.Point(784, 250);
            this.lblCEstatusAnt.Name = "lblCEstatusAnt";
            this.lblCEstatusAnt.Size = new System.Drawing.Size(262, 27);
            this.lblCEstatusAnt.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(591, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 27);
            this.label10.TabIndex = 16;
            this.label10.Text = "Estatus Anterior:";
            // 
            // lblCTiempo
            // 
            this.lblCTiempo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCTiempo.ForeColor = System.Drawing.Color.Black;
            this.lblCTiempo.Location = new System.Drawing.Point(784, 199);
            this.lblCTiempo.Name = "lblCTiempo";
            this.lblCTiempo.Size = new System.Drawing.Size(262, 27);
            this.lblCTiempo.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(591, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 27);
            this.label12.TabIndex = 14;
            this.label12.Text = "Tiempo Restante:";
            // 
            // lblCEstatus
            // 
            this.lblCEstatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEstatus.ForeColor = System.Drawing.Color.Black;
            this.lblCEstatus.Location = new System.Drawing.Point(784, 148);
            this.lblCEstatus.Name = "lblCEstatus";
            this.lblCEstatus.Size = new System.Drawing.Size(262, 27);
            this.lblCEstatus.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(591, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 27);
            this.label14.TabIndex = 12;
            this.label14.Text = "Estatus Actual:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 485);
            this.Controls.Add(this.lblCPos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCEstatusAnt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblCTiempo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblCEstatus);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblPPos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPEstatusAnt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPTiempo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPEstatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlContainer);
            this.Name = "Form1";
            this.Text = "Productor-Consumidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPEstatus;
        private System.Windows.Forms.Label lblPTiempo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPEstatusAnt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPPos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCPos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCEstatusAnt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCTiempo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCEstatus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer timer1;
    }
}

