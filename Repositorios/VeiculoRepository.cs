
using LogisticaApp.Utils;
using Sistema_Logistico.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace LogisticaApp.Repositorios
{
    public class VeiculoRepository
    {
        public void Inserir(Veiculo veiculo)
        {
            string sql = @"INSERT INTO VEICULO (MODELO, PLACA, CONSUMO_MEDIO, CARGA_MAXIMA) 
                           VALUES (@modelo, @placa, @consumo, @carga)";

            DatabaseHelper.ExecuteNonQuery(sql,
                new SQLiteParameter("@modelo", veiculo.Modelo),
                new SQLiteParameter("@placa", veiculo.Placa),
                new SQLiteParameter("@consumo", veiculo.ConsumoMedio),
                new SQLiteParameter("@carga", veiculo.CargaMaxima)
            );
        }

        public void Atualizar(Veiculo veiculo)
        {
            string sql = @"UPDATE VEICULO 
                           SET MODELO=@modelo, PLACA=@placa, CONSUMO_MEDIO=@consumo, CARGA_MAXIMA=@carga 
                           WHERE VEICULOID=@id";

            DatabaseHelper.ExecuteNonQuery(sql,
                new SQLiteParameter("@modelo", veiculo.Modelo),
                new SQLiteParameter("@placa", veiculo.Placa),
                new SQLiteParameter("@consumo", veiculo.ConsumoMedio),
                new SQLiteParameter("@carga", veiculo.CargaMaxima),
                new SQLiteParameter("@id", veiculo.VeiculoId)
            );
        }

        public void ExcluirLogico(int veiculoId)
        {
            string sql = "UPDATE VEICULO SET Ativo = 0 WHERE VEICULOID = @id";
            DatabaseHelper.ExecuteNonQuery(sql, new SQLiteParameter("@id", veiculoId));
        }

        public List<Veiculo> Listar()
        {
            var lista = new List<Veiculo>();
            string sql = "SELECT VEICULOID, MODELO, PLACA, CONSUMO_MEDIO, CARGA_MAXIMA FROM VEICULO WHERE Ativo = 1";

            var dt = DatabaseHelper.ExecuteQuery(sql);

            foreach (System.Data.DataRow row in dt.Rows)
            {
                lista.Add(new Veiculo(
                    Convert.ToInt32(row["VEICULOID"]),
                    row["MODELO"].ToString(),
                    row["PLACA"].ToString(),
                    Convert.ToDecimal(row["CONSUMO_MEDIO"]),
                    Convert.ToDecimal(row["CARGA_MAXIMA"])
                ));
            }

            return lista;
        }

    }
}
