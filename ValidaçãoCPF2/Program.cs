using System;
using System.Xml;

class ValidaçãoCPF2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um cpf: ");
        string cpf = Console.ReadLine();
        Console.WriteLine(ValidaCPF2(cpf));
    } 

    public static bool ValidaCPF2(string cpf)
    {
        cpf = cpf.Replace(".", "");
        cpf = cpf.Replace("-", "");

        if (cpf.Length == 11)
        {
            int soma = 0;
            for (int i = 0; i <= 9; i++)
            {

                for (int j = 10; j >= 2; j--)
                {
                    soma += Convert.ToInt32(cpf[i].ToString()) * j;
                    i++;
                }
            }
            int restoDivisao = soma % 11;

            if (restoDivisao < 2)
            {
                if (Convert.ToInt32(cpf[9].ToString()) != 0)
                {
                    return false;

                }

            }
            else if (restoDivisao >= 2)
            {
                int digitoVerificador = 11 - restoDivisao;

                if (Convert.ToInt32(cpf[9].ToString()) != digitoVerificador)
                {
                    return false;
                }
            }



            int soma2 = 0;
            for (int i = 0; i <= 10; i++)
            {

                for (int j = 11; j >= 2; j--)
                {
                    soma2 += Convert.ToInt32(cpf[i].ToString()) * j;
                    i++;
                }
            }

            int restoDivisao2 = soma2 % 11;

            if (restoDivisao2 < 2)
            {
                if (Convert.ToInt32(cpf[10].ToString()) != 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (restoDivisao2 >= 2)
            {
                int digitoVerificador2 = 11 - restoDivisao2;

                if (Convert.ToInt32(cpf[10].ToString()) != digitoVerificador2)
                {
                    return false;
                } 
                else
                {
                    return true;

                }
            }
            return false;
        }
        else
        {
            return false;
        }
    }
}
