using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veiculo
{
    class veiculo
    {
        public int Renavan { get; set;}
        public string Chassi { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Ano { get; set; }
        

        public Proprietario proprietario;

        public override string ToString()
        {
            return ("<==Dados do Veiculo==>"+
                    "\nChassi: " + Chassi +
                    "\nPlaca: " + Placa +
                    "\nMarca: " + Marca +
                    "\nModelo: " + Modelo +
                    "\nCor: " + Cor + 
                    "\nAno: " + Ano);
           
        }






    }
}
