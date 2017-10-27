namespace GestionHotel.Vista
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnSalidas = new System.Windows.Forms.Button();
            this.btnEntradas = new System.Windows.Forms.Button();
            this.btnNuevaReserva = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnEstancias = new System.Windows.Forms.Button();
            this.tbDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(74, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "OTEL SOFTWARE";
            // 
            // pictureBox1
            // 
//            this.pictureBox1.Image = global::GestionHotel.Properties.Resources.H_Store_logo2;
//            this.pictureBox1.InitialImage = global::GestionHotel.Properties.Resources.H_Store_logo2;
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Californian FB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(1160, 15);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 54);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.Location = new System.Drawing.Point(929, 15);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(75, 54);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnSalidas
            // 
            this.btnSalidas.Image = ((System.Drawing.Image)(resources.GetObject("btnSalidas.Image")));
            this.btnSalidas.Location = new System.Drawing.Point(818, 14);
            this.btnSalidas.Name = "btnSalidas";
            this.btnSalidas.Size = new System.Drawing.Size(78, 54);
            this.btnSalidas.TabIndex = 4;
            this.btnSalidas.Text = "Salidas Hoy";
            this.btnSalidas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalidas.UseVisualStyleBackColor = true;
            // 
            // btnEntradas
            // 
            this.btnEntradas.Image = ((System.Drawing.Image)(resources.GetObject("btnEntradas.Image")));
            this.btnEntradas.Location = new System.Drawing.Point(686, 14);
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Size = new System.Drawing.Size(93, 54);
            this.btnEntradas.TabIndex = 3;
            this.btnEntradas.Text = "Entradas Hoy";
            this.btnEntradas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEntradas.UseVisualStyleBackColor = true;
            // 
            // btnNuevaReserva
            // 
            this.btnNuevaReserva.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevaReserva.Image")));
            this.btnNuevaReserva.Location = new System.Drawing.Point(561, 15);
            this.btnNuevaReserva.Name = "btnNuevaReserva";
            this.btnNuevaReserva.Size = new System.Drawing.Size(92, 54);
            this.btnNuevaReserva.TabIndex = 2;
            this.btnNuevaReserva.Text = "Nueva Reserva";
            this.btnNuevaReserva.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevaReserva.UseVisualStyleBackColor = true;
            // 
            // btnReservas
            // 
            this.btnReservas.Image = ((System.Drawing.Image)(resources.GetObject("btnReservas.Image")));
            this.btnReservas.Location = new System.Drawing.Point(448, 15);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(81, 54);
            this.btnReservas.TabIndex = 1;
            this.btnReservas.Text = "Reservas";
            this.btnReservas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReservas.UseVisualStyleBackColor = true;
            this.btnReservas.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEstancias
            // 
            this.btnEstancias.BackColor = System.Drawing.Color.Transparent;
            this.btnEstancias.Image = ((System.Drawing.Image)(resources.GetObject("btnEstancias.Image")));
            this.btnEstancias.Location = new System.Drawing.Point(325, 15);
            this.btnEstancias.Name = "btnEstancias";
            this.btnEstancias.Size = new System.Drawing.Size(86, 54);
            this.btnEstancias.TabIndex = 0;
            this.btnEstancias.Text = "Estancias";
            this.btnEstancias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEstancias.UseVisualStyleBackColor = false;
            this.btnEstancias.Click += new System.EventHandler(this.btnEstancias_Click);
            // 
            // tbDatos
            // 
            this.tbDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbDatos.Location = new System.Drawing.Point(30, 129);
            this.tbDatos.Name = "tbDatos";
            this.tbDatos.Size = new System.Drawing.Size(1208, 829);
            this.tbDatos.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1272, 754);
            this.Controls.Add(this.tbDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnSalidas);
            this.Controls.Add(this.btnEntradas);
            this.Controls.Add(this.btnNuevaReserva);
            this.Controls.Add(this.btnReservas);
            this.Controls.Add(this.btnEstancias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Hotel Software";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEstancias;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnNuevaReserva;
        private System.Windows.Forms.Button btnEntradas;
        private System.Windows.Forms.Button btnSalidas;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tbDatos;
    }
}