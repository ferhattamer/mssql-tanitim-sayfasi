using fero.DataAccess;

namespace fero.Pages
{
    public partial class Tengri
    {
        private DbRequests? db;
        private string? tengriMetin;
        public string TengriMetin {
            get{
                db=new();
                tengriMetin=db.TakeData("pr81", "tengri");
                return tengriMetin;
            }
            set{
                tengriMetin=value;
            }
        }
    }
}