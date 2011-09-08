using System;
using System.Text;
using Microsoft.CSharp;
using System.Reflection;
using System.CodeDom.Compiler;
using System.Collections.Specialized;

namespace Evaluator
{
	/// <summary>
	/// A class providing static methods for the language-independent runtime compilation of .NET source code.
	/// </summary>
	public class Eval
	{
		/// <summary>
		/// Compiles an assembly from the provided source with the parameters specified.
		/// </summary>
		/// <param name="compiler">
		/// The compiler to use for compiling the source to MSIL.
		/// </param>
		/// <param name="assemblySource">
		/// The actual source of the assembly.
		/// </param>
		/// <param name="options">
		/// The parameters to be set for the compiler.
		/// </param>
		/// <param name="language">
		/// A specification of the syntax of the language of the code
		/// </param>
		/// <returns>
		/// The resulting assembly and any warnings produced by the compiler, wrapped in an AssemblyResults object.
		/// </returns>
		/// <exception cref="CompilationException"/>
		public static AssemblyResults CreateAssembly(ICodeCompiler compiler, string assemblySource, CompilerParameters options, Language language)
		{
			CompilerResults results = compiler.CompileAssemblyFromSource(options, assemblySource);
			return new AssemblyResults(results, assemblySource);
		}

		/// <summary>
		/// Compiles a type (or class) from the provided source with the parameters specified.
		/// </summary>
		/// <param name="compiler">
		/// The compiler to use for compiling the source to MSIL.
		/// </param>
		/// <param name="typeSource">
		/// The actual source of the type.
		/// </param>
		/// <param name="typeName">
		/// The name of the type.
		/// </param>
		/// <param name="options">
		/// The parameters to be set for the compiler.
		/// </param>
		/// <param name="language">
		/// A specification of the syntax of the language of the code
		/// </param>
		/// <returns>
		/// The resulting type and any warnings produced by the compiler, wrapped in a TypeResults object.
		/// </returns>
		/// <exception cref="CompilationException"/>
		public static TypeResults CreateType(ICodeCompiler compiler, string typeSource, string typeName, CompilerParameters options, Language language)
		{
            string namespaceName = options.OutputAssembly;
            if(namespaceName == null)
                namespaceName = "Evaluated";

			StringBuilder sourceBuilder = new StringBuilder();
           foreach(string referenced in options.ReferencedAssemblies)
			{
                sourceBuilder.Append(language.useStatement(referenced.Replace(".dll", "")));
			}

            sourceBuilder.Append(language.beginNamespace(namespaceName));
			sourceBuilder.Append(typeSource);
            sourceBuilder.Append(language.endNamespace(namespaceName));
            
			AssemblyResults compiled = CreateAssembly(compiler, sourceBuilder.ToString(), options, language);
            return compiled.GetType(namespaceName + "." + typeName, true);
		}

		/// <summary>
		/// Compiles a method from the provided source with the parameters specified.
		/// </summary>
		/// <param name="compiler">
		/// The compiler to use for compiling the source to MSIL.
		/// </param>
		/// <param name="methodSource">
		/// The actual source of the method.
		/// </param>
		/// <param name="methodName">
		/// The name of the method.
		/// </param>
		/// <param name="options">
		/// The parameters to be set for the compiler.
		/// </param>
		/// <param name="language">
		/// A specification of the syntax of the language of the code
		/// </param>
		/// <returns>
		/// The resulting method and any warnings produced by the compiler, wrapped in a MethodResults object.
		/// </returns>
		/// <exception cref="CompilationException"/>
		public static MethodResults CreateMethod(ICodeCompiler compiler, string methodSource, string methodName, CompilerParameters options, Language language)
		{
			string containerName = String.Format("{0}Container", methodName);

			StringBuilder sourceBuilder = new StringBuilder();
			sourceBuilder.Append(language.beginType(containerName));
			sourceBuilder.Append(methodSource);
			sourceBuilder.Append(language.endType(containerName));
			
			TypeResults compiledType = CreateType(compiler, sourceBuilder.ToString(), containerName, options, language);
			return compiledType.GetMethod(methodName);
		}

