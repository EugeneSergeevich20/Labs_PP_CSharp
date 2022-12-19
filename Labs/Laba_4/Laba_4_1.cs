using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.Laba_4
{
    internal class Laba_4_1
    {
        public int m_size;
        public string m_format;
        public int size1;
        public string format1;

        public Laba_4_1()
        {
            m_size = 0;
            size1 = 0;
            m_format = "";
            format1 = "";
        }
        Laba_4_1(int m_size, string format1, int size1, string m_format)
        {
            this.m_size = m_size;
            this.size1 = size1;
            this.m_format = m_format;
            this.format1 = format1;
        }
        public void SetsizeofMessage(string str) //Ввод данных о размере сообщения в класс
        {
            string[] _str = str.Split(' ');

            this.m_size = int.Parse(_str[0]);
            this.m_format = _str[1];

            ConvertofFormatMessage(str);

        }
        public void Setsizeof1Packet(string str) //Ввод данных о размере 1 пакета в класс
        {
            string[] _str = str.Split(' ');

            this.size1 = int.Parse(_str[0]);
            this.format1 = _str[1];

            ConvertofFormatPacket(str);


        }
        public void ConvertofFormatMessage(string str) //Конвертирование единицы измерения размера сообщения
        {
            string[] _str = str.Split(' ');
            this.m_size = int.Parse(_str[0]);
            this.m_format = _str[1];

            if (this.m_format == "KB")
            {
                this.m_size *= 1024;
                Console.Write(this.m_size + " bytes");
            }
            if (this.m_format == "MB")
            {
                this.m_size *= 1048576;
                Console.Write(this.m_size + " bytes");
            }

        }
        public void ConvertofFormatPacket(string str) //Конвертирование единицы измерения размера 1 пакета
        {
            string[] _str = str.Split(' ');
            this.size1 = int.Parse(_str[0]);
            this.format1 = _str[1];

            if (this.format1 == "KB")
            {
                this.size1 *= 1024;
                Console.WriteLine(this.size1 + " bytes");
            }
            if (this.format1 == "MB")
            {
                this.size1 *= 1048576;
                Console.WriteLine(this.size1 + " bytes");
            }
            CheckException(this.size1);
        }
        void CheckException(int m_size) //Проверка исключения в указании размера 1 пакета
        {

            this.m_size = m_size;
            try
            {
                if (32 < this.m_size && this.m_size < 32768)
                {
                    Console.WriteLine("All ok");

                }
                else
                    throw new Exception("Размер не соответствует диапозону");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");


            }
        }
    }
}
