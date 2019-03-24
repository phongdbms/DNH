namespace DataAccecss.InterfaceRepositories
{
    public class DbFactory : Disposable, IDbFactory
    {
        private DaiNamHungDBContext dbContext;

        DaiNamHungDBContext IDbFactory.Init()
        {
            return dbContext ?? (dbContext = new DaiNamHungDBContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
        
    }
}