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

            TextView musicWelcome = FindViewById<TextView>(Resource.Id.txtMusicWelcome);
            musicWelcome.Text = "Check out some of the music you\'ll be hearing at our concerts to get you in the mood.";

            TextView musicHelp = FindViewById<TextView>(Resource.Id.txtMusicHelp);
            musicHelp.Text = "Click the title of the song and then the \"Play/Pause\" button to start listening. Stop by pressing the \"Stop\" button.";

            Button motherLandButton = FindViewById<Button>(Resource.Id.btnCommunism);
            Button meLikeyButton = FindViewById<Button>(Resource.Id.btnLikey);
            Button knockKnockButton = FindViewById<Button>(Resource.Id.btnDoor);

            Button playStopButton = FindViewById<Button>(Resource.Id.btnPlayStop);
            Button pauseButton = FindViewById<Button>(Resource.Id.btnPause);

            int lastPlayed = 0 ;

            motherLandButton.Click += (sender, e) =>
            {
                if (player != null)
                { 
                    if (player.IsPlaying)
                        player.Stop();
                }
                player = MediaPlayer.Create(this, Resource.Raw.russia);
                lastPlayed = Resource.Raw.russia;
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
                lastPlayed = Resource.Raw.knockknock;
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
                lastPlayed = Resource.Raw.likey;
                player.Start();
            };

            playStopButton.Click += (sender, e) =>
            {

                if (lastPlayed != 0)
                {
                    if (player.IsPlaying)
                    {
                        player.Stop();
                    }
                    else
                    {
                        player = MediaPlayer.Create(this, lastPlayed);
                        player.Start();
                    }
                }
            };
            pauseButton.Click += (sender, e) =>
            {
                if (player != null)
                {
                    if (player.IsPlaying)
                    {
                        player.Pause();
                        pauseButton.Text = "Unpause";
                    }
                    else
                    {
                        player.Start();
                        pauseButton.Text = "Pause";
                    }
                }
            };
        }
    }
}