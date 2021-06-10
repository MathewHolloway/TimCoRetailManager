using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDataManager.Library.Internal.DataAccess
{
    internal class SqlDataAccess
    {
        public string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public List<T> LoadData<T, U>(string storedProcedure, U parameters, string connectionStringName)
        {
            string connectionString = GetConnectionString(connectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(storedProcedure, parameters,
                    commandType: CommandType.StoredProcedure).ToList();

                return rows;
            }
        }

        public void SaveData<T>(string storedProcedure, T parameters, string connectionStringName)
        {
            string connectionString = GetConnectionString(connectionStringName);

            using (IDbConnection connection = new SqlConnection())
            {
                connection.Execute(storedProcedure, parameters,
                    commandType: CommandType.StoredProcedure);

            }
        }
    }
}
//Bearer SmyqqsnVkbfYhOXCqVrmqUKUCcDqKqZnkuMFwKZJP5NLCd2DzXzJftfwExQsCUZWErsMvAFrr0JXBr1EcBE1GB4EZV2xz11jmZhfRJVlZakocnNBbvLlnMyRshz1sfoXgKe7r28KSkx0EEEd21FubjeMoGwcDWDsCqxSSEYUDwondBcaG0iI7ls - f1k1CpE54eR_iEaHHkaBvg9Mb - 2lB7eUO6KDKphDL_kmKoLdnHfDhUQmwT9r6DEWyRo - 6UyILeH8gpCSS2QWKI64W9XRACwMZyKyn7ErewrQs5JI45hmhmw54FIZNdTBOMjtuD5huL7DfXhtKYjg5rFvzyI_wc6d1t5tF_FEdCHUid0fbae5wic2PLPm2ZEx5qEGmZcJsXC4XBclzfDN86rGIfd1AZYM - QY67VbA - 0b1FtifIAJ0ewvXKES27nImE5SyqqnfRIHuoQYHwMQ1UhwO4l7pg9BZd0Jd0zLIcgxkgU0Lw4SjqBz20tv173nRkxq4G7PS
