This repository holds a class libary that reduces the code needed to add parameters to a objCommand.

EXAMPLE ON USE:

FillParameters fp = new FillParameters();

function objCommand GetUsersByName(string name){
        //Gets a new SQL Command object
	objCommand = new SqlCommand();

        //Sets which stored procedure the command object will use
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandText = "GetUsersByName";

        //Inputs parameters to the command object
        fp.AddParameter(ref objCommand, "@name", name);

        //Returns the DataSet
        return objDB.GetDataSetUsingCmdObj(objCommand);
}
