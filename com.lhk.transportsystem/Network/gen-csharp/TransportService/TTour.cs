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
  public partial class TTour : TBase
  {
    private string _Id;
    private string _Start;
    private string _Destination;
    private int _TravelTime;

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

    public string Start
    {
      get
      {
        return _Start;
      }
      set
      {
        __isset.Start = true;
        this._Start = value;
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

    public int TravelTime
    {
      get
      {
        return _TravelTime;
      }
      set
      {
        __isset.TravelTime = true;
        this._TravelTime = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool Id;
      public bool Start;
      public bool Destination;
      public bool TravelTime;
    }

    public TTour() {
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
              Start = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              Destination = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              TravelTime = iprot.ReadI32();
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
      TStruct struc = new TStruct("TTour");
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
      if (Start != null && __isset.Start) {
        field.Name = "Start";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Start);
        oprot.WriteFieldEnd();
      }
      if (Destination != null && __isset.Destination) {
        field.Name = "Destination";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Destination);
        oprot.WriteFieldEnd();
      }
      if (__isset.TravelTime) {
        field.Name = "TravelTime";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(TravelTime);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("TTour(");
      sb.Append("Id: ");
      sb.Append(Id);
      sb.Append(",Start: ");
      sb.Append(Start);
      sb.Append(",Destination: ");
      sb.Append(Destination);
      sb.Append(",TravelTime: ");
      sb.Append(TravelTime);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
