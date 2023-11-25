using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{

    public interface IUser1
    {
        void AddUser();
        void RemoveUser();
        void UpdateUser();
    }
    public interface ILog1
    {
        void Logger();
    }
    public interface IMessage1
    {
        void Message();
    }
    internal class InterfaceSegregationPrinciple
    {
    }
}
