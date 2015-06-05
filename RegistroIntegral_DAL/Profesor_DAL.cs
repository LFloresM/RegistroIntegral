using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using RegistroIntegral_BLL;

namespace RegistroIntegral_DAL
{
    public class Profesor_DAL
    {

        public DataTable ListarProfesores()
        {
            string cn = System.Configuration.ConfigurationManager.ConnectionStrings["cnRegistroIntegral"].ConnectionString;

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable profeDataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(cn))
            {
                adapter.SelectCommand = new SqlCommand("Profesor_GetAll", cn);
                adapter.Fill(profeDataTable);
            }
            return profeDataTable;




            //DataTable RegistroIntegral.Profesor_BLL.Profesor = new DataTable();

            //using (SqlConnection cn = new SqlConnection(RI_Connection))
            //{
            //    using (SqlCommand cmd = new SqlCommand("Profesor_GetAll", cn))
            //    {
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            //        {
            //            da.Fill(Profesor_BLL);
            //        }
            //    }
            //}
            //return Profesor_BLL;


        }



        //public static List<Profesor_BLL.Profesor> ListarProfesores()
        //{
        //    string ri_connection = System.Configuration.ConfigurationManager.ConnectionStrings["cnRegistroIntegral"].ConnectionString;

        //    List<Profesor_BLL.Profesor> arrProfesor = new List<Profesor_BLL.Profesor>();

        //    using (SqlConnection cn = new SqlConnection(ri_connection))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("Profesor_GetAll", cn))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
        //            {
        //                Profesor_BLL.Profesor profe = new Profesor_BLL.Profesor();


        //                da.Fill(arrProfesor);
        //            }
        //        }
        //    }
        //    return arrProfesor;
        //}


    }
}
