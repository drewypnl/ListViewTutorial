﻿using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using System;

namespace listViewTutorial
{
    [Activity(Label = "listViewTutorial", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private List<Person> mItems;
        private ListView mListView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            mListView = FindViewById<ListView>(Resource.Id.myListView);
            mItems = new List<Person>();

            mItems.Add(new Person() { FirstName = "Steve", LastName = "Drew", Age = "42", Gender = "Male" });
            mItems.Add(new Person() { FirstName = "Kate", LastName = "Drew", Age = "53", Gender = "Female" });
            mItems.Add(new Person() { FirstName = "Ellie", LastName = "Blenkin", Age = "24", Gender = "Female" });

            MyListViewAdapter adapter = new MyListViewAdapter(this, mItems);

            mListView.Adapter = adapter;

            mListView.ItemClick += MListView_ItemClick;
            mListView.ItemLongClick += MListView_ItemLongClick;
        }
        private void MListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Console.WriteLine(mItems[e.Position].FirstName);
        }

        private void MListView_ItemLongClick(object sender, AdapterView.ItemLongClickEventArgs e)
        {
            Console.WriteLine(mItems[e.Position].LastName);
        }
    }
}


