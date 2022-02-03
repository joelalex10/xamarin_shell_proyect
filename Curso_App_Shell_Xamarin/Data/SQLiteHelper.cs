using Curso_App_Shell_Xamarin.Models;
using SQLite;

namespace Curso_App_Shell_Xamarin.Data
{
    public class SQLiteHelper
    {
        private SQLiteAsyncConnection _connection;

        public SQLiteHelper(string dbPath)
        {
            _connection = new SQLiteAsyncConnection(dbPath);
            _connection.CreateTableAsync<ProductInfo>().Wait();
        }
    }
}