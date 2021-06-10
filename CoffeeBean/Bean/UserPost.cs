namespace CoffeeBean.Bean
{
    public class UserPost
    {
        private int id;
        private int userId;
        private string content;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public int UserId
        {
            get => userId;
            set => userId = value;
        }

        public string Content
        {
            get => content;
            set => content = value;
        }

        public UserPost(int id, int userId, string content)
        {
            this.id = id;
            this.userId = userId;
            this.content = content;
        }
        public UserPost(){}
    }
}