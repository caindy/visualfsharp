// Copyright (c) Microsoft Open Technologies, Inc.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

/// Parse "printf-style" format specifiers at compile time, producing
/// a list of items that specify the types of the things that follow.
///
/// Must be updated if the Printf runtime component is updated.

module internal Microsoft.FSharp.Compiler.Formats

open Internal.Utilities
open Microsoft.FSharp.Compiler 
open Microsoft.FSharp.Compiler.Tast 
open Microsoft.FSharp.Compiler.AbstractIL.Internal 

val ParseFormatString : Range.range -> Env.TcGlobals -> string -> TType -> TType -> TType -> TType * TType
