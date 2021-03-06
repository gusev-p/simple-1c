﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Simple1C.Impl.Generation.Rendering
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    internal partial class ClassFileTemplate : ClassFileTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing Simple1C.Interface;\r\nusin" +
                    "g Simple1C.Interface.ObjectModel;\r\n\r\nnamespace ");
            
            #line 11 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n");
            
            #line 13 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
 
	PushIndent("\t"); 
	RenderClass(Model.MainClass);
	PopIndent();

            
            #line default
            #line hidden
            this.Write("}\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 19 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"

public ClassFileModel Model { get; set; }

private void RenderClass(ClassModel model)
{

        
        #line default
        #line hidden
        
        #line 25 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
if(model.ConfigurationScope.HasValue)
{
        
        #line default
        #line hidden
        
        #line 26 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write("[ConfigurationScope(ConfigurationScope.");

        
        #line default
        #line hidden
        
        #line 27 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(model.ConfigurationScope.Value.ToString()));

        
        #line default
        #line hidden
        
        #line 27 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write(")]\r\n");

        
        #line default
        #line hidden
        
        #line 28 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
}
        
        #line default
        #line hidden
        
        #line 29 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
if(model.Synonym != null)
{
        
        #line default
        #line hidden
        
        #line 30 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write("[Synonym(\"");

        
        #line default
        #line hidden
        
        #line 31 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(model.Synonym));

        
        #line default
        #line hidden
        
        #line 31 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write("\")]\r\n");

        
        #line default
        #line hidden
        
        #line 32 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
}
        
        #line default
        #line hidden
        
        #line 33 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
if(model.ObjectPresentation != null)
{
        
        #line default
        #line hidden
        
        #line 34 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write("[ObjectPresentation(\"");

        
        #line default
        #line hidden
        
        #line 35 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(model.ObjectPresentation));

        
        #line default
        #line hidden
        
        #line 35 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write("\")]\r\n");

        
        #line default
        #line hidden
        
        #line 36 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
}
        
        #line default
        #line hidden
        
        #line 36 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write("public partial class ");

        
        #line default
        #line hidden
        
        #line 37 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(model.Name));

        
        #line default
        #line hidden
        
        #line 37 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write(" : Abstract1CEntity\r\n{\r\n");

        
        #line default
        #line hidden
        
        #line 39 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
for(var i = 0; i < model.Properties.Count; i++)
	{
		var prop = model.Properties[i];
		if(i != 0)
			Write("\r\n");
	
        
        #line default
        #line hidden
        
        #line 44 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write("\tprivate Requisite<");

        
        #line default
        #line hidden
        
        #line 44 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(prop.Type));

        
        #line default
        #line hidden
        
        #line 44 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write("> ");

        
        #line default
        #line hidden
        
        #line 44 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(prop.FieldName));

        
        #line default
        #line hidden
        
        #line 44 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write(";\r\n");

        
        #line default
        #line hidden
        
        #line 45 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
if(prop.MaxLength.HasValue) {
        
        #line default
        #line hidden
        
        #line 45 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write("\t[MaxLength(");

        
        #line default
        #line hidden
        
        #line 45 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(prop.MaxLength.Value));

        
        #line default
        #line hidden
        
        #line 45 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write(")]\r\n");

        
        #line default
        #line hidden
        
        #line 46 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
}
        
        #line default
        #line hidden
        
        #line 46 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write("\tpublic ");

        
        #line default
        #line hidden
        
        #line 46 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(prop.Type));

        
        #line default
        #line hidden
        
        #line 46 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write(" ");

        
        #line default
        #line hidden
        
        #line 46 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyName));

        
        #line default
        #line hidden
        
        #line 46 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write("\r\n\t{\r\n\t\tget { return Controller.GetValue(ref ");

        
        #line default
        #line hidden
        
        #line 48 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(prop.FieldName));

        
        #line default
        #line hidden
        
        #line 48 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write(", \"");

        
        #line default
        #line hidden
        
        #line 48 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyName));

        
        #line default
        #line hidden
        
        #line 48 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write("\"); }\r\n\t\tset { Controller.SetValue(ref ");

        
        #line default
        #line hidden
        
        #line 49 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(prop.FieldName));

        
        #line default
        #line hidden
        
        #line 49 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write(", \"");

        
        #line default
        #line hidden
        
        #line 49 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyName));

        
        #line default
        #line hidden
        
        #line 49 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write("\", value); }\r\n\t}\r\n");

        
        #line default
        #line hidden
        
        #line 51 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
}
        
        #line default
        #line hidden
        
        #line 51 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
if(model.NestedClasses != null)
		foreach(var nestedClass in model.NestedClasses)
		{
			Write("\r\n");
			PushIndent("\t");
			RenderClass(nestedClass);
			PopIndent();
		}
        
        #line default
        #line hidden
        
        #line 58 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
this.Write("}\r\n");

        
        #line default
        #line hidden
        
        #line 60 "C:\sources\Simple1C\Simple1C\Impl\Generation\Rendering\ClassFileTemplate.tt"
}
        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    internal class ClassFileTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
