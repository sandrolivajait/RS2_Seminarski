using Microsoft.Extensions.Configuration;
using ServiceLayer.Classes.Helper;
using Model.Models;


namespace ServiceLayer.Interfaces
{
    public interface ISmsService
    {
        string SendSms(SmsModel entity);
    }
}
