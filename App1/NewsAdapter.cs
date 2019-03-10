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

namespace CanadApp
{
    class NewsAdapter : ArrayAdapter
    {

        Context context;
        private int layoutId;
        private List<String> strings;

        public NewsAdapter(Context context, int layoutId, List<String> strings): base(context, layoutId, strings)
        {
            this.context = context;
            this.layoutId = layoutId;
            this.strings = strings;
        }


        public override Java.Lang.Object GetItem(int position)
        {
            return position;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;
            NewsAdapterViewHolder holder = null;

            if (view != null)
                holder = view.Tag as NewsAdapterViewHolder;

            if (holder == null)
            {
                holder = new NewsAdapterViewHolder();
                var inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
                view = inflater.Inflate(layoutId, parent, false);
                view.Tag = holder;
            }

            //fill in your items
            //holder.Title.Text = "new text here";
            TextView newslisttext = view.FindViewById<TextView>(Resource.Id.news_list_text);

            string value = strings[position];

            newslisttext.Text = value;

            return view;
        }

        //Fill in cound here, currently 0
        public override int Count
        {
            get
            {
                return 0;
            }
        }

    }

    class NewsAdapterViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
        //public TextView Title { get; set; }
    }
}