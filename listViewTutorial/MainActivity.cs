using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace listViewTutorial
{
    [Activity(Label = "listViewTutorial", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private List<string> mItems;
        private ListView mListView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            mListView = FindViewById<ListView>(Resource.Id.myListView);
            mItems = new List<string>();

            mItems.Add("Steve");
            mItems.Add("Kate");
            mItems.Add("Ellie");
            mItems.Add("Greg");
            mItems.Add("Connor");
            mItems.Add("Nick");

            MyListViewAdapter adapter = new MyListViewAdapter(this, mItems);

            mListView.Adapter = adapter;
        }
    }
}

