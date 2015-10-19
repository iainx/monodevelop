//
// AwesomeBar.cs
//
// Author:
//       iain <iain@xamarin.com>
//
// Copyright (c) 2015 Copyright © 2015 Xamarin, Inc
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
using AppKit;
using Foundation;

namespace MonoDevelop.MacIntegration.MainToolbar
{
	public class AwesomeBar : NSView
    {
		internal RunButton RunButton { get; set; }
		internal SelectorView SelectorView { get; set; }
		internal StatusBar StatusBar { get; set; }
		internal SearchBar SearchBar { get; set; }

        public AwesomeBar ()
        {
			//WantsLayer = true;
			//Layer.BackgroundColor = NSColor.Red.CGColor;
			//TranslatesAutoresizingMaskIntoConstraints = false;

			RunButton = new RunButton {
				TranslatesAutoresizingMaskIntoConstraints = false
			};
			AddSubview (RunButton);

			SelectorView = new SelectorView {
				TranslatesAutoresizingMaskIntoConstraints = false
			};
			AddSubview (SelectorView);

			StatusBar = new StatusBar {
				TranslatesAutoresizingMaskIntoConstraints = false
			};
			AddSubview (StatusBar);

			SearchBar = new SearchBar {
				TranslatesAutoresizingMaskIntoConstraints = false
			};
			AddSubview (SearchBar);

			var viewsDict = new NSDictionary ("runButton", RunButton, "selectorView", SelectorView, "statusBar", StatusBar, "searchBar", SearchBar);
			var constraints = NSLayoutConstraint.FromVisualFormat ("|-1-[runButton]-8-[selectorView]-(>=8)-[statusBar(==470@251)]-(>=8)-[searchBar(==270@249)]-1-|", NSLayoutFormatOptions.AlignAllCenterY, null, viewsDict);
			AddConstraints (constraints);

			//constraints = NSLayoutConstraint.FromVisualFormat ("[searchBar(==270)]-1-|", 0, null, viewsDict);
			//AddConstraints (constraints);

			var constraint = NSLayoutConstraint.Create (StatusBar, NSLayoutAttribute.CenterX, NSLayoutRelation.Equal, this, NSLayoutAttribute.CenterX, 1, 0);
			constraint.Priority = 250;
			AddConstraint (constraint);

			//constraints = NSLayoutConstraint.FromVisualFormat ("[statusBar(==500)]", 0, null, viewsDict);
			//AddConstraints (constraints);

			// Vertical constraints
			constraints = NSLayoutConstraint.FromVisualFormat ("V:|[runButton]", 0, null, viewsDict);
			AddConstraints (constraints);
			/*
			constraints = NSLayoutConstraint.FromVisualFormat ("V:|[selectorView]", 0, null, viewsDict);
			AddConstraints (constraints);
			constraints = NSLayoutConstraint.FromVisualFormat ("V:|[statusBar]", 0, null, viewsDict);
			AddConstraints (constraints);
			constraints = NSLayoutConstraint.FromVisualFormat ("V:|[searchBar]", 0, null, viewsDict);
			AddConstraints (constraints);
*/
		}
    }
}

