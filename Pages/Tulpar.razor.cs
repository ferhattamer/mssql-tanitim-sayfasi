using fero.DataAccess;

namespace fero.Pages
{
    public partial class Tulpar
    {
        private DbRequests? db;
        private string? tulparMetin;
        public string TulparMetin {
            get{
                db=new();
                tulparMetin=db.TakeData("pr81", "tulpar");
                return tulparMetin;
            }
            set{
                tulparMetin=value;
            }
        }
    }
}