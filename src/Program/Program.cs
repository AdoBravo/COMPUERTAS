namespace Program;

class GarageGate
{
    private CompuertaAND compuertaAND1;
    private CompuertaAND compuertaAND2;
    private CompuertaOR compuertaOR;
    private CompuertaNOT compuertaNOT_A;
    private CompuertaNOT compuertaNOT_B;

    public GarageGate()
    {
        // Crear las compuertas necesarias
        compuertaAND1 = new CompuertaAND();
        compuertaAND2 = new CompuertaAND();
        compuertaOR = new CompuertaOR();
        compuertaNOT_A = new CompuertaNOT();
        compuertaNOT_B = new CompuertaNOT();
    }

    public bool AbrirPuerta(int A, int B, int C)
    {
        // Condición 1: C pulsado, A y B en reposo
        compuertaNOT_A.AgregarEntrada(A);
        int notA = compuertaNOT_A.Calcular();

        compuertaNOT_B.AgregarEntrada(B);
        int notB = compuertaNOT_B.Calcular();

        compuertaAND1.AgregarEntrada(notA);
        compuertaAND1.AgregarEntrada(notB);
        compuertaAND1.AgregarEntrada(C);
        int resultado1 = compuertaAND1.Calcular();

        // Condición 2: A, B y C pulsados
        compuertaAND2.AgregarEntrada(A);
        compuertaAND2.AgregarEntrada(B);
        compuertaAND2.AgregarEntrada(C);
        int resultado2 = compuertaAND2.Calcular();

        // Resultado final con la compuerta OR
        compuertaOR.AgregarEntrada(resultado1);
        compuertaOR.AgregarEntrada(resultado2);
        int resultadoFinal = compuertaOR.Calcular();

        // Si el resultado final es 1, la puerta se abre (true)
        return resultadoFinal == 1;
    }
}