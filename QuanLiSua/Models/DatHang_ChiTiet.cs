﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLiSua.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class DatHang_ChiTiet
    {
        [Display(Name = "Mã Đặt hàng chi tiết")]
        public int ID { get; set; }

        [Display(Name = "Đơn đặt hàng")]
        [Required(ErrorMessage = "Chưa chọn hàng")]
        public Nullable<int> DatHang_ID { get; set; }

        [Display(Name = "Sữa")]
        [Required(ErrorMessage = "Chưa chọn sữa")]
        public Nullable<int> Sua_ID { get; set; }

        [Display(Name = "Số lượng")]
        [Required(ErrorMessage = "Vui lòng chọn số lượng!")]
        public Nullable<int> SoLuong { get; set; }

        [Display(Name = "Đơn giá")]
        [Required(ErrorMessage = "Đơn giá không được để trống!")]
        public Nullable<int> DonGia { get; set; }


        public virtual DatHang DatHang { get; set; }
        public virtual Sua Sua { get; set; }
    }
}
