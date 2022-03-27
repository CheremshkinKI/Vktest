using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
namespace Vktest.Models
{
    class Grid
    {
        public string time { get; set; }
        public string content { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int heigth { get; set; }
        public void addDat(int id)
        {
            var cs = "Host=localhost;Username=postgres;Password=A123z321;Database=Test";
            using var con = new NpgsqlConnection(cs);
            con.Open();
            var sql = "SELECT * FROM contrrollers WHERE id = " + id;
            using var cmd1 = new NpgsqlCommand(sql, con);
            using NpgsqlDataReader rdr = cmd1.ExecuteReader();
            rdr.Read();
            time = rdr.GetString(1);
            content = rdr.GetString(2);
        }
        static public int getsizebd()
        {
            var cs = "Host=localhost;Username=postgres;Password=A123z321;Database=Test";
            using var con = new NpgsqlConnection(cs);
            con.Open();
            int sizeb = 0;
            var sql = "SELECT * FROM contrrollers";
            using var cmd1 = new NpgsqlCommand(sql, con);
            using NpgsqlDataReader rdr = cmd1.ExecuteReader();
            while (rdr.Read())
            {
                sizeb++;
            }
            return sizeb;
        }
    }
}
