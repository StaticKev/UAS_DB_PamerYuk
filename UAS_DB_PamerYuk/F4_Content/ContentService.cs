using Class_PamerYuk;
using MySql.Data.MySqlClient;
using System.Windows.Documents;
using System.Collections.Generic;
using UAS_DB_PamerYuk.Repository.DAO;
using MSVidCtlLib;

namespace UAS_DB_PamerYuk.F2_Friendship
{
    public class ContentService
    {
        private readonly UserDAO userDAO;
        private readonly KontenDAO kontenDAO;

        public ContentService(Connection connection)
        {
            userDAO = new UserDAO(connection);
            kontenDAO = new KontenDAO(connection);
        }

        public List<User> RetrieveFriendReq(User user)
        {
            return userDAO.Read_AllFriend(user, UserDAO.FriendshipStatus.NOT_FRIEND);
        } 

        public void AcceptFriendRequest(User receiver, User sender)
        {
            if (!userDAO.Update_AcceptFriend(receiver, sender)) throw new System.Exception("GAGAL MENERIMA PERMINTAAN PERTEMANAN");
        }

        public int SaveKonten(Konten konten)
        {
            return kontenDAO.Insert_Content(konten);
        }

        public List<User> GetFriends(User user)
        {
            return userDAO.Read_AllFriend(user, UserDAO.FriendshipStatus.FRIEND);
        }

        public void TagUser(Konten konten, User user)
        {
            kontenDAO.Insert_LikeOrTag(KontenDAO.Table.TAG, konten, user);
        }

        public List<Konten> GetKontenTeman(User user)
        {

            return kontenDAO.Read_Content(user, KontenDAO.OwnedBy.FRIEND);
        }

        public List<Komen> GetPostComments(Konten konten)
        {
            return kontenDAO.Read_Comment(konten);
        }

        public void SendComment(Konten konten, Komen komen)
        {
            kontenDAO.Insert_Comment(konten, komen);
        }

        public bool UserLikes(Konten konten, User user)
        {
            return kontenDAO.Check_Like(konten, user);
        }

        public List<User> RetrievePostLike(Konten konten)
        {
            return userDAO.Read_FindById(UserDAO.Table.LIKE, konten.Id);
        }

        public List<User> RetrievePostTag(Konten konten)
        {
            return userDAO.Read_FindById(UserDAO.Table.TAG, konten.Id);
        }

        public void LikeContent(Konten konten, User user)
        {
            kontenDAO.Insert_LikeOrTag(KontenDAO.Table.LIKE, konten, user);
        }

        public void DislikeContent(Konten konten, User user)
        {
            kontenDAO.Delete_Like(konten, user);
        }
    }
}
