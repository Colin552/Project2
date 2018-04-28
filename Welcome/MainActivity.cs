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
    [Activity(Label = "Tissue Emporium", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button learnButton = FindViewById<Button>(Resource.Id.btnLearn);
            Button photoButton = FindViewById<Button>(Resource.Id.btnPhoto);

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


        }

        
    }
}

