using System;
using System.IO;
using System.Windows.Forms;
using System.Net;

namespace TheListQuote
{
    public partial class QuoteGetter : Form
    {
        //url for downloading the list
        private readonly string LIST_URL = "https://docs.google.com/document/d/14Jy3JvdCvajXGiOo7O-oxCec9W4fwZyHBCpiNbJSy3Y/export?format=txt";
        private readonly string fileName = String.Format(@"{0}\list.txt", Application.StartupPath); //where the list will be saved
        
        public QuoteGetter()
        {
            InitializeComponent();
            DownloadList();
            button1.Visible = false;
            button2.Visible = false;
        }

        string[] lines;

        int quoteNumber;

        //This method doesn't do anything but it needs to exist otherwise winforms gets all pissy.
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //callback for startbutton
        private void StartButton_Click(object sender, EventArgs e)
        {
            getRandomQuote();
            button1.Visible = true;
            button2.Visible = true;
            StartButton.Text = "Random";
        }

        //method to download list
        private void DownloadList()
        {
            //If we already have the list downloaded, delete it and download it again incase there have been any changes. I know this sucks, but I'm making this for fun so i dont care.
            if(File.Exists(fileName))
            {
                Console.WriteLine($"Found old version of list at {fileName}, deleting and redownloading");
                
                try
                {
                    File.Delete(fileName);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"UWU FUCKY WUCKY WHILE DELETING LIST, IS IT IN USE? {e.ToString()}");
                }
            }

            //we'll just download it using WebClient. There are better ways of doing this, but this is the simplest.
            WebClient client = new WebClient();
            Uri uri = new Uri(LIST_URL);
            client.DownloadFile(uri, fileName); //yes, not doing this async causes the program to momentarily hang, but it removes the problem of trying to access the list while it is still downloading
            InitializeList();
        }

        private void InitializeList()
        {
            if(File.Exists(fileName))
            {
                try
                {
                    lines = System.IO.File.ReadAllLines(fileName);
                } catch (Exception e)
                {
                    Console.WriteLine($"Error while loading list into memory {e.ToString()}");
                    DownloadList();
                }
            }
        }

        private void getRandomQuote()
        {
            if (lines[0] != null)
            {
                Random rand = new Random();
                quoteNumber = rand.Next(lines.Length);
                quoteNumber++; //the first line of the text document we are reading isn't actually a quote, so we'll offset by 1 to compensate.
                
                setDisplay(quoteNumber);
            } else
            {
                DownloadList();
                getRandomQuote();
            }
        }

        public string getQuote(int num)
        {
            if(num == 0)
            {
                return getQuote(lines.Length - 1);
            }
            if (lines[0] != null)
            {
                string returnString = "";
                int trimAmt = num.ToString().Length;
                returnString = lines[quoteNumber];
                returnString = returnString.Remove(0, trimAmt + 1);
                return returnString;
            }
            else
            {
                DownloadList();
                getRandomQuote();
                return getQuote(num);
            }
        }

        private void setDisplay(int _quoteNum)
        {
            QuoteBox.Text = getQuote(_quoteNum);
            NumberLabel.Text = _quoteNum + ".";     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (quoteNumber < lines.Length - 1)
            {
                quoteNumber++;
                setDisplay(quoteNumber);
            }
            else
            {
                quoteNumber = 1;
                setDisplay(quoteNumber);
            }
        }

        //callback for prev button
        private void button2_Click(object sender, EventArgs e)
        {
            if (quoteNumber > 1)
            {
                quoteNumber--;
                setDisplay(quoteNumber);
            } else
            {
                quoteNumber = lines.Length - 1;
                setDisplay(quoteNumber);
            }
        }
    }
}
