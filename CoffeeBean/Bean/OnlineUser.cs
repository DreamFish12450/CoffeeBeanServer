namespace CoffeeBean.Bean
{
    public class OnlineUser
    {
        private string phoneNumber;
        private string name;

        public OnlineUser(string phoneNumber, string name)
        {
            this.phoneNumber = phoneNumber;
            this.name = name;
        }

        public string PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public override string ToString()
        {
            return $"用户名：{name},电话号码{phoneNumber}";
        }
    }
}