public static string ConvertirBase(int x, int k)
{
    string resultado = "";

    while (x > 0)
    {
        int residuo = x % k;
        x = x / k;
        resultado = residuo.ToString() + resultado;
    }

    return resultado;
}

int x = 287;
int k = 4;
string resultado = ConvertirBase(x, k);
Console.WriteLine(resultado);