using Dapper;
using DapperExtensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWork
{
    public class GenericRepository<T> : IDisposable where T : class
    {
        private readonly string _tabloAdi;
        public readonly SqlConnection SQL = null;

        public GenericRepository(string tabloAdi)
        {
            _tabloAdi = tabloAdi;
        }

        public void Dispose()
        {
            if (SQL != null)
            {
                SQL.Dispose();
                GC.SuppressFinalize(this);
            }
        }
        public SqlConnection SqlConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["SQL"].ConnectionString);
        }
        public IDbConnection CreateConnection()
        {
            var SQL = SqlConnection();
            SQL.Open();
            return SQL;
        }

        public async Task<List<T>> Liste_Getir()
        {
            using (var connection = CreateConnection())
            {
                return await connection.QueryAsync<T>($"SELECT * FROM {_tabloAdi}") as List<T>;
            }
        }

        public async Task Veri_Kaydet(T t)
        {
            using (var connection = CreateConnection())
            {
                await connection.InsertAsync<T>(t);
            }
        }

        public async Task Veri_Guncelle(T t)
        {
            using (var connection = CreateConnection())
            {
                await connection.UpdateAsync<T>(t);
            }
        }
        public async Task Veri_Sil(int id)
        {
            using (var connection = CreateConnection())
            {
                await connection.ExecuteAsync($"DELETE FROM {_tabloAdi} WHERE Id=@Id", new { Id = id });

            }
        }

    }
}
