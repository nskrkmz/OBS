using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBS.Model
{
    class Personnel
    {
        private int _Id {get;}
        private string _NameSurname{get;}
        private string _Title{get;}
        private string _Department{get;}

        public Personnel(int id, string name, string title, string department)
        {
            this._Id = id;
            this._NameSurname = name;
            this._Title= title;
            this._Department= department;
        }
    }
}
