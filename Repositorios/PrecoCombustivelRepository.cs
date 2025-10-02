using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogisticaApp.Utils;
using Sistema_Logistico.Entidades;

namespace Sistema_Logistico.Repositorios
{
    internal class PrecoCombustivelRepository
    {
        public void Inserir(PrecoCombustivel preco)
        {
            string sql = @"INSERT INTO PRECO_COMBUSTIVEL (COMBUSTIVEL, PRECO, DATA_CONSULTA)
                           VALUES (@combustivel, @preco, @data)";

            DatabaseHelper.ExecuteNonQuery(sql,
                new SQLiteParameter("@combustivel", preco.Combustivel),
                new SQLiteParameter("@preco", preco.Preco),
                new SQLiteParameter("@data", preco.DataConsulta)
            );
        }

        public void Atualizar(PrecoCombustivel preco)
        {
            string sql = @"UPDATE PRECO_COMBUSTIVEL
                           SET COMBUSTIVEL=@combustivel, PRECO=@preco, DATA_CONSULTA=@data
                           WHERE PRECOID=@id";

            DatabaseHelper.ExecuteNonQuery(sql,
                new SQLiteParameter("@combustivel", preco.Combustivel),
                new SQLiteParameter("@preco", preco.Preco),
                new SQLiteParameter("@data", preco.DataConsulta),
                new SQLiteParameter("@id", preco.PrecoId)
            );
        }

        public void Excluir(int precoId)
        {
            string sql = "DELETE FROM PRECO_COMBUSTIVEL WHERE PRECOID=@id";
            DatabaseHelper.ExecuteNonQuery(sql, new SQLiteParameter("@id", precoId));
        }

        public List<PrecoCombustivel> Listar()
        {
            var lista = new List<PrecoCombustivel>();
            string sql = "SELECT PRECOID, COMBUSTIVEL, PRECO, DATA_CONSULTA FROM PRECO_COMBUSTIVEL";

            var dt = DatabaseHelper.ExecuteQuery(sql);

            foreach (System.Data.DataRow row in dt.Rows)
            {
                lista.Add(new PrecoCombustivel
                {
                    PrecoId = Convert.ToInt32(row["PRECOID"]),
                    Combustivel = row["COMBUSTIVEL"].ToString(),
                    Preco = Convert.ToDecimal(row["PRECO"]),
                    DataConsulta = Convert.ToDateTime(row["DATA_CONSULTA"])
                });
            }

            return lista;
        }
    }
}
