namespace WebAppBruh.Models {
    public class Message {
        public string msg { get;  set; }

        public int pgnum { get;  set; }

        public Message() {
            this.msg = string.Empty;
            this.pgnum = 0;
        }

        public Message(string msg, int pgnum) { 
            this.msg = msg;
            this.pgnum = pgnum;
        }
    }
}
