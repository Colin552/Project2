/*
 * 
 * 
 * 
 */
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace Welcome
{
    [Activity(Label = "Concert Helper", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            Button learnButton = FindViewById<Button>(Resource.Id.btnLearn);
            Button photoButton = FindViewById<Button>(Resource.Id.btnPhoto);
            Button callButton = FindViewById<Button>(Resource.Id.btnCall);
            Button listenButton = FindViewById<Button>(Resource.Id.btnListen);

            learnButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Learn));
                StartActivity(intent);
            };

            photoButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Photo));
                StartActivity(intent);
            };

            callButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Call));
                StartActivity(intent);
            };

            listenButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Audio));
                StartActivity(intent);
            };
        }
    }
}

