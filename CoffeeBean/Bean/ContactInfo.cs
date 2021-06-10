namespace CoffeeBean.Bean
{
    public class ContactInfo
    {
        private string noteName;
        private string name;
        private string homeAddress;
        private string workAddress;
        private string career;
        private string phoneNumber;
        private string avaterUri;

        public ContactInfo()
        {
        }

        public ContactInfo(string noteName, string name, string homeAddress, string workAddress, string career,
            string phoneNumber, string avaterUri)
        {
            this.noteName = noteName;
            this.name = name;
            this.homeAddress = homeAddress;
            this.workAddress = workAddress;
            this.career = career;
            this.phoneNumber = phoneNumber;
            this.avaterUri = avaterUri;
        }

        public string NoteName
        {
            get => noteName;
            set => noteName = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string HomeAddress
        {
            get => homeAddress;
            set => homeAddress = value;
        }

        public string WorkAddress
        {
            get => workAddress;
            set => workAddress = value;
        }

        public string Career
        {
            get => career;
            set => career = value;
        }

        public string PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }

        public string AvaterUri
        {
            get => avaterUri;
            set => avaterUri = value;
        }
    }
}