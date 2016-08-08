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
  public partial class TBus : TBase
  {
    private string _Id;
    private string _name;
    private int _SeatCount;
    private int _SubSeatCount;
    private int _BedCount;
    private int _SubBedCount;

    public string Id
    {
      get
      {
        return _Id;
      }
      set
      {
        __isset.Id = true;
        this._Id = value;
      }
    }

    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        __isset.name = true;
        this._name = value;
      }
    }

    public int SeatCount
    {
      get
      {
        return _SeatCount;
      }
      set
      {
        __isset.SeatCount = true;
        this._SeatCount = value;
      }
    }

    public int SubSeatCount
    {
      get
      {
        return _SubSeatCount;
      }
      set
      {
        __isset.SubSeatCount = true;
        this._SubSeatCount = value;
      }
    }

    public int BedCount
    {
      get
      {
        return _BedCount;
      }
      set
      {
        __isset.BedCount = true;
        this._BedCount = value;
      }
    }

    public int SubBedCount
    {
      get
      {
        return _SubBedCount;
      }
      set
      {
        __isset.SubBedCount = true;
        this._SubBedCount = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool Id;
      public bool name;
      public bool SeatCount;
      public bool SubSeatCount;
      public bool BedCount;
      public bool SubBedCount;
    }

    public TBus() {
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
              Id = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Name = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              SeatCount = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              SubSeatCount = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              BedCount = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I32) {
              SubBedCount = iprot.ReadI32();
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
      TStruct struc = new TStruct("TBus");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Id != null && __isset.Id) {
        field.Name = "Id";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Id);
        oprot.WriteFieldEnd();
      }
      if (Name != null && __isset.name) {
        field.Name = "name";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Name);
        oprot.WriteFieldEnd();
      }
      if (__isset.SeatCount) {
        field.Name = "SeatCount";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(SeatCount);
        oprot.WriteFieldEnd();
      }
      if (__isset.SubSeatCount) {
        field.Name = "SubSeatCount";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(SubSeatCount);
        oprot.WriteFieldEnd();
      }
      if (__isset.BedCount) {
        field.Name = "BedCount";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(BedCount);
        oprot.WriteFieldEnd();
      }
      if (__isset.SubBedCount) {
        field.Name = "SubBedCount";
        field.Type = TType.I32;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(SubBedCount);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("TBus(");
      sb.Append("Id: ");
      sb.Append(Id);
      sb.Append(",Name: ");
      sb.Append(Name);
      sb.Append(",SeatCount: ");
      sb.Append(SeatCount);
      sb.Append(",SubSeatCount: ");
      sb.Append(SubSeatCount);
      sb.Append(",BedCount: ");
      sb.Append(BedCount);
      sb.Append(",SubBedCount: ");
      sb.Append(SubBedCount);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
