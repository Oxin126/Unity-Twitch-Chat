namespace Lexone.UnityTwitchChat
{
    [System.Serializable]
    public class Raider
    {
        public Raider(string channel, IRCRaid tags)
        {
            this.channel = channel;
            this.tags = tags;
        }

        public string channel;
        public IRCRaid tags = null;
    }
}