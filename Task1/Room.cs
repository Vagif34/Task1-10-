using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Room
    {
        public int  _id;
        private string _name;
        private double _price;
        private int _personCapacity;
        private bool _isAvailable;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length>0)
                {
                    _name = value;
                }
            }
        }
        public int Id { get; } 
        public  Room()
        {
            _id++;
            _id = Id;
        }
        public int PersonCapacity
        {
            get
            {
                return _personCapacity;
            }
            set
            {
                if (value > 0)
                {
                    _personCapacity = value;
                }
            }
        }
        public bool IsAviable { get; set; }
      
        
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }

        public string ShowInfo()
        {
            return ("Room price- " + Price +  "Room IsAviable - " + IsAviable + "Room name -"+Name);
        }
        public override string ToString()
        {
            return ShowInfo();
        }
        public Room(int Id,string Name,double Price,bool IsAviable,int PersonCapacity)
        {
            _id = Id;
            _name = Name;
            _price = Price;
            _isAvailable = IsAviable;
            _personCapacity = PersonCapacity;
        }
       

        
    }
}
