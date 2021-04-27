
using ByteBankException;
using System;

namespace ByteBankExceptions
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; }
        public int Numero { get; }

        private double _saldo = 100;

        public static double TaxaOperacao { get; private set; }

        public static int TotalDeContasCriadas { get; private set; }

        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0) throw new ArgumentException("Agencia deve ser maior que 0" , nameof(agencia));
            if (numero <= 0) throw new ArgumentException("Numero da conta deve ser maior que 0 ",nameof(numero));
            
            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;

        }

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0) return;
                _saldo = value;
            }
        }

        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido", nameof(valor));
            }
            if (_saldo < valor)
            {
                 throw new SaldoInsuficienteException(Saldo,valor);

            }
            _saldo -= valor;
            
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }
        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor< 0)
            {
                throw new ArgumentException("Valor inválido para transferencia!", nameof(valor));
            }

            Sacar (valor);
            contaDestino.Depositar(valor);

        }
    }
}
