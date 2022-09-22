﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;

namespace Basic.CompilerLog.Util.Impl;

/// <summary>
/// This is used to load the analyzers from the compiler log file
///
/// TODO: consider handling the nested load context scenarios
/// </summary>
internal sealed class BasicAssemblyLoadContext : AssemblyLoadContext
{
    internal ImmutableArray<BasicAnalyzerReference> AnalyzerReferences { get; } = ImmutableArray<BasicAnalyzerReference>.Empty;

    internal BasicAssemblyLoadContext(string name, CompilerLogReader reader, List<Guid> analyzerMvids)
    {
        // var builder = ImmutableArray.CreateBuilder<BasicAnalyzerReference>(analyzerMvids.Count);
        // foreach (var mvid in analyzerMvids)
        // {
        //     var analyzerBytes = reader.GetAssemblyBytes(mvid);
        //     var assembly =  LoadFromStream(new MemoryStream(analyzerBytes.ToArray()));
        //     builder.Add(new(assembly));
        // }

        // AnalyzerReferences = builder.ToImmutable();
    }

    internal ImmutableArray<DiagnosticAnalyzer> GetAnalyzers(string languageName)
    {
        return ImmutableArray<DiagnosticAnalyzer>.Empty;
        // var builder = ImmutableArray.CreateBuilder<DiagnosticAnalyzer>();
        // foreach (var reference in AnalyzerReferences)
        // {
        //     reference.GetAnalyzers(builder, languageName);
        // }
        // return builder.ToImmutable();
    }

    internal ImmutableArray<ISourceGenerator> GetGenerators(string languageName)
    {
        return ImmutableArray<ISourceGenerator>.Empty;
        // var builder = ImmutableArray.CreateBuilder<ISourceGenerator>();
        // foreach (var reference in AnalyzerReferences)
        // {
        //     reference.GetGenerators(builder, languageName);
        // }
        // return builder.ToImmutable();
    }
}
