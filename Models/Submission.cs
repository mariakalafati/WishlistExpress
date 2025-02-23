namespace WishlistExpress.Models;

public class Submission
{

    public int SubmissionId { get; set; }
    public int WishlistId { get; set; }
    public int UserId { get; set; }
    public required string Name { get; set; }
    public required string Gift { get; set; }

}