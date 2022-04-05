using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace karbantartasAdmin
{
    public enum httpVerb
    { 
        GET,
        POST,
        PUT,
        DELETE
    }
    class RestClient
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }       
        public RestClient()
        {
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;
        }
        public string loginRequest(JObject data)
        {
            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            request.Method = httpMethod.ToString();
            request.Headers.Add("username", data.GetValue("username").ToString());
            request.Headers.Add("password", data.GetValue("password").ToString());

            HttpWebResponse response = null;

            try
            {
                response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("error code: " + response.StatusCode.ToString());
                }
                
                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                strResponseValue = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";
            }
            finally
            {
                if (response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }
            return strResponseValue;
        }

        public string makeRequest(JObject data)
        {
            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);
            
            request.Method = httpMethod.ToString();
            request.Headers.Add("userId", data.GetValue("id").ToString());
            request.Headers.Add("token", data.GetValue("token").ToString());

            HttpWebResponse response = null;

            try
            {
                response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("error code: " + response.StatusCode.ToString());
                }
               
                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                strResponseValue = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";
            }
            finally
            {
                if (response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }
            return strResponseValue;
        }


        public string takeRequest(JObject data)
        {
            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            request.Method = httpMethod.ToString();
            request.Headers.Add("userId", data.GetValue("id").ToString());
            request.Headers.Add("token", data.GetValue("token").ToString());

            if (request.Method == "PUT" || request.Method == "POST" || request.Method == "DELETE")
            {
                request.ContentType = "application/json";
                using (StreamWriter swJSONPayload = new StreamWriter(request.GetRequestStream()))
                {
                    swJSONPayload.Write(data);
                    swJSONPayload.Close();
                }
            }

            HttpWebResponse response = null;

            try
            {
                response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("error code: " + response.StatusCode.ToString());
                }

                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                strResponseValue = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";
            }
            finally
            {
                if (response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }
            return strResponseValue;
        }

            public string takeRequest(JObject data, JObject user)
            {
                string strResponseValue = string.Empty;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

                request.Method = httpMethod.ToString();
                request.Headers.Add("userId", user.GetValue("id").ToString());
                request.Headers.Add("token", user.GetValue("token").ToString());

                if (request.Method == "PUT" || request.Method == "POST" || request.Method == "DELETE")
                {
                    request.ContentType = "application/json";
                    using (StreamWriter swJSONPayload = new StreamWriter(request.GetRequestStream()))
                    {
                        swJSONPayload.Write(data);
                        swJSONPayload.Close();
                    }
                }

                HttpWebResponse response = null;

                try
                {
                    response = (HttpWebResponse)request.GetResponse();
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new ApplicationException("error code: " + response.StatusCode.ToString());
                    }

                    using (Stream responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                strResponseValue = reader.ReadToEnd();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    strResponseValue = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";
                }
                finally
                {
                    if (response != null)
                    {
                        ((IDisposable)response).Dispose();
                    }
                }
                return strResponseValue;
            }

            public string logOutRequest(JObject data)
            {
            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            request.Method = httpMethod.ToString();
            request.Headers.Add("userId", data.GetValue("id").ToString());
            //request.Headers.Add("token", data.GetValue("token").ToString());
            request.Headers.Add("logout", "true");

            if (request.Method == "PUT")
            {
                request.ContentType = "application/json";
                using (StreamWriter swJSONPayload = new StreamWriter(request.GetRequestStream()))
                {
                    swJSONPayload.Write(data);
                    swJSONPayload.Close();
                }
            }

            HttpWebResponse response = null;

            try
            {
                response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("error code: " + response.StatusCode.ToString());
                }

                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                strResponseValue = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";
            }
            finally
            {
                if (response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }
            return strResponseValue;
        }

        public string makeRequest()
       {
           string strResponseValue = string.Empty;

           HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

           request.Method = httpMethod.ToString();


           HttpWebResponse response = null;

           try
           {
               response = (HttpWebResponse)request.GetResponse();
               if (response.StatusCode != HttpStatusCode.OK)
               {
                   throw new ApplicationException("error code: " + response.StatusCode.ToString());
               }
               //Process the response stream...(could be JSON, XML or HTML)
               using (Stream responseStream = response.GetResponseStream())
               {
                   if (responseStream != null)
                   {
                       using (StreamReader reader = new StreamReader(responseStream))
                       {
                           strResponseValue = reader.ReadToEnd();
                       }
                   }
               }
           }
           catch (Exception ex) 
           {
               strResponseValue = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";
           }
           finally
           {
               if (response != null)
               {
                   ((IDisposable)response).Dispose();
               }
           }
           return strResponseValue;
       }

    }
}
