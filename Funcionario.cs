namespace WebApiExemplosPOO.Model
{
    public class Funcionario
    {
        public string nome;
        public string sexo;
        public int idade;
        public double salario;

        public double CalcularDecimoTerceiro(int mesesTrabalhados)
        {
            double decimoTerceiro;
            decimoTerceiro = salario * mesesTrabalhados / 12;
            return decimoTerceiro;
        }
        public double CalcularFerias()
        {
            double ferias = salario + (salario / 3);
            return ferias;
        }
    }
}
