using Microsoft.AspNetCore.Mvc;
using WebApiExemplosPOO.Model;

namespace WebApiExemplosPOO.Controllers
{
    public class ExemploEncapsulamentoContaCorrenteController : Controller
    {
        [HttpGet("ListarDadosCorrentista")]
        public string ListarDadosCorrentista(string nomeCorretistas, int numeroConta,
                                             double saldoCorrentista)
        {
            ContaCorrente contacorrente = new ContaCorrente();
            contacorrente.Titular = nomeCorretistas;
            contacorrente.Numero = numeroConta;
            //contacorrente.Saldo = saldoCorrentista;

            return $"Dados do Correntista\r\n" +
                   $"Titular :{contacorrente.Titular}\r\n" +
                   $"Número da conta : {contacorrente.Numero}\r\n" +
                   $"Saldo conta : {contacorrente.Saldo}";
        }

        [HttpPost("SacarValorCorrentista")]
        public string SacarValorCorrentista(string nomeCorretistas, int numeroConta,
                                             double valorSaque)
        {
            ContaCorrente contacorrente = new ContaCorrente();
            contacorrente.Titular = nomeCorretistas;
            contacorrente.Numero = numeroConta;
            if (contacorrente.Sacar(valorSaque))
            {
                return $"Dados do Correntista\r\n" +
                       $"Saque Autorizado\r\n" +
                       $"Titular :{contacorrente.Titular}\r\n" +
                       $"Número da conta : {contacorrente.Numero}\r\n" +
                       $"Valor Sacado R${valorSaque}" +
                       $"Saldo conta : {contacorrente.Saldo}";

            }
            else
            {
                return $"Dados do Correntista\r\n" +
                       $"Saque Não Autorizado\r\n" +
                       $"Titular :{contacorrente.Titular}\r\n" +
                       $"Número da conta : {contacorrente.Numero}\r\n" +
                       $"Saldo conta : {contacorrente.Saldo}";
            }

        }
        [HttpPost("DepositoValorCorrentista")]
        public string DepositoValorCorrentista(string nomeCorretistas, int numeroConta,
                                             double valorDeposito)
        {
            ContaCorrente contacorrente = new ContaCorrente();
            contacorrente.Titular = nomeCorretistas;
            contacorrente.Numero = numeroConta;
            contacorrente.Depositar(valorDeposito);
            return $"Dados do Correntista\r\n" +
                      $"Titular :{contacorrente.Titular}\r\n" +
                      $"Número da conta : {contacorrente.Numero}\r\n" +
                      $"Valor Depositado R${valorDeposito}\r\n" +
                      $"Saldo conta : {contacorrente.Saldo}";
            }
        }
}
