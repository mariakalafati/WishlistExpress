namespace WishlistExpress.Models;

public class Wishlist
{

    public int WishlistId { get; set; }
    public int UserId { get; set; }
    public required string Name { get; set; }
    public required string UniqueLink { get; set; }
    public int Submissions { get; set; }

}