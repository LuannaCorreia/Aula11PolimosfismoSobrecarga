namespace Aula11PolimosfismoSobrecarga
{
    public class Calculo
    {
         //Várias possibilidades de chamar um método
        public string Calcular() {
            return "Nulo, pois faltam operadores.";
        }

        public int Calcular(int n1, int n2, char op) {
            switch (op) {
                case '+':
                    return n1+n2;
                case '-':
                    return n1-n2;
                case 'x':
                case '*':
                    return n1*n2;
                case '/':
                    if (n2!=0) 
                        return n1/n2;
                    else 
                        return n2;
            }
            return op;
        }

        public bool Calcular(string expressaoNumerica) {
            if (expressaoNumerica == "")
                return false;
            return true;
        }
    }
}