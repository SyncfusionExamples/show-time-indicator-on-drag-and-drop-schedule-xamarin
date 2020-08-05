using Syncfusion.SfSchedule.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ScheduleXamarin
{
    public class SchedulerViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Meeting> meetings;

        public ObservableCollection<Meeting> Meetings
        {
            get
            {
                return meetings;
            }

            set
            {
                meetings = value;
                this.OnPropertyChanged("Meetings");
            }
        } 
        public SchedulerViewModel ()
        {
            Meetings = new ObservableCollection<Meeting>();
            Meeting meeting = new Meeting();
            meeting.From = DateTime.Today.AddHours(13);
            meeting.To = meeting.From.AddHours(1);
            meeting.EventName = "Anniversary";
            meeting.AllDay = false;
            meeting.Color = Color.Green;
            Meetings.Add(meeting);
        }
        /// <summary>
        /// Occurs when property changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Invoke method when property changed.
        /// </summary>
        /// <param name="propertyName">property name</param>
        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
