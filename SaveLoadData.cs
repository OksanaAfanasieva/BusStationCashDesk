using BusStationCashDesk.Windows_Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BusStationCashDesk.Classes
{
    public class SaveLoadData<T> //Клас для збереження та завантаження даних
    {
        private string filePath;

        public SaveLoadData(string filePath)
        {
            this.filePath = filePath;
        }

        //Метод, що зберігає список у файл .json
        public void Save(List<T> users)
        {
            string jsonData = JsonSerializer.Serialize(users);
            File.WriteAllText(filePath, jsonData);
        }

        //Метод, що перетворює дані з файлу .json у список
        public List<T> Load()
        {
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<T>>(jsonData) ?? new List<T>();
            }
            else
            {
                return new List<T>();
            }
        }
    }
}
