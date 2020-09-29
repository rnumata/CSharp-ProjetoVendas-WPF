using System;
using System.Collections.Generic;
using System.Text;

namespace VendasWpf.Utils
{
    class ValidarCpf
    {

        /// <summary>
        ///  Metodo faz a verificacao do tamanho do cpf, se possui numeros repetidos e se cpf valido
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>

        public static bool ValidaCpf(String cpf)
        {

            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length < 11 ||
               cpf.Equals("11111111111") ||
               cpf.Equals("22222222222") ||
               cpf.Equals("33333333333") ||
               cpf.Equals("44444444444") ||
               cpf.Equals("55555555555") ||
               cpf.Equals("66666666666") ||
               cpf.Equals("77777777777") ||
               cpf.Equals("88888888888") ||
               cpf.Equals("99999999999") ||
               cpf.Equals("00000000000"))
            {
                return false;
            }

            int soma = 0;
            int count1 = 10;
            for (int i = 0; i < cpf.Length - 2; i++)
            {
                int val = (int)Char.GetNumericValue(cpf[i]);
                soma += (val * count1);
                count1--;
            }

            int resto1 = soma % 11;
            if (resto1 < 2)
            {
                resto1 = 0;
            }
            else
            {
                resto1 = 11 - resto1;
            }

            int convert1 = (int)Char.GetNumericValue(cpf[9]);
            //se 1o digito ( resto1 ) eh valido entra no if para validar 2o digito
            if (resto1 == convert1)
            {
                soma = 0;
                int count2 = 11;
                for (int i = 0; i < cpf.Length - 1; i++)
                {
                    int val2 = Convert.ToInt32(cpf[i].ToString());
                    soma += (val2 * count2);
                    count2--;
                }

                int resto2 = soma % 11;
                if (resto2 < 2)
                {
                    resto2 = 0;
                }
                else
                {
                    resto2 = 11 - resto2;
                }

                int convert2 = (int)Char.GetNumericValue(cpf[10]);
                if (resto2 == convert2)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }

        } //fim metodo


    }
}
