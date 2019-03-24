using System;

namespace DataAccecss.InterfaceRepositories
{
    public interface IDbFactory : IDisposable
    {
       DaiNamHungDBContext Init();
    }
}