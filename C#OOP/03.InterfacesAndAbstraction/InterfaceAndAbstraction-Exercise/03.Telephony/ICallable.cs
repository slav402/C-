﻿namespace Telephony
{
    public interface ICallable
    {
        string Number { get; set; }

        void Calling();
    }

}
