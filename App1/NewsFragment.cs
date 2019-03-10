using System;
using System.Collections.Generic;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V4.Widget;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace CanadApp
{
    public class NewsFragment : Fragment
    {
        private int resourceID;

        public NewsFragment(int resourceID)
        {
            this.resourceID = resourceID;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(resourceID, container, false);
            ListView news_list = view.FindViewById<ListView>(Resource.Id.list);
            List<String> testing = new List<String>() { "Ben", "Maddie", "Wild", "Thing" };
            news_list.Adapter = new ArrayAdapter(Activity, Resource.Layout.NewsListItem, testing);
            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
        }
    }
}