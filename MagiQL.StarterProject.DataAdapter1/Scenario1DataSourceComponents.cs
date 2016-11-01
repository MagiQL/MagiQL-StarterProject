using MagiQL.Framework.Interfaces;
using MagiQL.Reports.DataAdapters.Base;

namespace MagiQL.StarterProject.DataAdapter1
{
    public class Scenario1DataSourceComponents : DataSourceComponentsBase
    {
        public Scenario1DataSourceComponents(IColumnProvider columnProvider) : base(columnProvider)
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