using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace list_T
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] anime= { "one Punch man ", "vinland Saga", "Attack on titan" };
        int[] episodes = { 24, 24, 28 };


        

        List<string> animeList =  new List<string> { "one Punch man ", "vinland Saga", "Attack on titan" };
       List<int> episodesList;

        string[] newAnime ;
        int[] newEpisodes;
        public MainWindow()
        {
            InitializeComponent();

            episodesList = episodes.ToList();
            DisplayFromList();
            runDisplay.Text = "";
           
        }
        public void FormatString(int i)
        {
           // runDisplay.Text = "";

            runDisplay.Text += $"{i}- {animeList[i]}-{episodesList[i]}\n";
        }

        public void DisplayFromList()
        {
            runDisplay.Text = "";

            for (int i = 0; i < animeList.Count ; i++)
            {

                FormatString(i);

            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            runDisplay.Text = "";

            string episodes = txtEpisodes.Text;
            string anime  = txtAnime.Text;
            string fanime = txtAnime.Text;


            runDisplay.Text = "";
         //   string fanime = txtAnime.Text;
            var lepisodes = int.Parse(txtEpisodes.Text);

            animeList.Add(fanime);
            episodesList.Add(lepisodes);
            DisplayFromList();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            runDisplay.Text = "";
            string fanime = txtAnime.Text;
            int lepisodes = int.Parse(txtEpisodes.Text);
            int index = int.Parse(txtinsertto.Text);

            animeList.Insert(index, fanime);
            episodesList.Insert(index, lepisodes);
            DisplayFromList();

           
        }

        

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
           // runDisplay.Text = "";

            string fanime = txtRemove.Text;
            bool wasremoved = animeList.Remove(fanime);
            DisplayFromList();

            if(wasremoved)
            {
                MessageBox.Show($"{fanime} was removed");

            }
            else
            {
                MessageBox.Show("was not removed");
            }
 
            foreach (string name in animeList)
            {
                runDisplay.Text += name + "\n";
                runDisplay.Text = "";


            }
           

             DisplayFromList();
        }

        private void btnremoveNum_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(txtremoveNum.Text);

            if(index < animeList.Count)
            {
                animeList.RemoveAt(index);
                episodesList.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("input a number ");
            }

            DisplayFromList();

        }

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            runDisplay.Text = "";

        }
    }
}
