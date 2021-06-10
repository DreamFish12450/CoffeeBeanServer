using System;

namespace CoffeeBean.Bean
{
    public class PhoneRecord
    {
        private string noteName;
        private string phoneNumber;
        private int status;
        private DateTime date;
        private string avaterUrl;

        int duration;

        public int Duration
        {
            get => duration;
            set => duration = value;
        }

        public int Status
        {
            get => status;
            set => status = value;
        }

        public DateTime Date
        {
            get => date;
            set => date = value;
        }

        public PhoneRecord(string noteName, string phoneNumber, int status, DateTime date, string avaterUrl,
            int duration)
        {
            this.noteName = noteName;
            this.phoneNumber = phoneNumber;
            this.status = status;
            this.date = date;
            this.avaterUrl = avaterUrl;
            this.duration = duration;
        }

        public PhoneRecord()
        {
        }

        public string NoteName
        {
            get => noteName;
            set => noteName = value;
        }

        public string PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }

        public string AvaterUrl
        {
            get => avaterUrl;
            set => avaterUrl = value;
        }
    }
}