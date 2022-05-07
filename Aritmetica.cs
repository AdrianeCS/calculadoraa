public class Aritmentica
{
public static double Soma(double parcela1, double parecla2)
{
    double total = parcela1 + parecla2;
    return total;
}

public static double Subtração (double minuendo, double subtraendo)
{
    double diferenca = minuendo - subtraendo;
    return diferenca;
}
public static double Multiplicação(double fator1, double fator2)
{
    double produto = fator1 + fator2;
    return produto;
}

public static double Divisão(double dividendo, double divisor)
{
    if(divisor == 0)
    {
        throw new Exception("nãp é possível dividir por zero");
    }
    double quociente = dividendo / divisor;
    return quociente;
}
}