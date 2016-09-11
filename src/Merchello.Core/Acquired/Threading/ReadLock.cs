﻿namespace Merchello.Core.Acquired.Threading
{
    using System;
    using System.Threading;

    /// <summary>
    /// Provides a convenience methodology for implementing locked access to resources. 
    /// </summary>
    /// <remarks>
    /// Intended as an infrastructure class.
    /// UMBRACO Direct port of Umbraco internal interface to get rid of hard dependency
    /// </remarks>
    internal class ReadLock : IDisposable
    {
        private readonly ReaderWriterLockSlim _rwLock;

        /// <summary>
		/// Initializes a new instance of the <see cref="ReadLock"/> class.
        /// </summary>
		public ReadLock(ReaderWriterLockSlim rwLock)
        {
            this._rwLock = rwLock;
            this._rwLock.EnterReadLock();
        }

        void IDisposable.Dispose()
        {
            this._rwLock.ExitReadLock();
        }
    }
}
