using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using TweetMVVM.Models;

namespace TweetMVVM.ViewModels
{
    public class PostsViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Post> Posts { get; set; }

        public PostsViewModel ()
        {
            Posts = new ObservableCollection<Post>();

            Posts.Add(new Post { Message = "Hello", Username = "Bob" });
            Posts.Add(new Post { Message = "Is this thing on?", Username = "Geiger4Evah" });
            Posts.Add(new Post { Message = "Build the wall!", Username = "President" });
            Posts.Add(new Post { Message = "How many days left in the semester? Let me count.", Username = "TheCount" });
            Posts.Add(new Post { Message = "Houston, we have a problem.", Username = "InternationalSpaceStation" });

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
