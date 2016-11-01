using MagiQL.Reports.DataAdapters.Base;

namespace MagiQL.StarterProject.DataAdapter1
{
    public class Constants : ConstantsBase
    {
        public override int DataSourceId { get { return 1; } }

        public override string Platform { get { return "MyDataSource1"; } }

        public override string RootTableName { get { return KnownTables.Room; } }

        public override string TextSearchColumnUniqueName { get { return "Room_Name"; } }

        public override string ConnectionStringName { get { return "MagiQL"; } }

    }
}