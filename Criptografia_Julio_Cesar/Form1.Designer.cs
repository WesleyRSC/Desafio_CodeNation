namespace Criptografia_Julio_Cesar
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
            this.btnReceberDados = new System.Windows.Forms.Button();
            this.btnDescriptografar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtDados = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReceberDados
            // 
            this.btnReceberDados.Location = new System.Drawing.Point(12, 12);
            this.btnReceberDados.Name = "btnReceberDados";
            this.btnReceberDados.Size = new System.Drawing.Size(75, 23);
            this.btnReceberDados.TabIndex = 0;
            this.btnReceberDados.Text = "Receber";
            this.btnReceberDados.UseVisualStyleBackColor = true;
            this.btnReceberDados.Click += new System.EventHandler(this.btnReceberDados_Click);
            // 
            // btnDescriptografar
            // 
            this.btnDescriptografar.Location = new System.Drawing.Point(111, 12);
            this.btnDescriptografar.Name = "btnDescriptografar";
            this.btnDescriptografar.Size = new System.Drawing.Size(95, 23);
            this.btnDescriptografar.TabIndex = 1;
            this.btnDescriptografar.Text = "Descriptografar";
            this.btnDescriptografar.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(230, 12);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // txtDados
            // 
            this.txtDados.Location = new System.Drawing.Point(12, 54);
            this.txtDados.Multiline = true;
            this.txtDados.Name = "txtDados";
            this.txtDados.Size = new System.Drawing.Size(293, 273);
            this.txtDados.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 384);
            this.Controls.Add(this.txtDados);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnDescriptografar);
            this.Controls.Add(this.btnReceberDados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReceberDados;
        private System.Windows.Forms.Button btnDescriptografar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtDados;
    }
}

