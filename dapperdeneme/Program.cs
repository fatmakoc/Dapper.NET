using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;


namespace dapperdeneme
{
    class Student
    {
        public int OgrNo { get; set; }
        public string Adi { get; set; }
        public string Bolum { get; set; }

    }


    class Program
    {
        static void Main(string[] args)
        {
            using (var sqlconnection = new SqlConnection("Data Source=FATMA\\SQLEXPRESS;Initial Catalog=OKUL;Integrated Security=True"))
            {
                IEnumerable<Student> students = sqlconnection.Query<Student>("SELECT * From Ogrenci where OgrNo >= @OgrNo", new { OgrNo = 12 });

                foreach (var student in students )
                Console.WriteLine("Ogrencinin Adı : {0}",student.Adi);
            
            }
        }

       
    }
}
