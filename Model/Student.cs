using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBS.Model
{
    class Student
    {
        private int _Id { get; }
        private string _NameSurname { get; }
        private string _Department{ get; }
        private string[] _Lessons { get; }

        public Student(int studentId, string studentName, string department, string[] lessons)
        {
            this._Id = studentId;
            this._NameSurname = studentName;
            this._Department = department;
            this._Lessons = lessons; 
        }
    }
}
