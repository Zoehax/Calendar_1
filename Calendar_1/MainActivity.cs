using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;

namespace Calendar_1
{
    [Activity(Label = "217196947", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.face);

            var btnStart = FindViewById<Button>(Resource.Id.btnStart);
            btnStart.Click += (s, e) =>
            {
                Intent nextActity_0 = new Intent(this, typeof(Activity1));
                StartActivity(nextActity_0);
            };

            var btnClose = FindViewById<Button>(Resource.Id.btnClose);

            btnClose.Click += delegate
            {
                this.Finish();
            };

        }
    }
}
