using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class MyDictionary<Person, Number,Id>
    {
        Person[] _persons;
        Number[] _numbers;
        Id[] _ids;


        public MyDictionary()
        {
            _persons = new Person[0];
            _numbers = new Number[0];
            _ids = new Id[0];

        }

        public void Add(Person person, Number number,Id id)
        {
            Person[] tempPerson = _persons;
            Number[] tempNumber = _numbers;
            Id[] tempId = _ids;

            _persons = new Person[_persons.Length + 1];
            _numbers = new Number[_numbers.Length + 1];
            _ids = new Id[_ids.Length + 1];

            

            for (int i = 0; i < tempPerson.Length; i++)
            {
                _persons[i] = tempPerson[i];
                _numbers[i] = tempNumber[i];
                _ids[i] = tempId[i];
            }

            //_persons[_numbers.Length - 1] = person;
            //_numbers[_numbers.Length - 1] = number;
            //_ids[_numbers.Length - 1] = id;

            bool containsKey = _numbers.Contains(number);
            if (containsKey)
            {
                string msg = number + " nolu key eklenemez. Zaten tanımlı!";
                Exception ex = new Exception(msg);
                throw ex;
            }
            else
            {
                _numbers[_numbers.Length - 1] = number;
                _persons[_persons.Length - 1] = person;
                _ids[_ids.Length - 1] = id;

            }


            Console.WriteLine("{0}, {1},{2}", person, number,id);


        }

    }
}
