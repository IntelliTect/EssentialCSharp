namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_30
{
    using System.Collections.Generic;
    using System.Dynamic;
   
    public class DynamicObject : IDynamicMetaObjectProvider
    {
        protected DynamicObject();

        public virtual IEnumerable<string> GetDynamicMemberNames();
        public virtual DynamicMetaObject GetMetaObject(
            Expression parameter);
        public virtual bool TryBinaryOperation(
            BinaryOperationBinder binder, object arg,
                out object result);
        public virtual bool TryConvert(
            ConvertBinder binder, out object result);
        public virtual bool TryCreateInstance(
            CreateInstanceBinder binder, object[] args,
                  out object result);
        public virtual bool TryDeleteIndex(
            DeleteIndexBinder binder, object[] indexes);
        public virtual bool TryDeleteMember(
            DeleteMemberBinder binder);
        public virtual bool TryGetIndex(
            GetIndexBinder binder, object[] indexes,
                  out object result);
        public virtual bool TryGetMember(
            GetMemberBinder binder, out object result);
        public virtual bool TryInvoke(
            InvokeBinder binder, object[] args, out object result);
        public virtual bool TryInvokeMember(
            InvokeMemberBinder binder, object[] args,
                  out object result);
        public virtual bool TrySetIndex(
            SetIndexBinder binder, object[] indexes, object value);
        public virtual bool TrySetMember(
            SetMemberBinder binder, object value);
        public virtual bool TryUnaryOperation(
            UnaryOperationBinder binder, out object result);
    }

}
