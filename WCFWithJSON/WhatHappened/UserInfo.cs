using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WhatHappened
{
    [DataContract]
    public class UserInfo
    {
        private string _cardNumber;
        [DataMember]
        public string CardNumber
        {
            get { return this._cardNumber; }
            set { this._cardNumber = value; }
        }

        private string _name;
        [DataMember]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        private string _role;
        [DataMember]
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        private int _age;
        [DataMember]
        public int Age
        {
            get { return this._age; }
            set { this._age = value; }
        }

        private char _sex;
        [DataMember]
        public char Sex
        {
            get { return this._sex; }
            set { this._sex = value; }
        }

        public UserInfo(string cardNumber, string name, string role ,int age, char sex)
        {
            this._cardNumber = cardNumber;
            this._name = name;
            this._role = role;
            this._age = age;
            this._sex = sex;
        }

        public UserInfo()
            : this("", "","", -1, 'F')
        {
        }
    }
}
