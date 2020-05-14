using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace WebApplication1.Models
{
    public class Context
    {
        SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=true");

        public List<Employee> GetEmployee()
        {
            List<Employee> listobj = new List<Employee>();

            SqlCommand cmd = new SqlCommand("sp_employee", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Employee obj = new Employee();
                obj.EmpId = Convert.ToInt32(dr[0]);
                obj.EmpName = Convert.ToString(dr[1]);
                obj.EmpSalary = Convert.ToInt32(dr[2]);
                listobj.Add(obj);
            }
            con.Close();
            return listobj;
        }

        public int SaveEmployee(Employee empobj)
        {
            SqlCommand cmd = new SqlCommand("spr_InsertEmployeeDetails", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empname", empobj.EmpName);
            cmd.Parameters.AddWithValue("@empsalary", empobj.EmpSalary);
            int result = cmd.ExecuteNonQuery();
            return result;
        }

        public Employee GetEmployeeById(int? EmpId)
        {
            Employee obj = new Employee();
            SqlCommand cmd = new SqlCommand("spr_getEmployeeDetailsbyId", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empid", EmpId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {

                obj.EmpId = Convert.ToInt32(dr[0]);
                obj.EmpName = Convert.ToString(dr[1]);
                obj.EmpSalary = Convert.ToInt32(dr[2]);

            }
            con.Close();
            return obj;
        }



        public int UpdateEmployee(Employee empobj)
        {
            SqlCommand cmd = new SqlCommand("spr_updateEmployeeDetails", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empid", empobj.EmpId);
            cmd.Parameters.AddWithValue("@empname", empobj.EmpName);
            cmd.Parameters.AddWithValue("@empsalary", empobj.EmpSalary);
            int result = cmd.ExecuteNonQuery();
            return result;
        }

        
             public int DeleteEmployeeById(int? id)
        {
            SqlCommand cmd = new SqlCommand("spr_deleteEmployeeDetails", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empid", id);
            int result = cmd.ExecuteNonQuery();
            return result;
        }
    }
}