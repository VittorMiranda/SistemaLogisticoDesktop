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
    internal class RotaRepository
    {
        public void Inserir(Rota rota)
        {
            string sql = @"INSERT INTO ROTA (ORIGEM, DESTINO, DISTANCIA)
                           VALUES (@origem, @destino, @distancia)";

            DatabaseHelper.ExecuteNonQuery(sql,
                new SQLiteParameter("@origem", rota.Origem),
                new SQLiteParameter("@destino", rota.Destino),
                new SQLiteParameter("@distancia", rota.Distancia)
            );
        }

        public void Atualizar(Rota rota)
        {
            string sql = @"UPDATE ROTA
                           SET ORIGEM=@origem, DESTINO=@destino, DISTANCIA=@distancia
                           WHERE ROTAID=@id";

            DatabaseHelper.ExecuteNonQuery(sql,
                new SQLiteParameter("@origem", rota.Origem),
                new SQLiteParameter("@destino", rota.Destino),
                new SQLiteParameter("@distancia", rota.Distancia),
                new SQLiteParameter("@id", rota.RotaId)
            );
        }

        public void ExcluirLogico(int rotaId)
        {
            string sql = "UPDATE ROTA SET Ativo = 0 WHERE ROTAID = @id";
            DatabaseHelper.ExecuteNonQuery(sql, new SQLiteParameter("@id", rotaId));
        }

        public List<Rota> Listar()
        {
            var lista = new List<Rota>();
            string sql = "SELECT ROTAID, ORIGEM, DESTINO, DISTANCIA FROM ROTA WHERE Ativo = 1";

            var dt = DatabaseHelper.ExecuteQuery(sql);

            foreach (System.Data.DataRow row in dt.Rows)
            {
                lista.Add(new Rota
                {
                    RotaId = Convert.ToInt32(row["ROTAID"]),
                    Origem = row["ORIGEM"].ToString(),
                    Destino = row["DESTINO"].ToString(),
                    Distancia = Convert.ToDecimal(row["DISTANCIA"])

                });
            }

            return lista;
        }
    }
}
