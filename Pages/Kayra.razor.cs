using fero.DataAccess;

namespace fero.Pages
{
    public partial class Kayra
    {
        private DbRequests? db;
        private string? kayraMetin;
        public string KayraMetin {
            get{
                db=new();
                kayraMetin=db.TakeData("pr81", "kayra");
                return kayraMetin;
            }
            set{
                kayraMetin=value;
            }
        }
    }
}