//
// Copyright (C) 2010 Novell Inc. http://novell.com
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using NUnit.Framework;
using System.Diagnostics;
#if PORTABLE_XAML
using Portable.Xaml.Markup;
using Portable.Xaml.ComponentModel;
using Portable.Xaml;
using Portable.Xaml.Schema;
#else
using System.Windows.Markup;
using System.ComponentModel;
using System.Xaml;
using System.Xaml.Schema;
#endif

namespace Tests.Portable.Xaml
{
	[TestFixture]
	public class XamlObjectReaderSettingsTest
	{
		[Test]
		public void DefaultValues ()
		{
			var s = new XamlObjectReaderSettings ();
			Assert.IsFalse (s.RequireExplicitContentVisibility, "#1");

			Assert.IsFalse (s.AllowProtectedMembersOnRoot, "#2");
			Assert.IsFalse (s.IgnoreUidsOnPropertyElements, "#3");
			Assert.AreEqual (Debugger.IsAttached, s.ProvideLineInfo, "#4");
			Assert.IsFalse (s.ValuesMustBeString, "#5");
			Assert.IsNull (s.BaseUri, "#6");
			Assert.IsNull (s.LocalAssembly, "#7");
		}
	}
}
