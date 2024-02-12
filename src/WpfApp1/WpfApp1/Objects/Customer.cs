﻿using SQLite;

namespace WpfApp1.Objects
{
    public class Customer
    {
        //[PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 電話番号
        /// </summary>
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name} - {Phone}";
        }
    }
}
