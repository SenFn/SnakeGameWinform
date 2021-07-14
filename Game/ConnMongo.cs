using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Windows.Forms;

namespace Snake_Final
{
    class ConnMongo
    {
        MongoClient dbClient;
        bool isConn = false;

        public int Score10 = 0;
        public ConnMongo()
        {
            //mongodb+srv://sen:sen@bxh.qrwid.mongodb.net/Snake?retryWrites=true&w=majority  
            try
            {
                dbClient = new MongoClient("mongodb+srv://sen:sen@bxh.qrwid.mongodb.net/Snake?retryWrites=true&w=majority");
                isConn = true;
            }
            catch (Exception)
            {
                // is not connection
            }

        }

        public string LoadBXH()
        {
            try
            {
                if (isConn == false) return "Không thể load BXH";
                var database = dbClient.GetDatabase("Snake");
                var collection = database.GetCollection<BsonDocument>("BXH");

                var documents = collection.Find(new BsonDocument()).Sort(Builders<BsonDocument>.Sort.Descending("Score")).ToList();

                int numLoad = 10;
                string mess = "";
                if (documents.Count <= 10) numLoad = documents.Count;

                for (int i = 0; i < numLoad; i++)
                {
                    int rankingorder = i + 1;
                    //mess += "Name: " + documents[i].GetElement("Name").Value + " - Score: " + documents[i].GetElement("Score").Value + "\r\n";
                    mess += "#" + rankingorder + " " + documents[i].GetElement("Name").Value + "-SCORE: " + documents[i].GetElement("Score").Value + "\r\n";
                    if (i == numLoad - 1)
                    {
                        Score10 = Int32.Parse(documents[i].GetElement("Score").Value.ToString());
                    }
                }
                return mess;
            }
            catch (Exception)
            {
                return "Can't load scoreboard, please check internet connection";
            }

        }

        public void ImportBXH(string Name, int Score)
        {
            try
            {
                if (isConn == false) return;


                var database = dbClient.GetDatabase("Snake");
                var collection = database.GetCollection<BsonDocument>("BXH");


                var document = new BsonDocument { { "Name", Name }, { "Score", Score }, { "Date", DateTime.Now } };
                collection.InsertOne(document);
                Console.WriteLine("Done");
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau!");
            }

        }

    }
}
