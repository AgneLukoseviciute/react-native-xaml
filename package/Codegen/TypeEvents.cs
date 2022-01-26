﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Codegen
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\asklar\source\repos\react-native-xaml\package\Codegen\TypeEvents.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class TypeEvents : TypeEventsBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(@"#pragma once
#include ""pch.h""
#include ""XamlMetadata.h""
#include ""Serialize.h""
#include ""Crc32Str.h""
#include <JSValueWriter.h>

/*************************************************************
THIS FILE WAS AUTOMATICALLY GENERATED, DO NOT MODIFY MANUALLY
**************************************************************/

");
            
            #line 17 "C:\Users\asklar\source\repos\react-native-xaml\package\Codegen\TypeEvents.tt"
 foreach (var ns in Events.Select(p => p.DeclaringType.GetNamespace()).Distinct()) { 
            
            #line default
            #line hidden
            this.Write("#include <winrt/");
            
            #line 18 "C:\Users\asklar\source\repos\react-native-xaml\package\Codegen\TypeEvents.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ns));
            
            #line default
            #line hidden
            this.Write(".h>\r\n");
            
            #line 19 "C:\Users\asklar\source\repos\react-native-xaml\package\Codegen\TypeEvents.tt"
 } 
            
            #line default
            #line hidden
            this.Write("#include <winrt/");
            
            #line 20 "C:\Users\asklar\source\repos\react-native-xaml\package\Codegen\TypeEvents.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(XamlNames.XamlNamespace));
            
            #line default
            #line hidden
            this.Write(".Input.h>\r\n\r\n/////// Events\r\ntemplate<typename TArgs>\r\nvoid SerializeEventArgs(wi" +
                    "nrt::Microsoft::ReactNative::IJSValueWriter const& writer, const winrt::Windows:" +
                    ":Foundation::IInspectable& sender, const TArgs& args);\r\n\r\n\r\ntemplate<typename T>" +
                    "\r\n__declspec(noinline) T DoTheTypeChecking(const winrt::Windows::Foundation::IIn" +
                    "spectable& ii, bool isWrapped) {\r\n  auto o = isWrapped ? Unwrap<T>(ii) : ii.try_" +
                    "as<T>();\r\n  return o;\r\n}\r\n\r\ntemplate<typename T>\r\n__declspec(noinline) void Disp" +
                    "atchTheEvent(const EventAttachInfo& eai, const winrt::Windows::Foundation::IInsp" +
                    "ectable& sender, const T& args) {\r\n  auto senderAsFE = sender.try_as<FrameworkEl" +
                    "ement>();\r\n  auto wEN = winrt::to_hstring(eai.jsEventName);\r\n  if (eai.xamlMetad" +
                    "ata.m_callFunctionReturnFlushedQueue.has_value()) {\r\n    const auto tag = winrt:" +
                    ":unbox_value<int64_t>(eai.obj.as<FrameworkElement>().Tag());\r\n    ExecuteJsi(eai" +
                    ".context, [metadata = eai.xamlMetadata.shared_from_this(), tag, senderAsFE, args" +
                    ", eventName = eai.jsEventName](facebook::jsi::Runtime& rt) {\r\n      auto objSend" +
                    "er = std::make_shared<XamlObject>(senderAsFE, metadata);\r\n      auto objArgs = s" +
                    "td::make_shared<XamlObject>(args, metadata);\r\n      auto obj = std::make_shared<" +
                    "facebook::jsi::Object>(rt);\r\n      obj->setProperty(rt, \"sender\", rt.global().cr" +
                    "eateFromHostObject(rt, objSender));\r\n      obj->setProperty(rt, \"args\", rt.globa" +
                    "l().createFromHostObject(rt, objArgs));\r\n\r\n      metadata->JsiDispatchEvent(rt, " +
                    "tag, std::string(eventName), obj);\r\n      });\r\n  }\r\n  else {\r\n    XamlUIService:" +
                    ":FromContext(eai.context).DispatchEvent(eai.obj.try_as<xaml::FrameworkElement>()" +
                    ", wEN.c_str(),\r\n      [senderAsFE, args](const winrt::Microsoft::ReactNative::IJ" +
                    "SValueWriter& evtDataWriter) {\r\n        SerializeEventArgs(evtDataWriter, sender" +
                    "AsFE, args);\r\n      });\r\n  }\r\n};\r\n\r\n/*static*/ const EventInfo EventInfo::xamlEv" +
                    "entMap[] = {\r\n");
            
            #line 58 "C:\Users\asklar\source\repos\react-native-xaml\package\Codegen\TypeEvents.tt"
 foreach (var evt in Events) { 
            
            #line default
            #line hidden
            this.Write("  {\"");
            
            #line 59 "C:\Users\asklar\source\repos\react-native-xaml\package\Codegen\TypeEvents.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.GetName()));
            
            #line default
            #line hidden
            this.Write("\", [](const EventAttachInfo& eai, bool isWrapped, winrt::event_token token) noexc" +
                    "ept {\r\n    if (const auto& c = DoTheTypeChecking<");
            
            #line 60 "C:\Users\asklar\source\repos\react-native-xaml\package\Codegen\TypeEvents.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Util.GetCppWinRTType(evt.DeclaringType)));
            
            #line default
            #line hidden
            this.Write(">(eai.obj, isWrapped)) {\r\n      if (!token) {\r\n        return c.");
            
            #line 62 "C:\Users\asklar\source\repos\react-native-xaml\package\Codegen\TypeEvents.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.GetName()));
            
            #line default
            #line hidden
            this.Write("([eai] (");
            
            #line 62 "C:\Users\asklar\source\repos\react-native-xaml\package\Codegen\TypeEvents.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Util.GetCppWinRTEventSignature(evt)));
            
            #line default
            #line hidden
            this.Write(") noexcept {\r\n            DispatchTheEvent(eai, sender, args);\r\n        });\r\n    " +
                    "  } else {\r\n        c.");
            
            #line 66 "C:\Users\asklar\source\repos\react-native-xaml\package\Codegen\TypeEvents.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.GetName()));
            
            #line default
            #line hidden
            this.Write("(token);\r\n        return winrt::event_token{ -1 };\r\n      }\r\n    }\r\n    return wi" +
                    "nrt::event_token{0};\r\n  } },\r\n");
            
            #line 72 "C:\Users\asklar\source\repos\react-native-xaml\package\Codegen\TypeEvents.tt"
 } 
            
            #line default
            #line hidden
            
            #line 73 "C:\Users\asklar\source\repos\react-native-xaml\package\Codegen\TypeEvents.tt"
 foreach (var evt in SyntheticEvents) { 
            
            #line default
            #line hidden
            this.Write("  {\"");
            
            #line 74 "C:\Users\asklar\source\repos\react-native-xaml\package\Codegen\TypeEvents.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.Name));
            
            #line default
            #line hidden
            this.Write("\", nullptr /* synthetic event */},\r\n");
            
            #line 75 "C:\Users\asklar\source\repos\react-native-xaml\package\Codegen\TypeEvents.tt"
 } 
            
            #line default
            #line hidden
            this.Write("};\r\n\r\nstatic_assert(ARRAYSIZE(EventInfo::xamlEventMap) == ");
            
            #line 78 "C:\Users\asklar\source\repos\react-native-xaml\package\Codegen\TypeEvents.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Events.Count() + SyntheticEvents.Count()));
            
            #line default
            #line hidden
            this.Write(@");

void JsEvent(winrt::Microsoft::ReactNative::IJSValueWriter const& constantWriter, std::wstring topName, std::wstring onName) {
    constantWriter.WritePropertyName(topName);
    constantWriter.WriteObjectBegin();
    WriteProperty(constantWriter, L""registrationName"", onName);
    constantWriter.WriteObjectEnd();
  }

#define JS_EVENT(evtName) JsEvent(constantWriter, L""top"" L#evtName, L""on"" L#evtName)

ConstantProviderDelegate GetEvents = 
    [](winrt::Microsoft::ReactNative::IJSValueWriter const& constantWriter) {
    for (auto const& e : EventInfo::xamlEventMap) {
        auto wideName = std::wstring(winrt::to_hstring(e.name));
        JsEvent(constantWriter, L""top"" + wideName, L""on"" + wideName);
    }
};

void XamlMetadata::PopulateNativeEvents(winrt::Windows::Foundation::Collections::IMap<winrt::hstring, ViewManagerPropertyType>& nativeProps) const {
    for (const auto& evtInfo : EventInfo::xamlEventMap) {
        auto jsEvtName = L""on"" + winrt::to_hstring(evtInfo.name);
        nativeProps.Insert(jsEvtName, ViewManagerPropertyType::Boolean);
    }
}

");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public class TypeEventsBase
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
