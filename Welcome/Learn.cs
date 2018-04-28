using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Welcome
{
    [Activity(Label = "Learn")]
    public class Learn : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Learn);

            Button firstButton = FindViewById<Button>(Resource.Id.btnBuy1);
            Button secondButton = FindViewById<Button>(Resource.Id.btnBuy2);
            Button thirdButton = FindViewById<Button>(Resource.Id.btnBuy3);

            firstButton.Click += (sender, e) =>
            {
                DoStuffWhenClicked();
            };

            secondButton.Click += (sender, e) =>
            {
                DoStuffWhenClicked();
            };

            thirdButton.Click += (sender, e) =>
            {
                DoStuffWhenClicked();
            };
            // Create your application here
        }

        public void DoStuffWhenClicked()
        {
            Android.App.AlertDialog.Builder dialog = new AlertDialog.Builder(this);
            AlertDialog alert = dialog.Create();
            alert.SetTitle("Sold Out");
            alert.SetMessage("Sorry, all tickets are currently sold out.");
            alert.SetButton("OK", (c, ev) =>
            {
                // Ok button click task  
            });
            alert.Show();
        }
    }
}