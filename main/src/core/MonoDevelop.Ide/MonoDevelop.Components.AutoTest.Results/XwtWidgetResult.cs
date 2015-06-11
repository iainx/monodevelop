//
// XwtWidgetResult.cs
//
// Author:
//       iain holmes <iain@xamarin.com>
//
// Copyright (c) 2015 Xamarin, Inc
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;

using Xwt;

namespace MonoDevelop.Components.AutoTest.Results
{
	public class XwtWidgetResult : AppResult
	{
		IWidgetSurface resultWidget;

		public XwtWidgetResult (IWidgetSurface resultWidget)
		{
			this.resultWidget = resultWidget;
		}

		public override string ToString ()
		{
			return string.Format ("[XwtWidgetResult] - {0}", resultWidget);
		}

		public override AppResult Marked (string mark)
		{
			throw new NotImplementedException ();
		}

		public override AppResult CheckType (Type desiredType)
		{
			throw new NotImplementedException ();
		}

		public override AppResult Text (string text, bool exact)
		{
			throw new NotImplementedException ();
		}

		public override AppResult Model (string column)
		{
			throw new NotImplementedException ();
		}

		public override System.Collections.Generic.List<AppResult> NextSiblings ()
		{
			throw new NotImplementedException ();
		}

		public override bool Select ()
		{
			throw new NotImplementedException ();
		}

		public override bool Click ()
		{
			throw new NotImplementedException ();
		}

		public override bool TypeKey (char key, string state)
		{
			throw new NotImplementedException ();
		}

		public override bool TypeKey (string keyString, string state = "")
		{
			throw new NotImplementedException ();
		}

		public override bool EnterText (string text)
		{
			throw new NotImplementedException ();
		}

		public override bool Toggle (bool active)
		{
			throw new NotImplementedException ();
		}
	}
}

