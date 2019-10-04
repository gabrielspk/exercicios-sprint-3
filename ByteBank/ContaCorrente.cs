namespace ByteBank {
    public class ContaCorrente {
        //*!ISSO É UM MÉTODO */
        public string Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public ContaCorrente (string Titular, int Agencia, int Numero) {
            this.Agencia = Agencia;
            this.Titular = Titular;
            this.Numero = Numero;
            this.Saldo = 0.0;
        }

        public double Deposito (double valor) {
            return this.Saldo += valor;
        }

        public bool saque(double valor){
            if(Saldo >= valor){
                Saldo -= valor;
                return true;
            } else {
                return false;
            }
        }

        public bool transferencia(ContaCorrente contaDestino, double valor){
            if(this.saque(valor)){
                contaDestino.Deposito(valor);
                return true;
            } else {
                return false;
            }
        }
            
    }
}