using System;

namespace Poo
{
    class Persona
    {
        // Atributos
        private int _id;
        private String _name;
        private String _lastName;
        private int _age;
        private String _email;
        private String _direction;

        public Persona(int id, string name, string lastname, int age, string email, string direction )
        {
            this._id = id;
            this._name = name;
            this._lastName = lastname;
            this._age = age;
            this._email = email;
            this._direction = direction;
        }

        public int id { get => _id; set => _id = value; }
        public string name { get => _name; set => _name = value; }
        public string lastName { get => _lastName; set => _lastName = value; }
        public int age { get => _age; set => _age = value; }
        public string email { get => _email; set => _email = value; }
        public string direction { get => _direction; set => _direction = value; }

        public override string ToString()
        {
            return $"Mi nombre es: {name} {lastName} de {age} años de edad, email: {email}, dirección {direction} ";
        }


    }
}
