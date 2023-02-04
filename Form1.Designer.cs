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
            this.button2 = new System.Windows.Forms.Button();
            this.grbdescuento = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.grbdetalleProducto.SuspendLayout();
            this.grbdescuento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltitulo.Location = new System.Drawing.Point(355, 22);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(360, 34);
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
            this.grbdetalleProducto.Location = new System.Drawing.Point(34, 115);
            this.grbdetalleProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbdetalleProducto.Name = "grbdetalleProducto";
            this.grbdetalleProducto.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbdetalleProducto.Size = new System.Drawing.Size(646, 452);
            this.grbdetalleProducto.TabIndex = 1;
            this.grbdetalleProducto.TabStop = false;
            this.grbdetalleProducto.Text = "Detalle Producto";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(322, 380);
            this.btncalcular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(114, 60);
            this.btncalcular.TabIndex = 16;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Location = new System.Drawing.Point(322, 327);
            this.txtsubtotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.ReadOnly = true;
            this.txtsubtotal.Size = new System.Drawing.Size(114, 33);
            this.txtsubtotal.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(197, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "SubTotal";
            // 
            // txtsubllave
            // 
            this.txtsubllave.Location = new System.Drawing.Point(470, 270);
            this.txtsubllave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsubllave.Name = "txtsubllave";
            this.txtsubllave.ReadOnly = true;
            this.txtsubllave.Size = new System.Drawing.Size(114, 33);
            this.txtsubllave.TabIndex = 13;
            // 
            // txtsubalicate
            // 
            this.txtsubalicate.Location = new System.Drawing.Point(470, 207);
            this.txtsubalicate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsubalicate.Name = "txtsubalicate";
            this.txtsubalicate.ReadOnly = true;
            this.txtsubalicate.Size = new System.Drawing.Size(114, 33);
            this.txtsubalicate.TabIndex = 12;
            // 
            // txtsubserrucho
            // 
            this.txtsubserrucho.Location = new System.Drawing.Point(470, 143);
            this.txtsubserrucho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsubserrucho.Name = "txtsubserrucho";
            this.txtsubserrucho.ReadOnly = true;
            this.txtsubserrucho.Size = new System.Drawing.Size(114, 33);
            this.txtsubserrucho.TabIndex = 11;
            // 
            // txtsubmartillos
            // 
            this.txtsubmartillos.Location = new System.Drawing.Point(470, 82);
            this.txtsubmartillos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsubmartillos.Name = "txtsubmartillos";
            this.txtsubmartillos.ReadOnly = true;
            this.txtsubmartillos.Size = new System.Drawing.Size(114, 33);
            this.txtsubmartillos.TabIndex = 10;
            // 
            // txtcantllave
            // 
            this.txtcantllave.Location = new System.Drawing.Point(322, 270);
            this.txtcantllave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcantllave.Name = "txtcantllave";
            this.txtcantllave.Size = new System.Drawing.Size(114, 33);
            this.txtcantllave.TabIndex = 9;
            // 
            // txtcantalicate
            // 
            this.txtcantalicate.Location = new System.Drawing.Point(322, 207);
            this.txtcantalicate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcantalicate.Name = "txtcantalicate";
            this.txtcantalicate.Size = new System.Drawing.Size(114, 33);
            this.txtcantalicate.TabIndex = 8;
            // 
            // txtcantserrucho
            // 
            this.txtcantserrucho.Location = new System.Drawing.Point(322, 143);
            this.txtcantserrucho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcantserrucho.Name = "txtcantserrucho";
            this.txtcantserrucho.Size = new System.Drawing.Size(114, 33);
            this.txtcantserrucho.TabIndex = 7;
            // 
            // txtcantmartillos
            // 
            this.txtcantmartillos.Location = new System.Drawing.Point(322, 82);
            this.txtcantmartillos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcantmartillos.Name = "txtcantmartillos";
            this.txtcantmartillos.Size = new System.Drawing.Size(114, 33);
            this.txtcantmartillos.TabIndex = 6;
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.AutoSize = true;
            this.lblsubtotal.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblsubtotal.Location = new System.Drawing.Point(483, 35);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(91, 21);
            this.lblsubtotal.TabIndex = 5;
            this.lblsubtotal.Text = "SubTotal";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcantidad.Location = new System.Drawing.Point(342, 35);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(93, 21);
            this.lblcantidad.TabIndex = 4;
            this.lblcantidad.Text = "Cantidad";
            // 
            // chbllave
            // 
            this.chbllave.AutoSize = true;
            this.chbllave.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbllave.Location = new System.Drawing.Point(27, 272);
            this.chbllave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbllave.Name = "chbllave";
            this.chbllave.Size = new System.Drawing.Size(260, 25);
            this.chbllave.TabIndex = 3;
            this.chbllave.Text = "Llave Ajustable L.150.00";
            this.chbllave.UseVisualStyleBackColor = true;
            // 
            // chbalicate
            // 
            this.chbalicate.AutoSize = true;
            this.chbalicate.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbalicate.Location = new System.Drawing.Point(27, 209);
            this.chbalicate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbalicate.Name = "chbalicate";
            this.chbalicate.Size = new System.Drawing.Size(275, 25);
            this.chbalicate.TabIndex = 2;
            this.chbalicate.Text = "Alicate Universal L.125.00";
            this.chbalicate.UseVisualStyleBackColor = true;
            // 
            // chbserrucho
            // 
            this.chbserrucho.AutoSize = true;
            this.chbserrucho.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbserrucho.Location = new System.Drawing.Point(27, 145);
            this.chbserrucho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbserrucho.Name = "chbserrucho";
            this.chbserrucho.Size = new System.Drawing.Size(207, 25);
            this.chbserrucho.TabIndex = 1;
            this.chbserrucho.Text = "Serrucho L. 120.00";
            this.chbserrucho.UseVisualStyleBackColor = true;
            // 
            // chbmartillos
            // 
            this.chbmartillos.AutoSize = true;
            this.chbmartillos.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbmartillos.Location = new System.Drawing.Point(27, 84);
            this.chbmartillos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbmartillos.Name = "chbmartillos";
            this.chbmartillos.Size = new System.Drawing.Size(195, 25);
            this.chbmartillos.TabIndex = 0;
            this.chbmartillos.Text = "Martillos L. 75.00";
            this.chbmartillos.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(950, 580);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 31);
            this.button2.TabIndex = 17;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // grbdescuento
            // 
            this.grbdescuento.Controls.Add(this.button1);
            this.grbdescuento.Controls.Add(this.textBox1);
            this.grbdescuento.Controls.Add(this.label1);
            this.grbdescuento.Controls.Add(this.radioButton4);
            this.grbdescuento.Controls.Add(this.radioButton3);
            this.grbdescuento.Controls.Add(this.radioButton2);
            this.grbdescuento.Controls.Add(this.radioButton1);
            this.grbdescuento.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grbdescuento.Location = new System.Drawing.Point(716, 115);
            this.grbdescuento.Name = "grbdescuento";
            this.grbdescuento.Size = new System.Drawing.Size(320, 452);
            this.grbdescuento.TabIndex = 18;
            this.grbdescuento.TabStop = false;
            this.grbdescuento.Text = "Descuento";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 380);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 60);
            this.button1.TabIndex = 19;
            this.button1.Text = "Calcular Total a Pagar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 335);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(130, 34);
            this.textBox1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Total a Pagar";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton4.Location = new System.Drawing.Point(29, 270);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(67, 25);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "50%";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton3.Location = new System.Drawing.Point(29, 207);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(67, 25);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "30%";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(29, 143);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 25);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "15%";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(29, 82);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 25);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "0%";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 633);
            this.Controls.Add(this.grbdescuento);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grbdetalleProducto);
            this.Controls.Add(this.lbltitulo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private Button button2;
        private GroupBox grbdescuento;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}