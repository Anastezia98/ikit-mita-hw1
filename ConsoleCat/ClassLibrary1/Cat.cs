using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Cat
    {
        private string _name;
        public string Name
        {
            get { return _name; }

            set
            {
                if (string.IsNullOrEmpty(_name))
                {
                    _name = value;
                }
            }
        }

        public DateTime BirthDay { get; set; }

        private TimeSpan _dateSpan;
        public int Age { get; private set; }

        private int _health { get; set; } = 5;

        public void Feed()
        {
            _health += 1;
            Console.WriteLine("Здоровье Вашего кота увеличилось на 1: {0}", _health);
        }

        public void Punish()
        {
            _health -= 1;
            Console.WriteLine("Здоровье Вашего кота уменьшилось на 1: {0}", _health);
        }

        private string _color;
        public string Color
        {
            get
            {
                if (_health > 5)
                {
                    _color = "Зелёный окрас";
                }
                if (_health == 5)
                {
                    _color = "Жёлтый окрас";
                }
                if (_health < 5)
                {
                    _color = "Красный окрас";
                }
                return _color;
            }
        }

        public Cat(string name, DateTime bd)
        {
            Name = name;
            BirthDay = bd;
            _dateSpan = DateTime.Today - BirthDay.Date;
            Age = _dateSpan.Days;
        }

    }


}

