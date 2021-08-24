using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameStore.Classes;

namespace GameStore.WinForms
{
    public partial class UserControlStoreManagement: UserControl
    {
        Store store;
        public UserControlStoreManagement()
        {
            InitializeComponent();
        }
        public UserControlStoreManagement(Store store)
        {
            this.store = store;
            InitializeComponent();
            ReloadListbox();
            foreach (Game g in store.Games)
            {
                comboBoxSelectGame1.Items.Add(g.Name);
                comboBoxSelectGame2.Items.Add(g.Name);
                comboBoxSelectGame3.Items.Add(g.Name);
                comboBoxSelectGame4.Items.Add(g.Name);
            }
        }

        public void ReloadListbox()
        {
           listView.Items.Clear();
           int index = 0;
           List<ListViewItem> rows = new List<ListViewItem>();
           
           foreach (Game g in store.Games)
           {
               rows.Add(new ListViewItem());
               rows[index].Text = g.ProductId.ToString();
               rows[index].SubItems.Add(g.Name);
               rows[index].SubItems.Add(g.GetType().ToString());
               rows[index].SubItems.Add(g.Price.ToString());
               rows[index].SubItems.Add(g.DiscountRate.ToString());
               rows[index].SubItems.Add(g.Featured.ToString());
               rows[index].SubItems.Add(g.Trending.ToString());
               rows[index].SubItems.Add(g.OnSale.ToString());
               rows[index].SubItems.Add(g.Published.ToString());
               listView.Items.Add(rows[index]);
               index++;
           }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void SelectedGameChanged1(object sender, EventArgs e)
        {
            comboBoxSelectNews1.Items.Clear();
            Game g = store.getGame(comboBoxSelectGame1.Text);
            foreach (News n in g.News)
            {
                comboBoxSelectNews1.Items.Add(n.Title);
            }
        }

        private void SelectedGameChanged2(object sender, EventArgs e)
        {
            comboBoxSelectNews2.Items.Clear();
            Game g = store.getGame(comboBoxSelectGame2.Text);
            foreach (News n in g.News)
            {
                comboBoxSelectNews2.Items.Add(n.Title);
            }
        }

        private void SelectedGameChanged3(object sender, EventArgs e)
        {
            comboBoxSelectNews3.Items.Clear();
            Game g = store.getGame(comboBoxSelectGame3.Text);
            foreach (News n in g.News)
            {
                comboBoxSelectNews3.Items.Add(n.Title);
            }
        }

        private void SelectedGameChanged4(object sender, EventArgs e)
        {
            comboBoxSelectNews4.Items.Clear();
            Game g = store.getGame(comboBoxSelectGame4.Text);
            foreach (News n in g.News)
            {
                comboBoxSelectNews4.Items.Add(n.Title);
            }
        }

        private void buttonSaveTopNews_Click(object sender, EventArgs e)
        {
            if (comboBoxSelectNews1.SelectedIndex == -1 || comboBoxSelectNews2.SelectedIndex == -1 || comboBoxSelectNews3.SelectedIndex == -1 || comboBoxSelectNews4.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select All TopNews");
            }
            else
            {
                store.TopNews[0] = store.getNews(comboBoxSelectNews1.Text);
                store.TopNews[1] = store.getNews(comboBoxSelectNews2.Text);
                store.TopNews[2] = store.getNews(comboBoxSelectNews3.Text);
                store.TopNews[3] = store.getNews(comboBoxSelectNews4.Text);
            }
        }

        private void buttonSaveGames_Click(object sender, EventArgs e)
        {
            bool duplicate = false;
            long id = long.Parse(listView.SelectedItems[0].Text);
            bool featured = bool.Parse(textBoxFeatured.Text);
            int onsale = Convert.ToInt32(textBoxOnSale.Text), trending = Convert.ToInt32(textBoxTrending.Text), discount = Convert.ToInt32(textBoxDiscountRate.Text);
            if (trending<-1 || onsale<-1 || (featured!=true && featured!= false) || trending>5 || onsale > 5) { MessageBox.Show("Invalid index"); return; }
            foreach (Game game in store.Games)
            {
                if (game.ProductId == id) continue;
                if (game.OnSale!=-1 && game.OnSale == onsale) { MessageBox.Show("Duplicate Value"); duplicate = true; break; }
                if (game.Trending!=-1 && game.Trending == trending) { MessageBox.Show("Duplicate Value"); duplicate = true; break; }
            }
            if (duplicate == false)
            {
                Game g = store.getGame(id);
                g.DiscountRate = discount;
                g.Featured = featured;
                g.Trending = trending;
                g.OnSale = onsale;
                bool addedToFeatured = false;
                foreach(Game gm in store.FeaturedGames)
                {
                    if(gm.ProductId == id)
                    {
                        addedToFeatured = true;
                        if (g.Featured == false)
                        {
                            store.FeaturedGames.Remove(gm);
                            break;
                        }
                    }
                }
                if (g.Featured == true && addedToFeatured == false) store.FeaturedGames.Add(g);
                string sql = " Update Products Set discountRate='" + g.DiscountRate + "', trending='" + g.Trending + "', featured='" + g.Featured + "', onsale='" + g.OnSale + "', published='" + g.Published + "'  Where productId = '" + id + "'";
                store.Uda.ExecuteQuery(sql);
            }
            ReloadListbox();
        }   

        private void Listview_Click(object sender, MouseEventArgs e)
        {
            textBoxDiscountRate.Text = listView.SelectedItems[0].SubItems[4].Text;
            textBoxFeatured.Text = listView.SelectedItems[0].SubItems[5].Text;
            textBoxTrending.Text = listView.SelectedItems[0].SubItems[6].Text;
            textBoxOnSale.Text = listView.SelectedItems[0].SubItems[7].Text;
        }
    }
}
