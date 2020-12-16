namespace Lista_de_Objetos.classes        
{
    public class Cartao
    {
        public string Titular {get; set;}
        public int Numero {get; set;}
        public string Bandeira {get; set;}
        public int Vencimento {get; set;}
        public int CVV {get; set;}

        public Cartao(){

        }

        public Cartao(string Titular, int Numero, string Bandeira, int Vencimento, int CVV){
            this.Titular = Titular;
            this.Numero = Numero;
            this.Bandeira = Bandeira;
            this.Vencimento = Vencimento;
            this.CVV = CVV;
        }

        public Cartao(int v1, string v2)
        {
        }
    }
}