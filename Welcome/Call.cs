using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Provider;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Welcome
{
    [Activity(Label = "Call")]
    public class Call : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Call);
            // Create your application here
            EditText phone = FindViewById<EditText>(Resource.Id.txtEnterPhone);
            Button callButton = FindViewById<Button>(Resource.Id.btnCall);
            string phoneNumber = "";
            int testedNumber = 0;
            callButton.Enabled = false;

            phone.TextChanged += (sender, e) =>
            {
                if (int.TryParse(phone.Text, out testedNumber))
                {
                    int numberLength =  Convert.ToInt32(Math.Floor(Math.Log10(testedNumber) + 1));
                    //callButton.Text = numberLength.ToString();
                    // Allowing for 10 digit long Number
                    // Ex: 9059059059
                    if (numberLength == 10)
                    {
                        callButton.Enabled = true;
                    }
                    else
                        callButton.Enabled = false;
                }
                else
                    callButton.Enabled = false;
            };
            
            if(phoneNumber != "")
            {
                callButton.Click += (object sender, EventArgs e) =>
                {
                    var callDialog = new AlertDialog.Builder(this);
                    callDialog.SetMessage("Call?");
                    callDialog.SetNeutralButton("Call", delegate
                    {
                        var callIntent = new Intent(Intent.ActionCall);
                        callIntent.SetData(Android.Net.Uri.Parse("tel:" + phoneNumber));
                    });
                    callDialog.SetNegativeButton("Cancel", delegate { });
                    callDialog.Show();
                };
            }

            
        }
    }
}