using System;
using System.Data;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace LawFirmAutomationSystem
{
    class Client
    {
        public static string address = "http://127.0.0.1:8001/";

        public DataTable Read(string fullAddress)
        {
            DataTable DATA;
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                WebRequest request = WebRequest.Create(fullAddress);
                WebResponse response = request.GetResponse();
                MemoryStream ms = new MemoryStream(response.ContentLength > 0 ? (int)response.ContentLength : 20000);
                using (Stream responseStream = response.GetResponseStream())
                {
                    responseStream.CopyTo(ms);
                }
                byte[] buf = ms.ToArray();
                ms.Close();
                response.Close();
                MemoryStream stream = new MemoryStream(buf);
                DATA = (DataTable)bf.Deserialize(stream);
                return DATA;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public DataTable ReadKBFromServer()
        {
            string fullAddress = address + "/ReadKB/";
            return Read(fullAddress);
        }

        public DataTable ReadTasksFromServer(string name)
        {
            string query = $"name={name}";
            string fullAddress = address + "/ReadTasks/" + query;
            return Read(fullAddress);
        }

        public DataTable ReadEventsFromServer(string day, string month, string year)
        {
            string query = $"day={day}&month={month}&year={year}";
            string fullAddress = address + "/ReadEvents/" + query;
            return Read(fullAddress);
        }

        public DataTable ReadMonthEventsFromServer(string month, string year)
        {
            string query = $"month={month}&year={year}";
            string fullAddress = address + "/ReadMonthEvents/" + query;
            return Read(fullAddress);
        }

        public DataTable GetListOfWorkers(int level)
        {
            string query = $"level={level}";
            string fullAddress = address + "/ReadListOfWorkers/" + query;
            return Read(fullAddress);
        }

        public string InsertOrUpdate(string fullAddress)
        {
            try
            {
                WebRequest request = WebRequest.Create(fullAddress);
                WebResponse response = request.GetResponse();
                string res = "";
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        res = reader.ReadToEnd();
                    }
                }
                response.Close();
                return res;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string InsertToEvents(string query)
        {
            string fullAddress = address + "/InsertToEvents/" + query;
            return InsertOrUpdate(fullAddress);
        }

        public string InsertToTasks(string query)
        {
            string fullAddress = address + "/InsertToTasks/" + query;
            return InsertOrUpdate(fullAddress);
        }

        public string InsertToRecords(string query)
        {
            string fullAddress = address + "/InsertToRecords/" + query;
            return InsertOrUpdate(fullAddress);
        }

        public string UpdateTask(string query)
        {
            string fullAddress = address + "/UpdateTask/" + query;
            return InsertOrUpdate(fullAddress);
        }

        public DataTable GetUser(string login, string password)
        {
            DataTable DATA = new DataTable();
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                WebRequest request = WebRequest.Create(address + "/Authorization/");
                var postData = "login=" + Uri.EscapeDataString(login);
                postData += "&password=" + Uri.EscapeDataString(password);
                var data = Encoding.ASCII.GetBytes(postData);
                request.Method = "POST";
                request.ContentLength = data.Length;

                using (var reqStream = request.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);
                }

                WebResponse response = request.GetResponse();
                MemoryStream ms = new MemoryStream(response.ContentLength > 0 ? (int)response.ContentLength : 20000);
                using (Stream responseStream = response.GetResponseStream())
                {
                    responseStream.CopyTo(ms);
                }
                byte[] buf = ms.ToArray();
                ms.Close();
                response.Close();
                MemoryStream stream = new MemoryStream(buf);
                DATA = (DataTable)bf.Deserialize(stream);
                return DATA;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
