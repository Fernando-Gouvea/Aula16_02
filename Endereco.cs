namespace veiculo
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public override string ToString()
        {
            return "\n<==Endereço do proprietario==>"+ 
                   "\nLogradouro: "+Logradouro+
                   "\nNumero: " + Numero +
                   "\nCEP: " + Cep +
                   "\nCidade: " + Cidade +
                   "\nEstado: " + Estado;
        }
    }
}