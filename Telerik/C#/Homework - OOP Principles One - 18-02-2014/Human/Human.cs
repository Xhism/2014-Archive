﻿namespace Human
{
    class Human
    {
        protected string firstName;
        protected string lastName;

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                Validator.ValidateName(value);
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                Validator.ValidateName(value);
                this.lastName = value;
            }
        }
    }
}
