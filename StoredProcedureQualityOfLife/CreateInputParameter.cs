using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoredProcedureQualityOfLife
{

    /*
     *  Ieuan Horton
     *  CreateInputParameter assists in the creation of a SqlParameter
     */

    public class CreateInputParameter
    {
        public SqlParameter CreateVarChar(SqlParameter sqlp)
        {
            sqlp.Direction = ParameterDirection.Input;
            sqlp.SqlDbType = SqlDbType.VarChar;
            sqlp.Size = 50;
            return sqlp;
        }

        public SqlParameter CreateVarChar(SqlParameter sqlp, bool max)
        {
            sqlp.Direction = ParameterDirection.Input;
            sqlp.SqlDbType = SqlDbType.VarChar;
            if (max == false)
            {
                sqlp.Size = 50;
            }
            return sqlp;
        }
        public SqlParameter CreateDateTime(SqlParameter sqlp)
        {
            sqlp.Direction = ParameterDirection.Input;
            sqlp.SqlDbType = SqlDbType.DateTime;
            return sqlp;
        }

        public SqlParameter CreateVarBinary(SqlParameter sqlp, bool max)
        {
            sqlp.Direction = ParameterDirection.Input;
            sqlp.SqlDbType = SqlDbType.VarBinary;
            if (max == false)
            {
                sqlp.Size = 50;
            }
            return sqlp;
        }
        public SqlParameter CreateVarChar(SqlParameter sqlp, int size)
        {
            sqlp.Direction = ParameterDirection.Input;
            sqlp.SqlDbType = SqlDbType.VarChar;
            sqlp.Size = size;
            return sqlp;
        }

        public SqlParameter CreateInt(SqlParameter sqlp)
        {
            sqlp.Direction = ParameterDirection.Input;
            sqlp.SqlDbType = SqlDbType.Int;
            sqlp.Size = 4;
            return sqlp;
        }

        public SqlParameter CreateInt(SqlParameter sqlp, int size)
        {
            sqlp.Direction = ParameterDirection.Input;
            sqlp.SqlDbType = SqlDbType.Int;
            sqlp.Size = size;
            return sqlp;
        }
    }
}
