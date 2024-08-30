using Microsoft.EntityFrameworkCore;
using catat.core;


namespace catat.core
{
    public class GeneratorDB
    {
        public void EnsureDatabaseCreated()
        {
            using (var context = new MainDataContext())
            {
                context.Database.EnsureCreated();
                CreateTablesIfNotExist(context);
            }
        }

        private void CreateTablesIfNotExist(MainDataContext context)
        {
            if (!context.Database.CanConnect())
            {
                context.Database.EnsureCreated();
            }

            var modelTypes = typeof(MainDataContext).Assembly.GetTypes()
                .Where(t => t.Namespace == "_5unSystem.Model.Entities" && t.IsClass);

            foreach (var type in modelTypes)
            {
                var tableName = type.Name;
                var tableExists = context.Database.ExecuteSqlRaw($"SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{tableName}'");
                if (tableExists == 0)
                {
                    var createTableSql = $"CREATE TABLE {tableName} (";
                    var properties = type.GetProperties();
                    foreach (var property in properties)
                    {
                        var propertyName = property.Name;
                        var propertyType = GetSqlType(property.PropertyType);
                        createTableSql += $"{propertyName} {propertyType},";
                    }
                    createTableSql = createTableSql.TrimEnd(',') + ")";
                    context.Database.ExecuteSqlRaw(createTableSql);
                }
            }

            // SeedInitialData(context);

        }

        public bool CheckDatabaseConnection()
        {
            using (var context = new MainDataContext())
            {
                try
                {
                    context.Database.OpenConnection();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        private string GetSqlType(Type type)
        {
            if (type == typeof(string))
                return "NVARCHAR(MAX)";
            else if (type == typeof(int))
                return "INT";
            else if (type == typeof(long))
                return "BIGINT";
            else if (type == typeof(bool))
                return "BIT";
            else if (type == typeof(DateTime))
                return "DATETIME";
            else if (type == typeof(Guid))
                return "UNIQUEIDENTIFIER";
            else
                return "NVARCHAR(MAX)";
        }




    }

}
