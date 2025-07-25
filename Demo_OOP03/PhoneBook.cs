using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP03
{
    public struct PhoneBook
    {
        private string[] names;
        private long[] numbers;
        private int _size;
        public PhoneBook(int size)
        {
           names = new string[size];
            numbers = new long [size];
            _size = size;
        }
        public int Size { get { return _size; } }


        ///***********************************************************
        //Indexer
        //get Number by Indexer
        //for one data type only one indexer
        public long this[string name]
        {
            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    string a = names[i];
                    if (names[i] == name)
                        return numbers[i];
                }
                return -1;

            }

            set
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (names[i] == name)
                    {
                        numbers[i] = value;
                    }
                }
            }
        }

        public string this[int index]
        {
            get
            {
                return $"index={index}, Name={names[index]}, number={numbers[index]}";
            }
        }

       ///*********************************************************

        public void AddPerson(string name,long number,int position)
        {
            if (position >= 0 && position < _size)
            {
                names[position] = name;
                numbers[position] = number;
            }
        }

        public long GetNumber(string name)
        {
            for(int i = 0; i < names.Length; i++)
            {
                string a= names[i];
                if(names[i] == name)
                    return numbers[i];
            }
            return -1;
        }

        public void UpdateNumber(string name,long newNumber)
        {
            for(int i = 0;i < numbers.Length;i++)
            {
                if (names[i] == name)
                {
                    numbers[i] = newNumber;
                }
            }
            
        }

    }
}
