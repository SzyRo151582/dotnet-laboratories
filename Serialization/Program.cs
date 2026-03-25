using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person student = new Person();
            student.name = "ABC";
            student.surname = "XYZ";
            student.pesel = 12345678901;
            student.street = "Grunwaldzka";
            student.house = "123B";
            student.flat = "15";
            student.city = "Gdansk";

            string fileName = "StudentData.xml";

            void Save()
            {
                XmlSerializer serializer1 = new XmlSerializer(typeof(Person));
                using (var fileStream = new FileStream(fileName, FileMode.Create))
                {
                    serializer1.Serialize(fileStream, student);
                }
            }

            void Load()
            {
                XmlSerializer serializer1 = new XmlSerializer(typeof(Person));
                using (var fileStream = new FileStream(fileName, FileMode.Open))
                {
                    student = (Person)serializer1.Deserialize(fileStream);
                    Console.Write($"{student.name} {student.surname} {student.pesel} {student.street} {student.house} {student.flat} {student.city}");
                    Console.ReadKey();
                }
            }

            Save();
            Load();

        }
    }
}

