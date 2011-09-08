using System;
using System.Text;

namespace Evaluator
{
	/// <summary>
	/// A base class for basic specifications of syntax for individual languages
	/// </summary>
	public abstract class Language
	{
		/// <summary>
		/// Generates a statement to allow treatment of classes within an assembly/namespace as if they were local
		/// </summary>
		/// <param name="assemblyName">
		/// The name of the assembly to be treated as local
		/// </param>
		/// <returns>
		/// A statement that will allow treatment of classes within an assembly/namespace as if they were local
		/// </returns>
		public abstract string useStatement(string assemblyName);

		/// <summary>
		/// Generates a statement to begin a namespace
		/// </summary>
		/// <param name="namespaceName">
		/// The name of the namespace
		/// </param>
		/// <returns>
		/// A statement to begin the namespace
		/// </returns>
		public abstract string beginNamespace(string namespaceName);
		/// <summary>
		/// Generates a statement to end a namespace
		/// </summary>
		/// <param name="namespaceName">
		/// The name of the namespace
		/// </param>
		/// <returns>
		/// A statement to end the namespace
		/// </returns>
		public abstract string endNamespace(string namespaceName);

		/// <summary>
		/// Generates a statement to begin a type
		/// </summary>
		/// <param name="typeName">
		/// The name of the type
		/// </param>
		/// <returns>
		/// A statement to begin the type
		/// </returns>
		public abstract string beginType(string typeName);
		/// <summary>
		/// Generates a statement to end a type
		/// </summary>
		/// <param name="typeName">
		/// The name of the type
		/// </param>
		/// <returns>
		/// A statement to end the type
		/// </returns>
		public abstract string endType(string typeName);
	}

	/// <summary>
	/// A basic specification of the syntax of C#
	/// </summary>
	public class CSharpLanguage : Language
	{
		/// <summary>
		/// Generates a statement to allow treatment of classes within an assembly/namespace as if they were local
		/// </summary>
		/// <param name="assemblyName">
		/// The name of the assembly to be treated as local
		/// </param>
		/// <returns>
		/// A statement that will allow treatment of classes within an assembly/namespace as if they were local
		/// </returns>
		public override string useStatement(string assemblyName)
		{
			return String.Format("using {0};{1}", assemblyName, Environment.NewLine);
		}

		/// <summary>
		/// Generates a statement to begin a namespace
		/// </summary>
		/// <param name="namespaceName">
		/// The name of the namespace
		/// </param>
		/// <returns>
		/// A statement to begin the namespace
		/// </returns>
		public override string beginNamespace(string namespaceName)
		{
			StringBuilder r = new StringBuilder();
			r.AppendFormat("namespace {0}{1}", namespaceName, Environment.NewLine);
			r.Append("{");
			r.Append(Environment.NewLine);
			return r.ToString();
		}
		/// <summary>
		/// Generates a statement to end a namespace
		/// </summary>
		/// <param name="namespaceName">
		/// The name of the namespace
		/// </param>
		/// <returns>
		/// A statement to end the namespace
		/// </returns>
		public override string endNamespace(string namespaceName)
		{
			StringBuilder r = new StringBuilder();
			r.Append("}");
			r.Append(Environment.NewLine);
			return r.ToString();
		}

		/// <summary>
		/// Generates a statement to begin a type
		/// </summary>
		/// <param name="typeName">
		/// The name of the type
		/// </param>
		/// <returns>
		/// A statement to begin the type
		/// </returns>
		public override string beginType(string typeName)
		{
			StringBuilder r = new StringBuilder();
			r.AppendFormat("public class {0}{1}", typeName, Environment.NewLine);
			r.Append("{");
			r.Append(Environment.NewLine);
			return r.ToString();
		}
		/// <summary>
		/// Generates a statement to end a type
		/// </summary>
		/// <param name="typeName">
		/// The name of the type
		/// </param>
		/// <returns>
		/// A statement to end the type
		/// </returns>
		public override string endType(string typeName)
		{
			StringBuilder r = new StringBuilder();
			r.Append(Environment.NewLine);
			r.Append("}");
			r.Append(Environment.NewLine);
			return r.ToString();
		}

		/// <summary>
		/// Constructs a new instance of the CSharpLanguageOptions class.
		/// </summary>
		public CSharpLanguage()
		{;}
	}

	/// <summary>
	/// A basic specification of the syntax of VB.NET
	/// </summary>
	public class VBLanguage : Language
	{
		/// <summary>
		/// Generates a statement to allow treatment of classes within an assembly/namespace as if they were local
		/// </summary>
		/// <param name="assemblyName">
		/// The name of the assembly to be treated as local
		/// </param>
		/// <returns>
		/// A statement that will allow treatment of classes within an assembly/namespace as if they were local
		/// </returns>
		public override string useStatement(string assemblyName)
		{
			return String.Format("Imports {0}{1}", assemblyName, Environment.NewLine);
		}

		/// <summary>
		/// Generates a statement to begin a namespace
		/// </summary>
		/// <param name="namespaceName">
		/// The name of the namespace
		/// </param>
		/// <returns>
		/// A statement to begin the namespace
		/// </returns>
		public override string beginNamespace(string namespaceName)
		{
			return String.Format("Namespace {0}{1}", namespaceName, Environment.NewLine);
		}
		/// <summary>
		/// Generates a statement to end a namespace
		/// </summary>
		/// <param name="namespaceName">
		/// The name of the namespace
		/// </param>
		/// <returns>
		/// A statement to end the namespace
		/// </returns>
		public override string endNamespace(string namespaceName)
		{
			return String.Format("End Namespace{0}", Environment.NewLine);
		}

		/// <summary>
		/// Generates a statement to begin a type
		/// </summary>
		/// <param name="typeName">
		/// The name of the type
		/// </param>
		/// <returns>
		/// A statement to begin the type
		/// </returns>
		public override string beginType(string typeName)
		{
			return String.Format("Public Class {0}{1}", typeName, Environment.NewLine);
		}
		/// <summary>
		/// Generates a statement to end a type
		/// </summary>
		/// <param name="typeName">
		/// The name of the type
		/// </param>
		/// <returns>
		/// A statement to end the type
		/// </returns>
		public override string endType(string typeName)
		{
			return String.Format("{0}End Class{0}", Environment.NewLine);
		}

		/// <summary>
		/// Constructs a new instance of the VBLanguageOptions class.
		/// </summary>
		public VBLanguage()
		{;}
	}
}
