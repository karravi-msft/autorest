namespace Fixtures.SwaggerBatBodyByte
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    public static partial class ByteModelExtensions
    {
            /// <summary>
            /// Get null byte value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static byte[] GetNull(this IByteModel operations)
            {
                return Task.Factory.StartNew(s => ((IByteModel)s).GetNullAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get null byte value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<byte[]> GetNullAsync( this IByteModel operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<byte[]> result = await operations.GetNullWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Get empty byte value ''
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static byte[] GetEmpty(this IByteModel operations)
            {
                return Task.Factory.StartNew(s => ((IByteModel)s).GetEmptyAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get empty byte value ''
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<byte[]> GetEmptyAsync( this IByteModel operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<byte[]> result = await operations.GetEmptyWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Get non-ascii byte string hex(FF FE FD FC FB FA F9 F8 F7 F6)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static byte[] GetNonAscii(this IByteModel operations)
            {
                return Task.Factory.StartNew(s => ((IByteModel)s).GetNonAsciiAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get non-ascii byte string hex(FF FE FD FC FB FA F9 F8 F7 F6)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<byte[]> GetNonAsciiAsync( this IByteModel operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<byte[]> result = await operations.GetNonAsciiWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Put non-ascii byte string hex(FF FE FD FC FB FA F9 F8 F7 F6)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='byteBody'>
            /// Base64-encoded non-ascii byte string hex(FF FE FD FC FB FA F9 F8 F7 F6)
            /// </param>
            public static void PutNonAscii(this IByteModel operations, byte[] byteBody)
            {
                Task.Factory.StartNew(s => ((IByteModel)s).PutNonAsciiAsync(byteBody), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put non-ascii byte string hex(FF FE FD FC FB FA F9 F8 F7 F6)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='byteBody'>
            /// Base64-encoded non-ascii byte string hex(FF FE FD FC FB FA F9 F8 F7 F6)
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task PutNonAsciiAsync( this IByteModel operations, byte[] byteBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PutNonAsciiWithOperationResponseAsync(byteBody, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get invalid byte value ':::SWAGGER::::'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static byte[] GetInvalid(this IByteModel operations)
            {
                return Task.Factory.StartNew(s => ((IByteModel)s).GetInvalidAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get invalid byte value ':::SWAGGER::::'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<byte[]> GetInvalidAsync( this IByteModel operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<byte[]> result = await operations.GetInvalidWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}
