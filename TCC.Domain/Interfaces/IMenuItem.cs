
namespace TCC.Domain.Interfaces
{
    public interface IMenuItem
    {
        decimal? IdMenu { get; set; }
        decimal? IdMenuType { get; set; }
        string Title { get; set; }
        string Url { get; set; }
        decimal? Order { get; set; }
        string Icon { get; set; }
    }
}
