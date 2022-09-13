using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientação_a_Objetos
{
    public class Aluno : Usuario
    {
        public int Matricula;
        public string Nome;
        public decimal Media;
        private List<Materia> Materias;

        public void CalcularMedia(decimal nota1, decimal nota2, decimal nota3)
        {
            decimal total = nota1 + nota2 + nota3;
            Media = total / 3;
        }

        public string AdicionarMateria(Materia materia)
        {
            foreach (Materia mate in Materias)
            {
                if (mate.Nome == materia.Nome)
                    return "Esta matéria já existe";
            }

            Materias.Add(materia);
            return "Matéria adicionada com sucesso";
        }
    }
}
