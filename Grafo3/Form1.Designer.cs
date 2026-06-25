namespace Grafo3 {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.textCosto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFloyd = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnMatriz = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textDestino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btninsertar = new System.Windows.Forms.Button();
            this.textOrigen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.textVertice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVertices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textCosto
            // 
            this.textCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCosto.Location = new System.Drawing.Point(98, 162);
            this.textCosto.Name = "textCosto";
            this.textCosto.Size = new System.Drawing.Size(92, 26);
            this.textCosto.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 89;
            this.label4.Text = "Costo:";
            // 
            // btnFloyd
            // 
            this.btnFloyd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFloyd.Location = new System.Drawing.Point(232, 340);
            this.btnFloyd.Name = "btnFloyd";
            this.btnFloyd.Size = new System.Drawing.Size(738, 37);
            this.btnFloyd.TabIndex = 88;
            this.btnFloyd.Text = "FLOYD WARSHALL";
            this.btnFloyd.UseVisualStyleBackColor = true;
            this.btnFloyd.Click += new System.EventHandler(this.btnFloyd_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(232, 136);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(738, 194);
            this.richTextBox1.TabIndex = 87;
            this.richTextBox1.Text = "";
            // 
            // btnMatriz
            // 
            this.btnMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatriz.Location = new System.Drawing.Point(232, 93);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(738, 37);
            this.btnMatriz.TabIndex = 86;
            this.btnMatriz.Text = "MATRIZ DE COSTO";
            this.btnMatriz.UseVisualStyleBackColor = true;
            this.btnMatriz.Click += new System.EventHandler(this.btnMatriz_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(54, 270);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 304);
            this.listBox1.TabIndex = 85;
            // 
            // textDestino
            // 
            this.textDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDestino.Location = new System.Drawing.Point(98, 130);
            this.textDestino.Name = "textDestino";
            this.textDestino.Size = new System.Drawing.Size(92, 26);
            this.textDestino.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 83;
            this.label3.Text = "Destino:";
            // 
            // btninsertar
            // 
            this.btninsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertar.Location = new System.Drawing.Point(69, 209);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(121, 37);
            this.btninsertar.TabIndex = 82;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // textOrigen
            // 
            this.textOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOrigen.Location = new System.Drawing.Point(98, 98);
            this.textOrigen.Name = "textOrigen";
            this.textOrigen.Size = new System.Drawing.Size(92, 26);
            this.textOrigen.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 80;
            this.label2.Text = "Origen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 31);
            this.label1.TabIndex = 79;
            this.label1.Text = "GRAFOS DIRIGIDOS";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(232, 383);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(738, 197);
            this.richTextBox2.TabIndex = 91;
            this.richTextBox2.Text = "";
            // 
            // textVertice
            // 
            this.textVertice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVertice.Location = new System.Drawing.Point(232, 49);
            this.textVertice.Name = "textVertice";
            this.textVertice.Size = new System.Drawing.Size(508, 26);
            this.textVertice.TabIndex = 92;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 20);
            this.label5.TabIndex = 93;
            this.label5.Text = "Ingrese número vertices::";
            // 
            // btnVertices
            // 
            this.btnVertices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVertices.Location = new System.Drawing.Point(768, 44);
            this.btnVertices.Name = "btnVertices";
            this.btnVertices.Size = new System.Drawing.Size(202, 37);
            this.btnVertices.TabIndex = 94;
            this.btnVertices.Text = "Insertar";
            this.btnVertices.UseVisualStyleBackColor = true;
            this.btnVertices.Click += new System.EventHandler(this.btnVertices_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 609);
            this.Controls.Add(this.btnVertices);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textVertice);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.textCosto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFloyd);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnMatriz);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textDestino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.textOrigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCosto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFloyd;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnMatriz;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.TextBox textOrigen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox textVertice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVertices;
    }
}

