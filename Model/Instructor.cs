using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBS.Model
{
    class Instructor
    {
        private int _Id { get; }
        private string _NameSurname{ get; }
        private string _Title{ get; }
        private string _Department{ get; }
        private string[] _lessons{ get; }

        public Instructor(int id, string name, string title, string department, string[] lessons)
        {
            this._Id = id;
            this._NameSurname = name;
            this._Title = title;
            this._Department = department;
            this._lessons= lessons;
        }
    }
}
