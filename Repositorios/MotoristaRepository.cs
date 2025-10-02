using LogisticaApp.Utils;
using Sistema_Logistico.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace LogisticaApp.Repositorios
{
    public class MotoristaRepository
    {
        public void Inserir(Motorista motorista)
        {
            string sql = @"INSERT INTO MOTORISTA (NOME, CNH, TELEFONE) 
                           VALUES (@nome, @cnh, @telefone)";

            DatabaseHelper.ExecuteNonQuery(sql,
                new SQLiteParameter("@nome", motorista.Nome),
                new SQLiteParameter("@cnh", motorista.CNH),
                new SQLiteParameter("@telefone", motorista.Telefone)
            );
        }

        public void Atualizar(Motorista motorista)
        {
            string sql = @"UPDATE MOTORISTA 
                           SET NOME=@nome, CNH=@cnh, TELEFONE=@telefone 
                           WHERE MOTORISTAID=@id";

            DatabaseHelper.ExecuteNonQuery(sql,
                new SQLiteParameter("@nome", motorista.Nome),
                new SQLiteParameter("@cnh", motorista.CNH),
                new SQLiteParameter("@telefone", motorista.Telefone),
                new SQLiteParameter("@id", motorista.MotoristaId)
            );
        }

        public void ExcluirLogico(int motoristaId)
        {
            string sql = "UPDATE MOTORISTA SET Ativo = 0 WHERE MOTORISTAID = @id";
            DatabaseHelper.ExecuteNonQuery(sql, new SQLiteParameter("@id", motoristaId));
        }

        public List<Motorista> Listar()
        {
            var lista = new List<Motorista>();
            string sql = "SELECT MOTORISTAID, NOME, CNH, TELEFONE FROM MOTORISTA WHERE Ativo = 1";
            var dt = DatabaseHelper.ExecuteQuery(sql);

            foreach (System.Data.DataRow row in dt.Rows)
            {
                lista.Add(new Motorista
                {
                    MotoristaId = Convert.ToInt32(row["MOTORISTAID"]),
                    Nome = row["NOME"].ToString(),
                    CNH = row["CNH"].ToString(),
                    Telefone = row["TELEFONE"].ToString()
                });
            }

            return lista;
        }
    }
}
