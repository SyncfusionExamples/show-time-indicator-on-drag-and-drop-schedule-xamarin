# How to show time indicator on a specific time when dragging an appointment in Xamarin.Forms Schedule (Sfschedule)

You can show the popup on specific time when do drag and drop the appointment in Xamarin.Forms [SfSchedule](https://help.syncfusion.com/xamarin/scheduler/getting-started) by using the [DragDropSetting ShowTimeIndicator](https://help.syncfusion.com/xamarin/scheduler/drag-and-drop-appointments#customize-appearance-of-dragging-time-indicator) property in a [AppointmentDragOver](https://help.syncfusion.com/xamarin/scheduler/drag-and-drop-appointments#get-the-dragging-appointment-position) event

You can also refer the following article.

https://www.syncfusion.com/kb/11859/how-to-show-time-indicator-on-a-specific-time-when-dragging-an-appointment-in-xamarin-forms

**C#**

**ShowTimeIndicator** property updated in **AppointmentDragOver** event based on the dragging time.

``` c#
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
        schedule.AppointmentDragOver += schedule_AppointmentDragOver;
    }
}
```

**Output**

![ShowTimeIndicator](https://github.com/SyncfusionExamples/show-time-indicator-on-drag-and-drop-schedule-xamarin/blob/master/ScreenShot/ShowTimeIndicator.gif)
