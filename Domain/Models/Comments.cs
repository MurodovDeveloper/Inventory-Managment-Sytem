namespace Domain.Models;

public class Comments
{
    public Comments() => this.TaggedUsers = new HashSet<TagFriendInComment>();

    public int Id { get; set; }

    public string Content { get; set; }

    public DateTime DatePosted { get; set; }

    public string AuthorId { get; set; }

    public User Author { get; set; }

    public int CommentedPostId { get; set; }

    public Posts CommentedPost { get; set; }

    public ICollection<TagFriendInComment> TaggedUsers { get; set; }
}