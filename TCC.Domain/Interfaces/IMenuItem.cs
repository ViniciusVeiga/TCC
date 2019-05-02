﻿
namespace TCC.Domain.Interfaces
{
    public interface IMenuItem
    {
        decimal? IdMenu { get; set; }
        string Title { get; set; }
        string Url { get; set; }
        decimal? Order { get; set; }
    }
}
