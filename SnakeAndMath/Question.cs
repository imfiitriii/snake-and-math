using System;
using System.Data.OleDb;

namespace SnakeAndMath
{
    public class Question
    {
        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Question.accdb;";//Persist Security Info=False;
        private int id;
        private string questionText;
        private string trueAnswer;

        public string Level { get; set; }

        public int ID
        {
            get { return id; }
            private set { id = value; }
        }

        public Question(int idNum, string level)
        {
            ID = idNum;
            Level = level.Trim();
            Level = char.ToUpper(Level[0]) + Level.Substring(1).ToLower();
        }

        public string DisplayQuestion()
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
            if (string.IsNullOrWhiteSpace(trueAnswer))
                return false;

            return userAnswer.Trim().Equals(trueAnswer.Trim(), StringComparison.OrdinalIgnoreCase);
        }

        // ADD THIS
        public string GetCorrectAnswer()
        {
            return trueAnswer;
        }
    }
}
//public class Question
//{
//    private string connStr =@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\azfar\OneDrive\Documents\Database3.accdb;Persist Security Info=False;";
//    private int id;
//    private string questionText;
//    private string trueAnswer;
//    public string Level { get; set; } // property to hold the level information

//    public int ID
//    {
//        get { return id; }
//        private set { id = value; }
//    }

//    public Question(int idNum,string level)
//    {
//        ID = idNum;
//        Level = level;
//    }

//public string DisplayQUestion(int ID,string Level)
//{
//    GenerateQuestion();
//    return questionText;
//}

//public bool CheckAnswer(string userAnswer)
//{
//    return userAnswer.Trim() == trueAnswer.Trim();
//}

//private void GenerateQuestion()
//{
//    int a = 0, b = 0, answer = 0;
//    string op = "";

//    Random rnd = new Random(ID + DateTime.Now.Millisecond);

//    switch (Level)
//    {
//        case "Easy":
//            a = rnd.Next(1, 10);
//            b = rnd.Next(1, 10);
//            op = rnd.Next(0, 2) == 0 ? "+" : "-";

//            if (op == "+")
//                answer = a + b;
//            else
//                answer = a - b;

//            questionText = $"{a} {op} {b} = ?";
//            break;

//        case "Medium":
//            a = rnd.Next(5, 20);
//            b = rnd.Next(1, 10);
//            op = rnd.Next(0, 2) == 0 ? "*" : "+";

//            if (op == "*")
//                answer = a * b;
//            else
//                answer = a + b;

//            questionText = $"{a} {op} {b} = ?";
//            break;

//        case "Hard":
//            a = rnd.Next(10, 50);
//            b = rnd.Next(1, 10);
//            op = rnd.Next(0, 3) == 0 ? "/" : "*";

//            if (op == "/")
//            {
//                int temp = a * b;
//                answer = a;
//                questionText = $"{temp} / {b} = ?";
//            }
//            else
//            {
//                answer = a * b;
//                questionText = $"{a} * {b} = ?";
//            }
//            break;

//        default:
//            questionText = $"Invalid Level: {Level}";
//            trueAnswer = "";
//            return;
//    }

//    trueAnswer = answer.ToString();
//}


