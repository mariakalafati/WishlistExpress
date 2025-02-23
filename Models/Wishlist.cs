namespace WishlistExpress.Models;

public class Wishlist
{

    public Int64 WishlistId { get; set; }
    public Int64 UserId { get; set; }
    public string Name { get; set; }
    public string UniqueLink { get; set; }
    public Int64 Submissions { get; set; }

}