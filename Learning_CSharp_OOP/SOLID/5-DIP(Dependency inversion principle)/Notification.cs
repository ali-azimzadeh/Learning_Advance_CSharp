using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp_OOP.SOLID._5_DIP_Dependency_inversion_principle_
{
    //***************
    // Solution(1) 
    //***************
    //public class Notification
    //{
    //    private Email _email;
    //    public Notification()
    //    {
    //        _email = new Email();
    //    }

    //    public void PromotionalNotification()
    //    {
    //        _email.SendEmail();
    //    }
    //}

    //******************************************
    // Solution(2) 
    //Notification class depends on Email class
    //******************************************

    //public class Notification
    //{
    //    private IMessenger _iMessenger;
    //    public Notification() => _iMessenger = new Email();
    //    public void DoNotify()
    //    {
    //        _iMessenger.SendMessage();
    //    }
    //}

    //*********************
    // Solution(3) 
    //Constructor Injection
    //*********************

    //public class Notification
    //{
    //    private IMessenger _iMessenger;
    //    public Notification(IMessenger pMessenger)
    //    {
    //        _iMessenger = pMessenger;
    //    }
    //    public void DoNotify()
    //    {
    //        _iMessenger.SendMessage();
    //    }
    //}

    //*********************
    // Solution(3) 
    //Property Injection
    //*********************

    //public class Notification
    //{
    //    private IMessenger _iMessenger;

    //    public Notification()
    //    {
    //    }
    //    public IMessenger MessageService
    //    {
    //        private get 
    //        {
    //            return _iMessenger;
    //        }
    //        set
    //        {
    //            _iMessenger = value;
    //        }
    //    }

    //    public void DoNotify()
    //    {
    //        _iMessenger.SendMessage();
    //    }
    //}

    //*********************
    // Solution(4) 
    //Method Injection
    //*********************
    //public class Notification
    //{
    //    public void DoNotify(IMessenger pMessenger)
    //    {
    //        pMessenger.SendMessage();
    //    }
    //}
}
