using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WhatHappened
{
    [DataContract]
    public class CreditInfo
    {
        private DateTime _recordTime;
        [DataMember]
        public DateTime RecordTime
        {
            get { return this._recordTime; }
            set { this._recordTime = value; }
        }

        private int _creditLine;
        [DataMember]
        public int CreditLine
        {
            get { return this._creditLine; }
            set { this._creditLine = value; }
        }


        public CreditInfo(DateTime recordTime, int creditLine)
        {
            this._recordTime = recordTime;
            this._creditLine = creditLine;
        }

        public CreditInfo()
            : this(DateTime.Now,-1)
        {
        }
    }
}
