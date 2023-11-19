using dataLearning.data;
using dataLearning.Model;
using System.Data;

namespace dataLearning
{
	internal class Program
	{

		static void Main(string[] args)
		{
			Mydb mydata = new Mydb();

			//Department d = new Department(); 
			//d.DeptName = "Development";
			//d.DeptId = 20;
			//d.ManagerId = 101;

			//string sql = @"INSERT INTO MYDEPT("
			//	+ "  DEPTID"
			//	+ ", DEPTNAME"
			//	+ ", MANAGERID)"
			//	+ " values("
			//	+ " " + d.DeptId
			//	+ ", '" + d.DeptName
			//	+ "', " + d.ManagerId
			//	+ ")";

			//mydata.ExecuteSql(sql);
			
			IEnumerable<Department> deptlist= mydata.getDBData< Department>("select deptid, deptname, managerid from mydept order by 1");
			Console.WriteLine("Dept No, Department Name, ManagerID");
			foreach (Department d in deptlist)
			{
				Console.WriteLine(d.DeptId + "," + d.DeptName + "," +d.ManagerId);
			}

			//Insert record
			//Update record
			//Delete record
			//select list

		}
	}
}