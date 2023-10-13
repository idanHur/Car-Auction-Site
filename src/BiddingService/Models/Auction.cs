using MongoDB.Entities;

namespace BiddingService;

public class Auction: Entity
{
    public DateTime AuctionEnd { get; set;}
    public string Seller { get; set;}
    public int ReservPrice { get; set;}
    public bool Finished { get; set;}    
}
