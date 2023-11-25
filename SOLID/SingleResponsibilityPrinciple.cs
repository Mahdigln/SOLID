using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public interface IUser
    {
        void AddUser();
        void RemoveUser();
        void UpdateUser();
    }
    public interface ILog
    {
        void Logger();
    }
    public interface IMessage
    {
        void Message();
    }
    public class User : IUser
    {
        public void AddUser()
        {
            Console.WriteLine("Added User");
        }
        public void RemoveUser()
        {
            Console.WriteLine("Removed User");
        }
        public void UpdateUser()
        {
            Console.WriteLine("User Updated");
        }
    }

    public class Log : ILog
    {
        public void Logger()
        {
            Console.WriteLine("Logged Error");
        }
    }

    public class Msg : IMessage
    {
        public void Message()
        {
            Console.WriteLine("Messaged Sent");
        }
    }
    class Class_DI
    {
        private readonly IUser _user;
        private readonly ILog _log;
        private readonly IMessage _msg;
        public Class_DI(IUser user, ILog log, IMessage msg)
        {
            this._user = user;
            this._log = log;
            this._msg = msg;
        }
        public void User()
        {
            this._user.AddUser();
            this._user.RemoveUser();
            this._user.UpdateUser();
        }
        public void Log()
        {
            this._log.Logger();
        }
        public void Msg()
        {
            this._msg.Message();
        }
    }

    class Example1
    {
        public static void Main()
        {
            Class_DI di = new Class_DI(new User(), new Log(), new Msg());
            di.User();
            di.Log();
            di.Msg();
            Console.ReadLine();
        }
    }
    
}
