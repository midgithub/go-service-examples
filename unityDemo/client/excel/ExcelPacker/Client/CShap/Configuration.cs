//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Configuration.proto
namespace _Configuration_client_
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"_audio_")]
  public partial class _audio_ : global::ProtoBuf.IExtensible
  {
    public _audio_() {}
    
    private uint _id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _path = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"path", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string path
    {
      get { return _path; }
      set { _path = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"_Excel_")]
  public partial class _Excel_ : global::ProtoBuf.IExtensible
  {
    public _Excel_() {}
    
    private readonly global::System.Collections.Generic.List<_Configuration_client_._audio_> _audioData = new global::System.Collections.Generic.List<_Configuration_client_._audio_>();
    [global::ProtoBuf.ProtoMember(1, Name=@"audioData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<_Configuration_client_._audio_> audioData
    {
      get { return _audioData; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}