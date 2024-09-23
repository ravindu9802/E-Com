using CatelogService.Domain.Enums;
using CatelogService.Domain.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace CatelogService.Domain.Entities;

public class Catalog
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    [MaxLength(200)]
    public string? Description { get; set; }
    public Price? Price { get; set; }
    public string? Slug { get; set; }
    public ItemType ItemType { get; set; }
    public Manufacturer Manufacturer {  get; set; }
    public DateOnly Added {  get; set; }
    public string? ImageURL { get; set; }
}
