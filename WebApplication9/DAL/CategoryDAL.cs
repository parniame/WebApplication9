using Dapper;
using System.Data;
using System.Data.SqlClient;
using WebApplication9.Models;

namespace WebApplication9.DAL
{
    public class CategoryDAL
    {
        public IDbConnection Connection;
        public CategoryDAL(IConfiguration configuration)
        {
            Connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        public async Task<IEnumerable<Category>> GetAll()
        {
            IEnumerable<Category> categories;
            using(IDbConnection connection = Connection)
            {
                var query = "SELECT * FROM production.categories;";
                categories =  await (connection.QueryAsync<Category>(query));
            }
            return categories;
        }
    }
}
