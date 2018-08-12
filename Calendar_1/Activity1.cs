using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace Calendar_1
{
    [Activity(Label = "SIT 313")]
    public class Activity1 : AppCompatActivity
    {
       
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var calendarView = FindViewById<CalendarView>(Resource.Id.calendarView);
            var txtDisplay = FindViewById<TextView>(Resource.Id.txtDisplay);

            txtDisplay.Text = "Date: ";

            calendarView.DateChange += (s, e) =>
            {
                int day = e.DayOfMonth;
                int month = e.Month;
                int year = e.Year;
                txtDisplay.Text = "Date: " + day + " / " + month + " / " + year;

            };

            var btnJump = FindViewById<Button>(Resource.Id.btnJump);
            btnJump.Click += (s, e) =>
            {
                Intent nextActity_0 = new Intent(this, typeof(Activity_mid));
                StartActivity(nextActity_0);
            };
            var btnBac = FindViewById<Button>(Resource.Id.btnBtF);
            btnBac.Click += delegate
            {
                this.Finish();
            };

        }
    }
}