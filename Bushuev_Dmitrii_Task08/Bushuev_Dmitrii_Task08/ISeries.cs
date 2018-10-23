namespace Bushuev_Dmitrii_Task08
{
    partial class Program
    {
        interface ISeries<T>
        {
            T GetCurrent();
            bool MoveNext();
            void Reset();
        }
    }
}
