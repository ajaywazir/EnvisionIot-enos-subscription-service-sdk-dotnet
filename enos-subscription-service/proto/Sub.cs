// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: my.proto

#pragma warning disable 1591, 0612, 3021
namespace enos_subscription.proto
{

    [global::ProtoBuf.ProtoContract()]
    public partial class IdleReq : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public IdleReq()
        {
            OnConstructor();
        }

        partial void OnConstructor();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class IdleRsp : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public IdleRsp()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1, IsRequired = true)]
        public long svrTime { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class AuthReq : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public AuthReq()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1, IsRequired = true)]
        public string accessKey { get; set; }

        [global::ProtoBuf.ProtoMember(2, IsRequired = true)]
        public string subId { get; set; }

        [global::ProtoBuf.ProtoMember(3, IsRequired = true)]
        public string sign { get; set; }

        [global::ProtoBuf.ProtoMember(4, IsRequired = true)]
        public int subType { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class AuthRsp : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public AuthRsp()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1, IsRequired = true)]
        public int ack { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string msg
        {
            get { return __pbn__msg ?? ""; }
            set { __pbn__msg = value; }
        }
        public bool ShouldSerializemsg()
        {
            return __pbn__msg != null;
        }
        public void Resetmsg()
        {
            __pbn__msg = null;
        }
        private string __pbn__msg;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string channelId
        {
            get { return __pbn__channelId ?? ""; }
            set { __pbn__channelId = value; }
        }
        public bool ShouldSerializechannelId()
        {
            return __pbn__channelId != null;
        }
        public void ResetchannelId()
        {
            __pbn__channelId = null;
        }
        private string __pbn__channelId;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SubReq : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public SubReq()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1, IsRequired = true)]
        public int category { get; set; }

        [global::ProtoBuf.ProtoMember(2, IsRequired = true)]
        public string clientId { get; set; }

        [global::ProtoBuf.ProtoMember(3, IsRequired = true)]
        public string subId { get; set; }

        [global::ProtoBuf.ProtoMember(4, IsRequired = true)]
        public string accessKey { get; set; }

        [global::ProtoBuf.ProtoMember(5, IsRequired = true)]
        public string consumerGroup { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SubRsp : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public SubRsp()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1, IsRequired = true)]
        public int ack { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string channelId
        {
            get { return __pbn__channelId ?? ""; }
            set { __pbn__channelId = value; }
        }
        public bool ShouldSerializechannelId()
        {
            return __pbn__channelId != null;
        }
        public void ResetchannelId()
        {
            __pbn__channelId = null;
        }
        private string __pbn__channelId;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string msg
        {
            get { return __pbn__msg ?? ""; }
            set { __pbn__msg = value; }
        }
        public bool ShouldSerializemsg()
        {
            return __pbn__msg != null;
        }
        public void Resetmsg()
        {
            __pbn__msg = null;
        }
        private string __pbn__msg;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PullReq : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public PullReq()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1, IsRequired = true)]
        public long id { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Message : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public Message()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1, IsRequired = true)]
        public string topic { get; set; }

        [global::ProtoBuf.ProtoMember(2, IsRequired = true)]
        public int partition { get; set; }

        [global::ProtoBuf.ProtoMember(3, IsRequired = true)]
        public long offset { get; set; }

        [global::ProtoBuf.ProtoMember(4, IsRequired = true)]
        public long timestamp { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue("")]
        public string key
        {
            get { return __pbn__key ?? ""; }
            set { __pbn__key = value; }
        }
        public bool ShouldSerializekey()
        {
            return __pbn__key != null;
        }
        public void Resetkey()
        {
            __pbn__key = null;
        }
        private string __pbn__key;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue("")]
        public string value
        {
            get { return __pbn__value ?? ""; }
            set { __pbn__value = value; }
        }
        public bool ShouldSerializevalue()
        {
            return __pbn__value != null;
        }
        public void Resetvalue()
        {
            __pbn__value = null;
        }
        private string __pbn__value;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MessageDTO : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public MessageDTO()
        {
            messages = new global::System.Collections.Generic.List<Message>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<Message> messages { get; private set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PullRsp : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public PullRsp()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1, IsRequired = true)]
        public long id { get; set; }

        [global::ProtoBuf.ProtoMember(2, IsRequired = true)]
        public int code { get; set; }

        [global::ProtoBuf.ProtoMember(3, IsRequired = true)]
        public MessageDTO msgDTO { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Commit : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public Commit()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1, IsRequired = true)]
        public string topic { get; set; }

        [global::ProtoBuf.ProtoMember(2, IsRequired = true)]
        public int partition { get; set; }

        [global::ProtoBuf.ProtoMember(3, IsRequired = true)]
        public long offset { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CommitDTO : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public CommitDTO()
        {
            commits = new global::System.Collections.Generic.List<Commit>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<Commit> commits { get; private set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CloseReq : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public CloseReq()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1, IsRequired = true)]
        public long id { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public enum CmdId
    {
        [global::ProtoBuf.ProtoEnum(Name = @"idle_req")]
        IdleReq = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"idle_rsp")]
        IdleRsp = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"auth_req")]
        AuthReq = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"auth_rsp")]
        AuthRsp = 3,
        [global::ProtoBuf.ProtoEnum(Name = @"pull_req")]
        PullReq = 4,
        [global::ProtoBuf.ProtoEnum(Name = @"pull_rsp")]
        PullRsp = 5,
        [global::ProtoBuf.ProtoEnum(Name = @"sub_req")]
        SubReq = 6,
        [global::ProtoBuf.ProtoEnum(Name = @"sub_rsp")]
        SubRsp = 7,
        [global::ProtoBuf.ProtoEnum(Name = @"commit_req")]
        CommitReq = 8,
        [global::ProtoBuf.ProtoEnum(Name = @"commit_rsp")]
        CommitRsp = 9,
        [global::ProtoBuf.ProtoEnum(Name = @"close_req")]
        CloseReq = 10,
        [global::ProtoBuf.ProtoEnum(Name = @"close_rsp")]
        CloseRsp = 11,
    }

}

#pragma warning restore 1591, 0612, 3021