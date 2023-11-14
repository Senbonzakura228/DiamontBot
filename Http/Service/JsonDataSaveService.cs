using System;
using System.Diagnostics;
using System.IO;
using System.Net.Mime;
using Newtonsoft.Json;

namespace MyNameIsGiorgio.Http.Service
{
    public class JsonDataSaveService
    {
        public bool SaveData<T>(string relativePath, T data)
        {
            var path = relativePath;
            if (File.Exists(path))
            {
                try
                {
                    File.Delete(path);
                    using (FileStream stream = File.Create(path))
                    {
                        stream.Close();
                        File.WriteAllText(path, JsonConvert.SerializeObject(data));
                        return true;
                    }
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            else
            {
                try
                {
                    using (FileStream stream = File.Create(path))
                    {
                        stream.Close();
                        File.WriteAllText(path, JsonConvert.SerializeObject(data));
                        return true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
            }
        }

        public T LoadData<T>(string relativePath)
        {
            var path = relativePath;
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"{path} does not exist");
            }

            try
            {
                var data = JsonConvert.DeserializeObject<T>(File.ReadAllText(path));
                return data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}