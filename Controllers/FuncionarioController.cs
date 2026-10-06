using Microsoft.AspNetCore.Mvc;
using WebApiExemplosPOO.Model;

namespace WebApiExemplosPOO.Controllers
{
    public class FuncionarioController : Controller
    {
        [HttpGet("ListarDadosFuncionario")]
        public string ListarDadosFuncionario(string nomeFuncionario,
                                             string sexoFuncionario, int idadeFuncioanrio,
                                             double salarioFuncionario)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.nome = nomeFuncionario;
            funcionario.sexo = sexoFuncionario;
            funcionario.idade = idadeFuncioanrio;
            funcionario.salario = salarioFuncionario;
            return $"#########DADOS FUNCIONÁRIO\"#########\r\n" +
                $"Nome Funcionário : {funcionario.nome}\r\n" +
                $"Sexo Funcionário : {funcionario.sexo}\r\n" +
                $"idade Funcionário : {funcionario.idade}\r\n" +
                $"Salário Funcionário : {funcionario.salario}";
        }
        [HttpPost("CalcularDecimoTerceiro")]
        public string CalcularDecimoTerceiro(string nomeFuncionario,
                                             string sexoFuncionario, int idadeFuncioanrio,
                                             double salarioFuncionario, int mesesTrabalhados)
        {
            Funcionario funcionario = new Funcionario();
            double decimoTerceiro;
            funcionario.nome = nomeFuncionario;
            funcionario.sexo = sexoFuncionario;
            funcionario.idade = idadeFuncioanrio;
            funcionario.salario = salarioFuncionario;

            decimoTerceiro = funcionario.CalcularDecimoTerceiro(mesesTrabalhados);
            return $"#########Décimo Terceiro do Funcionário\"#########\r\n" +
                   $"Nome Funcionário    : {funcionario.nome}\r\n" +
                   $"Sexo Funcionário    : {funcionario.sexo}\r\n" +
                   $"idade Funcionário   : {funcionario.idade}\r\n" +
                   $"Salário Funcionário : R${funcionario.salario}\r\n" + 
                   $"Décimo Terceiro     | R${Math.Round(decimoTerceiro, 2)}";
        }
        [HttpPost("CalcularFeriasFuncionario")]
        public string CalcularFeriasFuncionario(string nomeFuncionario,
                                      string sexoFuncionario, int idadeFuncioanrio,
                                      double salarioFuncionario)
        {
            Funcionario funcionario = new Funcionario();
            double ferias;
            funcionario.nome = nomeFuncionario;
            funcionario.sexo = sexoFuncionario;
            funcionario.idade = idadeFuncioanrio;
            funcionario.salario = salarioFuncionario;

            ferias = funcionario.CalcularFerias();
            return $"#########Ferias do Funcionário#########\r\n" +
                   $"Nome Funcionário     : {funcionario.nome}\r\n" +
                   $"Sexo Funcionário     : {funcionario.sexo}\r\n" +
                   $"idade Funcionário    : {funcionario.idade}\r\n" +
                   $"Salário Funcionário  : R${funcionario.salario}\r\n" +
                   $"Férias do funcionário: R${Math.Round(ferias,2)}";

        }
    }
}
