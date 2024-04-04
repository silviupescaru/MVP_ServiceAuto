using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceAutoMVP.Model;
using ServiceAutoMVP.Model.Repository;

namespace ServiceAutoMVP_Test
{
    [TestFixture]
    public class UserRepositoryTest
    {
        [Test]
        public void AddUserTest()
        {
            UserRepository userRepository = new UserRepository();
            User user1 = new User(10, "administrator", "admin", "Administrator");
            User user2 = new User(11, "manager", "man", "Manager");
            User user3 = new User(12, "employee", "emp", "Employee");

            bool result1 = userRepository.AddUser(user1);
            bool result2 = userRepository.AddUser(user2);
            bool result3 = userRepository.AddUser(user3);

            Repository repository = new Repository();
            string deleteSQL = "delete from [User] where userID > 3";
            repository.CommandSQL(deleteSQL);

            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
            Assert.IsTrue(result3);

        }

        [Test]
        public void UpdateUserTest()
        {
            UserRepository userRepository = new UserRepository();
            User user = new User(3, "mike", "forza", "Employee");

            bool result = userRepository.UpdateUser(user);

            Repository repository = new Repository();
            string deleteSQL = "delete from [User] where userID > 3";
            repository.CommandSQL(deleteSQL);

            Assert.IsTrue(result);
        }

        [Test]
        public void DeleteUserTest()
        {
            UserRepository userRepository = new UserRepository();
            User user = new User(4, "testUser", "test", "Employee");

            bool result = userRepository.DeleteUser(user.UserID);

            Repository repository = new Repository();
            string deleteSQL = "delete from [User] where userID > 3";
            repository.CommandSQL(deleteSQL);

            Assert.IsFalse(result);

        }

        [Test]
        public void UserListTest()
        {
            UserRepository userRepository = new UserRepository();

            User user1 = new User(123, "test1", "test", "Administrator");
            User user2 = new User(124, "test2", "test", "Employee");

            userRepository.AddUser(user1);
            userRepository.AddUser(user2);

            List<User> result = userRepository.UserList();

            Repository repository = new Repository();
            string deleteSQL = "delete from [User] where userID > 3";
            repository.CommandSQL(deleteSQL);

            Assert.IsNotNull(result);
        }

        [Test]
        public void SearchUserTest()
        {
            CarRepository carRepository = new CarRepository();
            UserRepository userRepository = new UserRepository();

            User user1 = new User(123, "test1", "test", "Administrator");
            User user2 = new User(124, "test2", "test", "Employee");

            userRepository.AddUser(user1);
            userRepository.AddUser(user2);

            User result1 = userRepository.SearchUserByID(user2.UserID.ToString());
            List<User> result2 = userRepository.SearchUserByRole(user1.Role);
            User result3 = userRepository.SearchUserByID("3");

            Repository repository = new Repository();
            string deleteSQL = "delete from [User] where userID > 3";
            repository.CommandSQL(deleteSQL);

            Assert.IsNull(result1);
            Assert.IsNotNull(result2);
            Assert.IsNotNull(result3);
        }
    }
}
