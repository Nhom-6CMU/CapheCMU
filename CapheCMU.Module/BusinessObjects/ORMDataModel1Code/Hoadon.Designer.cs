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

    [DefaultProperty("Soban")]
    public partial class Hoadon : DevExpress.Persistent.BaseImpl.BaseObject
    {
        Khachhang fKhachID;
        [Association(@"HoadonReferencesKhachhang")]
        [DevExpress.Xpo.DisplayName(@"Tên khách hàng")]
        public Khachhang KhachID
        {
            get { return fKhachID; }
            set { SetPropertyValue<Khachhang>(nameof(KhachID), ref fKhachID, value); }
        }
        Nhanvien fNhanvienID;
        [Association(@"HoadonReferencesNhanvien")]
        [DevExpress.Xpo.DisplayName(@"Tên nhân viên")]
        public Nhanvien NhanvienID
        {
            get { return fNhanvienID; }
            set { SetPropertyValue<Nhanvien>(nameof(NhanvienID), ref fNhanvienID, value); }
        }
        uint fSoban;
        [DevExpress.Xpo.DisplayName(@"Số bàn")]
        public uint Soban
        {
            get { return fSoban; }
            set { SetPropertyValue<uint>(nameof(Soban), ref fSoban, value); }
        }
        DateTime fNgay;
        [DevExpress.Xpo.DisplayName(@"Ngày bán")]
        [DevExpress.ExpressApp.Model.ModelDefault("EditMask", "dd/MM/yyyy HH:mm"),
DevExpress.ExpressApp.Model.ModelDefault("DisplayFormat", "{0:dd/MM/yyyy HH:mm}")]
        public DateTime Ngay
        {
            get { return fNgay; }
            set { SetPropertyValue<DateTime>(nameof(Ngay), ref fNgay, value); }
        }
        int fSophieu;
        [DevExpress.Xpo.DisplayName(@"Số phiếu")]
        [DevExpress.Persistent.Validation.RuleUniqueValue]
        public int Sophieu
        {
            get { return fSophieu; }
            set { SetPropertyValue<int>(nameof(Sophieu), ref fSophieu, value); }
        }
        [Association(@"HoadonCTReferencesHoadon"), Aggregated]
        public XPCollection<HoadonCT> HoadonCTs { get { return GetCollection<HoadonCT>(nameof(HoadonCTs)); } }
    }

}