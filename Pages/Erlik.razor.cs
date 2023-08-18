using fero.DataAccess;

namespace fero.Pages
{
    public partial class Erlik
    {
        private DbRequests? db;
        private string? erlikMetin;
        public string ErlikMetin {
            get{
                db=new();
                erlikMetin=db.TakeData("pr81", "erlik");
                return erlikMetin;
            }
            set{
                erlikMetin=value;
            }
        }
    }
}