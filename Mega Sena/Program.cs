//3. Faça um programa que sorteie os seis números da mega sena e grave-os em um vetor ordenado; Imprima depois;

int size = 6, auxiliar;
int[] vetor_sorteado = new int[size];
int[] copia_sorteado = new int[size];
int[] vetor_sorteado_repetido = new int[size];
bool vetor_nao_copiado = false;

for (int i = 0; i < size; i++)
{
    vetor_sorteado[i] = new Random().Next(1, 61);

    do
    {
        for (int referencia = 0; referencia < size; referencia++)
        {
            for (int comparacao = referencia + 1; comparacao < size; comparacao++)
            {
                if (vetor_sorteado[referencia] == vetor_sorteado[comparacao])
                {
                    vetor_sorteado_repetido[i] = vetor_sorteado[i];
                    vetor_sorteado[i] = new Random().Next(1, 61);
                }
                else
                    vetor_nao_copiado = true;
            }
        }
    } while (vetor_nao_copiado != true);

    copia_sorteado[i] = vetor_sorteado[i];

} while (vetor_nao_copiado != true) ;

Console.WriteLine("Números sorteados, sem ordenação: ");
for (int x = 0; x < size; x++)
{
    Console.Write(copia_sorteado[x] + " ");
}

for (int referencia_2 = 0; referencia_2 < size; referencia_2++)
{
    for (int comparacao_2 = referencia_2 + 1; comparacao_2 < size; comparacao_2++)
    {
        for (int vetor_repetido = referencia_2 + 1; vetor_repetido < size; vetor_repetido++)
        {
            if (copia_sorteado[referencia_2] > copia_sorteado[comparacao_2])
            {
                auxiliar = copia_sorteado[referencia_2];
                copia_sorteado[referencia_2] = copia_sorteado[comparacao_2];
                copia_sorteado[comparacao_2] = auxiliar;
            }
        }
    }
}

Console.WriteLine("\nNúmeros sorteados em ordem crescente: ");
for (int x = 0; x < size; x++)
{
    Console.Write(copia_sorteado[x] + " ");
}