﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace CapheCMU.Module.BusinessObjects.ORMDataModel1
{

    [DefaultProperty("Hoten")]
    public partial class Nhanvien : DevExpress.Persistent.BaseImpl.BaseObject
    {
        string fHoten;
        [DevExpress.Xpo.DisplayName(@"Họ và tên")]
        public string Hoten
        {
            get { return fHoten; }
            set { SetPropertyValue<string>(nameof(Hoten), ref fHoten, value); }
        }
        string fDienthoai;
        [DevExpress.Xpo.DisplayName(@"Số điện thoại")]
        [DevExpress.Persistent.Validation.RuleUniqueValue]
        public string Dienthoai
        {
            get { return fDienthoai; }
            set { SetPropertyValue<string>(nameof(Dienthoai), ref fDienthoai, value); }
        }
        decimal fMucluong;
        [DevExpress.Xpo.DisplayName(@"Mức lương")]
        [DevExpress.ExpressApp.Model.ModelDefault("DisplayFormat", "###,###,###,###,###,###"),
DevExpress.ExpressApp.Model.ModelDefault("EditMask", "###,###,###,###,###,###")]
        public decimal Mucluong
        {
            get { return fMucluong; }
            set { SetPropertyValue<decimal>(nameof(Mucluong), ref fMucluong, value); }
        }
        string fChucvu;
        [DevExpress.Xpo.DisplayName(@"Chức vụ")]
        public string Chucvu
        {
            get { return fChucvu; }
            set { SetPropertyValue<string>(nameof(Chucvu), ref fChucvu, value); }
        }
        [Association(@"BangluongReferencesNhanvien"), Aggregated]
        public XPCollection<Bangluong> Bangluongs { get { return GetCollection<Bangluong>(nameof(Bangluongs)); } }
        [Association(@"ChamcongReferencesNhanvien"), Aggregated]
        public XPCollection<Chamcong> Chamcongs { get { return GetCollection<Chamcong>(nameof(Chamcongs)); } }
        [Association(@"HoadonReferencesNhanvien"), Aggregated]
        public XPCollection<Hoadon> Hoadons { get { return GetCollection<Hoadon>(nameof(Hoadons)); } }
        [Association(@"PhieuchiReferencesNhanvien"), Aggregated]
        public XPCollection<Phieuchi> Phieuchis { get { return GetCollection<Phieuchi>(nameof(Phieuchis)); } }
        [Association(@"PhieunhapReferencesNhanvien"), Aggregated]
        public XPCollection<Phieunhap> Phieunhaps { get { return GetCollection<Phieunhap>(nameof(Phieunhaps)); } }
    }

}
