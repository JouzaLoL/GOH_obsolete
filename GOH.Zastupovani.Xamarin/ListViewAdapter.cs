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
using Object = Java.Lang.Object;

namespace GOH.Zastupovani.Xamarin
{
    class ListViewAdapter : BaseAdapter
    {
        private List<Supl> _supl;
        private Context lContext;

        public ListViewAdapter(Context context, List<Supl> items)
        {
            _supl = items;
            lContext = context;
        }
        public override int Count
        {
            get { return _supl.Count; }
        }

        public override Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if (row == null)
            {
                row = LayoutInflater.From(lContext).Inflate(Resource.Layout.listview_row, null, false);
            }

            TextView hour = (TextView)row.FindViewById(Resource.Id.hour);
            TextView ucebna = (TextView)row.FindViewById(Resource.Id.ucebna);
            TextView predmet = (TextView)row.FindViewById(Resource.Id.predmet);
            TextView chybejici = (TextView)row.FindViewById(Resource.Id.Chybejici);
            TextView zastup = (TextView)row.FindViewById(Resource.Id.zastupujici);
            TextView note = (TextView)row.FindViewById(Resource.Id.poznamka);
            hour.Text = _supl[position].Hodina;
            ucebna.Text = _supl[position].Ucebna;
            predmet.Text = _supl[position].Predmet;
            chybejici.Text = _supl[position].Chybejici;
            zastup.Text = _supl[position].Zastupujici;
            note.Text = _supl[position].Poznamka;

            return row;
        }

        public Supl this[int position]
        {
            get { return _supl[position]; }
        }

    }
}