using MagiQL.Framework.Interfaces;
using MagiQL.Reports.DataAdapters.Base;

namespace MagiQL.StarterProject.DataAdapter1
{
    public class MyDataSource1Components : DataSourceComponentsBase
    {
        public MyDataSource1Components(IColumnProvider columnProvider) : base(columnProvider)
        {
        }

        protected override void RegisterComponents()
        {
            Constants = new Constants();
            TableMappings = new MyDataSource1TableMappings();

            QueryBuilderBase = new MyDataSource1QueryBuilderBase(this);
        }

    }
}