using fero.DataAccess;

namespace fero.Pages
{
    public partial class Semruk
    {
        private DbRequests? db;
        private string? semrukMetin;
        public string SemrukMetin {
            get{
                db=new();
                semrukMetin=db.TakeData("pr81", "semruk");
                return semrukMetin;
            }
            set{
                semrukMetin=value;
            }
        }
    }
}