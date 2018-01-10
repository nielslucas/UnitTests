using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface MyInterface
    {
        void CreateFileWithUniqueInts();
        List<int> GenerateUniqueIntList();
        List<string> ConvertIntListToStringList(List<int> value);
        void WriteToFile(List<string> value);
    }
}
