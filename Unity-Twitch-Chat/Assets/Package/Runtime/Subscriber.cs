namespace Lexone.UnityTwitchChat
{
    [System.Serializable]
    public class Subscriber
    {
        public Subscriber(string channel, string message, IRCSubscription tags)
        {
            this.channel = channel;
            this.message = message;
            this.tags = tags;
        }

        public string channel, message;
        public IRCSubscription tags = null;
    }
}