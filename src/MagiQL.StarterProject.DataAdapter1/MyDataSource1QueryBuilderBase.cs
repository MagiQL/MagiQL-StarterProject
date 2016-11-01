using MagiQL.DataAdapters.Infrastructure.Sql.Model;
using MagiQL.Reports.DataAdapters.Base;
using MagiQL.Reports.DataAdapters.Base.DataSource.QueryExecutor.QueryBuilders.Base;

namespace MagiQL.StarterProject.DataAdapter1
{
    public class MyDataSource1QueryBuilderBase : QueryBuilderBase
    {
        public MyDataSource1QueryBuilderBase(IDataSourceComponents dataSourceComponents)
            : base(dataSourceComponents)
        {
        } 

        public override bool WhereFilterColumnAllowIsNull(MappedSearchRequestFilter filter)
        {
            return true;
        }

        public override bool RequireCurrencyGroupBy(MappedSearchRequest request)
        {
            return false;
        }
    }
}