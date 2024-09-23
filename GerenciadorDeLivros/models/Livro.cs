using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace GerenciadorLivros.models;

public class Livro
{
    public string Nome { get; set; }
    public string Autor { get; set; }
    public int QuantidadePaginas { get; set; }
    public bool Leu { get; set; }

    public override string ToString()
    {
        return $"Nome: {Nome}, Autor: {Autor}, Páginas: {QuantidadePaginas}, Leu: {(Leu ? "Sim" : "Não")}";
    }
}

