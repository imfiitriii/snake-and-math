using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace SnakeAndMath
{
    public class Question
    {
        private string connStr =@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Question.accdb";
        private int id;
        private string questionText;
        private string trueAnswer;
        public string Level { get; set; } // property to hold the level information

        public int ID
        {
            get { return id; }
            private set { id = value; }
        }

        public Question(int idNum,string level)
        {
            ID = idNum;
            Level = level;
        }

        public string DisplayQUestion(int ID, string Level)
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();

                string query = $"SELECT * FROM [{Level}] WHERE ID = ?";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", id);

                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    questionText = reader["Question"].ToString();
                    trueAnswer = reader["Answer"].ToString();
                }
                return "Question : " + questionText;
            }
        }

        public bool CheckAnswer(string userAnswer)
        {
            return userAnswer.Trim() == trueAnswer.Trim();
        }
    }
}
