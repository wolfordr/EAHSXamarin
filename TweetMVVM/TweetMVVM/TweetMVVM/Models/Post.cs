using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TweetMVVM.Models
{
    public class Post : INotifyPropertyChanged
    {
        // Private data
        private string message;
        private string username;

        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
                OnPropertyChanged("Message");
            }
        }

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
                OnPropertyChanged("Username");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged (string name)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
