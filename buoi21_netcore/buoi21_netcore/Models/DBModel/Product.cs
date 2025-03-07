using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace buoi21_netcore.Models.DBModel;

public partial class Product
{

    public int Id { get; set; }

    [DisplayName("Danh Muc")]
    [Required(ErrorMessage = "Danh muc khong duoc de trong")]
    public int? Cid { get; set; }
    [DisplayName("Ma")]  
    [Required(ErrorMessage = "Ma khong duoc de trong")]
    public string? Code { get; set; }
    [DisplayName("Ten San Pham")]
    [Required(ErrorMessage = "Ten san pham khong duoc de trong")]
    public string? Title { get; set; }
    [DisplayName("Mo Ta")]
    public string? Description { get; set; }
    [DisplayName("Content")]
    public string? Content { get; set; }
    [DisplayName("Hinh Anh")]
    public string? Image { get; set; }
    [DisplayName("Ten Hien Thi")]
    public string? MetaTitle { get; set; }
    [DisplayName("Ten Tim Kiem")]
    public string? MetaKeyword { get; set; }
    [DisplayName("Ten Mo Ta")]
    public string? MetaDescription { get; set; }
    [DisplayName("Duong Dan")]
    public string? Slug { get; set; }
    [DisplayName("Gia Ban")]
    public decimal? PriceOld { get; set; }
    [DisplayName("Giam Gia")]
    public decimal? PriceNew { get; set; }
    [DisplayName("Kich Thuoc")]
    public string? Size { get; set; }
    [DisplayName("Luot Xem")]
    public int? Views { get; set; }
    [DisplayName("Luot Like")]
    public int? Likes { get; set; }
    [DisplayName("Danh Gia")]
    public double? Star { get; set; }
    [DisplayName("Co nen de trang Home")]
    public byte? Home { get; set; }
    [DisplayName("San pham co hot hay khong")]
    public byte? Hot { get; set; }
    [DisplayName("Ngay tao")]
    public DateTime? CreatedDate { get; set; }
    [DisplayName("Ngay cap nhat")]
    public DateTime? UpdatedDate { get; set; }
    [DisplayName("Nguoi tao")]
    public string? AdminCreated { get; set; }
    [DisplayName("Nguoi cap nhat")]
    public string? AdminUpdated { get; set; }
    [DisplayName("Trang Thai")]
    public byte? Status { get; set; }
    [DisplayName("Trang Thai Xoa")]
    public bool? Isdelete { get; set; }
}
