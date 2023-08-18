using fero.DataAccess;

namespace fero.Pages
{
    public partial class Mergen
    {
        private DbRequests? db;
        private string? mergenMetin;
        public string MergenMetin {
            get{
                db=new();
                mergenMetin=db.TakeData("pr81", "mergen");
                return mergenMetin;
            }
            set{
                mergenMetin=value;
            }
        }
    }
}