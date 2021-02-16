namespace veiculo
{
    public class Proprietario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string DataNascimento {get; set;}

        public string DataCompra { get; set; }

        public Endereco endereco;

        public override string ToString()
        {
            return "\n<==Dados do Proprietario==>"+ 
                "\nNome do proprietario: " + Nome +
                   "\nCpf: " + Cpf +
                   "\nData de nascimento: " + DataNascimento +
                   "\nData de compra: " + DataCompra;         
        }

    }
}