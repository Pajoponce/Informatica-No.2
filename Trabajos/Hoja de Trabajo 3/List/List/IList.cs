namespace List
{
    public interface IList<T> 
    {
        bool Get(int Obj, out T Obj2);
        bool Set(int Obj, T Obj2);
        void Push(T Obj);
        int Length { get; }
    }
}
