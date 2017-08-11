using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Widget;

namespace GOH.Zastupovani.Xamarin
{
    [Activity(Label = "GOH Zastupování", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        public string currentClass = string.Empty;
        public string currentDate = string.Empty;
        public List<Supl> supl = new List<Supl>(); 
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            Core.Initialize(); //Init the Core 

            var s = (Spinner) FindViewById(Resource.Id.datesSpinner); //Fill in Dates
            var list = (ListView)FindViewById(Resource.Id.listView1);

            var spinnerArrayAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerDropDownItem,
                Core.GetDates());
            spinnerArrayAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerItem);
            s.Adapter = spinnerArrayAdapter;
            s.ItemSelected += delegate(object sender, AdapterView.ItemSelectedEventArgs args)
            {
                currentDate = Core.GetDatesValues()[args.Position];
                if (currentClass != string.Empty)
                {                   
                    supl = Core.GetSuplovani(currentClass, currentDate);
                    if (supl == null)
                        return;
                    supl.Clear();
                    supl.Add(Core.GetHeader());
                    supl.AddRange(Core.GetSuplovani(currentClass, currentDate));
                    var adapter = new ListViewAdapter(this, supl);
                    list.Adapter = adapter;
                }
            };

            var s2 = (Spinner) FindViewById(Resource.Id.classesSpinner); //Fill in Classes

            var spinnerArrayAdapter2 = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerDropDownItem,
                Core.GetClasses());
            spinnerArrayAdapter2.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerItem);
            s2.Adapter = spinnerArrayAdapter2;
            s2.ItemSelected += delegate (object sender, AdapterView.ItemSelectedEventArgs args)
            {
                currentClass = (string)s2.GetItemAtPosition(args.Position);
                if (currentDate != string.Empty)
                {
                    supl = Core.GetSuplovani(currentClass, currentDate);
                    if (supl == null)
                        return;
                    supl.Clear();
                    supl.Add(Core.GetHeader());
                    supl.AddRange(Core.GetSuplovani(currentClass, currentDate));
                    var adapter = new ListViewAdapter(this, supl);
                    list.Adapter = adapter;
                }
            };
        }
    }
}