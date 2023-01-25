using System;

namespace Learning
{

    public class StudentInformation
    {
        private int _id;
        private string _name;
        private float _marks = 35;
        private string _email;

        public string Email { get; set; }
        public float Marks { get; }
        public int ID
        {
            set
            {
                if( value <= 0)
                {
                    throw new Exception("ID is not being Negative");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }
        public string Name
        {
            set
            {
               if(string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name could not be Null");
                }
                this._name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._name) ? "No Null" : this._name;
            }
        }


    }
    class getset
    {
    }
}
