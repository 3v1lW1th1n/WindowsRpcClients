//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\bisrv.dll
// Interface ID: 857fb1be-084f-4fb5-b59c-4b2c4be5f0cf
// Interface Version: 1.0



namespace rpc_857fb1be_084f_4fb5_b59c_4b2c4be5f0cf_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_1 p0)
        {
            WriteStruct<Struct_1>(p0);
        }
    }
    internal class _Unmarshal_Helper : NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer
    {
        public _Unmarshal_Helper(NtApiDotNet.Win32.Rpc.RpcClientResponse r) : 
                base(r.NdrBuffer, r.Handles, r.DataRepresentation)
        {
        }
        public _Unmarshal_Helper(byte[] ba) : 
                base(ba)
        {
        }
        public Struct_1 Read_0()
        {
            return ReadStruct<Struct_1>();
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_1 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteUInt3264(Member0);
            m.WriteInt32(Member8);
            m.WriteInt32(MemberC);
            m.WriteInt32(Member10);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadUInt3264();
            Member8 = u.ReadInt32();
            MemberC = u.ReadInt32();
            Member10 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member0;
        public int Member8;
        public int MemberC;
        public int Member10;
        public static Struct_1 CreateDefault()
        {
            return new Struct_1();
        }
        public Struct_1(NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member0, int Member8, int MemberC, int Member10)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.MemberC = MemberC;
            this.Member10 = Member10;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("857fb1be-084f-4fb5-b59c-4b2c4be5f0cf", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int SrvOdbPrivGetLaunchInfo(System.Guid p0, out System.Nullable<Struct_1> p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(0, m);
            p1 = u.ReadReferentValue<Struct_1>(new System.Func<Struct_1>(u.Read_0), false);
            return u.ReadInt32();
        }
    }
    #endregion
}
