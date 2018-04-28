/*
 * Authors: Calvin Lapp, Elizabeth Welch, Colin Strong
 * Date: 4/26/2018
 * Description: This file is used for the Listen.axml,
 * depending on which button was pressed it will play
 * a different song.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Welcome
{
    [Activity(Label = "Listen")]
    class Audio : Activity
    {
        MediaPlayer player;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Listen);

            Button motherLandButton = FindViewById<Button>(Resource.Id.btnCommunism);
            Button meLikeyButton = FindViewById<Button>(Resource.Id.btnLikey);
            Button knockKnockButton = FindViewById<Button>(Resource.Id.btnDoor);

            motherLandButton.Click += (sender, e) =>
            {
                if (player != null)
                { 
                    if (player.IsPlaying)
                        player.Stop();
                }
                player = MediaPlayer.Create(this, Resource.Raw.russia);
                player.Start();
            };

            knockKnockButton.Click += (sender, e) =>
            {
                if (player != null)
                {
                    if (player.IsPlaying)
                        player.Stop();
                }
                player = MediaPlayer.Create(this, Resource.Raw.knockknock);
                player.Start();
            };

            meLikeyButton.Click += (sender, e) =>
            {
                if (player != null)
                {
                    if (player.IsPlaying)
                        player.Stop();
                }
                player = MediaPlayer.Create(this, Resource.Raw.likey);
                player.Start();
            };
        }
    }
}