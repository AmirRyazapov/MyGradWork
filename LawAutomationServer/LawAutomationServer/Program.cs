using System;
using System.Text;
using System.Net;
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace LawAutomationServer
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add("http://127.0.0.1:8001/");
            WorkWithDB wwdb = new WorkWithDB();
            DataTable DATA;
            while (true)
            {
                listener.Start();
                Console.WriteLine("Ожидание подключений...");
                HttpListenerContext context = listener.GetContext();
                HttpListenerRequest request = context.Request;
                HttpListenerResponse response = context.Response;

                string methodName = request.Url.Segments[1].Trim('/');
                if (methodName == "ReadKB")
                {
                    DATA = wwdb.ReadKBFromDB();
                    SendData(response, DATA);
                }
                else if (methodName == "ReadEvents")
                {
                    string[] arg = request.Url.Segments[2].Split('&');
                    string day = "", month = "", year = "";
                    foreach (string s in arg)
                    {
                        string[] sArg = s.Split('=');
                        if (sArg[0] == "day" && sArg.Length > 1)
                        {
                            day = sArg[1];
                        }
                        else if (sArg[0] == "month" && sArg.Length > 1)
                        {
                            month = sArg[1];
                        }
                        else if (sArg[0] == "year" && sArg.Length > 1)
                        {
                            year = sArg[1];
                        }
                    }
                    DATA = wwdb.ReadEventsFromDB(day, month, year);
                    SendData(response, DATA);
                }
                else if (methodName == "ReadTasks")
                {
                    string[] arg = request.Url.Segments[2].Split('&');
                    string name = "";
                    foreach (string s in arg)
                    {
                        string[] sArg = s.Split('=');
                        if (sArg[0] == "name" && sArg.Length > 1)
                        {
                            name = sArg[1];
                        }
                    }
                    DATA = wwdb.ReadTasksFromDB(name);
                    SendData(response, DATA);
                }
                else if (methodName == "ReadMonthEvents")
                {
                    string[] arg = request.Url.Segments[2].Split('&');
                    string month = "", year = "";
                    foreach (string s in arg)
                    {
                        string[] sArg = s.Split('=');
                        if (sArg[0] == "month" && sArg.Length > 1)
                        {
                            month = sArg[1];
                        }
                        else if (sArg[0] == "year" && sArg.Length > 1)
                        {
                            year = sArg[1];
                        }
                    }
                    DATA = wwdb.ReadMonthEventsFromDB(month, year);
                    SendData(response, DATA);
                }
                else if (methodName == "ReadListOfWorkers")
                {
                    string[] arg = request.Url.Segments[2].Split('&');
                    string level = "";
                    foreach (string s in arg)
                    {
                        string[] sArg = s.Split('=');
                        if (sArg[0] == "level" && sArg.Length > 1)
                        {
                            level = sArg[1];
                        }
                    }
                    DATA = wwdb.ReadListOfWorkers(level);
                    SendData(response, DATA);
                }
                else if (methodName == "InsertToEvents")
                {
                    string[] arg = request.Url.Segments[2].Split('&');
                    string datetimestart = "", datetimefinish = "", text = "", level = "", idauthor = "";
                    foreach (string s in arg)
                    {
                        string[] sArg = s.Split('=');
                        if (sArg[0] == "datetimestart" && sArg.Length > 1)
                        {
                            datetimestart = sArg[1];
                        }
                        else if (sArg[0] == "datetimefinish" && sArg.Length > 1)
                        {
                            datetimefinish = sArg[1];
                        }
                        else if (sArg[0] == "text" && sArg.Length > 1)
                        {
                            text = sArg[1];
                        }
                        else if (sArg[0] == "level" && sArg.Length > 1)
                        {
                            level = sArg[1];
                        }
                        else if (sArg[0] == "idauthor" && sArg.Length > 1)
                        {
                            idauthor = sArg[1];
                        }
                    }
                    string answer = wwdb.WriteEventToDB(datetimestart, datetimefinish, text, level, idauthor);
                    SendMessage(response, answer);
                }
                else if (methodName == "InsertToTasks")
                {
                    string[] arg = request.Url.Segments[2].Split('&');
                    string author = "", datetimeappointment = "", datetimefinish = "", text = "", subordinate = "";
                    foreach (string s in arg)
                    {
                        string[] sArg = s.Split('=');
                        if (sArg[0] == "author" && sArg.Length > 1)
                        {
                            author = sArg[1];
                        }
                        else if (sArg[0] == "datetimeappointment" && sArg.Length > 1)
                        {
                            datetimeappointment = sArg[1];
                        }
                        else if (sArg[0] == "datetimefinish" && sArg.Length > 1)
                        {
                            datetimefinish = sArg[1];
                        }
                        else if (sArg[0] == "text" && sArg.Length > 1)
                        {
                            text = sArg[1];
                        }
                        else if (sArg[0] == "subordinate" && sArg.Length > 1)
                        {
                            subordinate = sArg[1];
                        }
                    }
                    string answer = wwdb.WriteTaskToDB(author, datetimeappointment, datetimefinish, text, subordinate);
                    SendMessage(response, answer);
                }
                else if (methodName == "UpdateTask")
                {
                    string[] arg = request.Url.Segments[2].Split('&');
                    string id = "", process = "";
                    foreach (string s in arg)
                    {
                        string[] sArg = s.Split('=');
                        if (sArg[0] == "id" && sArg.Length > 1)
                        {
                            id = sArg[1];
                        }
                        else if (sArg[0] == "process" && sArg.Length > 1)
                        {
                            process = sArg[1];
                        }
                    }
                    string answer = wwdb.UpdateTask(id, process);
                    SendMessage(response, answer);
                }
                else if (methodName == "InsertToRecords")
                {
                    string[] arg = request.Url.Segments[2].Split('&');
                    string question = "", answer = "", date = "", author = "";
                    foreach (string s in arg)
                    {
                        string[] sArg = s.Split('=');
                        if (sArg[0] == "question" && sArg.Length > 1)
                        {
                            question = sArg[1];
                        }
                        else if (sArg[0] == "answer" && sArg.Length > 1)
                        {
                            answer = sArg[1];
                        }
                        else if (sArg[0] == "date" && sArg.Length > 1)
                        {
                            date = sArg[1];
                        }
                        else if (sArg[0] == "author" && sArg.Length > 1)
                        {
                            author = sArg[1];
                        }
                    }
                    string answr = wwdb.WriteRecordToDB(question, answer, date, author);
                    SendMessage(response, answr);
                }
                else if (methodName == "Authorization")
                {
                    string text;
                    using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                    {
                        text = reader.ReadToEnd();
                    }
                    string [] arg = text.Split('&');
                    string login = "", password = "";
                    foreach (string s in arg)
                    {
                        string [] sArg = s.Split('=');
                        if (sArg[0] == "login" && sArg.Length > 1)
                        {
                            login = sArg[1];
                        }
                        else if (sArg[0] == "password" && sArg.Length > 1)
                        {
                            password = sArg[1];
                        }
                    }
                    password = wwdb.GetHashPassword(password);
                    DATA = wwdb.Auth(login, password);
                    SendData(response, DATA);
                }
            }
        }

        private static void SendData(HttpListenerResponse response, DataTable DATA)
        {
            MemoryStream stream = new MemoryStream();
            System.Runtime.Serialization.IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, DATA);
            byte[] buffer = stream.GetBuffer();
            response.ContentLength64 = buffer.Length;
            Stream output = response.OutputStream;
            output.Write(buffer, 0, buffer.Length);
            output.Close();
        }

        private static void SendMessage(HttpListenerResponse response, string message)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            response.ContentLength64 = buffer.Length;
            Stream output = response.OutputStream;
            output.Write(buffer, 0, buffer.Length);
            output.Close();
        }
    }
}