using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Transport;

namespace Tools
{
    public class ProjectSerialize
    {
        /// <summary>
        /// Получение списка транспорта из файла.
        /// </summary>
        public List<ITransport> DeserializeTransport(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            List<ITransport> list = new List<ITransport>();
            while (fs.Position != fs.Length)
            {
                var deserialized = (List<ITransport>)binaryFormatter.Deserialize(fs);
                list = deserialized;
            }
            fs.Close();
            return list;
        }

        /// <summary>
        /// Удаление транспорта из списка.
        /// </summary>
        public void RemoveTransport(int id, List<ITransport> list, string fileName)
        {
            list.RemoveAt(id);
            FileStream fs = new FileStream(fileName, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                for (int i = 0; i < list.Count; i++)
                {
                    formatter.Serialize(fs, list[i]);
                }
            }
            catch (SerializationException exception)
            {
                Console.WriteLine("Filed to serialize. Reason: " + exception.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        /// <summary>
        /// Добавление транспорта в файл.
        /// </summary>
        public void SerializeTranspot(string fileName, List<ITransport> transport)
        {
            FileStream fs = new FileStream(fileName, FileMode.Append);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, transport);
            }
            catch (SerializationException exception)
            {
                Console.WriteLine("Filed to serialize. Reason: " + exception.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        /// <summary>
        /// Поиск транспорта в списке.
        /// </summary>
        public List<ITransport> SearchTransport(List<ITransport> transportList, string transportType, string distance)
        {
            List<ITransport> searchList = new List<ITransport>();
            if (transportType == "")
            {
                searchList =
                    transportList.FindAll(
                        transport => transport.Distance.Equals(Convert.ToDouble(distance)));
            }
            else if (distance == "")
            {
                searchList = transportList.FindAll(transport => transport.GetType().Name.Equals(transportType));
            }
            else
            {
                searchList =
                    transportList.FindAll(
                        transport =>
                            transport.GetType().Name.Equals(transportType) &&
                            transport.Distance.Equals(Convert.ToDouble(distance)));
            }
            return searchList;
        }
    }
}