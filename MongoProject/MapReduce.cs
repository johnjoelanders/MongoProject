using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace MongoProject
{
    public partial class MapReduce : Form
    {
        protected static IMongoClient _client = new MongoClient();
        protected static IMongoDatabase _database = _client.GetDatabase("books");
        public MapReduce()
        {
            InitializeComponent();
        }

        private async void MapReduce_Load(object sender, EventArgs e)
        {

            var collection = _database.GetCollection<BsonDocument>("books");

            var map = new BsonJavaScript( @"
                function(){
                        emit(this.Category,1)};");

            var reduce =  new BsonJavaScript( @"        
                function(key,values){
                    var totalCount = 0;

                    values.forEach(function(value) {
                    totalCount ++;
                    });
        
                    return totalCount;
                };");

            var result = await collection.MapReduceAsync<BsonDocument>(map, reduce);
            List<objReturn> list = new List<objReturn>();
            while (await result.MoveNextAsync())
            {
                foreach (var doc in result.Current)
                {
                    var myObj = BsonSerializer.Deserialize<objReturn>(doc);
                    list.Add(myObj);

                }
                var source = new BindingSource();
                source.DataSource = list;
                dgvMapreduce.DataSource = source;                
            }   
        }
        public class objReturn
        {
            public string id { get; set; }
            public Object value { get; set; }
        }

        private void mapReduceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MapReduce mapreduceFrm = new MapReduce();
            mapreduceFrm.Show();
            this.Hide();
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add addFrm = new Add();
            addFrm.Show();
            this.Hide();
        }

        private void showBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            read readFrm = new read();
            readFrm.Show();
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
    }
}
