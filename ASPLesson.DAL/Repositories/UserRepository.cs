using ASPLesson.Domain.Entity;
using ASPLesson.Domain.Interfaces.Interfaces;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASPLesson.DAL.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(IConfiguration configuration) : base(configuration) { }

        public async Task<User> Insert(User user)
        {
            using (var db  = new SqlConnection(ConnectionString))
            {
                var result = await db.ExecuteAsync(@"
                    INSERT INTO [dbo].[User] 
                        (Name, Age) 
                        VALUES (@Name, @Age)",
                    new 
                    {
                        Name = user.Name,
                        Age = user.Age
                    });

                return null;
            }
        }

        public async Task<User> Get(int id)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                var user = await db.QueryFirstOrDefaultAsync<User>(@"
                    SELECT * FROM [dbo].[User]
                    WHERE Id = @Id",
                    new 
                    {
                        Id = id
                    });

                return user;
            }
        }

        public async Task<User> GetByName(string name)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                return await db.QueryFirstOrDefaultAsync<User>(@"
                    SELECT * FROM [dbo].[User]
                    WHERE Name = @Name",
                    new
                    {
                        Name = name
                    });
            }
        }

        public async Task<IEnumerable<User>> Select()
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                return await db.QueryAsync<User>(@"
                    SELECT * FROM [dbo].[User]");
            }
        }
    }
}
