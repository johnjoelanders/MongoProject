using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoProject
{
    public partial class Add : Form
    {
        protected static IMongoClient _client = new MongoClient();
        protected static IMongoDatabase _database = _client.GetDatabase("books");
        
            
        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            addCategories();

        }
        private void addCategories()
        {
            comboCategory.Items.Add("Science fiction");
            comboCategory.Items.Add("Action");
            comboCategory.Items.Add("Romance");
            comboCategory.Items.Add("Horror");
            comboCategory.Items.Add("Health");
            comboCategory.Items.Add("Science");
            comboCategory.Items.Add("Autobiographies");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Title: " + txtTitle.Text + "\n" + "Author: " + txtAuthor.Text + "\n" + "Publisher: " + txtPublisher.Text +
                "\n" + "Isbn: " + txtIsbn.Text.ToString() + "\n" + "Category: " + comboCategory.Text, "Hello", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BsonDocument doc = new BsonDocument
            {
                {"Title",txtTitle.Text},
                {"Author",txtAuthor.Text},
                {"Publisher",txtPublisher.Text},
                {"Isbn",txtIsbn.Text},
                {"Category",comboCategory.Text}
            };
            
            var collection = _database.GetCollection<BsonDocument>("books");
            collection.InsertOneAsync(doc);
            txtAuthor.Clear();
            txtIsbn.Clear();
            txtPublisher.Clear();
            txtTitle.Clear();
            comboCategory.Items.Clear();
            addCategories();
            
        }

        private void showBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            read readFrm = new read();
            readFrm.Show();
            this.Hide();
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add addFrm = new Add();
            addFrm.Show();
            this.Hide();
        }

        private void updateBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update updateFrm = new update();
            updateFrm.Show();
            this.Hide();

        }

        private void deleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete deleteFrm = new delete();
            deleteFrm.Show();
            this.Hide();

        }

        private void mapReduceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MapReduce mapreduceFrm = new MapReduce();
            mapreduceFrm.Show();
            this.Hide();
        }

    }
}
