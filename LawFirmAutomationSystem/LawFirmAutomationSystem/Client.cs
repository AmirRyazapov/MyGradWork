using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LawFirmAutomationSystem
{
    class Client
    {
        public static string address = "http://127.0.0.1:8001/";
        public DataTable ReadKBFromServer()
        {
            DataTable DATA = new DataTable();
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                WebRequest request = WebRequest.Create(address + "/ReadKB/");
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

        public DataTable ReadTasksFromServer(string name)
        {
            DataTable DATA;
            try
            {
                string query = $"name={name}";
                BinaryFormatter bf = new BinaryFormatter();
                WebRequest request = WebRequest.Create(address + "/ReadTasks/" + query);
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

        public DataTable ReadEventsFromServer(string day, string month, string year)
        {
            DataTable DATA = new DataTable();
            string query = $"day={day}&month={month}&year={year}";
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                WebRequest request = WebRequest.Create(address + "/ReadEvents/" + query);
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

        public DataTable ReadMonthEventsFromServer(string month, string year)
        {
            DataTable DATA = new DataTable();
            string query = $"month={month}&year={year}";
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                WebRequest request = WebRequest.Create(address + "/ReadMonthEvents/" + query);
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

        public DataTable GetListOfWorkers(int level)
        {
            DataTable DATA = new DataTable();
            string query = $"level={level}";
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                WebRequest request = WebRequest.Create(address + "/ReadListOfWorkers/" + query);
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

        public string InsertToEvents(string query)
        {
            try
            {
                WebRequest request = WebRequest.Create(address + "/InsertToEvents/" + query);
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

        public string InsertToTasks(string author, string datetimeappointment, string datetimefinish, string text, string subordinate)
        {
            try
            {
                string query = $"datetimeappointment={datetimeappointment}&datetimefinish={datetimefinish}&text={text}&author={author}&subordinate={subordinate}";
                WebRequest request = WebRequest.Create(address + "/InsertToTasks/" + query);
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

        public string InsertToRecords(string query)
        {
            try
            {
                WebRequest request = WebRequest.Create(address + "/InsertToRecords/" + query);
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

        public string UpdateTask(string id, string process)
        {
            string query = $"id={id}&process={process}";
            try
            {
                WebRequest request = WebRequest.Create(address + "/UpdateTask/" + query);
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

        public DataTable GetHashPassword(string login, string password)
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
