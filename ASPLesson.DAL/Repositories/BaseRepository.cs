using Microsoft.Extensions.Configuration;

namespace ASPLesson.DAL.Repositories
{
    public class BaseRepository
    {
        private readonly IConfiguration Configuration;
        protected string ConnectionString { get; set; }

        public BaseRepository(IConfiguration configuration)
        {
            Configuration = configuration;
            SetConnectionString();
        }

        public void SetConnectionString()
        {
            ConnectionString = Configuration.GetConnectionString("DefaultConnection");
        }
    }
}
