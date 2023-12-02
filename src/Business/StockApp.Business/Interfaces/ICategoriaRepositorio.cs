using StockApp.Business.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Business.Interfaces
{
    public interface ICategoriaRepositorio
    {
        bool Incluir(Categoria categoria);
        bool Atualizar(Categoria categoria);
        bool Remover(int id);
        bool Ativar(int id);
        bool Inativar(int id);


        Categoria Categoria (int id);
        List<Categoria> obterTodos (int id);
        List<Categoria> obterTodasAtivas();
    }
}
