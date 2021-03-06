﻿// Copyright (c) Autofac Project. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Autofac.Core.Resolving;

namespace Autofac.Diagnostics
{
    /// <summary>
    /// Event data for the <see cref="OperationDiagnosticTracerBase{TContent}.OperationCompleted"/> event.
    /// </summary>
    /// <typeparam name="TContent">
    /// The type of content generated by the trace at the end of the operation.
    /// </typeparam>
    public sealed class OperationTraceCompletedArgs<TContent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationTraceCompletedArgs{TContent}"/> class.
        /// </summary>
        /// <param name="operation">The operation for which a trace has completed.</param>
        /// <param name="traceContent">The content of the trace.</param>
        public OperationTraceCompletedArgs(IResolveOperation operation, TContent traceContent)
        {
            Operation = operation;
            TraceContent = traceContent;
        }

        /// <summary>
        /// Gets the operation for which a trace is available.
        /// </summary>
        public IResolveOperation Operation { get; }

        /// <summary>
        /// Gets the content of the trace.
        /// </summary>
        public TContent TraceContent { get; }
    }
}
