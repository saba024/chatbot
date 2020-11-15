using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace chatbot.Models
{
    public class TelegramUser : INotifyPropertyChanged
    {

        private string nick;
        private long id;
        public ObservableCollection<string> Messages { get; set; }

        public TelegramUser()
        {
           
        }

        public TelegramUser(string nick, long id)
        {
            this.nick = nick;
            this.id = id;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public string Nick
        {
            get { return this.nick; }
            set {
                this.nick = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Nick)));
            }
        }

        public long Id
        {
            get { return this.id; }
            set
            {
                this.id = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Id)));
            }
        }

        public void AddMessage(string Text)
        {
            Messages.Add(Text);
        }

        public bool Equals(TelegramUser other)
        {
            return other.Id == this.Id;
        }
    }
}
