namespace Aula11Polimorfismo
{
    public class Calculo
    {
        
        public string Calcular(){

            return "Não há calculo para ser aplicado";

        }

        public string Calcular(int pista){

            return $"A pista tem {pista} km";

        }

        public string Calcular(int pista, int bonus){

            return $"A pista com o bônus tem {pista+bonus} km";

        }

        public string Calcular(string nome, string sobrenome){
            return $"O nome completo do piloto é {nome} {sobrenome}";
        }

    }
}