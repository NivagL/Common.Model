namespace Common.Model;

public interface IHasImage
{
  public Guid? ImageId { get; set; }
  public string? ImageUrl { get; set; }
}
