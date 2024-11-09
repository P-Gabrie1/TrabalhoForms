using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmPrincipal
{
    internal class Utilitarios
    {
        public static (int horas, int minutos, int segundos) ConverterSegundos(int totalSegundos)
        {
            int horas = totalSegundos / 3600;
            int minutos = (totalSegundos % 3600) / 60;
            int segundos = totalSegundos % 60;

            return (horas, minutos, segundos);

        }
               public static bool Divisivel(int num)
        {
            return (num % 3 == 0);
        }

        public static int MostrarIdade(DateTime dataNascimento)
        {
            DateTime hoje = DateTime.Today;
            int idade = hoje.Year - dataNascimento.Year;

            // Ajusta a idade se o aniversário ainda não ocorreu este ano
            if (dataNascimento.Date > hoje.AddYears(-idade))
            {
                idade--;
            }

            return idade;
        }

        }
    }
    


        
       
    
