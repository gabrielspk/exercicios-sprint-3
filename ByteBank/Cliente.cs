namespace ByteBank {
    public class Cliente {
        public string Nome;
        public string Cpf;
        public string Email;
        public string Senha;
        public Cliente (string Nome, string Cpf, string Email) {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Email = Email;
        }
        public bool TrocaSenha (string senha) {
            if ((senha.Length > 6) && (senha.Length < 16)) {
                this.Senha = Senha;
                return true;
            } else {
                return false;
            }
        }
    }
}