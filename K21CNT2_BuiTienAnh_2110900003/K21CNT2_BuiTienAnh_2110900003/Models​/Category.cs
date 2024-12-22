﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace K21CNT2_BuiTienAnh_2110900003.Models;

public partial class Category
{
    public int Id { get; set; }

    [Display(Name = "Tiêu đề")]
    [Required(ErrorMessage = "Tiêu đề không được để trống")]
    [StringLength(255, ErrorMessage = "Tiêu đề không được vượt quá 255 ký tự")]
    public string? Title { get; set; }

    [Display(Name = "Biểu tượng")]
    [StringLength(255, ErrorMessage = "Biểu tượng không được vượt quá 255 ký tự")]
    public string? Icon { get; set; }

    [Display(Name = "Tiêu đề meta")]
    [StringLength(255, ErrorMessage = "Tiêu đề meta không được vượt quá 255 ký tự")]
    public string? MateTitle { get; set; }

    [Display(Name = "Từ khóa meta")]
    [StringLength(255, ErrorMessage = "Từ khóa meta không được vượt quá 255 ký tự")]
    public string? MetaKeyword { get; set; }

    [Display(Name = "Mô tả meta")]
    [StringLength(500, ErrorMessage = "Mô tả meta không được vượt quá 500 ký tự")]
    public string? MetaDescription { get; set; }

    [Display(Name = "Slug")]
    [StringLength(255, ErrorMessage = "Slug không được vượt quá 255 ký tự")]
    public string? Slug { get; set; }

    [Display(Name = "Thứ tự")]
    [Range(1, int.MaxValue, ErrorMessage = "Thứ tự phải là một số dương")]
    public int? Orders { get; set; }

    [Display(Name = "ID danh mục cha")]
    public int? Parentid { get; set; }

    [Display(Name = "Ngày tạo")]
    [DataType(DataType.Date)]
    public DateTime? CreatedDate { get; set; }

    [Display(Name = "Ngày cập nhật")]
    [DataType(DataType.Date)]
    public DateTime? UpdatedDate { get; set; }

    [Display(Name = "Người tạo")]
    [StringLength(255, ErrorMessage = "Tên người tạo không được vượt quá 255 ký tự")]
    public string? AdminCreated { get; set; }

    [Display(Name = "Người cập nhật")]
    [StringLength(255, ErrorMessage = "Tên người cập nhật không được vượt quá 255 ký tự")]
    public string? AdminUpdated { get; set; }

    [Display(Name = "Ghi chú")]
    [StringLength(1000, ErrorMessage = "Ghi chú không được vượt quá 1000 ký tự")]
    public string? Notes { get; set; }

    [Display(Name = "Trạng thái")]
    [Range(0, 1, ErrorMessage = "Trạng thái phải là giá trị hợp lệ (0 hoặc 1)")]
    public byte? Status { get; set; }

    [Display(Name = "Đã xóa")]
    public bool? Isdelete { get; set; }
}
