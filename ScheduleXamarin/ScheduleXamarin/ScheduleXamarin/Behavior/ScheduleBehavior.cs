using Syncfusion.SfSchedule.XForms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ScheduleXamarin
{
    public class ScheduleBehavior : Behavior<ContentPage>
    {
        SfSchedule schedule;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            schedule = bindable.FindByName<SfSchedule>("schedule");
            schedule.AppointmentDragOver += schedule_AppointmentDragOver;
        }
        private void schedule_AppointmentDragOver(object sender, AppointmentDragEventArgs e)
        {
            if (e.DraggingTime.Minute == 30 || e.DraggingTime.Minute == 00)
            {
                schedule.DragDropSettings.ShowTimeIndicator = true;
            }
            else
                schedule.DragDropSettings.ShowTimeIndicator = false;
        }
        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            schedule.AppointmentDragOver -= schedule_AppointmentDragOver;
        }
    }
}
