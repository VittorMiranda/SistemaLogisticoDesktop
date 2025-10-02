using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using LogisticaApp.Utils;
using Sistema_Logistico.Entidades;

namespace Sistema_Logistico.Repositorios
{
    public class ViagemRepository
    {
        public void Inserir(Viagem viagem)
        {
            string sql = @"INSERT INTO VIAGEM 
                           (MOTORISTAID, VEICULOID, ROTAID, DATA_SAIDA, DATA_CHEGADA, SITUACAO, ATIVO)
                           VALUES (@MotoristaId, @VeiculoId, @RotaId, @DataSaida, @DataChegada, @Situacao, 1)";

            DatabaseHelper.ExecuteNonQuery(sql,
                new SQLiteParameter("@MotoristaId", viagem.MotoristaId),
                new SQLiteParameter("@VeiculoId", viagem.VeiculoId),
                new SQLiteParameter("@RotaId", viagem.RotaId),
                new SQLiteParameter("@DataSaida", viagem.DataSaida),
                new SQLiteParameter("@DataChegada", (object?)viagem.DataChegada ?? DBNull.Value),
                new SQLiteParameter("@Situacao", viagem.Situacao)
            );
        }

        public void Atualizar(Viagem viagem)
        {
            string sql = @"UPDATE VIAGEM 
                           SET MOTORISTAID = @MotoristaId, 
                               VEICULOID = @VeiculoId, 
                               ROTAID = @RotaId,
                               DATA_SAIDA = @DataSaida,
                               DATA_CHEGADA = @DataChegada,
                               SITUACAO = @Situacao
                           WHERE VIAGEMID = @ViagemId";

            DatabaseHelper.ExecuteNonQuery(sql,
                new SQLiteParameter("@MotoristaId", viagem.MotoristaId),
                new SQLiteParameter("@VeiculoId", viagem.VeiculoId),
                new SQLiteParameter("@RotaId", viagem.RotaId),
                new SQLiteParameter("@DataSaida", viagem.DataSaida),
                new SQLiteParameter("@DataChegada", (object?)viagem.DataChegada ?? DBNull.Value),
                new SQLiteParameter("@Situacao", viagem.Situacao),
                new SQLiteParameter("@ViagemId", viagem.ViagemId)
            );
        }

        public void Excluir(int id)
        {
            string sql = "UPDATE VIAGEM SET ATIVO = 0 WHERE VIAGEMID = @ViagemId";
            DatabaseHelper.ExecuteNonQuery(sql, new SQLiteParameter("@ViagemId", id));
        }

        public List<Viagem> ListarResumo()
        {
            string sql = @"SELECT 
                                V.VIAGEMID,
                                V.MOTORISTAID,
                                V.VEICULOID,
                                V.ROTAID,
                                M.NOME AS MotoristaNome,
                                VE.MODELO || ' (' || VE.PLACA || ')' AS VeiculoNome,
                                R.ORIGEM || ' >> ' || R.DESTINO AS RotaDescricao,
                                V.DATA_SAIDA,
                                V.DATA_CHEGADA,
                                V.SITUACAO
                            FROM VIAGEM V
                            INNER JOIN MOTORISTA M ON V.MOTORISTAID = M.MOTORISTAID
                            INNER JOIN VEICULO VE ON V.VEICULOID = VE.VEICULOID
                            INNER JOIN ROTA R ON V.ROTAID = R.ROTAID
                            WHERE V.ATIVO = 1;";

            var dt = DatabaseHelper.ExecuteQuery(sql);
            var lista = new List<Viagem>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new Viagem
                {
                    ViagemId = Convert.ToInt32(row["VIAGEMID"]),
                    MotoristaId = Convert.ToInt32(row["MOTORISTAID"]),
                    VeiculoId = Convert.ToInt32(row["VEICULOID"]),
                    RotaId = Convert.ToInt32(row["ROTAID"]),
                    MotoristaNome = row["MotoristaNome"].ToString(),
                    VeiculoNome = row["VeiculoNome"].ToString(),
                    RotaNome = row["RotaDescricao"].ToString(),
                    DataSaida = Convert.ToDateTime(row["DATA_SAIDA"]),
                    DataChegada = row["DATA_CHEGADA"] == DBNull.Value ? null : Convert.ToDateTime(row["DATA_CHEGADA"]),
                    Situacao = row["SITUACAO"].ToString()
                });
            }

            return lista;
        }



    }
}
