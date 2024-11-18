namespace ArbolBinarioApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAmplitud;
        private System.Windows.Forms.Button btnPreorden;
        private System.Windows.Forms.Button btnInorden;
        private System.Windows.Forms.Button btnPostorden;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Label lblTitulo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnAmplitud = new System.Windows.Forms.Button();
            this.btnPreorden = new System.Windows.Forms.Button();
            this.btnInorden = new System.Windows.Forms.Button();
            this.btnPostorden = new System.Windows.Forms.Button();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(180, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(210, 19);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Recorridos en Árbol Binario";

            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(50, 50);
            this.textBoxResultado.Multiline = true;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultado.Size = new System.Drawing.Size(450, 120);
            this.textBoxResultado.TabIndex = 4;

            // 
            // btnAmplitud
            // 
            this.btnAmplitud.BackColor = System.Drawing.Color.LightBlue;
            this.btnAmplitud.Location = new System.Drawing.Point(50, 200);
            this.btnAmplitud.Name = "btnAmplitud";
            this.btnAmplitud.Size = new System.Drawing.Size(100, 40);
            this.btnAmplitud.TabIndex = 0;
            this.btnAmplitud.Text = "Amplitud";
            this.btnAmplitud.UseVisualStyleBackColor = false;
            this.btnAmplitud.Click += new System.EventHandler(this.btnAmplitud_Click);

            // 
            // btnPreorden
            // 
            this.btnPreorden.BackColor = System.Drawing.Color.LightGreen;
            this.btnPreorden.Location = new System.Drawing.Point(170, 200);
            this.btnPreorden.Name = "btnPreorden";
            this.btnPreorden.Size = new System.Drawing.Size(100, 40);
            this.btnPreorden.TabIndex = 1;
            this.btnPreorden.Text = "Preorden";
            this.btnPreorden.UseVisualStyleBackColor = false;
            this.btnPreorden.Click += new System.EventHandler(this.btnPreorden_Click);

            // 
            // btnInorden
            // 
            this.btnInorden.BackColor = System.Drawing.Color.LightCoral;
            this.btnInorden.Location = new System.Drawing.Point(290, 200);
            this.btnInorden.Name = "btnInorden";
            this.btnInorden.Size = new System.Drawing.Size(100, 40);
            this.btnInorden.TabIndex = 2;
            this.btnInorden.Text = "Inorden";
            this.btnInorden.UseVisualStyleBackColor = false;
            this.btnInorden.Click += new System.EventHandler(this.btnInorden_Click);

            // 
            // btnPostorden
            // 
            this.btnPostorden.BackColor = System.Drawing.Color.Khaki;
            this.btnPostorden.Location = new System.Drawing.Point(410, 200);
            this.btnPostorden.Name = "btnPostorden";
            this.btnPostorden.Size = new System.Drawing.Size(100, 40);
            this.btnPostorden.TabIndex = 3;
            this.btnPostorden.Text = "Postorden";
            this.btnPostorden.UseVisualStyleBackColor = false;
            this.btnPostorden.Click += new System.EventHandler(this.btnPostorden_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(550, 280);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.btnPostorden);
            this.Controls.Add(this.btnInorden);
            this.Controls.Add(this.btnPreorden);
            this.Controls.Add(this.btnAmplitud);
            this.Name = "Form1";
            this.Text = "Árbol Binario - Recorridos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
