namespace WebApiExemplosPOO.Model
{
    public class ContaCorrente
    {
        private int numero;
        private string titular;
        private double saldo = 1000;

        public int Numero { get => numero; set => numero = value; }
        public string Titular { get => titular; set => titular = value; }
        public double Saldo { get => saldo; private set => saldo = value; }

        public bool Sacar(double valor)
        {
            if (valor < saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return true;
            }
        }
        public void Depositar(double valor)
        {
            saldo += valor;
        }
        public void AlterarNomePessoa(string novoNome)
        {
            titular = novoNome;
        }
        public double consultarSaldo()
        {
            return saldo;
        }
    }
}
