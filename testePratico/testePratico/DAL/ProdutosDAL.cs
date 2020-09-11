using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using testePratico.Lib;
using testePratico.Model;

namespace testePratico.DAL
{
    public class ProdutosDAL
    {
        public static object listaProdutos()
        {
            try
            {
                TestePraticoEntities conn = new TestePraticoEntities();

                var lista = (from p in conn.Produtoes
                             join f in conn.Fornecedors on p.FornecedorID equals f.FornecedorID
                             select new
                             {
                                 ProdutoID = p.ProdutoID,
                                 NomeProduto = p.Nome,
                                 NomeFornecedor = f.Nome,
                                 Quantidade = p.Quantidade
                             }).ToList();

                return lista;
            }
            catch
            {
                return null;
            }
        }

        public static object pesquisaParcial(string pTexto)
        {
            try
            {
                TestePraticoEntities conn = new TestePraticoEntities();

                var lista = (from p in conn.Produtoes
                             join f in conn.Fornecedors on p.FornecedorID equals f.FornecedorID
                             where p.Nome.Contains(pTexto)
                             select new
                             {
                                 ProdutoID = p.ProdutoID,
                                 NomeProduto = p.Nome,
                                 NomeFornecedor = f.Nome,
                                 Quantidade = p.Quantidade
                             }).ToList();

                return lista;
            }
            catch
            {
                return null;
            }
        }

        public static bool excluirProduto(int iProdutoID)
        {
            try
            {
                TestePraticoEntities conn = new TestePraticoEntities();
                Produto prod = conn.Produtoes.Where(f => f.ProdutoID == iProdutoID).Select(f => f).FirstOrDefault();

                if (prod != null)
                {
                    conn.Produtoes.Remove(prod);
                    conn.SaveChanges();

                    return true;
                }
                else
                {
                    GlobalVars.Error_Messages = "Produto não localizado.";
                    return false;
                }
            }
            catch (Exception err)
            {
                GlobalVars.Error_Messages = "Erro: " + err.Message.ToString();
                return false;
            }
        }

        internal static Produto buscaProdutoPorID(int pProdutoID)
        {
            try
            {
                TestePraticoEntities conn = new TestePraticoEntities();
                Produto prod = conn.Produtoes.Include("Fornecedor").Where(f => f.ProdutoID == pProdutoID).Select(f => f).FirstOrDefault();
                return prod;
            }
            catch
            {
                return null;
            }
        }
    }
}
