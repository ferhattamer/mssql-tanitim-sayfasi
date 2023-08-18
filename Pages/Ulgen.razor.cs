using fero.DataAccess;

namespace fero.Pages
{
    public partial class Ulgen
    {
        private DbRequests? db;
        private string? ulgenMetin;
        public string Ulgenmetin {
            get{
                db=new();
                ulgenMetin=db.TakeData("pr81", "ulgen");
                return ulgenMetin;
            }
            set{
                ulgenMetin=value;
            }
        }
    }
}