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
                      
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int martillo = 0;  
            int serrucho = 0;
            int alicate = 0;
            int llave = 0;
            int resultado = 0;

            if (chbmartillos.Checked)
            {
                martillo = Convert.ToInt32(txtcantmartillos.Text);
                resultado = martillo * 75;
                txtsubmartillos.Text = resultado.ToString();
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

            

        }

        
    }
}