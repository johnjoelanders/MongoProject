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
using MongoDB.Bson.Serialization;

namespace MongoProject
{
    public partial class delete : Form
    {
        protected static IMongoClient _client = new MongoClient();
        protected static IMongoDatabase _database = _client.GetDatabase("books");
        
            
            
        public delete()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var collection = _database.GetCollection<BsonDocument>("books");
            List<Book> book = new List<Book>();
            using (var cursor = await collection.Find(Builders<BsonDocument>.Filter.Eq("Title", txtNameOfBook.Text)).ToCursorAsync())
            {
                while (await cursor.MoveNextAsync())
                {
                    foreach (var doc in cursor.Current)
                    {
                        var myObj = BsonSerializer.Deserialize<Book>(doc);
                        book.Add(myObj);
                    }
                    var source = new BindingSource();
                    source.DataSource = book;
                    dgvDelete.DataSource = source;
                }
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var collection = _database.GetCollection<BsonDocument>("books");
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(txtId.Text));
            var result = await collection.DeleteManyAsync(filter);
            if (result.IsAcknowledged)
            {
                MessageBox.Show("Book Deleted", "Delete book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAuthor.Clear();
                txtId.Clear();
                txtIsbn.Clear();
                txtPublisher.Clear();
                txtTitle.Clear();
                comboCategory.Items.Clear();
                dgvDelete.Rows.Clear();
                dgvDelete.Refresh();
            }
            else
            {
                MessageBox.Show("Book not Deleted", "Delete book", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            getBook(dgvDelete.Rows[dgvDelete.CurrentCell.RowIndex].Cells[0].Value.ToString());
        }
        public async void getBook(String dgvId)
        {
            var collection = _database.GetCollection<BsonDocument>("books");
            using (var cursor = await collection.Find(Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(dgvId))).ToCursorAsync())
            {
                while (await cursor.MoveNextAsync())
                {
                    foreach (var doc in cursor.Current)
                    {
                        var myObj = BsonSerializer.Deserialize<Book>(doc);
                        txtId.Text = myObj.id.ToString();
                        txtAuthor.Text = myObj.Title.ToString();
                        txtIsbn.Text = myObj.Isbn.ToString();
                        comboCategory.Text = myObj.Category.ToString();
                        txtPublisher.Text = myObj.Publisher.ToString();
                        txtTitle.Text = myObj.Title.ToString();
                    }
                }
            }
        }

        private void addBookToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Add addFrm = new Add();
            addFrm.Show();
            this.Hide();
        }

        private void showBookToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            read readFrm = new read();
            readFrm.Show();
            this.Hide();
        }

        private void updateBookToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            update updateFrm = new update();
            updateFrm.Show();
            this.Hide();
        }

        private void deleteBookToolStripMenuItem_Click_1(object sender, EventArgs e)
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
