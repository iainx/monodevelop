﻿//
// GtkTreeModelResult.cs
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
using System.Collections.Generic;
using Gtk;

namespace MonoDevelop.Components.AutoTest.Results
{
	public class GtkTreeModelResult : AppResult
	{
		TreeView TView;
		TreeModel TModel;
		int Column;
		TreeIter? resultIter;
		string DesiredText;

		public GtkTreeModelResult (TreeView treeView, TreeModel treeModel, int column)
		{
			TView = treeView;
			TModel = treeModel;
			Column = column;
		}

		public GtkTreeModelResult (TreeView treeView, TreeModel treeModel, int column, TreeIter iter)
		{
			TView = treeView;
			TModel = treeModel;
			Column = column;
			resultIter = iter;
		}
			
		public override AppResult Marked (string mark)
		{
			return null;
		}

		public override AppResult CheckType (Type desiredType)
		{
			return null;
		}

		public override AppResult Model (string column)
		{
			return null;
		}

		bool CheckForText (TreeModel model, TreeIter iter)
		{
			string modelText = model.GetValue (iter, Column) as string;
			return (modelText != null && modelText == DesiredText);
		}

		bool FindText (TreeModel model, TreePath path, TreeIter iter)
		{
			if (CheckForText (model, iter)) {
				resultIter = iter;
				return true;
			}

			return false;
		}

		public override AppResult Text (string text)
		{
			DesiredText = text;

			if (resultIter.HasValue) {
				return (AppResult)AutoTestService.CurrentSession.UnsafeSync (() => CheckForText (TModel, (TreeIter) resultIter) ? this : null);
			}

			return (AppResult) AutoTestService.CurrentSession.UnsafeSync (delegate {
				TModel.Foreach (FindText);

				return resultIter.HasValue ? this : null;
			});
		}

		public override AppResult Property (string propertyName, object value)
		{
			return null;
		}

		public override List<AppResult> NextSiblings ()
		{
			if (!resultIter.HasValue) {
				return null;
			}

			return (List<AppResult>)AutoTestService.CurrentSession.UnsafeSync (() => {
				List<AppResult> newList = new List<AppResult> ();
				TreeIter currentIter = (TreeIter) resultIter;

				while (TModel.IterNext (ref currentIter)) {
					newList.Add (new GtkTreeModelResult (TView, TModel, Column, currentIter));
				}

				return newList;
			});
		}

		public override bool Select ()
		{
			if (!resultIter.HasValue) {
				return false;
			}

			return (bool) AutoTestService.CurrentSession.UnsafeSync (delegate {
				TView.Selection.SelectIter ((TreeIter)resultIter);

				return true;
			});
		}

		public override bool Click ()
		{
			// FIXME: Same as select?
			return true;
		}

		public override bool TypeKey (char key, string state)
		{
			return false;
		}

		public override bool Toggle (bool active)
		{
			return false;
		}
	}
}

