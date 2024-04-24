//3. Faça um programa que sorteie os seis números da mega sena e grave-os em um vetor ordenado; Imprima depois;

int size = 6, auxiliar, auxiliar_vetor_3;
int[] vetor_original = new int[size];
int[] segundo_vetor = new int[size];
int[] verificacao_vetor_repetido = new int[size];
bool vetor_nao_copiado = false;

for (int i = 0; i < size; i++)
{
    vetor_original[i] = new Random().Next(0, 100);

    do
    {
        for (int referencia = 0; referencia < size; referencia++)
        {
            for (int comparacao = referencia + 1; comparacao < size; comparacao++)
            {
                if (vetor_original[referencia] == vetor_original[comparacao])
                {
                    verificacao_vetor_repetido[i] = vetor_original[i];
                    vetor_original[i] = new Random().Next(0, 10);

                    for (int s = 0; s < size; s++)
                    {
                        if (vetor_original[s] == verificacao_vetor_repetido[s])
                        {
                            vetor_original[s] = new Random().Next(0, 10);
                        }
                        else
                            vetor_nao_copiado = true;
                    }
                }
            }
        }

    } while (vetor_nao_copiado != true);

    segundo_vetor[i] = vetor_original[i];
}

for (int referencia_2 = 0; referencia_2 < size; referencia_2++)
{
    for (int comparacao_2 = referencia_2 + 1; comparacao_2 < size; comparacao_2++)
    {
        if (segundo_vetor[referencia_2] > segundo_vetor[comparacao_2])
        {
            auxiliar = segundo_vetor[referencia_2];
            segundo_vetor[referencia_2] = segundo_vetor[comparacao_2];
            segundo_vetor[comparacao_2] = auxiliar;
        }
    }
}

Console.WriteLine("Números sorteados: ");
for (int x = 0; x < size; x++)
{
    Console.Write(segundo_vetor[x] + " ");
}