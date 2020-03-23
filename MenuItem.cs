using System;

namespace dotnet_DinerMax3000Console
{
    public class MenuItem
    {
        public string Title; 
        public string Description;
        public double Price 
        {
            get { return _price; } 
            set { 
                if (value > 0) 
                {
                    _price = value; 
                }
                else 
                {
                    throw new ApplicationException("You cannot have free or negative valued items.");
                }
             }
        }

        private double _price; 

    }
}
