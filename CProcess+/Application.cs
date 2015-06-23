using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CProcess_
{
    public class Application
    {
        private string _Name;
        private string _File;

        public Application() { }

        public Application(string name, string filepath)
        {
            
            _Name = name;
            _File = filepath;
        }

        public string Name { get { return _Name;} set { _Name = value ;} }
        public string Filepath { get { return _File;} set { _File = value;}}
    }
}
