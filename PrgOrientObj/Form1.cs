using System.Diagnostics;

namespace PrgOrientObj
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Calculadora_Load_1(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(OP1.Text);
            double num2 = double.Parse(OP2.Text);

            // Obtenemos la operación seleccionada del ComboBox
            string operacion = comboBox1.SelectedItem.ToString();

            // Realizamos la operación correspondiente
            double resultado = 0;
            switch (operacion)
            {
                case "+ Suma":
                    resultado = num1 + num2;
                    break;
                case "- Resta":
                    resultado = num1 - num2;
                    break;
                case "x Multiplicar":
                    resultado = num1 * num2;
                    break;
                case "/ Dividir":
                    resultado = num1 / num2;
                    break;
            }

            // Mostramos el resultado en el txt
            txtResult.Text = resultado.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Operar_Click(object sender, EventArgs e)
        {
            string operacion = ComboBoxText.SelectedItem.ToString();

            // Obtener las tres cadenas de texto de los TextBox
            string cadena1 = text1.Text;
            string cadena2 = text2.Text;
            string cadena3 = text3.Text;

            // Realizar la operación seleccionada en el ComboBox
            switch (operacion)
            {
                case "Concatenar":
                    string resultadoConcatenar = cadena1 + cadena2 + cadena3;
                    resultado2.Text = resultadoConcatenar;
                    break;
                case "Reemplazar":
                    string resultadoReemplazar = cadena1.Replace(cadena2, cadena3);
                    resultado2.Text = resultadoReemplazar;
                    break;
                case "Longitud":
                    int resultadoLongitud = cadena1.Length + cadena2.Length + cadena3.Length;
                    resultado2.Text = resultadoLongitud.ToString();
                    break;
                case "Mayusculas":
                    string resultadoMayusculas = cadena1.ToUpper() + cadena2.ToUpper() + cadena3.ToUpper();
                    resultado2.Text = resultadoMayusculas;
                    break;
                case "Minusculas":
                    string resultadoMinusculas = cadena1.ToLower() + cadena2.ToLower() + cadena3.ToLower();
                    resultado2.Text = resultadoMinusculas;
                    break;
                case "Comparar":
                    int resultadoComparar = string.Compare(cadena1, cadena2, true);
                    resultado2.Text = resultadoComparar.ToString();
                    break;
                default:
                    resultado2.Text = "Seleccione una operación válida";
                    break;
            }
        }
    }
}
