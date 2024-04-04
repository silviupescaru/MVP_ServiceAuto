namespace ServiceAutoMVP.Model
{


    public class User
    {
        protected uint userID;
        protected string username;
        protected string password;
        protected string role;

        public User()
        {
            this.userID = 1;
            this.username = "mike";
            this.password = "nebunu";
            this.role = "Administrator";
        }

        public User(uint userID, string username, string password, string role)
        {
            this.userID = userID;
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public User(User user)
        {
            this.userID = user.userID;
            this.username = user.username;
            this.password = user.password;
            this.role = user.role;
        }

        public uint UserID
        {
            get { return this.userID; }
            set { this.userID = value; }
        }

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public string Role
        {
            get { return this.role; }
            set { this.role = value; }
        }

        public override string ToString()
        {
            string s = "Username: " + this.username;
            s += "\nPassword: " + this.password;
            s += "\nRole: " + this.role;
            return s;
        }
    }
}