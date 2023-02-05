namespace Ferreteria_los_Proceres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();//centra el formulario
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink; //inhabilta modificar el tamaño del formulario
            this.ControlBox = false; //elimina la barra de control de arriba
                      
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int martillo = 0;  
            int serrucho = 0;
            int alicate = 0;
            int llave = 0;
            int resultado = 0;
            int subtotal = 0;

            txtsubmartillos.Text = "0";
            txtsubserrucho.Text = "0";
            txtsubalicate.Text = "0";
            txtsubllave.Text = "0";

            if (chbmartillos.Checked)
            {
                martillo = Convert.ToInt32(txtcantmartillos.Text);
                resultado = martillo * 75;
                txtsubmartillos.Text = resultado.ToString(); //muestra el precio a pagar por cada producto
            }
            if (chbserrucho.Checked)
            {
                serrucho = Convert.ToInt32(txtcantserrucho.Text);
                resultado = serrucho * 120;
                txtsubserrucho.Text = resultado.ToString();
            }
            if (chbalicate.Checked)
            {
                alicate = Convert.ToInt32(txtcantalicate.Text);
                resultado = alicate * 125;
                txtsubalicate.Text = resultado.ToString();
            }
            if (chbllave.Checked)
            {
                llave = Convert.ToInt32(txtcantllave.Text);
                resultado = llave * 150;
                txtsubllave.Text = resultado.ToString();
            }

            
            subtotal = Convert.ToInt32(txtsubmartillos.Text) + Convert.ToInt32(txtsubserrucho.Text) 
                       + Convert.ToInt32(txtsubalicate.Text) + Convert.ToInt32(txtsubllave.Text);
            txtsubtotal.Text= subtotal.ToString();
        }

        private void btntotalpagar_Click(object sender, EventArgs e)
        {
            int subtotal = Convert.ToInt32(txtsubtotal.Text);
            double impuesto = .15;
            double totalpagar = 0;
            totalpagar = (subtotal * impuesto) + subtotal; //calculo y la suma del 15% del subtotal

            if (rdb0.Checked)
            {
                txttotalapagar.Text = totalpagar.ToString();
            }
   
            if (rdb15.Checked)
            {
                totalpagar = totalpagar - (totalpagar * .15);//calculo del descuento asignado, se representa como el total a apagar por el cliente 
                txttotalapagar.Text = totalpagar.ToString();
            }

            if (rdb30.Checked)
            {
                totalpagar = totalpagar - (totalpagar * .30);
                txttotalapagar.Text = totalpagar.ToString();
            }

            if (rdb50.Checked)
            {
                totalpagar = totalpagar - (totalpagar * .50);
                txttotalapagar.Text = totalpagar.ToString();
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close(); //cierra el formulario 
        }
    }
}