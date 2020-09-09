using System;
using System.Collections.Generic;
using System.Linq;
using testePratico.Lib;
using testePratico.Model;

namespace testePratico.DAL
{
    public class FornecedoresDAL
    {
        public static List<Fornecedor> listaFornecedores()
        {
            try
            {
                TestePraticoEntities conn = new TestePraticoEntities();
                var lista = conn.Fornecedors.Select(f => f).OrderBy(f => f.Nome).ToList();
                return lista;
            }
            catch
            {
                return null;
            }
        }

        public static Fornecedor buscaFornecedorPorID(int pFornecedorID)
        {
            try
            {
                TestePraticoEntities conn = new TestePraticoEntities();
                Fornecedor forn = conn.Fornecedors.Where(f => f.FornecedorID == pFornecedorID).Select(f => f).FirstOrDefault();
                return forn;
            }
            catch
            {
                return null;
            }
        }

        public static bool excluirFornecedor(int pFornecedorID)
        {
            try
            {
                TestePraticoEntities conn = new TestePraticoEntities();
                Fornecedor forn = conn.Fornecedors.Where(f => f.FornecedorID == pFornecedorID).Select(f => f).FirstOrDefault();

                if (forn != null)
                {
                    conn.Fornecedors.Remove(forn);
                    conn.SaveChanges();

                    return true;
                }
                else
                {
                    GlobalVars.Error_Messages = "Fornecedor não localizado.";
                    return false;
                }
            }
            catch (Exception err)
            {
                GlobalVars.Error_Messages = "Erro: " + err.Message.ToString();
                return false;
            }
        }

        public static List<Fornecedor> pesquisaParcial(string pTexto)
        {
            try
            {
                TestePraticoEntities conn = new TestePraticoEntities();
                var lista = conn.Fornecedors.Where(f => f.Nome.Contains(pTexto)).Select(f => f).OrderBy(f => f.Nome).ToList();
                return lista;
            }
            catch
            {
                return null;
            }
        }
    }
}
