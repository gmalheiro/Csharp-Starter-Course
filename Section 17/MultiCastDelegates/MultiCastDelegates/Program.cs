using MultiCastDelegates.Services;

namespace MultiCastDelegates
{
    public class Program
    {
        // Multicast delegates são delegates que guardam a referência para mais de um método
        // Para adicionar uma referência, pode-se usar o operador += 
        // A chamada Invoke executa  todos os métodos na ordem em que foram adicionados
        // Como todos os métodos vão ser adicionados, não faz muito sentido trabalharmos com métodos que retornam valor
        // Seu uso faz sentido para métodos void

        delegate void BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {
            double n1 = 10;
            double n2 = 12;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;
            //op.Invoke(n1, n2);
            op(n1,n2);
        }
    }
}