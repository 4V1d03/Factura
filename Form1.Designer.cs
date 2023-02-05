namespace Ferreteria_los_Proceres
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltitulo = new System.Windows.Forms.Label();
            this.grbdetalleProducto = new System.Windows.Forms.GroupBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsubllave = new System.Windows.Forms.TextBox();
            this.txtsubalicate = new System.Windows.Forms.TextBox();
            this.txtsubserrucho = new System.Windows.Forms.TextBox();
            this.txtsubmartillos = new System.Windows.Forms.TextBox();
            this.txtcantllave = new System.Windows.Forms.TextBox();
            this.txtcantalicate = new System.Windows.Forms.TextBox();
            this.txtcantserrucho = new System.Windows.Forms.TextBox();
            this.txtcantmartillos = new System.Windows.Forms.TextBox();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.chbllave = new System.Windows.Forms.CheckBox();
            this.chbalicate = new System.Windows.Forms.CheckBox();
            this.chbserrucho = new System.Windows.Forms.CheckBox();
            this.chbmartillos = new System.Windows.Forms.CheckBox();
            this.btncerrar = new System.Windows.Forms.Button();
            this.grbdescuento = new System.Windows.Forms.GroupBox();
            this.btntotalpagar = new System.Windows.Forms.Button();
            this.txttotalapagar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdb50 = new System.Windows.Forms.RadioButton();
            this.rdb30 = new System.Windows.Forms.RadioButton();
            this.rdb15 = new System.Windows.Forms.RadioButton();
            this.rdb0 = new System.Windows.Forms.RadioButton();
            this.grbdetalleProducto.SuspendLayout();
            this.grbdescuento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltitulo.Location = new System.Drawing.Point(311, 13);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(291, 25);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Ferreteria Los \"Proceres\"";
            // 
            // grbdetalleProducto
            // 
            this.grbdetalleProducto.Controls.Add(this.btncalcular);
            this.grbdetalleProducto.Controls.Add(this.txtsubtotal);
            this.grbdetalleProducto.Controls.Add(this.label3);
            this.grbdetalleProducto.Controls.Add(this.txtsubllave);
            this.grbdetalleProducto.Controls.Add(this.txtsubalicate);
            this.grbdetalleProducto.Controls.Add(this.txtsubserrucho);
            this.grbdetalleProducto.Controls.Add(this.txtsubmartillos);
            this.grbdetalleProducto.Controls.Add(this.txtcantllave);
            this.grbdetalleProducto.Controls.Add(this.txtcantalicate);
            this.grbdetalleProducto.Controls.Add(this.txtcantserrucho);
            this.grbdetalleProducto.Controls.Add(this.txtcantmartillos);
            this.grbdetalleProducto.Controls.Add(this.lblsubtotal);
            this.grbdetalleProducto.Controls.Add(this.lblcantidad);
            this.grbdetalleProducto.Controls.Add(this.chbllave);
            this.grbdetalleProducto.Controls.Add(this.chbalicate);
            this.grbdetalleProducto.Controls.Add(this.chbserrucho);
            this.grbdetalleProducto.Controls.Add(this.chbmartillos);
            this.grbdetalleProducto.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grbdetalleProducto.Location = new System.Drawing.Point(30, 83);
            this.grbdetalleProducto.Name = "grbdetalleProducto";
            this.grbdetalleProducto.Size = new System.Drawing.Size(565, 339);
            this.grbdetalleProducto.TabIndex = 1;
            this.grbdetalleProducto.TabStop = false;
            this.grbdetalleProducto.Text = "Detalle Producto";
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.DodgerBlue;
            this.btncalcular.Location = new System.Drawing.Point(282, 285);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(100, 45);
            this.btncalcular.TabIndex = 16;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Location = new System.Drawing.Point(282, 245);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.ReadOnly = true;
            this.txtsubtotal.Size = new System.Drawing.Size(100, 28);
            this.txtsubtotal.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(172, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "SubTotal";
            // 
            // txtsubllave
            // 
            this.txtsubllave.Location = new System.Drawing.Point(411, 202);
            this.txtsubllave.Name = "txtsubllave";
            this.txtsubllave.ReadOnly = true;
            this.txtsubllave.Size = new System.Drawing.Size(100, 28);
            this.txtsubllave.TabIndex = 13;
            // 
            // txtsubalicate
            // 
            this.txtsubalicate.Location = new System.Drawing.Point(411, 155);
            this.txtsubalicate.Name = "txtsubalicate";
            this.txtsubalicate.ReadOnly = true;
            this.txtsubalicate.Size = new System.Drawing.Size(100, 28);
            this.txtsubalicate.TabIndex = 12;
            // 
            // txtsubserrucho
            // 
            this.txtsubserrucho.Location = new System.Drawing.Point(411, 107);
            this.txtsubserrucho.Name = "txtsubserrucho";
            this.txtsubserrucho.ReadOnly = true;
            this.txtsubserrucho.Size = new System.Drawing.Size(100, 28);
            this.txtsubserrucho.TabIndex = 11;
            // 
            // txtsubmartillos
            // 
            this.txtsubmartillos.Location = new System.Drawing.Point(411, 62);
            this.txtsubmartillos.Name = "txtsubmartillos";
            this.txtsubmartillos.ReadOnly = true;
            this.txtsubmartillos.Size = new System.Drawing.Size(100, 28);
            this.txtsubmartillos.TabIndex = 10;
            // 
            // txtcantllave
            // 
            this.txtcantllave.Location = new System.Drawing.Point(282, 202);
            this.txtcantllave.Name = "txtcantllave";
            this.txtcantllave.Size = new System.Drawing.Size(100, 28);
            this.txtcantllave.TabIndex = 9;
            // 
            // txtcantalicate
            // 
            this.txtcantalicate.Location = new System.Drawing.Point(282, 155);
            this.txtcantalicate.Name = "txtcantalicate";
            this.txtcantalicate.Size = new System.Drawing.Size(100, 28);
            this.txtcantalicate.TabIndex = 8;
            // 
            // txtcantserrucho
            // 
            this.txtcantserrucho.Location = new System.Drawing.Point(282, 107);
            this.txtcantserrucho.Name = "txtcantserrucho";
            this.txtcantserrucho.Size = new System.Drawing.Size(100, 28);
            this.txtcantserrucho.TabIndex = 7;
            // 
            // txtcantmartillos
            // 
            this.txtcantmartillos.Location = new System.Drawing.Point(282, 62);
            this.txtcantmartillos.Name = "txtcantmartillos";
            this.txtcantmartillos.Size = new System.Drawing.Size(100, 28);
            this.txtcantmartillos.TabIndex = 6;
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.AutoSize = true;
            this.lblsubtotal.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblsubtotal.Location = new System.Drawing.Point(423, 26);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(70, 16);
            this.lblsubtotal.TabIndex = 5;
            this.lblsubtotal.Text = "SubTotal";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcantidad.Location = new System.Drawing.Point(299, 26);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(71, 16);
            this.lblcantidad.TabIndex = 4;
            this.lblcantidad.Text = "Cantidad";
            // 
            // chbllave
            // 
            this.chbllave.AutoSize = true;
            this.chbllave.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbllave.Location = new System.Drawing.Point(24, 204);
            this.chbllave.Name = "chbllave";
            this.chbllave.Size = new System.Drawing.Size(204, 20);
            this.chbllave.TabIndex = 3;
            this.chbllave.Text = "Llave Ajustable L.150.00";
            this.chbllave.UseVisualStyleBackColor = true;
            // 
            // chbalicate
            // 
            this.chbalicate.AutoSize = true;
            this.chbalicate.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbalicate.Location = new System.Drawing.Point(24, 157);
            this.chbalicate.Name = "chbalicate";
            this.chbalicate.Size = new System.Drawing.Size(216, 20);
            this.chbalicate.TabIndex = 2;
            this.chbalicate.Text = "Alicate Universal L.125.00";
            this.chbalicate.UseVisualStyleBackColor = true;
            // 
            // chbserrucho
            // 
            this.chbserrucho.AutoSize = true;
            this.chbserrucho.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbserrucho.Location = new System.Drawing.Point(24, 109);
            this.chbserrucho.Name = "chbserrucho";
            this.chbserrucho.Size = new System.Drawing.Size(162, 20);
            this.chbserrucho.TabIndex = 1;
            this.chbserrucho.Text = "Serrucho L. 120.00";
            this.chbserrucho.UseVisualStyleBackColor = true;
            // 
            // chbmartillos
            // 
            this.chbmartillos.AutoSize = true;
            this.chbmartillos.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbmartillos.Location = new System.Drawing.Point(24, 63);
            this.chbmartillos.Name = "chbmartillos";
            this.chbmartillos.Size = new System.Drawing.Size(154, 20);
            this.chbmartillos.TabIndex = 0;
            this.chbmartillos.Text = "Martillos L. 75.00";
            this.chbmartillos.UseVisualStyleBackColor = true;
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.Red;
            this.btncerrar.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncerrar.Location = new System.Drawing.Point(805, 427);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(101, 45);
            this.btncerrar.TabIndex = 17;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // grbdescuento
            // 
            this.grbdescuento.Controls.Add(this.btntotalpagar);
            this.grbdescuento.Controls.Add(this.txttotalapagar);
            this.grbdescuento.Controls.Add(this.label1);
            this.grbdescuento.Controls.Add(this.rdb50);
            this.grbdescuento.Controls.Add(this.rdb30);
            this.grbdescuento.Controls.Add(this.rdb15);
            this.grbdescuento.Controls.Add(this.rdb0);
            this.grbdescuento.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grbdescuento.Location = new System.Drawing.Point(626, 83);
            this.grbdescuento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbdescuento.Name = "grbdescuento";
            this.grbdescuento.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbdescuento.Size = new System.Drawing.Size(280, 339);
            this.grbdescuento.TabIndex = 18;
            this.grbdescuento.TabStop = false;
            this.grbdescuento.Text = "Descuento";
            // 
            // btntotalpagar
            // 
            this.btntotalpagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btntotalpagar.Location = new System.Drawing.Point(68, 285);
            this.btntotalpagar.Name = "btntotalpagar";
            this.btntotalpagar.Size = new System.Drawing.Size(129, 45);
            this.btntotalpagar.TabIndex = 19;
            this.btntotalpagar.Text = "Calcular Total a Pagar";
            this.btntotalpagar.UseVisualStyleBackColor = false;
            this.btntotalpagar.Click += new System.EventHandler(this.btntotalpagar_Click);
            // 
            // txttotalapagar
            // 
            this.txttotalapagar.Location = new System.Drawing.Point(142, 251);
            this.txttotalapagar.Name = "txttotalapagar";
            this.txttotalapagar.ReadOnly = true;
            this.txttotalapagar.Size = new System.Drawing.Size(114, 28);
            this.txttotalapagar.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Total a Pagar";
            // 
            // rdb50
            // 
            this.rdb50.AutoSize = true;
            this.rdb50.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb50.Location = new System.Drawing.Point(25, 202);
            this.rdb50.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb50.Name = "rdb50";
            this.rdb50.Size = new System.Drawing.Size(56, 21);
            this.rdb50.TabIndex = 3;
            this.rdb50.TabStop = true;
            this.rdb50.Text = "50%";
            this.rdb50.UseVisualStyleBackColor = true;
            // 
            // rdb30
            // 
            this.rdb30.AutoSize = true;
            this.rdb30.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb30.Location = new System.Drawing.Point(25, 155);
            this.rdb30.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb30.Name = "rdb30";
            this.rdb30.Size = new System.Drawing.Size(56, 21);
            this.rdb30.TabIndex = 2;
            this.rdb30.TabStop = true;
            this.rdb30.Text = "30%";
            this.rdb30.UseVisualStyleBackColor = true;
            // 
            // rdb15
            // 
            this.rdb15.AutoSize = true;
            this.rdb15.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb15.Location = new System.Drawing.Point(25, 107);
            this.rdb15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb15.Name = "rdb15";
            this.rdb15.Size = new System.Drawing.Size(56, 21);
            this.rdb15.TabIndex = 1;
            this.rdb15.TabStop = true;
            this.rdb15.Text = "15%";
            this.rdb15.UseVisualStyleBackColor = true;
            // 
            // rdb0
            // 
            this.rdb0.AutoSize = true;
            this.rdb0.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb0.Location = new System.Drawing.Point(25, 62);
            this.rdb0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb0.Name = "rdb0";
            this.rdb0.Size = new System.Drawing.Size(46, 21);
            this.rdb0.TabIndex = 0;
            this.rdb0.TabStop = true;
            this.rdb0.Text = "0%";
            this.rdb0.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(936, 485);
            this.Controls.Add(this.grbdescuento);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.grbdetalleProducto);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Form1";
            this.Text = "Factura Ferreeria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbdetalleProducto.ResumeLayout(false);
            this.grbdetalleProducto.PerformLayout();
            this.grbdescuento.ResumeLayout(false);
            this.grbdescuento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        
        private Label lbltitulo;
        private GroupBox grbdetalleProducto;
        private Label lblsubtotal;
        private Label lblcantidad;
        private CheckBox chbllave;
        private CheckBox chbalicate;
        private CheckBox chbserrucho;
        private CheckBox chbmartillos;
        private Button btncalcular;
        private TextBox txtsubtotal;
        private Label label3;
        private TextBox txtsubllave;
        private TextBox txtsubalicate;
        private TextBox txtsubserrucho;
        private TextBox txtsubmartillos;
        private TextBox txtcantllave;
        private TextBox txtcantalicate;
        private TextBox txtcantserrucho;
        private TextBox txtcantmartillos;
        private Button btncerrar;
        private GroupBox grbdescuento;
        private Button btntotalpagar;
        private TextBox txttotalapagar;
        private Label label1;
        private RadioButton rdb50;
        private RadioButton rdb30;
        private RadioButton rdb15;
        private RadioButton rdb0;
    }
}