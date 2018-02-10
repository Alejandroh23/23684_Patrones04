using System;
namespace _Patrones04.Clases
{
    public class NotifySubject
    {
        public NotifySubject()
        {
            Object[] arrLocal;

            synchronized(this) {

                if (!changed)
                    return;
                arrLocal = obs.toArray();
                clearChanged();
            }
            for (int i = arrLocal.length - 1; i >= 0; i--)
                ((Observer)arrLocal[i]).update(this, arg);
        }
    }
}