using System;
using System.Collections.Generic;
using System.Text;

namespace _02.XAMLBaseDKill
{
    public  class Person
    {
        /// <summary>
        /// 编号
        /// </summary>
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// 姓名
        /// </summary>
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 年龄
        /// </summary>
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        /// <summary>
        /// 工资
        /// </summary>
        private double _salary;
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
       
    }
}
