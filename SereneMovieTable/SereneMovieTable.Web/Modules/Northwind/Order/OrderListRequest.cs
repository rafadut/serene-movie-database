using Serenity.Services;

namespace SereneMovieTable.Northwind
{
    public class OrderListRequest : ListRequest
    {
        public int? ProductID { get; set; }
    }
}