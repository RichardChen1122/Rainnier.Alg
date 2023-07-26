using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rannier.Alg.Core.LanguageFeature
{
    internal class RecordFeature
    {
        public void Execute()
        {
            var s = new Student();
            s.Test();
        }
    }

    internal record Student
    {
        public int Age { get; init; }
        public string Name { get; init; }

        public string Test()
        {
            return Age + Name;
        }
    }

    internal class MyStudent
    {
        public int Age { get; init; }
        public string Name { get; init; }
    }
}
