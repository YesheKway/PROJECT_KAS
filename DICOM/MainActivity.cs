﻿using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace DICOM
{
    [Activity(Label = "DICOM", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        //halo
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

        }
    }
}

