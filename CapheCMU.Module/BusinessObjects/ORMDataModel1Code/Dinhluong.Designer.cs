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

    public partial class Dinhluong : DevExpress.Persistent.BaseImpl.BaseObject
    {
        Sanpham fSanphamID;
        [Association(@"DinhluongReferencesSanpham")]
        [DevExpress.Xpo.DisplayName(@"Sản phẩm")]
        public Sanpham SanphamID
        {
            get { return fSanphamID; }
            set { SetPropertyValue<Sanpham>(nameof(SanphamID), ref fSanphamID, value); }
        }
        Sanpham fThanhphanID;
        [Association(@"DinhluongReferencesSanpham1")]
        [DevExpress.Xpo.DisplayName(@"Thành phần")]
        public Sanpham ThanhphanID
        {
            get { return fThanhphanID; }
            set { SetPropertyValue<Sanpham>(nameof(ThanhphanID), ref fThanhphanID, value); }
        }
        double fSoluong;
        [DevExpress.Xpo.DisplayName(@"Số lượng")]
        public double Soluong
        {
            get { return fSoluong; }
            set { SetPropertyValue<double>(nameof(Soluong), ref fSoluong, value); }
        }
    }

}
