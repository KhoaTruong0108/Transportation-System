/**
 * Autogenerated by Thrift Compiler (0.8.0-dev)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Transport;
namespace TransportService
{

  [Serializable]
  public partial class TIrregularOrder : TBase
  {
    private string _OrderId;
    private string _Destination;
    private string _SenderName;
    private string _SenderPhone;
    private string _SenderIdNo;
    private string _RecipientName;
    private string _RecipientPhone;
    private string _RecipientIdNo;
    private string _PaymentStatus;
    private string _OrderStaus;
    private double _TotalCost;
    private double _TotalValue;
    private int _TotalQuantity;
    private string _CreateBy;
    private string _CreateDate;
    private string _CloseDate;
    private string _UserReponsitory;
    private bool _isDeleted;

    public string OrderId
    {
      get
      {
        return _OrderId;
      }
      set
      {
        __isset.OrderId = true;
        this._OrderId = value;
      }
    }

    public string Destination
    {
      get
      {
        return _Destination;
      }
      set
      {
        __isset.Destination = true;
        this._Destination = value;
      }
    }

    public string SenderName
    {
      get
      {
        return _SenderName;
      }
      set
      {
        __isset.SenderName = true;
        this._SenderName = value;
      }
    }

    public string SenderPhone
    {
      get
      {
        return _SenderPhone;
      }
      set
      {
        __isset.SenderPhone = true;
        this._SenderPhone = value;
      }
    }

    public string SenderIdNo
    {
      get
      {
        return _SenderIdNo;
      }
      set
      {
        __isset.SenderIdNo = true;
        this._SenderIdNo = value;
      }
    }

    public string RecipientName
    {
      get
      {
        return _RecipientName;
      }
      set
      {
        __isset.RecipientName = true;
        this._RecipientName = value;
      }
    }

    public string RecipientPhone
    {
      get
      {
        return _RecipientPhone;
      }
      set
      {
        __isset.RecipientPhone = true;
        this._RecipientPhone = value;
      }
    }

    public string RecipientIdNo
    {
      get
      {
        return _RecipientIdNo;
      }
      set
      {
        __isset.RecipientIdNo = true;
        this._RecipientIdNo = value;
      }
    }

    public string PaymentStatus
    {
      get
      {
        return _PaymentStatus;
      }
      set
      {
        __isset.PaymentStatus = true;
        this._PaymentStatus = value;
      }
    }

    public string OrderStaus
    {
      get
      {
        return _OrderStaus;
      }
      set
      {
        __isset.OrderStaus = true;
        this._OrderStaus = value;
      }
    }

    public double TotalCost
    {
      get
      {
        return _TotalCost;
      }
      set
      {
        __isset.TotalCost = true;
        this._TotalCost = value;
      }
    }

    public double TotalValue
    {
      get
      {
        return _TotalValue;
      }
      set
      {
        __isset.TotalValue = true;
        this._TotalValue = value;
      }
    }

    public int TotalQuantity
    {
      get
      {
        return _TotalQuantity;
      }
      set
      {
        __isset.TotalQuantity = true;
        this._TotalQuantity = value;
      }
    }

    public string CreateBy
    {
      get
      {
        return _CreateBy;
      }
      set
      {
        __isset.CreateBy = true;
        this._CreateBy = value;
      }
    }

    public string CreateDate
    {
      get
      {
        return _CreateDate;
      }
      set
      {
        __isset.CreateDate = true;
        this._CreateDate = value;
      }
    }

    public string CloseDate
    {
      get
      {
        return _CloseDate;
      }
      set
      {
        __isset.CloseDate = true;
        this._CloseDate = value;
      }
    }

    public string UserReponsitory
    {
      get
      {
        return _UserReponsitory;
      }
      set
      {
        __isset.UserReponsitory = true;
        this._UserReponsitory = value;
      }
    }

    public bool IsDeleted
    {
      get
      {
        return _isDeleted;
      }
      set
      {
        __isset.isDeleted = true;
        this._isDeleted = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool OrderId;
      public bool Destination;
      public bool SenderName;
      public bool SenderPhone;
      public bool SenderIdNo;
      public bool RecipientName;
      public bool RecipientPhone;
      public bool RecipientIdNo;
      public bool PaymentStatus;
      public bool OrderStaus;
      public bool TotalCost;
      public bool TotalValue;
      public bool TotalQuantity;
      public bool CreateBy;
      public bool CreateDate;
      public bool CloseDate;
      public bool UserReponsitory;
      public bool isDeleted;
    }

    public TIrregularOrder() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.String) {
              OrderId = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Destination = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              SenderName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              SenderPhone = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.String) {
              SenderIdNo = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.String) {
              RecipientName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.String) {
              RecipientPhone = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.String) {
              RecipientIdNo = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.String) {
              PaymentStatus = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.String) {
              OrderStaus = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.Double) {
              TotalCost = iprot.ReadDouble();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 12:
            if (field.Type == TType.Double) {
              TotalValue = iprot.ReadDouble();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 13:
            if (field.Type == TType.I32) {
              TotalQuantity = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 14:
            if (field.Type == TType.String) {
              CreateBy = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 15:
            if (field.Type == TType.String) {
              CreateDate = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 16:
            if (field.Type == TType.String) {
              CloseDate = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 17:
            if (field.Type == TType.String) {
              UserReponsitory = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 18:
            if (field.Type == TType.Bool) {
              IsDeleted = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("TIrregularOrder");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (OrderId != null && __isset.OrderId) {
        field.Name = "OrderId";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(OrderId);
        oprot.WriteFieldEnd();
      }
      if (Destination != null && __isset.Destination) {
        field.Name = "Destination";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Destination);
        oprot.WriteFieldEnd();
      }
      if (SenderName != null && __isset.SenderName) {
        field.Name = "SenderName";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(SenderName);
        oprot.WriteFieldEnd();
      }
      if (SenderPhone != null && __isset.SenderPhone) {
        field.Name = "SenderPhone";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(SenderPhone);
        oprot.WriteFieldEnd();
      }
      if (SenderIdNo != null && __isset.SenderIdNo) {
        field.Name = "SenderIdNo";
        field.Type = TType.String;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(SenderIdNo);
        oprot.WriteFieldEnd();
      }
      if (RecipientName != null && __isset.RecipientName) {
        field.Name = "RecipientName";
        field.Type = TType.String;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(RecipientName);
        oprot.WriteFieldEnd();
      }
      if (RecipientPhone != null && __isset.RecipientPhone) {
        field.Name = "RecipientPhone";
        field.Type = TType.String;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(RecipientPhone);
        oprot.WriteFieldEnd();
      }
      if (RecipientIdNo != null && __isset.RecipientIdNo) {
        field.Name = "RecipientIdNo";
        field.Type = TType.String;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(RecipientIdNo);
        oprot.WriteFieldEnd();
      }
      if (PaymentStatus != null && __isset.PaymentStatus) {
        field.Name = "PaymentStatus";
        field.Type = TType.String;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(PaymentStatus);
        oprot.WriteFieldEnd();
      }
      if (OrderStaus != null && __isset.OrderStaus) {
        field.Name = "OrderStaus";
        field.Type = TType.String;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(OrderStaus);
        oprot.WriteFieldEnd();
      }
      if (__isset.TotalCost) {
        field.Name = "TotalCost";
        field.Type = TType.Double;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(TotalCost);
        oprot.WriteFieldEnd();
      }
      if (__isset.TotalValue) {
        field.Name = "TotalValue";
        field.Type = TType.Double;
        field.ID = 12;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(TotalValue);
        oprot.WriteFieldEnd();
      }
      if (__isset.TotalQuantity) {
        field.Name = "TotalQuantity";
        field.Type = TType.I32;
        field.ID = 13;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(TotalQuantity);
        oprot.WriteFieldEnd();
      }
      if (CreateBy != null && __isset.CreateBy) {
        field.Name = "CreateBy";
        field.Type = TType.String;
        field.ID = 14;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(CreateBy);
        oprot.WriteFieldEnd();
      }
      if (CreateDate != null && __isset.CreateDate) {
        field.Name = "CreateDate";
        field.Type = TType.String;
        field.ID = 15;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(CreateDate);
        oprot.WriteFieldEnd();
      }
      if (CloseDate != null && __isset.CloseDate) {
        field.Name = "CloseDate";
        field.Type = TType.String;
        field.ID = 16;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(CloseDate);
        oprot.WriteFieldEnd();
      }
      if (UserReponsitory != null && __isset.UserReponsitory) {
        field.Name = "UserReponsitory";
        field.Type = TType.String;
        field.ID = 17;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(UserReponsitory);
        oprot.WriteFieldEnd();
      }
      if (__isset.isDeleted) {
        field.Name = "isDeleted";
        field.Type = TType.Bool;
        field.ID = 18;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(IsDeleted);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("TIrregularOrder(");
      sb.Append("OrderId: ");
      sb.Append(OrderId);
      sb.Append(",Destination: ");
      sb.Append(Destination);
      sb.Append(",SenderName: ");
      sb.Append(SenderName);
      sb.Append(",SenderPhone: ");
      sb.Append(SenderPhone);
      sb.Append(",SenderIdNo: ");
      sb.Append(SenderIdNo);
      sb.Append(",RecipientName: ");
      sb.Append(RecipientName);
      sb.Append(",RecipientPhone: ");
      sb.Append(RecipientPhone);
      sb.Append(",RecipientIdNo: ");
      sb.Append(RecipientIdNo);
      sb.Append(",PaymentStatus: ");
      sb.Append(PaymentStatus);
      sb.Append(",OrderStaus: ");
      sb.Append(OrderStaus);
      sb.Append(",TotalCost: ");
      sb.Append(TotalCost);
      sb.Append(",TotalValue: ");
      sb.Append(TotalValue);
      sb.Append(",TotalQuantity: ");
      sb.Append(TotalQuantity);
      sb.Append(",CreateBy: ");
      sb.Append(CreateBy);
      sb.Append(",CreateDate: ");
      sb.Append(CreateDate);
      sb.Append(",CloseDate: ");
      sb.Append(CloseDate);
      sb.Append(",UserReponsitory: ");
      sb.Append(UserReponsitory);
      sb.Append(",IsDeleted: ");
      sb.Append(IsDeleted);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
