namespace WebApiExemplosPOO.Model
{
    public class ExemploAutoPropriedadeContaCorrentecs
    {
        public string Titular { get; set; }
        public string Numero { get; set; }
        public double Saldo { get; private set; }
        public bool Sacar(double valor)
        {
            if (valor < Saldo)
            {
                Saldo -= valor;
                return true;
            }
            else
            {
                return true;
            }
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        public void AlterarNomePessoa(string novoNome)
        {
            Titular = novoNome;
        }
        public double consultarSaldo()
        {
            return Saldo;
        }
    }
}

