using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoredProcedureQualityOfLife
{
    /*
     *  Ieuan Horton
     *  FillParameters creates an inputParameter and adds it to the objCommand
     */

    public class FillParameters
    {
        CreateInputParameter cip = new CreateInputParameter();

        //Adds a string parameter to the objCommand object
        public void AddParameter(ref SqlCommand objCommand, string pName, string pValue)
        {
            SqlParameter ip = new SqlParameter(pName, pValue);
            ip = cip.CreateVarChar(ip);
            objCommand.Parameters.Add(ip);
        }

        //Add a date time
        public void AddParameter(ref SqlCommand objCommand, string pName, DateTime pValue)
        {
            SqlParameter ip = new SqlParameter(pName, pValue);
            ip = cip.CreateDateTime(ip);
            objCommand.Parameters.Add(ip);
        }

        //Adds a string parameter to the objCommand object with max size
        public void AddParameter(ref SqlCommand objCommand, string pName, string pValue, bool max)
        {
            SqlParameter ip = new SqlParameter(pName, pValue);
            ip = cip.CreateVarChar(ip, true);
            objCommand.Parameters.Add(ip);
        }

        //Adds a binary parameter to the objCommand object with max size
        public void AddParameter(ref SqlCommand objCommand, string pName, byte[] pValue, bool max)
        {
            SqlParameter ip = new SqlParameter(pName, pValue);
            ip = cip.CreateVarBinary(ip, true);
            objCommand.Parameters.Add(ip);
        }


        //Adds a string parameter to the objCommand object at size
        public void AddParameter(ref SqlCommand objCommand, string pName, string pValue, int size)
        {
            SqlParameter ip = new SqlParameter(pName, pValue);
            ip = cip.CreateVarChar(ip, size);
            objCommand.Parameters.Add(ip);
        }

        //Adds an int parameter to the objcommand object
        public void AddParameter(ref SqlCommand objCommand, string pName, int pValue)
        {
            SqlParameter ip = new SqlParameter(pName, pValue);
            ip = cip.CreateInt(ip);
            objCommand.Parameters.Add(ip);
        }

        //Adds a string parameter of bytes to the objCommand object. This is used to store serialized objects
        public void AddParameter(ref SqlCommand objCommand, string pName, byte[] pValue)
        {
            SqlParameter ip = new SqlParameter(pName, pValue);
            ip = cip.CreateVarChar(ip);
            objCommand.Parameters.Add(ip);
        }
    }
}
