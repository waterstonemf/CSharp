using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace WhatHappened
{
    [DataContract]
    public class CustomerInfo
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

        public CustomerInfo(string cardNumber, string name, int age, char sex)
        {
            this._cardNumber = cardNumber;
            this._name = name;
            this._age = age;
            this._sex = sex;
        }

        public CustomerInfo()
            : this("", "", -1, 'F')
        {
        }
    }
}
