
namespace TCC.Domain.Interfaces
{
    interface IMenuType
    {
        string Title { get; set; }
        decimal? Order { get; set; }
        string Icon { get; set; }
    }
}
