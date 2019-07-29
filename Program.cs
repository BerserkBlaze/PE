using System;

namespace PPE_Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = NumeroPrimo(388);
            Console.WriteLine(res);
            Console.WriteLine(Numero_A_Letra(res));
            string par = Par(res);
            Console.WriteLine(par);
            //1-Es par?-L-
            //2-Escribir en numero Romano
            //3-Escribirlo en letra-L-

            //limitacion: 1 000 000-Salida-L-    
        }

        static private int NumeroPrimo(int limite)
        {
            int contador = 0, resultado = 0, contP = 0;
            int Numero_Primo = 1;

            if (resultado >78498)
            {
                resultado = -1;
            }
      
            while (resultado == 0)
            {
                for (int i = 1; i <= Numero_Primo; i++)
                {
                    if (Numero_Primo % i == 0)
                    {
                        contador++;
                    }
                }

                if (contador == 2)
                {
                    contP++;
                }
                Numero_Primo++;
                contador = 0;
                if (contP == limite)
                {
                    resultado = Numero_Primo-1;
                }
            }
            return resultado;
        }

        static private string Par(int numero)
        {
            string resultado="No es par";
            if (numero%2==0)
            {
                resultado = "Si es par";
            }
            return resultado;
        }
        
        static private string Numero_A_Letra(int numero)
        {
            string resultado="";
            if ((numero / 1000) > 0)
            {
                if ((numero / 1000) == 1)
                {
                    resultado = " Mil " + Numero_A_Letra(numero % 1000);
                }
                else
                {
                    resultado = Numero_A_Letra(numero / 1000) + " Mil " + Numero_A_Letra(numero % 1000);
                }
            }
            else
            {
                if ((numero / 100) > 0)
                {
                    if ((numero / 100) == 1)
                    {
                        if ((numero%100)==0)
                        {
                            resultado = " Cien ";
                        }
                        else
                        {
                            resultado = " Cien " + Numero_A_Letra(numero % 100);
                        }
                       
                    }
                    else
                    {
                        if ((numero / 100) == 5)
                        {
                            resultado = " Quinientos " + Numero_A_Letra(numero % 100);
                        }
                        else
                        {
                            if ((numero / 100) == 9)
                            {
                                resultado = " Novecientos " + Numero_A_Letra(numero % 100);
                            }
                            else
                            {
                                resultado = Numero_A_Letra(numero / 100) + " Cientos " + Numero_A_Letra(numero % 100);
                            }
                        }
                    }
                }
                else
                {
                    if ((numero / 10) > 0)
                    {
                        switch ((int) (numero/10))
                        {
                            case 1:
                                switch ((int)(numero % 10))
                                {
                                    case 0: resultado = " Diez ";break;
                                    case 1: resultado = " Once "; break;
                                    case 2: resultado = " Doce "; break;
                                    case 3: resultado = " Trece "; break;
                                    case 4: resultado = " Catorce "; break;
                                    case 5: resultado = " Quince "; break;
                                    default:
                                        resultado = " Diez y " + Numero_A_Letra(numero % 10);break;
                                }
                                break;
                            case 2:
                                switch ((int)(numero % 10))
                                {
                                    case 0: resultado = " Veinte ";break;
                                    default:
                                        resultado = " Veinti " + Numero_A_Letra(numero % 10); break;
                                }
                                break;

                            case 3:
                                switch ((int)(numero % 10))
                                {
                                    case 0: resultado = " Treinta "; break;
                                    default:
                                        resultado = " Treinta y " + Numero_A_Letra(numero % 10); break;
                                }
                                break;

                            case 4:
                                switch ((int)(numero % 10))
                                {
                                    case 0: resultado = " Cuarenta "; break;
                                    default:
                                        resultado = " Cuarenta y " + Numero_A_Letra(numero % 10); break;
                                }
                                break;

                            case 5:
                                switch ((int)(numero % 10))
                                {
                                    case 0: resultado = " Cincuenta "; break;
                                    default:
                                        resultado = " Cincuenta y " + Numero_A_Letra(numero % 10); break;
                                }
                                break;

                            case 6:
                                switch ((int)(numero % 10))
                                {
                                    case 0: resultado = " Sesenta "; break;
                                    default:
                                        resultado = " Sesenta y " + Numero_A_Letra(numero % 10); break;
                                }
                                break;

                            case 7:
                                switch ((int)(numero % 10))
                                {
                                    case 0: resultado = " Setenta "; break;
                                    default:
                                        resultado = " Setenta y " + Numero_A_Letra(numero % 10); break;
                                }
                                break;

                            case 8:
                                switch ((int)(numero % 10))
                                {
                                    case 0: resultado = " Ochenta "; break;
                                    default:
                                        resultado = " Ochenta y " + Numero_A_Letra(numero % 10); break;
                                }
                                break;

                            case 9:
                                switch ((int)(numero % 10))
                                {
                                    case 0: resultado = " Noventa "; break;
                                    default:
                                        resultado = " Noventa y " + Numero_A_Letra(numero % 10); break;
                                }
                                break;
                        }
                    }
                    else
                    {
                        switch ((int)(numero))
                        {
                            case 0: resultado = "Cero";break;
                            case 1: resultado = "Uno"; break;
                            case 2: resultado = "Dos"; break;
                            case 3: resultado = "Tres"; break;
                            case 4: resultado = "Cuatro"; break;
                            case 5: resultado = "Cinco"; break;
                            case 6: resultado = "Seis"; break;
                            case 7: resultado = "Siete"; break;
                            case 8: resultado = "Ocho"; break;
                            case 9: resultado = "Nueve"; break;
                        }
                    }
                }
            }
           
            return resultado;
        }
    }
}
