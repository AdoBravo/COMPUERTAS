namespace Library;

class CompuertaAND : Compuerta
{
    private List<object> entradas = new List<object>();

    public override void AgregarEntrada(object valor)
    {
        entradas.Add(valor);
    }

    public override int Calcular()
    {
        int resultado = 1;
        foreach (var entrada in entradas)
        {
            if ((int)entrada == 0)
            {
                resultado = 0;
                break;
            }
        }
        return resultado;
    }
}

class CompuertaOR : Compuerta
{
    private List<object> entradas = new List<object>();

    public override void AgregarEntrada(object valor)
    {
        entradas.Add(valor);
    }

    public override int Calcular()
    {
        int resultado = 0;
        foreach (var entrada in entradas)
        {
            if ((int)entrada == 1)
            {
                resultado = 1;
                break;
            }
        }
        return resultado;
    }
}

class CompuertaNOT : Compuerta
{
    private object entrada;

    public override void AgregarEntrada(object valor)
    {
        entrada = valor;
    }

    public override int Calcular()
    {
        return (int)entrada == 1 ? 0 : 1;
    }
}