		/// <summary>
		/// Creates a CompilerParameters object containing the default settings for an assembly generated in memory.
		/// </summary>
		/// <param name="debug">
		/// Determines whether debug information is included in the compiler's final output.
		/// </param>
		/// <param name="assemblyName">
		/// The name of the resulting assembly.
		/// </param>
		/// <param name="references">
		/// The assemblies referenced by the input to the compiler.
		/// </param>
		/// <returns>
		/// A CompilerParameters object containing the default settings for an assembly generated in memory.
		/// </returns>
		protected static CompilerParameters GetVirtualParameters(bool debug, string assemblyName, params string[] references)
		{
			CompilerParameters options = new CompilerParameters();
			options.GenerateInMemory = true;
			options.GenerateExecutable = false;
			options.IncludeDebugInformation = debug;
			options.ReferencedAssemblies.AddRange(references);

			return options;
		}

		/// <summary>
		/// Compiles an assembly from the provided source and stores it in memory using the parameters specified.
		/// </summary>
		/// <param name="compiler">
		/// The compiler to use for compiling the source to MSIL.
		/// </param>
		/// <param name="assemblySource">
		/// The actual source of the assembly.
		/// </param>
		/// <param name="language">
		/// A specification of the syntax of the language of the code
		/// </param>
		/// <param name="debug">
		/// Determines whether debug information is included in the compiled assembly.
		/// </param>
		/// <param name="references">
		/// The assemblies referenced by the assembly being compiled.
		/// </param>
		/// <returns>
		/// The resulting assembly and any warnings produced by the compiler, wrapped in an AssemblyResults object.
		/// </returns>
		/// <exception cref="CompilationException"/>
		public static AssemblyResults CreateVirtualAssembly(ICodeCompiler compiler, string assemblySource, Language language, bool debug, params string[] references)
		{
			return CreateAssembly(compiler, assemblySource, GetVirtualParameters(debug, "Evaluated", references), language);
		}

		/// <summary>
		/// Compiles a type (or class) from the provided source and stores it in memory using the parameters specified.
		/// </summary>
		/// <param name="compiler">
		/// The compiler to use for compiling the source to MSIL.
		/// </param>
		/// <param name="typeSource">
		/// The actual source of the type.
		/// </param>
		/// <param name="typeName">
		/// The name of the type.
		/// </param>
		/// <param name="language">
		/// A specification of the syntax of the language of the code
		/// </param>
		/// <param name="debug">
		/// Determines whether debug information is included in the compiled assembly.
		/// </param>
		/// <param name="references">
		/// The assemblies referenced by the assembly being compiled.
		/// </param>
		/// <returns>
		/// The resulting assembly and any warnings produced by the compiler, wrapped in an AssemblyResults object.
		/// </returns>
		/// <exception cref="CompilationException"/>
		public static TypeResults CreateVirtualType(ICodeCompiler compiler, string typeSource, string typeName, Language language, bool debug, params string[] references)
		{
			return CreateType(compiler, typeSource, typeName, GetVirtualParameters(debug, "Evaluated", references), language);
		}

		/// <summary>
		/// Compiles a method from the provided source and stores it in memory with the parameters specified.
		/// </summary>
		/// <param name="compiler">
		/// The compiler to use for compiling the source to MSIL.
		/// </param>
		/// <param name="methodSource">
		/// The actual source of the method.
		/// </param>
		/// <param name="methodName">
		/// The name of the method.
		/// </param>
		/// <param name="language">
		/// A specification of the syntax of the language of the code
		/// </param>
		/// <param name="debug">
		/// Determines whether debug information is included in the compiled assembly.
		/// </param>
		/// <param name="references">
		/// The assemblies referenced by the assembly being compiled.
		/// </param>
		/// <returns>
		/// The resulting method and any warnings produced by the compiler, wrapped in a MethodResults object.
		/// </returns>
		/// <exception cref="CompilationException"/>
		public static MethodResults CreateVirtualMethod(ICodeCompiler compiler, string methodSource, string methodName, Language language, bool debug, params string[] references)
		{
			return CreateMethod(compiler, methodSource, methodName, GetVirtualParameters(debug, "Evaluated", references), language);
		}

		private Eval()
		{;}
	}
}
