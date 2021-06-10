namespace CoffeeBean.Bean
{
    public class userInfo
    {
        private int id;
        private string username;
        private string password;
        private int vip_level;
        private double amount;
        private string phoneNumber;
        public int Id
        {
            get => id;
            set => id = value;
        }

        public string PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }
        public string Username
        {
            get => username;
            set => username = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public int VipLevel
        {
            get => vip_level;
            set => vip_level = value;
        }

        public double Amount
        {
            get => amount;
            set => amount = value;
        }

        public userInfo()
        {
        }

        public userInfo(int id, string username, string password, int vipLevel, double amount)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            vip_level = vipLevel;
            this.amount = amount;
        }
    }
}