using System;
using System.Dynamic;
using System.Resources;
using System.Xml;

class ValidadorCPF
{
    static void Main(string[] args)
    {
        bool validador = false;
        Console.WriteLine("Digite seu CPF: ");
        string cpf = Console.ReadLine();

        string valorCPF;

        valorCPF = cpf.Replace(".", "");//TIRAR OS CARACTERES DE . DO CPF
        valorCPF = valorCPF.Replace("-", "");//TIRAR OS CARACTERES DE - DO CPF (QUE JA ESTAO SEM O .)

        if (valorCPF.Length == 11) //SE O CPF TIVER UM TAMANHO IGUAL A 11
        {
            int a = Convert.ToInt32(valorCPF[0].ToString()) * 10;
            int b = Convert.ToInt32(valorCPF[1].ToString()) * 9;
            int c = Convert.ToInt32(valorCPF[2].ToString()) * 8;
            int d = Convert.ToInt32(valorCPF[3].ToString()) * 7;
            int e = Convert.ToInt32(valorCPF[4].ToString()) * 6;
            int f = Convert.ToInt32(valorCPF[5].ToString()) * 5;
            int g = Convert.ToInt32(valorCPF[6].ToString()) * 4;
            int h = Convert.ToInt32(valorCPF[7].ToString()) * 3;
            int i = Convert.ToInt32(valorCPF[8].ToString()) * 2;

            int somaCPF = a + b + c + d + e + f + g + h + i;//SOMA DOS RESULTADOS DAS MULTIPLICACOES

            int restoCPF = somaCPF % 11;//PEGAR O RESTO DA DIVISAO DA SOMA POR 11

            if (restoCPF < 2)//SE O RESTO DA DIVISAO ACIMA FOR MENOR QUE 2
            {
                if ((Convert.ToInt32(valorCPF[9].ToString()) != 0))//SE A POSICAO 9 DO CPF (PRIMEIRO DIGITO VERIFICADOR), FOR DIFERENTE DE 0
                {
                    validador = false;
                }
                
            }
            else if (restoCPF >= 2)//SE O RESTO DA DIVISAO FOR MAIOR OU IGUAL A 2
            {
                int digitoVerificador = 11 - restoCPF;//DIGITO VERIFICADOR SERA IGUAL A 11 - RESTO DA DIVISAO
                if (Convert.ToInt32(valorCPF[9].ToString()) != digitoVerificador)//SE O VALOR DA POSICAO 9 DO CPF FOR DIFERENTE DO PRIMEIRO DIGITO VERIFICADOR ACIMA
                {
                    validador = false;
                }
                else
                {
                    int j = Convert.ToInt32(valorCPF[0].ToString()) * 11;
                    int k = Convert.ToInt32(valorCPF[1].ToString()) * 10;
                    int l = Convert.ToInt32(valorCPF[2].ToString()) * 9;
                    int m = Convert.ToInt32(valorCPF[3].ToString()) * 8;
                    int n = Convert.ToInt32(valorCPF[4].ToString()) * 7;
                    int o = Convert.ToInt32(valorCPF[5].ToString()) * 6;
                    int p = Convert.ToInt32(valorCPF[6].ToString()) * 5;
                    int q = Convert.ToInt32(valorCPF[7].ToString()) * 4;
                    int r = Convert.ToInt32(valorCPF[8].ToString()) * 3;
                    int s = Convert.ToInt32(valorCPF[9].ToString()) * 2;

                    int somaCPF2 = j + k + l + m + n + o + p + q + r + s;//SOMA DOS RESULTADOS DA MULTIPLICACAO ACIMA

                    int restoCPF2 = somaCPF2 % 11;//PEGA O RESTO DA DIVISAO POR 11 DA SOMA ACIMA

                    if (restoCPF2 < 2)
                    {
                        if ((Convert.ToInt32(valorCPF[10].ToString()) != 0))
                        {
                            validador = false;
                        }
                        else
                        {
                            validador = true;

                        }
                    }
                    else if (restoCPF2 >= 2)
                    {
                        int digitoVerificador2 = 11 - restoCPF2;
                        if ((Convert.ToInt32(valorCPF[10].ToString()) != digitoVerificador2))
                        {
                            validador = false;
                        }
                        else
                        {
                            validador = true;

                        }
                    }
                }
            }
        }
        else//SE O CPF TIVER UM TAMANHO MAIOR QUE 11
        {
            Console.WriteLine("CPF FALSO, ULTRAPASSOU LIMITE DE CARACTERES");
            validador = false;
        }
        Console.WriteLine("Este CPF é: " + validador);

        Console.ReadKey();
    }
}