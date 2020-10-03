using Nexmo.Api.Messaging;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

using Model.Database;
using Nexmo.Api.Request;
using ServiceLayer.Classes.Helper;
using Microsoft.Extensions.Configuration;
using RepositoryLayer;
using Microsoft.Extensions.Options;

namespace ServiceLayer.Classes
{
    public class SmsService : ISmsService
    {
        private IRepository<SmsLog> SmsRepository { get; set; }
        private SmsSettings SmsSettings { get; set; }

        public SmsService(IRepository<SmsLog> smsRepository, IOptions<SmsSettings> smsSettings)
        {
            this.SmsRepository = smsRepository;
            this.SmsSettings = smsSettings.Value;
        }

        public string SendSms(SmsModel entity)
        {
            

            var credentials = Credentials.FromApiKeyAndSecret(SmsSettings.NEXMO_API_KEY, SmsSettings.NEXMO_API_SECRET);
            var client = new SmsClient(credentials);
            var request = new SendSmsRequest { To = entity.To, From = SmsSettings.BROJ_MOBITELA, Text = entity.Text };
            var response = client.SendAnSms(request);

            // if we sent the sms succesfully save the details to database.
            if(response != null) { 
                SmsLog log = new SmsLog { Broj = entity.To, Poruka = entity.Text, Dodatnisadrzaj = response.Messages[0].MessageId };
                SmsRepository.Insert(log);
                return response.Messages[0].MessageId;
            }

            return null;
        }
    }
}
