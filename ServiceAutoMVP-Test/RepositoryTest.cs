using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceAutoMVP.Model.Repository;

namespace ServiceAutoMVP_Test
{
    [TestFixture]
    public class RepositoryTest
    {
        [Test]
        public void OpeningConnectionTest()
        {
            Repository repository = new Repository();
            repository.OpeningConnection();
            Assert.IsTrue(repository.Connection.State == ConnectionState.Open);
        }

        [Test]
        public void ClosingConnectionTest()
        {
            Repository repository = new Repository();
            repository.ClosingConnection();
            Assert.IsTrue(repository.Connection.State == ConnectionState.Closed);
        }

        [Test]
        public void CommandSQLTest()
        {
            Repository repository = new Repository();
            string c1 = "insert into Car values('Silviu', 'Nissan', 'Gray', 'Diesel')";
            string c2 = "insert into Car values('Eugen', 'Skoda', 'Racing Blue', 'LPG')";
            string c3 = "update Car set owner='Marius', brand='Mercedes-Benz', color='Black', fuel='Gasoline' where carID = 2";
            string c4 = "delete from Car where carID = 1";
            string c5 = "delete from Car where carID = 5";
            string c6 = "insert into Car values('Ella', 'Mazda', 'Dark Green', 'Gasoline')";

            bool result1 = repository.CommandSQL(c1);
            bool result2 = repository.CommandSQL(c2);
            bool result3 = repository.CommandSQL(c3);
            bool result4 = repository.CommandSQL(c4);
            bool result5 = repository.CommandSQL(c5);
            bool result6 = repository.CommandSQL(c6);

            string deleteSQL = "delete from Car where carID > 10";
            repository.CommandSQL(deleteSQL);

            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
            Assert.IsTrue(result3);
            Assert.IsFalse(result4);
            Assert.IsFalse(result5);
            Assert.IsTrue(result6);
        }

        [Test]
        public void GetTableTest()
        {
            Repository repository = new Repository();
            string selectSQL = "select * from Car order by owner";

            DataTable result = repository.GetTable(selectSQL);

            string deleteSQL = "delete from Car where carID > 10";
            repository.CommandSQL(deleteSQL);

            Assert.IsNotNull(result);
            Assert.AreEqual(5, result.Columns.Count);
        }
    }
}