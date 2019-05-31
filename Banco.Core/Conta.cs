using System;

namespace Banco.Core
{
    public class Conta
    {
        public int Numero { get; set; }

        public double Saldo { get; set; }

        public Cliente Titular { get; set; }

        public void Deposita(double valor)
        {
            throw new NotImplementedException();
        }
    }
}