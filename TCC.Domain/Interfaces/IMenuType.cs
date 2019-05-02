
namespace TCC.Domain.Interfaces
{
    interface IMenuType
    {
        decimal? IdMenu { get; set; }
        string Title { get; set; }
        decimal? Order { get; set; }
        string Icon { get; set; }
    }
}
