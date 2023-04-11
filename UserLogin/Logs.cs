using System;

namespace UserLogin
{
    public class Logs
    {
        private String text;

        public Logs(string text)
        {
            this.text = text;
        }

        public Logs()
        {
        }

        public string Text
        {
            get => text;
            set => text = value;
        }
    }
}