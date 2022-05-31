using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace LawAutomationServer
{
    class WorkWithDB
    {
        public string WriteEventToDB(string datetimestart, string datetimefinish, string text, string level, string idauthor)
        {
            var utf8 = Encoding.GetEncoding("utf-8");
            datetimestart = HttpUtility.UrlDecode(datetimestart, utf8);
            datetimefinish = HttpUtility.UrlDecode(datetimefinish, utf8);
            text = HttpUtility.UrlDecode(text, utf8);
            level = HttpUtility.UrlDecode(level, utf8);
            idauthor = HttpUtility.UrlDecode(idauthor, utf8);
            DBConnection db = new DBConnection();
            try
            {
                db.openConnection();
                MySqlCommand command = new MySqlCommand("INSERT INTO events (datetime_start, datetime_finish, text, level, id_author) " +
                    $"VALUES (?datetimestart, ?datetimefinish, ?text, ?level, (SELECT id_user FROM users WHERE login = ?idauthor))", db.getConnection());              
                command.Parameters.AddWithValue("?datetimestart", datetimestart);
                command.Parameters.AddWithValue("?datetimefinish", datetimefinish);
                command.Parameters.AddWithValue("?text", text);
                command.Parameters.AddWithValue("?level", level);
                command.Parameters.AddWithValue("?idauthor", idauthor);
                command.ExecuteNonQuery();
                return "Запись успешно добавлена!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.closeConnection();
            }
        }

        public string WriteTaskToDB(string author, string datetimeappointment, string datetimefinish, string text, string subordinate)
        {
            var utf8 = Encoding.GetEncoding("utf-8");
            author = HttpUtility.UrlDecode(author, utf8);
            datetimeappointment = HttpUtility.UrlDecode(datetimeappointment, utf8);
            datetimefinish = HttpUtility.UrlDecode(datetimefinish, utf8);
            text = HttpUtility.UrlDecode(text, utf8);
            subordinate = HttpUtility.UrlDecode(subordinate, utf8);
            DBConnection db = new DBConnection();
            try
            {
                db.openConnection();
                MySqlCommand command = new MySqlCommand("INSERT INTO tasks (datetime_appointment, datetime_finish, text, id_author, id_subordinate, process) " +
                    "VALUES (?datetimeappointment, ?datetimefinish, ?text, (SELECT id_user FROM users WHERE login = ?author), " +
                    "(SELECT id_user FROM users WHERE login = ?subordinate), 'В работе')", db.getConnection());
                command.Parameters.AddWithValue("?author", author);
                command.Parameters.AddWithValue("?datetimeappointment", datetimeappointment);
                command.Parameters.AddWithValue("?datetimefinish", datetimefinish);
                command.Parameters.AddWithValue("?text", text);
                command.Parameters.AddWithValue("?subordinate", subordinate);
                command.ExecuteNonQuery();
                return "Запись успешно добавлена!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.closeConnection();
            }
        }

        public string WriteRecordToDB(string question, string answer, string date, string author)
        {
            var utf8 = Encoding.GetEncoding("utf-8");
            question = HttpUtility.UrlDecode(question, utf8);
            answer = HttpUtility.UrlDecode(answer, utf8);
            date = HttpUtility.UrlDecode(date, utf8);
            author = HttpUtility.UrlDecode(author, utf8);
            DBConnection db = new DBConnection();
            try
            {
                db.openConnection();
                MySqlCommand command = new MySqlCommand("INSERT INTO knowledgebase (question, answer, date, id_author) " +
                    "VALUES (?question, ?answer, ?date, (SELECT id_user FROM users WHERE login = ?author))", db.getConnection());
                command.Parameters.AddWithValue("?question", question);
                command.Parameters.AddWithValue("?answer", answer);
                command.Parameters.AddWithValue("?date", date);
                command.Parameters.AddWithValue("?author", author);
                command.ExecuteNonQuery();
                return "Запись успешно добавлена!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.closeConnection();
            }
        }

        public string UpdateTask(string id, string process)
        {
            var utf8 = Encoding.GetEncoding("utf-8");
            id = HttpUtility.UrlDecode(id, utf8);
            process = HttpUtility.UrlDecode(process, utf8);
            DBConnection db = new DBConnection();
            try
            {
                db.openConnection();
                MySqlCommand command = new MySqlCommand("UPDATE tasks SET process = ?process WHERE id_task = ?id", db.getConnection());
                command.Parameters.AddWithValue("?id", id);
                command.Parameters.AddWithValue("?process", process);
                command.ExecuteNonQuery();
                return "Запись успешно изменена!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.closeConnection();
            }
        }

        public DataTable ReadKBFromDB()
        {
            string query = $"SELECT id_question AS 'ID вопроса', question AS 'Вопрос', answer AS 'Ответ', date AS 'Дата'," +
                    $" (SELECT login FROM users WHERE id_user = id_author) AS 'Автор' FROM knowledgebase";
            DBConnection db = new DBConnection();
            MySqlDataAdapter SDA;
            DataTable DATA = new DataTable();
            try
            {
                db.openConnection();
                SDA = new MySqlDataAdapter(query, db.getConnection());
                SDA.Fill(DATA);
            }
            catch
            {
                return null;
            }
            finally
            {
                db.closeConnection();
            }
            return DATA;
        }

        public DataTable ReadEventsFromDB(string day, string month, string year)
        {
            var utf8 = Encoding.GetEncoding("utf-8");
            day = HttpUtility.UrlDecode(day, utf8);
            month = HttpUtility.UrlDecode(month, utf8);
            year = HttpUtility.UrlDecode(year, utf8);
            DBConnection db = new DBConnection();
            DataTable DATA = new DataTable();
            try
            {
                db.openConnection();
                MySqlCommand command = new MySqlCommand("SELECT datetime_start, datetime_finish, text, level, " +
                    "(SELECT login FROM users WHERE events.id_author = users.id_user) AS author " +
                    "FROM events WHERE YEAR(datetime_start) = ?year AND MONTH(datetime_start) = ?month " +
                    "AND DAY(datetime_start) = ?day ORDER BY datetime_start", db.getConnection());
                command.Parameters.AddWithValue("?day", day);
                command.Parameters.AddWithValue("?month", month);
                command.Parameters.AddWithValue("?year", year);
                DATA = GetAnswer(command);
            }
            catch
            {
                return null;
            }
            finally
            {
                db.closeConnection();
            }
            return DATA;
        }

        public DataTable ReadMonthEventsFromDB(string month, string year)
        {
            var utf8 = Encoding.GetEncoding("utf-8");
            month = HttpUtility.UrlDecode(month, utf8);
            year = HttpUtility.UrlDecode(year, utf8);
            DBConnection db = new DBConnection();
            DataTable DATA = new DataTable();
            try
            {
                db.openConnection();
                MySqlCommand command = new MySqlCommand("SELECT datetime_start FROM events WHERE " +
                    "YEAR(datetime_start) = ?year AND MONTH(datetime_start) = ?month ORDER BY datetime_start", db.getConnection());
                command.Parameters.AddWithValue("?month", month);
                command.Parameters.AddWithValue("?year", year);
                DATA = GetAnswer(command);
            }
            catch
            {
                return null;
            }
            finally
            {
                db.closeConnection();
            }
            return DATA;
        }

        public DataTable ReadTasksFromDB(string name)
        {
            var utf8 = Encoding.GetEncoding("utf-8");
            name = HttpUtility.UrlDecode(name, utf8);
            DBConnection db = new DBConnection();
            DataTable DATA = new DataTable();
            try
            {
                db.openConnection();
                MySqlCommand command = new MySqlCommand("SELECT id_task AS 'id задачи', datetime_appointment AS 'Дата и время назначения задачи', " +
                    "datetime_finish AS 'Срок выполнения задачи', text AS 'Описание задачи', (SELECT login FROM users WHERE tasks.id_author = users.id_user) " +
                    "AS 'Задачу назначил', process AS 'Статус задачи' FROM tasks WHERE id_subordinate = (SELECT id_user FROM users WHERE login = ?name) " +
                    "ORDER BY datetime_finish", db.getConnection());
                command.Parameters.AddWithValue("?name", name);
                DATA = GetAnswer(command);
            }
            catch
            {
                return null;
            }
            finally
            {
                db.closeConnection();
            }
            return DATA;
        }

        public DataTable ReadListOfWorkers(string level)
        {
            var utf8 = Encoding.GetEncoding("utf-8");
            level = HttpUtility.UrlDecode(level, utf8);
            DBConnection db = new DBConnection();
            DataTable DATA = new DataTable();
            try
            {
                db.openConnection();
                MySqlCommand command = new MySqlCommand("SELECT login FROM users WHERE type > ?level", db.getConnection());
                command.Parameters.AddWithValue("?level", level);
                DATA = GetAnswer(command);
            }
            catch
            {
                return null;
            }
            finally
            {
                db.closeConnection();
            }
            return DATA;
        }

        public DataTable Auth(string login, string password)
        {
            DBConnection db = new DBConnection();
            DataTable DATA = new DataTable();
            try
            {
                db.openConnection();
                MySqlCommand command = new MySqlCommand("SELECT type, login FROM users WHERE login = ?login AND password = ?password", db.getConnection());
                command.Parameters.AddWithValue("?login", login);
                command.Parameters.AddWithValue("?password", password);
                DATA = GetAnswer(command);
            }
            catch
            {
                return null;
            }
            finally
            {
                db.closeConnection();
            }
            return DATA;
        }

        static DataTable GetAnswer(MySqlCommand command)
        {
            DataTable DATA = new DataTable();
            try
            {
                MySqlDataReader dr = command.ExecuteReader();
                DATA.Load(dr);
                return DATA;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return DATA;
        }

        public string GetHashPassword(string password)
        {
            byte[] pw = Encoding.UTF8.GetBytes(password);
            byte[] salt = Encoding.UTF8.GetBytes("lawfirmpassword");
            byte[] hashPw = GenerateHashWithSalt(pw, salt);
            return Convert.ToBase64String(hashPw);
        }

        static byte[] GenerateHashWithSalt(byte[] password, byte[] salt)
        {
            HashAlgorithm ha = new SHA256Managed();
            byte[] passwordWithSaltBytes = new byte[password.Length + salt.Length];
            for (int i = 0; i < password.Length; i++)
            {
                passwordWithSaltBytes[i] = password[i];
            }
            for (int i = 0; i < salt.Length; i++)
            {
                passwordWithSaltBytes[password.Length + i] = salt[i];
            }
            return ha.ComputeHash(passwordWithSaltBytes);
        }
    }
}